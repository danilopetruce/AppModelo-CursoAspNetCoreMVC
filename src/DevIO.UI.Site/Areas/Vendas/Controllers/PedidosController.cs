﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Areas.Vendas.Controllers
{
    [Area("Vendas")]
    public class PedidosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}