
# **Sentiment Analysis App**

Ứng dụng phân tích cảm xúc sử dụng **ML.NET** để dự đoán cảm xúc tích cực hoặc tiêu cực từ các câu bình luận.

## **Mục Lục**

1. [Tính năng](#tính-năng)
2. [Cấu trúc dự án](#cấu-trúc-dự-án)
3. [Yêu cầu hệ thống](#yêu-cầu-hệ-thống)
4. [Hướng dẫn cài đặt](#hướng-dẫn-cài-đặt)
5. [Chạy ứng dụng](#chạy-ứng-dụng)
6. [Ví dụ kết quả](#ví-dụ-kết-quả)

---

## **Tính năng**

- Tải dữ liệu huấn luyện và kiểm tra từ file văn bản.
- Huấn luyện mô hình để phân tích cảm xúc.
- Đánh giá mô hình với các chỉ số như Accuracy, Precision, Recall, và F1 Score.
- Dự đoán cảm xúc của các bình luận mới (Tích cực/ Tiêu cực).

---

## **Cấu trúc dự án**

```plaintext
SentimentAnalysisApp/
├── Data/
│   └── SentimentData.txt        # File chứa dữ liệu cảm xúc
├── Models/
│   ├── SentimentData.cs         # Định nghĩa cấu trúc dữ liệu đầu vào
│   └── SentimentPrediction.cs   # Định nghĩa cấu trúc dữ liệu dự đoán
├── Services/
│   ├── DataLoader.cs            # Tải dữ liệu từ file
│   ├── ModelTrainer.cs          # Huấn luyện mô hình
│   ├── ModelEvaluator.cs        # Đánh giá mô hình
│   ├── SentimentPredictor.cs    # Dự đoán cảm xúc
│   └── SentimentAnalysisService.cs # Tích hợp các dịch vụ
└── Program.cs                   # File chính để chạy ứng dụng
```

### **Chi tiết các thư mục và file**
- **Data/**: Chứa dữ liệu cảm xúc sử dụng trong quá trình huấn luyện và kiểm tra.
- **Models/**: Định nghĩa các lớp dữ liệu đầu vào và đầu ra của mô hình.
- **Services/**: Chứa các lớp dịch vụ để xử lý các bước như tải dữ liệu, huấn luyện, đánh giá, và dự đoán.
- **Program.cs**: Điểm bắt đầu của ứng dụng, tích hợp các dịch vụ để thực hiện toàn bộ quy trình.

---

## **Yêu cầu hệ thống**

- .NET SDK **6.0** trở lên (tải tại [dotnet.microsoft.com](https://dotnet.microsoft.com/download)).
- Git để clone dự án (tải tại [git-scm.com](https://git-scm.com)).

---

## **Hướng dẫn cài đặt**

### **1. Clone dự án**

Clone repository từ GitHub về máy:

```bash
git clone https://github.com/Tranggg1210/MSCNPTPM_Group10_TX2.git
```

### **2. Cài đặt .NET SDK**

Tải và cài đặt .NET SDK nếu chưa có:

- Kiểm tra cài đặt bằng lệnh:
  ```bash
  dotnet --version
  ```

### **3. Cài đặt các gói phụ thuộc**

Di chuyển đến thư mục dự án và cài đặt các gói cần thiết:

```bash
cd SentimentAnalysisApp
dotnet restore
```

### **4. Tạo tệp dữ liệu**

Đảm bảo thư mục **Data/** có file `SentimentData.txt` với nội dung ví dụ như sau:

```plaintext
The service was terrible!,0
I love this place!,1
The pizza was awful!,0
The service is fast!,1
```

- **1**: Cảm xúc tích cực.
- **0**: Cảm xúc tiêu cực.

---

## **Chạy ứng dụng**

Chạy ứng dụng bằng lệnh:

```bash
dotnet run
```

Ứng dụng sẽ:
1. Tải dữ liệu từ **SentimentData.txt**.
2. Huấn luyện và đánh giá mô hình.
3. Dự đoán cảm xúc cho các câu bình luận mẫu.

---

## **Ví dụ kết quả**

Kết quả xuất ra trên console:

```plaintext
Dữ liệu đã được tải và chia thành tập huấn luyện và kiểm tra.
Mô hình đã được huấn luyện.
Độ chính xác: 0.85
Precision: 0.87
Recall: 0.82
F1 Score: 0.84
Cảm xúc: I love this product! | Dự đoán: Tích cực | Xác suất: 0.92
Cảm xúc: This is a terrible product. | Dự đoán: Tiêu cực | Xác suất: 0.88
```

---

Hướng dẫn này giúp bạn dễ dàng bắt đầu với dự án! 🎉
