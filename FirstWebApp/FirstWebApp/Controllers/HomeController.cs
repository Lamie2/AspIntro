using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Controllers
{
    public class HomeController:Controller
    {
        public ContentResult Index()
        {
            return Content("Salam dunya");
        }

        public ViewResult About()
        {
            var view = new ViewResult();
            view.ViewName = "About";
            return view;
        }

        public ViewResult Center()
        {
            return View();
        }


    }
}
