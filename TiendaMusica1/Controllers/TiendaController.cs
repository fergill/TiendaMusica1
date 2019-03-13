using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaMusica1.Models;

namespace TiendaMusica1.Controllers
{
    public class TiendaController : Controller
    {

        TiendaMusicaEntities storeDB = new TiendaMusicaEntities();

        // GET: /Tienda/
        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();
            return View(genres);
        }
            
            //
            // GET: /Tienda/Browse?genre=Disco
            public ActionResult Browse(string genre)
        {
            var genreModel = storeDB.Genres.Include("Albums")
                .Single(g => g.Name == genre);

            return View(genreModel);
        }
        //

       



        // GET: /Tienda/Details/5
        public ActionResult Details(int id)
        {
            var album = storeDB.Albums.Find(id);
            return View(album);
        }

        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = storeDB.Genres.ToList();
            return PartialView(genres);
        }
    }
}



