﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Context;

namespace WebsiteBanHang.Controllers
{
    public class HomeController : Controller
    {
        WebBanHangEntities obj = new WebBanHangEntities();
        public ActionResult Index()
        {
            var lstProduct = obj.Products.ToList();
            return View(lstProduct);
        }

    }
}