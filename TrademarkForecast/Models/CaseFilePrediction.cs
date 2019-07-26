using Microsoft.ML.Data;

namespace TrademarkForecast.Models
{
    public class CasefilePrediction:Casefile
    {
        [ColumnName("PredictedLabel")]
        public bool Prediction { get; set; }

        public float Probability { get; set; }

        public float Score { get; set; }
    }
}
