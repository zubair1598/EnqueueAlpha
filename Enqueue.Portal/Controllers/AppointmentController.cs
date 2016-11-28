using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Enqueue.Portal.Models;

namespace Enqueue.Portal.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Index()
        {
           return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public ActionResult GetAppointment()
        {
            return PartialView("_Appointment");
        }
        [HttpPost]
        public ActionResult GetAppointment(AppointmentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home",model);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}