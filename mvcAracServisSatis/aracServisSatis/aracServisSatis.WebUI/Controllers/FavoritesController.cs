using aracServisSatis.Entities;
using aracServisSatis.Service.Abstract;
using aracServisSatis.WebUI.ExtensionMethods;
using Microsoft.AspNetCore.Mvc;

namespace aracServisSatis.WebUI.Controllers
{
    public class FavoritesController : Controller
    {
        private readonly ICarService _serviceArac;

        public FavoritesController(ICarService serviceArac)
        {
            _serviceArac = serviceArac;
        }

        public IActionResult Index()
        {
            var favoriler = GetFavorites();
            return View(favoriler);
        }

        private List<Arac> GetFavorites()
        {
            List<Arac>? araclar = new List<Arac>();
            araclar = HttpContext.Session.GetJson<List<Arac>>("GetFavorites");
            return araclar ?? new List<Arac>();
        }

        public IActionResult Add(int aracId)
        {
            var arac = _serviceArac.Find(aracId);
            var favoriler = GetFavorites();
            if (arac != null && favoriler != null && !favoriler.Any(a => a.Id == aracId))
            {
                favoriler.Add(arac);
                HttpContext.Session.SetJson("GetFavorites", favoriler);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int aracId)
        {
            var arac = _serviceArac.Find(aracId);
            var favoriler = GetFavorites();
            if (arac != null && favoriler != null && favoriler.Any(a => a.Id == aracId))
            {
                favoriler.RemoveAll(a => a.Id == aracId);
                HttpContext.Session.SetJson("GetFavorites", favoriler);
            }
            return RedirectToAction("Index");
        }
    }
}
