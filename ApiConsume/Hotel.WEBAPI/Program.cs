using Hotel.Business.Extensions;
using Hotel.DataAccess.Concrete;
using Hotel.DataAccess.Extensions;
using Hotel.Entity.Concrete;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


//comsume kaynak

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("OtelApiCors", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});


builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

// DataAccess + Business
builder.Services.AddService();
builder.Services.AddRepository();
builder.Services.AddDbContext<Context>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("OtelApiCors");
app.UseAuthorization();

app.MapControllers();

app.Run();
