# 🛒 Product Catalog Application

## 💻 ASP.NET MVC Product Catalog

This project is a simple **Product Catalog Application** developed using **ASP.NET Core MVC**. It demonstrates the basic MVC architecture using **Models, Controllers, Views, and Routing**.

## 🎯 Aim

To create a Product Catalog Application using ASP.NET MVC Architecture with:

* 🧩 Models
* 🎮 Controllers
* 👁️ Views
* 🔗 Routing

## 🛠️ Technologies Used

* 💻 C#
* 🌐 ASP.NET Core MVC
* ⚙️ .NET
* 📝 Razor View
* 🎨 HTML
* 🖥️ Visual Studio Code

## 📂 Project Structure

```text
productcatalog
│
├── Controllers
│   └── ProductController.cs
│
├── Models
│   └── Product.cs
│
├── Views
│   └── Product
│       └── Index.cshtml
│
└── Program.cs
```

## ✨ Features

* 📋 Displays a list of products.
* 🆔 Shows Product ID.
* 📦 Shows Product Name.
* 📄 Shows Product Description.
* 💰 Shows Product Price.
* 📊 Shows Product Quantity.
* 🏗️ Uses MVC architecture.
* 🔗 Uses routing to access the Product Catalog page.

## 🛍️ Product Details

The application contains sample products such as:

| 🆔 Product    | 📄 Description      | 💰 Price | 📦 Quantity |
| ------------- | ------------------- | -------: | ----------: |
| 💻 Laptop     | HP Laptop           |  ₹55,000 |          10 |
| 📱 Mobile     | Samsung Mobile      |  ₹25,000 |          15 |
| 🎧 Headphones | Wireless Headphones |   ₹2,000 |          20 |

## 🏗️ MVC Architecture

### 📦 Model

The `Product.cs` model defines the product properties:

* ProductId
* ProductName
* Description
* Price
* Quantity

### 🎮 Controller

The `ProductController.cs` creates the product list and sends the data to the View.

### 👁️ View

The `Index.cshtml` file displays the product information in an HTML table.

### 🔗 Routing

The Product Catalog can be accessed using:

```text
/Product/Index
```

## 🚀 How to Run

Clone the repository:

```bash
git clone https://github.com/diyakarmakar133348-ai/product-catalog.git
```

Navigate to the project folder:

```bash
cd product-catalog
```

Run the application:

```bash
dotnet run
```

Open the displayed localhost URL and navigate to:

```text
/Product/Index
```

## 🎓 Purpose

This project was created as an academic practical to understand the fundamentals of **ASP.NET Core MVC architecture** and the interaction between **Models, Controllers, Views, and Routing**.

## 👩‍💻 Author

**Diya Karmakar**

🎓 B.Tech Computer Science and Engineering

## 📜 License

© 2026 **Diya Karmakar. All Rights Reserved.**

This project is created for educational and academic purposes. Unauthorized copying, redistribution, or commercial use of this project is not permitted without permission from the author.
