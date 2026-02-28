```md
# ECommerce Admin Panel (ASP.NET Core MVC) — Module 24 Assignment

A minimal **ASP.NET Core Admin Panel** for an existing E-Commerce source project, built with **.NET 8**, **MSSQL**, **Entity Framework Core**, **N-Tier Architecture**, and **Repository Pattern**.  
Includes complete **CRUD** (List, Details, Create, Edit, Delete) for **Product** and **Category**.

---

## ✅ Features

- **.NET 8** (or latest)
- **ASP.NET Core MVC Admin Panel**
- **MSSQL + Entity Framework Core**
- **N-Tier Architecture**
  - Presentation (Web)
  - Business/Services
  - Data Access (Repositories)
  - Domain (Entities)
- **Repository Pattern**
- **CRUD** for:
  - Product
  - Category
- Working **Database Update / Migration commands**
- Bug fixing & debugging improvements from the original E-Commerce source

---

## 🧱 Project Architecture (N-Tier)

Example structure:

```

ECommerce.sln
│
├─ ECommerce.Web               # Presentation Layer (Admin Panel MVC)
│   ├─ Controllers
│   ├─ Views
│   ├─ wwwroot
│   └─ appsettings.json
│
├─ ECommerce.Application       # Business Layer (Services, DTOs)
│   ├─ Services
│   └─ Interfaces
│
├─ ECommerce.Infrastructure    # Data Access Layer (EF Core, Repos)
│   ├─ Data
│   ├─ Repositories
│   └─ Migrations
│
└─ ECommerce.Domain            # Domain Layer (Entities)
└─ Entities

````

> If your solution structure is slightly different, update this section accordingly.

---

## 🛠 Tech Stack

- **ASP.NET Core MVC (.NET 8)**
- **Entity Framework Core**
- **MS SQL Server**
- **Repository Pattern**
- **N-Tier Architecture**

---

## 🚀 Getting Started

### 1) Clone the repository

```bash
git clone <your-repo-url>
cd ECommerce
````

### 2) Configure Database Connection

Update your SQL Server connection string in:

`ECommerce.Web/appsettings.json`

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=ECommerceDb;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

✅ **Note:** This project supports changing the server name and running migrations successfully.

---

## 🧩 Entity Framework Core Migration Commands

Open terminal in solution folder (where `.sln` exists).

### Create Migration (If needed)

```bash
dotnet ef migrations add InitialCreate --project ECommerce.Infrastructure --startup-project ECommerce.Web
```

### Update Database (Required)

```bash
dotnet ef database update --project ECommerce.Infrastructure --startup-project ECommerce.Web
```

> If your DbContext is located in another project, adjust the `--project` accordingly.

---

## ▶️ Run the Project

```bash
dotnet run --project ECommerce.Web
```

Then open:

* `https://localhost:xxxx/`

---

## 🔐 Admin Panel Routes

You can use a separate Admin route (recommended). Examples:

* `/Admin/Product`
* `/Admin/Category`

Or using Areas:

* `/Admin/Product`
* `/Admin/Category`

> Update routes based on your implementation.

---

## 📌 CRUD Modules

### ✅ Category

* List
* Details
* Create
* Edit
* Delete

### ✅ Product

* List
* Details
* Create
* Edit
* Delete

---

## 🐛 Debugging & Fixes

This assignment also includes fixing existing issues from the original E-Commerce source, such as:

* Incorrect routing / broken views
* Validation issues
* Null reference errors
* Data not loading due to EF relations
* Incorrect model binding

> Add your actual fixed issues here (recommended for grading).

---

## 🧪 Sample Data (Optional)

If you added seed data, explain here:

* Default categories
* Sample products

---

## 📷 Screenshots (Optional)

Add screenshots of:

* Product list
* Create/Edit forms
* Category list

---

## 📄 License

This project is created for **Module 24 Assignment** practice and educational use.

---

## 👤 Author

**Md. Rifatul Islam**
ECommerce Admin Panel — Module 24 Assignment

```
```
