using System.Web;
using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TiendaMusica1.Filters
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
