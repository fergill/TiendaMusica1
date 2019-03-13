using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaMusica1.Models;
using TiendaMusica1.Controllers;
using TiendaMusica1.ViewModels;

namespace TiendaMusica1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        TiendaMusicaEntities storeDB = new TiendaMusicaEntities();
        public ActionResult Index()
        {
            // Get most popular albums
            var albums = GetTopSellingAlbums(5);

            return View(albums);
        }
        private List<Album> GetTopSellingAlbums(int count)
        {
            // Group the order details by album and return
            // the albums with the highest count
            return storeDB.Albums
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }
    }
}