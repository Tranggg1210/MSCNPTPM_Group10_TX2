using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Data;




namespace SentimentAnalysis.Models
{
    internal class SentimentData
    {
        [LoadColumn(0)]
        public string SentimentText { get; set; }

        [LoadColumn(1)]
        public bool Label { get; set; }  // Đây là nhãn (0 hoặc 1)
    }
}
