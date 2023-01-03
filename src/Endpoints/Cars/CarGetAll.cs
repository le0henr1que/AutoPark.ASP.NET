
namespace AutoPark.Endpoints.Cars;

using AutoPark.src.Infra.Data;

// using AutoPark.src.Domain.Cars;

using AutoPark.Endpoints.CarsResponse;

public class CarsGetAll
{
    public static string Template => "/cars";
    public static string[] Methods => new string[] {HttpMethod.Get.ToString()};
    public static Delegate Handle => Action;

    public static IResult Action(ApplicationDbContext context)
    {
    
        var car = context.Car.ToList();

        var response = car.Select(c => new CarDTOResponse {
            Id = c.Id,
            Name = c.Name, 
            City = c.City,
            Brand   = c.Brand,
            Model = c.Model,
            Year = c.Year,
            Quilometragem = c.Quilometragem,
            Price = c.Price,
            Image = c.Image
        });
     
        return Results.Ok(response);
    }
}