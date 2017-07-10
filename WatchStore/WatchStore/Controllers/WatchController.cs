using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WatchStore.DAL;
using WatchStore.Models;

namespace WatchStore.Controllers
{
    public class WatchController : Controller
    {
        private IWatchRepository _watchRepository;
        public WatchController()
        {
            this._watchRepository = new WatchRepository(new WatchContext());
        }

        public ActionResult Index()
        {
            var watchs = from book in _watchRepository.GetWatchs()
                        select book;
            return View(watchs.ToList());
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