using Prometheus;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.UseMetricServer(); 
app.UseHttpMetrics();
app.MapGet("/health", () => Results.Ok("healthy"));

app.Run();