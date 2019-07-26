using System;
using System.IO;
using Microsoft.ML;
using Newtonsoft.Json;

using TrademarkForecast.Models;
namespace TrademarkForecast
{
    class Program
    {
        const string modelFilename = "FiledAsUsedInCommerceModel.zip";

        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine(Properties.Resources.Instructions.Replace(@"\n",Environment.NewLine));
                PressAnyKey();
                return;
            }
            else
            {
                string jsonFilepath = args[0];
                if (!File.Exists(jsonFilepath))
                {
                    Console.WriteLine(Properties.Resources.FileNotFound);
                    PressAnyKey();
                    return;
                }

                // Try to parse file
                try
                {
                    dynamic trademarkFile = JsonConvert.DeserializeObject(File.ReadAllText(jsonFilepath));

                    Casefile casefile = Services.Parser.TrademarkFileToCasefile(trademarkFile);

                    // Make prediction
                    MLContext mlContext = new MLContext();
                    ITransformer model = GetModel(mlContext, "ML" + Path.DirectorySeparatorChar + modelFilename);
                    var prediction = Predict(mlContext, model, casefile);

                    //output results

                    ShowPrediction(prediction);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error parsing file: " + ex.Message);
                }
            }
        }

        private static ITransformer GetModel(MLContext mlContext, string filepath)
        {
            return mlContext.Model.Load(filepath, out DataViewSchema columns);
        }

        private static (bool Prediction, float Probability) Predict(MLContext mlContext, ITransformer model, Casefile casefile)
        {
            PredictionEngine<Casefile, CasefilePrediction> predictionFunction = mlContext.Model.CreatePredictionEngine<Casefile, CasefilePrediction>(model);

            var resultPrediction = predictionFunction.Predict(casefile);

            return (resultPrediction.Prediction, resultPrediction.Probability);
        }

        #region UI

        static void ShowPrediction((bool Prediction, float Probability) prediction)
        {
            Console.WriteLine("Prediction: " + (prediction.Prediction ? " Will be cancelled" : "Will not be cancelled"));
            Console.WriteLine("Probability: " + Math.Round(prediction.Probability * 100) + "%");
        }

        static void PressAnyKey()
        {
            Console.WriteLine(Properties.Resources.PressAnyKey);
            Console.ReadKey(true);
        }
        #endregion
    }
}
