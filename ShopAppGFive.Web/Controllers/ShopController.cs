using Microsoft.AspNetCore.Mvc;
using Shop.DAL.Interfaces;
using Shop.DAL.Models;

namespace ShopAppGFive.Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly IShopDb _shopDb;

        public ShopController(IShopDb shopDb)
        {
            _shopDb = shopDb;
        }

        public IActionResult Index()
        {
            var categories = _shopDb.GetCategories();
            return View(categories);
        }

        public IActionResult Details(int id)
        {
            var category = _shopDb.GetCategory(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryAddModel categoryAddModel)
        {
            if (ModelState.IsValid)
            {
                _shopDb.SaveCategory(categoryAddModel);
                return RedirectToAction(nameof(Index));
            }
            return View(categoryAddModel);
        }

        public IActionResult Edit(int id)
        {
            var category = _shopDb.GetCategory(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryUpdateModel categoryUpdateModel)
        {
            if (ModelState.IsValid)
            {
                _shopDb.UpdateCategory(categoryUpdateModel);
                return RedirectToAction(nameof(Index));
            }
            return View(categoryUpdateModel);
        }

        public IActionResult Delete(int id)
        {
            var category = _shopDb.GetCategory(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var categoryRemoveModel = new CategoryRemoveModel { categoryid = id };
            _shopDb.RemoveCategory(categoryRemoveModel);
            return RedirectToAction(nameof(Index));
        }
    }
}




//public ActionResult Delete(int id)
//{
//return View();
//}

// POST: ShopController/Delete/5
//[HttpPost]
//[ValidateAntiForgeryToken]
//public ActionResult Delete(int id, IFormCollection collection)
//{
//try
//{
//return RedirectToAction(nameof(Index));
//}
// catch
// {
// return View();
//}
//}