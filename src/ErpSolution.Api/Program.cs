using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseHttpsRedirection();

if (app.Environment.IsDevelopment())
{
        app.UseSwagger(options =>
    {
        options.RouteTemplate = "/openapi/{documentName}.json";
    });
    app.MapScalarApiReference(options => options
    .WithTheme(ScalarTheme.Kepler)
    .WithDarkModeToggle(true)
    .WithClientButton(true));
}

app.MapGet("/api/hello", () => "Hello, World!").WithOpenApi();

await app.RunAsync();