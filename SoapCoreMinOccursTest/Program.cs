using SoapCore;
using SoapCoreMinOccursTest.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSoapCore();
builder.Services.AddSingleton<ITempConverterService,TempComverterService>();

var app = builder.Build();

app.UseRouting();

app.UseSoapEndpoint<ITempConverterService>("/TempConverter.asmx", new SoapEncoderOptions());

app.Run();