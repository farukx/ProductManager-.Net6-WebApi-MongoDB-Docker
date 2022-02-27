// <snippet_UsingModels>
using ProductManager.Models;
// </snippet_UsingModels>
// <snippet_UsingServices>
using ProductManager.Services;
// </snippet_UsingServices>

// <snippet_AddControllers>
// <snippet_ProductsService>
// <snippet_DatabaseSettings>
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<DatabaseSettings>(
    builder.Configuration.GetSection("ProductDatabase"));
// </snippet_DatabaseSettings>

builder.Services.AddSingleton<ProductsService>();
// </snippet_ProductsService>

builder.Services.AddControllers()
    .AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
// </snippet_AddControllers>

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();