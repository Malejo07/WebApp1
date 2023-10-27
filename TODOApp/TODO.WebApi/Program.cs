using Microsoft.EntityFrameworkCore;
using TODO.WebApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();//1.con esta l�nea se agregan los controladores que necesitemos autom�ticamente
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TODOAppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));//3.Conexi�n a la base de datos.
});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseRouting();//2.con esta l�nea se utilizan rutas???????
app.UseEndpoints(endpoints => 
{ 
    endpoints.MapControllers(); 
}
);

app.UseHttpsRedirection();


app.Run();
