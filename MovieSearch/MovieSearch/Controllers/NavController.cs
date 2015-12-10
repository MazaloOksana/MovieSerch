using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MovieSearch.Repository;

namespace MovieSearch.Controllers
{
    public class NavController : Controller
    {
        //
        // GET: /Nav/

        public PartialViewResult Menu()
        {
            var db = new EFContext();
            IEnumerable<string> categories = db.Genres.Select(m => m.Name);
            return PartialView(categories);
        }

    }
}
