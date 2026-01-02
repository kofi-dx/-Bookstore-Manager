# Bookstore Management System

## Assignment Submission Details
**Name:** Emeka Kumassah  
**Course:** ASP.NET Core Web Development  
**Assignment:** Build a Simple Bookstore Web Application  
**Submission Date:** February 1, 2025  

## Project Links
**GitHub Repository:** https://github.com/kofi-dx/Bookstore-Manager  
**Live Application:** [Not currently deployed - can run locally]

## About This Project

Hi! This is my ASP.NET Core assignment where I built a complete bookstore management system from scratch. It was quite a journey getting everything working, especially with authentication and the database setup, but I'm proud of how it turned out.

## What This Application Does

This is a web application that lets you manage a bookstore inventory. You can:

- Browse all the books in the store (no login needed)
- Search for books by author name
- View detailed information about each book
- Create an account and log in
- Add new books to the collection (after logging in)
- Edit existing book details
- Delete books you no longer want

The cool part is that anyone can view the books, but only logged-in users can make changes. This keeps the data safe while still letting people browse.

## How to Run It on Your Computer

### What You'll Need First:
- .NET 9.0 SDK (you can download it from Microsoft's website)
- Either Visual Studio 2022 or VS Code (I used VS Code)
- A web browser (Chrome, Firefox, or Edge works fine)

### Step-by-Step Setup:

1. **Get the code:**
   ```bash
   git clone https://github.com/kofi-dx/Bookstore-Manager.git
   cd Bookstore-Manager
   ```

2. **Install what's needed:**
   ```bash
   dotnet restore
   ```

3. **Run the application:**
   ```bash
   dotnet run
   ```

4. **Open your browser and go to:**
   - http://localhost:5000
   - or https://localhost:5001

### Quick Login Details (for testing):
If you want to skip creating an account, use these:
- **Email:** admin@bookstore.com
- **Password:** Admin@123

Or create your own account using the registration form.

## What I Built (Technical Stuff)

### The Main Parts:

1. **The Book Model** - This defines what information each book has:
   - ID (automatic number)
   - Title (the book name)
   - Author (who wrote it)
   - Price (how much it costs)

2. **The Database** - I used SQLite, which creates a simple file on your computer (bookstore.db) to store all the book and user information.

3. **Controllers** - These handle all the actions:
   - HomeController: Shows the main page
   - BooksController: Handles everything book-related (listing, adding, editing, deleting)

4. **Views** - The web pages you see:
   - Home page with recent books and stats
   - Books list with search
   - Forms for adding and editing books
   - Book details page
   - Login and registration pages

5. **Authentication** - The login system that uses ASP.NET Core Identity. It handles user accounts securely.

## Features That Work

✅ **Book Browsing** - Anyone can see all books  
✅ **Search** - Find books by author name  
✅ **User Accounts** - Register and login system  
✅ **Add Books** - Only when logged in  
✅ **Edit Books** - Update book details  
✅ **Delete Books** - Remove books from inventory  
✅ **Responsive Design** - Works on phones and computers  
✅ **Sample Data** - Comes with 4 books already added  

## Testing the Application

Here's what you should try to see everything working:

### First (Without Login):
1. Open the home page - should see welcome message and book stats
2. Click "Books" in the menu - see all available books
3. Try the search box - type "Fitzgerald" to find "The Great Gatsby"
4. Click "Details" on any book - see more information

### Then (Create Account):
5. Click "Register" - make a new account
6. Log in with your new account
7. Notice the menu changes - you should see "Add Book" now

### Finally (Manage Books):
8. Click "Add Book" - fill out the form and submit
9. Find your new book in the list
10. Click "Edit" on your book - change something and save
11. Try deleting a book (be careful!)

## Project Structure (Where Everything Is)

```
Bookstore/
├── Controllers/          # Handles user requests
│   ├── HomeController.cs
│   └── BooksController.cs
├── Models/              # Defines our data
│   ├── Book.cs
│   └── ApplicationUser.cs
├── Views/               # All the web pages
│   ├── Home/
│   ├── Books/
│   └── Shared/
├── Data/                # Database setup
│   └── BookstoreContext.cs
├── wwwroot/             # CSS and JavaScript
├── Program.cs           # Where the app starts
├── appsettings.json     # Settings file
└── Bookstore.csproj     # Project configuration
```

## Challenges I Faced (And How I Solved Them)

1. **Database Setup** - Getting SQLite working with Entity Framework took some trial and error. I had to make sure all the right packages were installed.

2. **Authentication** - Setting up the login system was tricky. I learned how to use ASP.NET Core Identity properly.

3. **Authorization** - Making sure only logged-in users could edit books while letting everyone view them required careful controller setup.

4. **Null Reference Errors** - These showed up a lot! I fixed them by checking if values exist before using them.

## Assignment Requirements Checklist

Here's everything the assignment asked for, and what I delivered:

- [x] **ASP.NET Core MVC project** - Complete and working
- [x] **SQLite database with EF Core** - Stores books and users
- [x] **Book model with properties** - Id, Title, Author, Price
- [x] **Full CRUD operations** - Create, read, update, delete all work
- [x] **Authentication system** - Users can register and login
- [x] **Authorization** - Only logged-in users can modify books
- [x] **All necessary views** - Home, list, create, edit, details, delete
- [x] **Sample data** - 4 books included
- [x] **Navigation menu** - Easy to move around the app
- [x] **Tested functionality** - Everything works as expected

## Extra Features I Added

Beyond the requirements, I also included:
- Search functionality to find books by author
- A clean, modern interface using Bootstrap
- Responsive design that works on mobile devices
- Informative home page with book statistics
- User-friendly forms with validation

## Technologies I Used

- **ASP.NET Core MVC** - The main framework
- **Entity Framework Core** - For database operations
- **SQLite** - Simple file-based database
- **ASP.NET Core Identity** - For user authentication
- **Bootstrap 5** - For styling and responsiveness
- **Bootstrap Icons** - For nice icons throughout

## How to Build and Run (Developer Notes)

```bash
# Clean everything
dotnet clean

# Get all dependencies
dotnet restore

# Build the project
dotnet build

# Run it
dotnet run

# Or run with auto-restart on changes (for development)
dotnet watch run
```

## If You Have Problems Running It

1. **Port already in use?** Try:
   ```bash
   dotnet run --urls "http://localhost:5002"
   ```

2. **Database issues?** Delete the `bookstore.db` file and restart.

3. **Build errors?** Make sure you have .NET 9.0 SDK installed.

## Final Thoughts

This project taught me a lot about full-stack web development with ASP.NET Core. From setting up the database to implementing authentication and creating a user-friendly interface, I got hands-on experience with real-world web development concepts.

The most satisfying part was seeing everything come together - the database storing data, the authentication working, and the clean interface making it all accessible.

## License & Usage

This project was created for educational purposes as part of my coursework. Feel free to use it as a reference or starting point for your own learning!

---
**Submitted by:** Emeka Kumassah 
**For:** ASP.NET Core Web Development Assignment  
**Date:** February 2025