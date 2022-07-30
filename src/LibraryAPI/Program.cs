using LibraryAPI.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<IStudentRepository,SqlStudentRepository>();
builder.Services.AddScoped<IBookRepository,SqlBookRepository>();
var app = builder.Build();
app.MapControllers();
app.Run();
