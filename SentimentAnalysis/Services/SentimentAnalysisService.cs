using System;
using Microsoft.ML;
using SentimentAnalysis.Models;
using System.IO;

namespace SentimentAnalysis.Services
{
    public class SentimentAnalysisService
    {
        private readonly MLContext _context;
        private IDataView _trainData;
        private IDataView _testData;
        private readonly DataLoader _dataLoader;
        private readonly ModelTrainer _modelTrainer;
        private readonly ModelEvaluator _modelEvaluator;
        private readonly SentimentPredictor _sentimentPredictor;

        public SentimentAnalysisService()
        {
            _context = new MLContext();
            _dataLoader = new DataLoader(_context);
            _modelTrainer = new ModelTrainer(_context);
            _modelEvaluator = new ModelEvaluator(_context);
            _sentimentPredictor = new SentimentPredictor(_context);
        }

        public void LoadData(string dataFilePath)
        {
            _dataLoader.LoadData(dataFilePath);
        }

        public ITransformer TrainModel()
        {
            return _modelTrainer.TrainModel(_trainData);
        }

        public void EvaluateModel(ITransformer model)
        {
            _modelEvaluator.EvaluateModel(model, _testData);
        }

        public void PredictSentiment(ITransformer model, string sentimentText)
        {
            _sentimentPredictor.PredictSentiment(model, sentimentText);
        }
    }
}
