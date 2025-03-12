using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BestBasket.Controllers
{
    public class UserBasketController : Controller
    {
        // GET: UserBasketController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserBasketController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserBasketController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserBasketController/Create
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

        // GET: UserBasketController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserBasketController/Edit/5
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

        // GET: UserBasketController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserBasketController/Delete/5
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
