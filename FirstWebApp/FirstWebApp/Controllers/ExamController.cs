using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Controllers
{
    public class ExamController:Controller
    {
        private List<Exam> _exams;
        public ActionResult Result(int studentId=19)
        {
            return Content(studentId.ToString());
            //return View();
        }
        public ActionResult Detail(int id)
        {
            TempData["ExamId"] = id;
            ViewData["ExamId"] = id;
            ViewBag.ExamId = id;
            return View();

        }
    }
}
