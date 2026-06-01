using Microsoft.EntityFrameworkCore;
using FurnitureHub.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Add database context for SQL Server LocalDB
string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=FurnitureHubDB;Trusted_Connection=True;TrustServerCertificate=True;";
builder.Services.AddDbContext<FurnitureDbContext>(options =>
    options.UseSqlServer(connectionString));

// Add controllers support
builder.Services.AddControllers();

var app = builder.Build();

// Enable Controllers
app.MapControllers();

// Auto-create/seed database using Entity Framework Core Code-First approach
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<FurnitureDbContext>();
    try
    {
        // Creates database and seeds data defined in OnModelCreating
        context.Database.EnsureCreated();
    }
    catch (Exception ex)
    {
        var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while creating or seeding the database.");
    }
}

app.Run("http://localhost:5100");
