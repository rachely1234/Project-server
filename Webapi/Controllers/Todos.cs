using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Webapi.Controllers
{
    public class Todos : Controller
    {
        // GET: Todos
        public ActionResult Index()
        {
            return View();
        }

        // GET: Todos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Todos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Todos/Create
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

        // GET: Todos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Todos/Edit/5
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

        // GET: Todos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Todos/Delete/5
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
