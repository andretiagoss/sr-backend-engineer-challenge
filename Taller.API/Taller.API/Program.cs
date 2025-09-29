using System.Text.Json.Serialization;
using Taller.Application;
using Taller.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

await builder.Services.AddInfrastructureLayer(builder.Configuration);
builder.Services.AddApplicationLayer();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
