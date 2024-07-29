using Microsoft.AspNetCore.Mvc;
using Microsoft.Web.WebView2.Core;
using Razor.Templating.Core;
using RazorToPDF.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.MapGet("DownloadInvoice", async () =>
{
    Invoice invoice = new Invoice()
    {
        Id = 12345,
        Name = "Test",
    };
    var html = await RazorTemplateEngine.RenderAsync("/Views/InvoiceToPDF.cshtml", invoice);


    var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
    var pdfBytes = htmlToPdf.GeneratePdf(html);


    return;
});

app.Run();

