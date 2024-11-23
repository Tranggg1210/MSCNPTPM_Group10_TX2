using System;
using SentimentAnalysis.Services;

namespace SentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Khởi tạo dịch vụ phân tích cảm xúc
                var sentimentAnalysisService = new SentimentAnalysisService();

                // Đường dẫn đến file dữ liệu
                string dataFilePath = @"D:\MSCNPTPM_Group10_TX2\SentimentAnalysis\Data\SentimentData.txt";

                // Tải và chia dữ liệu
                sentimentAnalysisService.LoadData(dataFilePath);

                // Huấn luyện mô hình
                var model = sentimentAnalysisService.TrainModel();

                // Đánh giá mô hình
                sentimentAnalysisService.EvaluateModel(model);

                // Dự đoán cảm xúc từ các bình luận mẫu
                var sampleComments = new[] {
                    "The service was terrible!",
                    "I love this place!"
                };

                foreach (var comment in sampleComments)
                {
                    sentimentAnalysisService.PredictSentiment(model, comment);
                }

                Console.WriteLine("Hoàn thành.");
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine($"Có lỗi xảy ra: {ex.Message}");
            }
        }
    }
}
