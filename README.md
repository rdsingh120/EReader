# 📚 EBook-Reader Desktop Application

![.NET](https://img.shields.io/badge/.NET-8-blue)
![License](https://img.shields.io/badge/license-MIT-green)

A simple **WPF E-Reader application** built with **.NET 8**, **AWS DynamoDB**, **AWS S3**, and **Syncfusion PDF Viewer**.  
Users can log in, view their saved books, and open PDFs directly inside the app.

---

## 🚀 Features

- 🔐 **User Authentication** with AWS DynamoDB  
- 📑 **Book List** fetched dynamically from DynamoDB  
- ☁️ **PDF Storage in S3** (retrieves books as streams)  
- 📖 **Syncfusion PDF Viewer** for reading inside the app  
- 💾 Remembers **last read page number** per book  

---

## 🛠️ Tech Stack

- **Frontend:** WPF (.NET 8, C#)  
- **Backend/Services:** AWS DynamoDB, AWS S3  
- **UI Controls:** Syncfusion PDF Viewer for WPF  
- **Data Models:** `User`, `Book`

---

## 📦 Dependencies

This project uses the following NuGet packages:

- **AWS SDKs**
  - `AWSSDK.DynamoDBv2` → For working with Amazon DynamoDB  
  - `AWSSDK.S3` → For storing and retrieving PDF files from Amazon S3  

- **Environment Variables**
  - `DotNetEnv` → For loading `.env` files into `Environment.GetEnvironmentVariable()`  

- **PDF Viewing**
  - `Syncfusion.PdfViewer.WPF` → For rendering PDFs inside the WPF application  

---

## 📷 Screenshots

> Add screenshots in the `screenshots/` folder

![Login Window](screenshots/login.png)  
![Book List](screenshots/booklist.png)  
![PDF Reader](screenshots/pdfreader.png)  

---

## 📂 Project Structure

```plaintext
EReader/
├── images/                  # Images
│   └── logo.png
│
├── Models/                  # User and Book classes
│   ├── User.cs
│   └── Book.cs
│
├── Services/                # DynamoDB and S3 operations, Login Authentication
│   ├── DynamoDBOperations.cs
│   ├── S3Operations.cs.cs
│   └── LoginOperation.cs
│
├── UserControls/            # Custom UI components
│   └── BookControl.xaml
│
├── Views/                   # WPF Windows
│   ├── Login.xaml
│   ├── EBookReader.xaml
│   └── Reader.xaml
│
├── screenshots/             # Screenshots for README
├── login.png
├── booklist.png
└── pdfreader.png


## ⚙️ Setup

### 1. Clone the repo  
```sh
git clone https://github.com/your-username/EReader.git
cd EReader
```


### 2. Create a .env file in the project root
```sh
AWS_ACCESS_KEY_ID=your-access-key
AWS_SECRET_ACCESS_KEY=your-secret-key
```

### 3. Install NuGet dependencies
```sh
dotnet add package AWSSDK.DynamoDBv2
dotnet add package AWSSDK.S3
dotnet add package DotNetEnv
dotnet add package Syncfusion.PdfViewer.WPF
```

### 4. Run the project
```sh
dotnet build
dotnet run
```





