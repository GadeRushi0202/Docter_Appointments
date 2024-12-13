using Doctor_appointments.Models;
using Doctor_appointments.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Doctor_appointments.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctorServices services;
        public DoctorController(IDoctorServices services) 
        {
            this.services = services;
        }
        // GET: DoctorController
        public ActionResult Index()
        {
            return View(services.GetAllDoctor());
        }

        // GET: DoctorController/Details/5
        public ActionResult Details(int id)
        {
            var model = services.GetDoctorById(id);
            return View(model);
        }

        // GET: DoctorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Doctor doctor)
        {
            try
            {
                int result = services.AddDoctor(doctor);
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

        // GET: DoctorController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = services.GetDoctorById(id);
            return View(model);
        }

        // POST: DoctorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Doctor doctor)
        {
            try
            {
                int result = services.UpdateDoctor(doctor);
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

        // GET: DoctorController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = services.GetDoctorById(id);
            return View(model);
        }

        // POST: DoctorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                var result = services.DeleteDoctor(id);
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
