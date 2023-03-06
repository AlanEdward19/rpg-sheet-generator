using BDS.TransferPrice.Configuration;

var builder = WebApplication.CreateBuilder(args);

#region Configure

builder.Services.ConfigureController();
builder.Services.ConfigureServices(builder.Configuration);

#endregion

#region Swagger

builder.Services.ConfigureApiDocumentarion();
builder.Services.AddEndpointsApiExplorer();

#endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.ConfigureApiDocumentarionUi();

app.Run();
