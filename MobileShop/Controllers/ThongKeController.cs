﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileShop.Models.B2B;
using MobileShop.Models;

namespace MobileShop.Controllers
{
    public class ThongKeController : Controller
    {
        //
        // GET: /ThongKe/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ThongKeDoanhThu()
        {
            return View();
        }

        public ActionResult ThongKeDTTheoTG(DateTime? froms, DateTime? tos)
        {
            if (froms == null)
                froms = DateTime.Today.AddMonths(-1);
            if (tos == null)
                tos = DateTime.Today;
            ViewBag.froms = froms.Value.ToShortDateString();
            ViewBag.tos = tos.Value.ToShortDateString();
            DonhangKHModel donhang = new DonhangKHModel();
            return PartialView("TheoTime", donhang.ThongKeDoanhThu(froms, tos).ToList());
        }

        public ActionResult ThongKeTiTrong(DateTime? froms, DateTime? tos)
        {
            if (froms == null)
                froms = DateTime.Today.AddMonths(-1);
            if (tos == null)
                tos = DateTime.Today;
            ViewBag.froms = froms.Value.ToShortDateString();
            ViewBag.tos = tos.Value.ToShortDateString();
            DonhangKHModel donhang = new DonhangKHModel();
            return PartialView("TheoTiTrong", donhang.ThongKeTiTrong(froms, tos).ToList());
        }
	}
}