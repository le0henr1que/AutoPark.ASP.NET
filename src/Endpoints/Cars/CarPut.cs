
namespace AutoPark.Endpoints.Cars;

using AutoPark.src.Infra.Data;
// using AutoPark.src.Domain.Cars;
using Microsoft.AspNetCore.Mvc;

public class CarsPut
{
    public static string Template => "/cars/{id}";
    public static string[] Methods => new string[] {HttpMethod.Put.ToString()};
    public static Delegate Handle => Action;

    public static IResult Action([FromRoute] Guid id, CarDTORequest carDTO, ApplicationDbContext context)
    {

        var car = context.Car.Where(c => c.Id == id).FirstOrDefault();

        car.Name = carDTO.Name;
        car.City = carDTO.City;
        car.Brand   = carDTO.Brand;
        car.Model = carDTO.Model;
        car.Year = carDTO.Year;
        car.Quilometragem = carDTO.Quilometragem;
        car.Price = carDTO.Price;
        car.Image = carDTO.Image;

        context.SaveChanges();

        return Results.Ok();
    }
}