using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Bookstore.Data;
using Bookstore.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure the database
builder.Services.AddDbContext<BookstoreContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection") ?? "Data Source=bookstore.db"));

// Configure Identity
builder.Services.AddDefaultIdentity<IdentityUser>(options => 
    {
        options.SignIn.RequireConfirmedAccount = false;
        options.Password.RequireDigit = true;
        options.Password.RequiredLength = 6;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = true;
        options.Password.RequireLowercase = true;
    })
    .AddEntityFrameworkStores<BookstoreContext>();

// Add Razor Pages for Identity UI
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

// Initialize database
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<BookstoreContext>();
        context.Database.EnsureCreated();
        
        // Seed initial data
        if (!context.Books.Any())
        {
            context.Books.AddRange(
    new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 12.99m, Genre = "Classic" },
    new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 14.99m, Genre = "Drama" },
    new Book { Title = "1984", Author = "George Orwell", Price = 10.99m, Genre = "Dystopian" },
    new Book { Title = "Pride and Prejudice", Author = "Jane Austen", Price = 9.99m, Genre = "Romance" }
);
            context.SaveChanges();
        }
        
        // Seed an admin user (skip roles for now to simplify)
        var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
        
        // Create admin user
        var adminEmail = "admin@bookstore.com";
        var adminUser = await userManager.FindByEmailAsync(adminEmail);
        if (adminUser == null)
        {
            adminUser = new IdentityUser
            {
                UserName = adminEmail,
                Email = adminEmail,
                EmailConfirmed = true
            };
            
            var result = await userManager.CreateAsync(adminUser, "Admin@123");
            // We'll add roles later if needed
        }
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while initializing the database.");
    }
}

app.Run();