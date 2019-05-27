using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _200395831_class_project.Models;

namespace _200395831_class_project.Controllers
{
    public class CarsController : Controller
    {
        //Cars List
        List<Car> carList = new List<Car>()
        {
            new Car {ID = 1, Brand = "Toyota", Model = "Corolla", Type = "Compact", Year = 2017},
            new Car {ID=2, Brand="Ford", Model="F-150", Type="Truck", Year=2018},
            new Car {ID=3, Brand="Dodge", Model="Caravan", Type="Minivan", Year=2019}
        };
        // GET: Cars
        public ActionResult Index()
        {
            return View(carList);
        }

        public ActionResult Details(int? id)
        {
            if(id == null || id > carList.Count)
            {
                return Content("Invalid Car ID");
            }
            var ind = Convert.ToInt32(id) - 1;
            var car = carList[ind];

            return View(car);
        }
    }
}