using Microsoft.ML;
using Microsoft.ML.Trainers;

namespace SentimentAnalysis.Services
{
    public class ModelTrainer
    {
        private readonly MLContext _context;

        public ModelTrainer(MLContext context)
        {
            _context = context;
        }

        public ITransformer TrainModel(IDataView trainData)
        {
            var pipeline = _context.Transforms.Text.FeaturizeText("SentimentText")
                .Append(_context.BinaryClassification.Trainers.SdcaLogisticRegression(
                    labelColumnName: "Label", featureColumnName: "SentimentText"));

            var model = pipeline.Fit(trainData);
            Console.WriteLine("Mô hình đã được huấn luyện.");
            return model;
        }
    }
}
