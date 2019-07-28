using System;
using System.IO;
using Microsoft.ML;
using Newtonsoft.Json;

using TrademarkForecast.Models;

namespace TrademarkForecast
{
    class Program
    {
        const string AllApplicationsModel = "AllApplicationsLbfgsLogisticRegression.zip";

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
                string serialNumber = args[0];               

                // Try to parse
                try
                {
                    dynamic trademarkFile = JsonConvert.DeserializeObject(DAO.TsdrDAO.GetApplicationData(serialNumber));

                    Casefile casefile = Services.Parser.TrademarkFileToCasefile(trademarkFile);

                    // Make prediction
                    MLContext mlContext = new MLContext();
                    ITransformer model = GetModel(mlContext, "ML" + Path.DirectorySeparatorChar + AllApplicationsModel);
                    var prediction = Predict(mlContext, model, casefile);

                    // Output results
                    ShowPrediction(prediction);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error parsing data: " + ex.Message);
                }
            }
        }

        private static ITransformer GetModel(MLContext mlContext, string filepath)
        {
            return mlContext.Model.Load(filepath, out DataViewSchema columns);
        }

        private static bool Predict(MLContext mlContext, ITransformer model, Casefile casefile)
        {
            PredictionEngine<Casefile, CasefilePrediction> predictionFunction = mlContext.Model.CreatePredictionEngine<Casefile, CasefilePrediction>(model);

            var resultPrediction = predictionFunction.Predict(casefile);

            // return (resultPrediction.Prediction, resultPrediction.Probability);
            return resultPrediction.Prediction;
        }

        #region UI

        static void ShowPrediction(bool prediction)
        {
            Console.WriteLine("Prediction: " + (prediction ? "Will be cancelled" : "Will not be cancelled"));
           // Console.WriteLine("Probability: " + Math.Round(prediction.Probability * 100) + "%");
        }

        static void PressAnyKey()
        {
            Console.WriteLine(Properties.Resources.PressAnyKey);
            Console.ReadKey(true);
        }
        #endregion
    }
}
