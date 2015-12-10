using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MovieSearch.Models;
using MovieSearch.Repository;
using MovieSearch.Repository.Domain;
using PagedList;

namespace MovieSearch.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index(string category, int page = 1)
        {
            var db = new EFContext();
            const int pageSize = 5;
            int pageNumber = page;
            var model = db.MovieToGenres.OrderBy(m => m.MovieId).ToList();
            var opa = new HashSet<MovieToGenre>();
            if (category != null)
            {
                model =
                db.MovieToGenres.Where(p => p.Genre.Name == category).ToList();   
            }
            foreach (var item in model)
            {
                if (opa.Count == 0)
                {
                    opa.Add(item);
                }
                if (opa.Last().MovieId != item.MovieId)
                    opa.Add(item);
            }
            return View(opa.OrderBy(m => m.MovieId).ToPagedList(pageNumber, pageSize));
        }

        public ActionResult MovieView(Guid movieId)
        {
            var db = new EFContext();
            var movie = db.Movies.First(m => m.Id == movieId);
            var poster = "http://st.kp.yandex.net/images/poster/" + db.Posters.First(m => m.MovieId == movieId).PosterId + ".jpg";
            return View(new MoviePostersViewModel{Movie = movie, Poster = poster});
        }

        public ActionResult Find(string name, int page = 1)
        {
            var db = new EFContext();
            const int pageSize = 5;
            int pageNumber = page;
            var model = db.Movies.Where(m => m.RussianTitle.Contains(name));
            return View(model.OrderBy(m => m.Id).ToPagedList(pageNumber, pageSize));
        }
    }
}
