using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace SentimentAnalysis.Models
{
    internal class SentimentPrediction
    {
        public float Score { get; set; }  // Điểm thô (raw score)
        public float Probability { get; set; }  // Khả năng cảm xúc tích cực
        public bool Prediction { get; set; }  // Dự đoán cảm xúc (true: tích cực, false: tiêu cực)
    }
}
