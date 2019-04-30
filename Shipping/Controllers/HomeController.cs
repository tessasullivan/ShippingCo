using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ShippingCo.Models;

namespace ShippingCo.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
        return View();
        // return new EmptyResult();
    }
  }
}