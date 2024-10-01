using breakfast.Services.Breakfasts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IBreakfastService, BreakfastService>();

// Configure logging
builder.Logging.ClearProviders(); // Optional: Clears default loggers
builder.Logging.AddConsole(); // Ensure Console logging is added

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.MapControllers();
app.UseExceptionHandler("/error");

app.Run();
