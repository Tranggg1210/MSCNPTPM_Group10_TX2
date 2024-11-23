using Microsoft.ML;
using SentimentAnalysis.Models;

namespace SentimentAnalysis.Services
{
    public class SentimentPredictor
    {
        private readonly MLContext _context;

        public SentimentPredictor(MLContext context)
        {
            _context = context;
        }

        public void PredictSentiment(ITransformer model, string sentimentText)
        {
            var predictionEngine = _context.Model.CreatePredictionEngine<SentimentData, SentimentPrediction>(model);
            var prediction = predictionEngine.Predict(new SentimentData { SentimentText = sentimentText });
            Console.WriteLine($"Cảm xúc: {sentimentText} | Dự đoán: {(prediction.Prediction ? "Tích cực" : "Tiêu cực")} | Xác suất: {prediction.Probability:0.####}");
        }
    }
}
