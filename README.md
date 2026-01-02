# Bookstore Web Application

A complete ASP.NET Core MVC web application for managing a bookstore inventory with user authentication and authorization.

## 🎯 Project Overview

This application allows users to browse, create, update, and delete books in a bookstore inventory. It includes user authentication and role-based authorization features.

## ✨ Features

- **User Authentication** - Register, login, and logout functionality
- **Book Management** - Full CRUD operations (Create, Read, Update, Delete)
- **Authorization** - Only authenticated users can modify books
- **Database** - SQLite database with Entity Framework Core
- **Responsive UI** - Clean, modern interface that works on all devices
- **Search Functionality** - Search books by author name

## 🛠️ Technologies Used

- **ASP.NET Core MVC** - Web framework
- **Entity Framework Core** - Database ORM
- **SQLite** - Database engine
- **ASP.NET Core Identity** - Authentication system
- **Bootstrap 5** - Frontend framework
- **Bootstrap Icons** - Icon library

## 📁 Project Structure

```
Bookstore/
├── Controllers/
│   ├── HomeController.cs
│   └── BooksController.cs
├── Models/
│   ├── Book.cs
│   └── ApplicationUser.cs
├── Views/
│   ├── Home/
│   │   └── Index.cshtml
│   ├── Books/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   ├── Details.cshtml
│   │   └── Delete.cshtml
│   └── Shared/
│       ├── _Layout.cshtml
│       └── _LoginPartial.cshtml
├── Data/
│   └── BookstoreContext.cs
├── wwwroot/
│   ├── css/
│   │   └── site.css
│   └── js/
│       └── site.js
├── Program.cs
├── appsettings.json
└── Bookstore.csproj
```

## 🚀 Getting Started

### Prerequisites
- .NET 9.0 SDK
- Visual Studio 2022 or VS Code
- Git (optional)

### Installation

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd Bookstore
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Run the application**
   ```bash
   dotnet run
   ```

4. **Open in browser**
   Navigate to `https://localhost:5001` or `http://localhost:5000`

### Default Credentials
- **Admin User**: `admin@bookstore.com` / `Admin@123`
- **Test User**: `test@bookstore.com` / `Test@123`

## 📋 Requirements Met

✅ **ASP.NET Core MVC Project** - Complete web application  
✅ **SQLite Database with EF Core** - Data persistence  
✅ **Book Model** - Id, Title, Author, Price properties  
✅ **CRUD Operations** - Create, Read, Update, Delete books  
✅ **Authentication** - ASP.NET Core Identity implementation  
✅ **Authorization** - Only authenticated users can modify books  
✅ **Views** - Index, Create, Edit, Details, Delete views  
✅ **Navigation** - Menu with Home and Books links  
✅ **Sample Data** - Pre-populated with 4 sample books  

## 🧪 Testing the Application

### Public Features (No Login Required)
- View home page
- Browse all books
- View book details
- Search books by author

### Authenticated User Features (Login Required)
- Add new books
- Edit existing books
- Delete books
- User registration and login

### Test Steps
1. **Home Page**: Verify the welcome page loads with book statistics
2. **Browse Books**: Click "Books" in navigation to see all books
3. **Search**: Try searching for books by author name
4. **Register**: Create a new user account
5. **Login**: Login with your credentials
6. **Add Book**: Create a new book entry
7. **Edit Book**: Modify an existing book
8. **Delete Book**: Remove a book from the inventory

## 🔧 Configuration

The application uses `appsettings.json` for configuration:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=bookstore.db"
  }
}
```

## 📊 Database Schema

### Books Table
| Column | Type | Description |
|--------|------|-------------|
| Id | INT | Primary key |
| Title | NVARCHAR(100) | Book title |
| Author | NVARCHAR(50) | Author name |
| Price | DECIMAL | Book price |

### Identity Tables
Automatically created by ASP.NET Core Identity for user management.

## 🎨 UI Components

- **Navigation Menu**: Home and Books links
- **Book Table**: Displays all books with actions
- **Search Bar**: Filter books by author
- **Action Buttons**: View, Edit, Delete for each book
- **Authentication Links**: Register/Login or user greeting

## ⚙️ Build and Run

```bash
# Clean build
dotnet clean

# Restore packages
dotnet restore

# Build project
dotnet build

# Run application
dotnet run

# For development
dotnet watch run
```

## 📝 Assignment Requirements Checklist

- [x] Create ASP.NET Core MVC project
- [x] Configure SQLite database with EF Core
- [x] Create Book model with properties
- [x] Implement database context
- [x] Generate controllers and views with scaffolding
- [x] Implement authentication with Identity
- [x] Implement authorization (authenticated users only for modifications)
- [x] Create views for list, create, update, delete
- [x] Add sample data
- [x] Create navigation menu
- [x] Test all functionality

## 🤝 Contributing

This is an assignment project. For educational purposes only.

## 📄 License

Educational Use - Created for academic assignment

## 👨‍💻 Author

Student Assignment - ASP.NET Core Web Application

---

**Note**: This application was created as part of an academic assignment to demonstrate proficiency in ASP.NET Core MVC, Entity Framework Core, and ASP.NET Core Identity.