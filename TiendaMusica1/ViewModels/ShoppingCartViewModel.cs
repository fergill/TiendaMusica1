using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaMusica1.Models;

namespace TiendaMusica1.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}