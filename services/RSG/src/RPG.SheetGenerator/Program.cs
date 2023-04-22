using BDS.TransferPrice.Configuration;

var builder = WebApplication.CreateBuilder(args);

#region Configure

builder.Services.ConfigureController();
builder.Services.ConfigureServices(builder.Configuration);
builder.Services.AddHealthChecks();

#endregion

#region Swagger

builder.Services.ConfigureApiDocumentarion();
builder.Services.AddEndpointsApiExplorer();

#endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.ConfigureApiDocumentarionUi();

app.UseAuthorization();
app.ConfigureEndpoints(builder.Configuration.GetSection("EndPointsConfig"));
app.ConfigureMiddlewares();

app.Run();
