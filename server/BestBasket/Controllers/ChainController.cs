using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BestBasket.Controllers
{
    public class ChainController : Controller
    {
        // GET: ChainController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ChainController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ChainController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChainController/Create
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

        // GET: ChainController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ChainController/Edit/5
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

        // GET: ChainController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ChainController/Delete/5
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
