var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

// Route to Furniture Controller by default
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Furniture}/{action=Index}/{id?}");

app.Run("http://localhost:5200");
