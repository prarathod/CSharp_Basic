using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_using_viklele_curd.Controllers
{
    public class EmoloyeeController : Controller
    {
        // GET: EmoloyeeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EmoloyeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmoloyeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmoloyeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmoloyeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmoloyeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmoloyeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmoloyeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
