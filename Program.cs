using Microsoft.Net.Http.Headers;
using TwitterStatistics.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHostedService<TimedHostedService>();

// better to have a config spec that has the name....
builder.Services.AddHttpClient("TwitterVolumeStreams", httpClient =>
{
    httpClient.BaseAddress = new Uri("https://api.twitter.com/");

    // From Java Sample code
    string bearer_token = "BBBBBBBBBBBBBBBBBBBBBB%2BuVRzYSrYO74EDv8zNBzQ%3DvYDMNI31A4QHnXsfTL2kpJqeXS2Pzt5ARhW8ZZU25juWqIflBF";

    httpClient.DefaultRequestHeaders.Add(
        HeaderNames.Authorization, bearer_token);

});

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

// https://learn.microsoft.com/en-us/aspnet/core/fundamentals/error-handling?view=aspnetcore-6.0


app.Run();
