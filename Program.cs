using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddDataProtection()
    .PersistKeysToFileSystem(new System.IO.DirectoryInfo("C:\\Inetpub\\vhosts\\mintplayer.com\\SLvHdahBxVmuTQar"))
    .SetDefaultKeyLifetime(TimeSpan.FromDays(365));

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