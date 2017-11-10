﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Test(string id)
        {
            return View((object)id);
        }

        public ActionResult Test2(string id)
        {
            return PartialView("Test", (object)id);
        }

        public ActionResult ContentDemo()
        {
            // SaveChange();

            return Content("<script>alert('新增成功');location.href='/';</script>");
        }

        public ActionResult Succeed()
        {
            return View("JSAlertRedirect", (object)"新增成功");
        }
    }
}