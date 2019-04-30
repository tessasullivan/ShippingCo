using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcel.Models;

namespace ShippingCo.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
        List<Car> allCars = Car.GetAll();
        return View(allCars);
    }
    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
        return View();
    }
    [HttpPost("/cars")]
    public ActionResult Create(string makeModel, int price, int miles)
    {
        Car myCar = new Car(makeModel, price, miles);
        return RedirectToAction("Index");
    }
    // public ActionResult Create(string description)
    // {
    //     Item myItem = new Item(description);
    //     return RedirectToAction("Index");
    // }
  }
}