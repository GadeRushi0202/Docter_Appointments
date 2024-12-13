using Doctor_appointments.Models;
using Doctor_appointments.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Doctor_appointments.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentServices services;
        private readonly IDoctorServices doctorServices;

        public AppointmentController(IAppointmentServices services, IDoctorServices doctorServices)
        {
            this.services = services;
            this.doctorServices = doctorServices;
        }
        // GET: AppointmentController
        public ActionResult Index()
        {
            return View(services.GetAllAppointments());
        }

        // GET: AppointmentController/Details/5
        public ActionResult Details(int id)
        {
            var model = services.GetAppointmentById(id);
            return View(model);
        }

        // GET: AppointmentController/Create
        public ActionResult Create()
        {
            ViewBag.Doctors = new SelectList(doctorServices.GetAllDoctor(), "DoctorId", "Name");
            return View();
        }

        // POST: AppointmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Appointment appointment)
        {
            try
            {
                int result = services.AddAppointment(appointment);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Doctors = new SelectList(doctorServices.GetAllDoctor(), "DoctorId", "Name");
                    return View();
                }

            }
            catch
            {
                ViewBag.Doctors = new SelectList(doctorServices.GetAllDoctor(), "DoctorId", "Name");
                return View();
            }
        }

        // GET: AppointmentController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = services.GetAppointmentById(id);
            ViewBag.Doctors = new SelectList(doctorServices.GetAllDoctor(), "DoctorId", "Name");
            return View(model);
        }

        // POST: AppointmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Appointment appointment)
        {
            try
            {
                int result = services.UpdateAppointment(appointment);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Doctors = new SelectList(doctorServices.GetAllDoctor(), "DoctorId", "Name");
                    return View();
                }
            }
            catch
            {
                ViewBag.Doctors = new SelectList(doctorServices.GetAllDoctor(), "DoctorId", "Name");
                return View();
            }
        }

        // GET: AppointmentController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = services.GetAppointmentById(id);
            return View(model);
        }

        // POST: AppointmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                var result = services.DeleteAppointment(id);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }

            }
            catch
            {
                return View();
            }
        }
    }
}
