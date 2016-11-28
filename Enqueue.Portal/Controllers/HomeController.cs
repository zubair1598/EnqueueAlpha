using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Enqueue.Portal.Models;

namespace Enqueue.Portal.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {   //ViewBag.Appointment = model;
            return View(GetAppointmentModel());
        }

        private static AppointmentViewModel GetAppointmentModel()
        {
            AppointmentViewModel model = new AppointmentViewModel();
            List<SelectListItem> list = new List<SelectListItem>
            {
                new SelectListItem {Value = "1", Text = "John"},
                new SelectListItem {Value = "2", Text = "Michael"},
                new SelectListItem {Value = "3", Text = "Chris"}
            };
            model.AvailableDcotors.Add(new SelectListItem() { Value = "1", Text = "John" });
            model.AvailableDcotors.Add(new SelectListItem() { Value = "2", Text = "Michael" });
            model.AvailableDcotors.Add(new SelectListItem() { Value = "3", Text = "Chris" });
            // model.AvailableDcotors.Add();;
            return model;
        }

        [HttpPost]
        public ActionResult Index(AppointmentViewModel model, FormCollection form)
        {
            //var name = form["SelectedDoctor"].ToString();

            if (model.SelectedDoctor > 0)
            {
                ModelState["SelectedDoctor"].Errors.Clear();
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ViewBag.Msg = "Your Token # is : ";
            ViewBag.Token = "1045";
            //return View(GetAppointmentModel());

            return View(GetAppointmentModel());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}