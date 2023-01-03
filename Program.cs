using AutoPark.Endpoints.Cars;
using AutoPark.src.Infra.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSqlServer<ApplicationDbContext>(builder.Configuration["ConnectionString:AutoPark"]);

var app = builder.Build();




app.MapMethods(CarsPost.Template, CarsPost.Methods, CarsPost.Handle);

app.MapMethods(CarsGetAll.Template, CarsGetAll.Methods, CarsGetAll.Handle);

app.MapMethods(CarsPut.Template, CarsPut.Methods, CarsPut.Handle);

app.MapMethods(CarsDelete.Template, CarsDelete.Methods, CarsDelete.Handle);

app.Run();
