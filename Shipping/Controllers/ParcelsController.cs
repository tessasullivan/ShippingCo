using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ShippingCo.Models;

namespace ShippingCo.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
        List<Parcel> allParcels = Parcel.GetAll();
        return View(allParcels);
    }
    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
        return View();
    }
    [HttpPost("/parcels")]
    public ActionResult Create(int length, int width, int weight)
    {
        Parcel myParcel = new Parcel(length, width, weight);
        return RedirectToAction("Index");
    }
  }
}