using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcel.Models;

namespace ShippingCo.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    // public string Hello() { return "Hello friend!"; }

    public ActionResult Index()
    {

        return View();
        // return new EmptyResult();
    }
  }
}