using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Webapi.Controllers
{
    public class PhotosController : Controller
    {
        // GET: Photos
        public ActionResult Index()
        {
            return View();
        }

        // GET: Photos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Photos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Photos/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
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

        // GET: Photos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Photos/Edit/5
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

        // GET: Photos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Photos/Delete/5
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
