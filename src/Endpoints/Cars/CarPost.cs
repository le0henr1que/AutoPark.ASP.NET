
namespace AutoPark.Endpoints.Cars;

using AutoPark.src.Infra.Data;

using AutoPark.src.Domain.Cars;

public class CarsPost
{
    public static string Template => "/cars";
    public static string[] Methods => new string[] {HttpMethod.Post.ToString()};
    public static Delegate Handle => Action;

    public static IResult Action(CarDTORequest carDTO, ApplicationDbContext context)
    {

        if(string.IsNullOrEmpty(carDTO.Name))
            return Results.BadRequest("Name Is required");

        var cars = new Cars {
            Name = carDTO.Name, 
            CreatedBy = "Teste", 
            CreatedOn = DateTime.Now, 
            EditedBy = "Test", 
            EditedOn = DateTime.Now,
            City = carDTO.City,
            Brand   = carDTO.Brand,
            Model = carDTO.Model,
            Year = carDTO.Year,
            Quilometragem = carDTO.Quilometragem,
            Price = carDTO.Price,
            Image = carDTO.Image
        };

        context.Car.Add(cars);
        context.SaveChanges();

        return Results.Created($"cars/{cars.Id}", cars.Id);
    }
}