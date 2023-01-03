
namespace AutoPark.Endpoints.Cars;

using AutoPark.src.Infra.Data;
// using AutoPark.src.Domain.Cars;
using Microsoft.AspNetCore.Mvc;

public class CarsDelete
{
    public static string Template => "/cars/{id}";
    public static string[] Methods => new string[] {HttpMethod.Delete.ToString()};
    public static Delegate Handle => Action;

    public static IResult Action([FromRoute] Guid id, ApplicationDbContext context)
    {

        var car = context.Car.Where(c => c.Id == id).First();

        context.Car.Remove(car);
        context.SaveChanges();
        return Results.Ok();
    }
}