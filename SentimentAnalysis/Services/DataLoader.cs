using Microsoft.ML;
using System.IO;
using SentimentAnalysis.Models;

namespace SentimentAnalysis.Services
{
    public class DataLoader
    {
        private readonly MLContext _context;

        public DataLoader(MLContext context)
        {
            _context = context;
        }

        public IDataView LoadData(string dataFilePath)
        {
            if (!File.Exists(dataFilePath))
            {
                throw new FileNotFoundException("Tệp dữ liệu không tồn tại!");
            }

            var data = _context.Data.LoadFromTextFile<SentimentData>(dataFilePath, separatorChar: ',', hasHeader: false);
            var trainTestData = _context.Data.TrainTestSplit(data, testFraction: 0.2);

            _trainData = trainTestData.TrainSet;
            _testData = trainTestData.TestSet;

            Console.WriteLine("Dữ liệu đã được tải và chia thành tập huấn luyện và kiểm tra.");
            return _trainData;
        }
    }
}
