using Microsoft.ML;
using Microsoft.ML.Data;

namespace SentimentAnalysis.Services
{
    public class ModelEvaluator
    {
        private readonly MLContext _context;

        public ModelEvaluator(MLContext context)
        {
            _context = context;
        }

        public void EvaluateModel(ITransformer model, IDataView testData)
        {
            var predictions = model.Transform(testData);
            var metrics = _context.BinaryClassification.Evaluate(predictions, labelColumnName: "Label", scoreColumnName: "PredictedLabel");

            Console.WriteLine($"Độ chính xác: {metrics.Accuracy:0.##}");
            Console.WriteLine($"Precision: {metrics.PositivePrecision:0.##}");
            Console.WriteLine($"Recall: {metrics.PositiveRecall:0.##}");
            Console.WriteLine($"F1 Score: {metrics.F1Score:0.##}");
        }
    }
}
