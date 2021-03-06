using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MobileShop.Models;
using System.Web;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using System.Web.Http.Cors;

namespace MobileShop.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class OrdersController : ApiController
    {
        private Entities db = new Entities();

        // GET api/Orders
        //[HttpGet]
        //[Route("api/orders")]
        //[Authorize]
        //public HttpResponseMessage GetHopDongNCCs(string supplier_key)
        //{
        //    try
        //    {
        //            var maNcc = from p in db.Oauths where p.Consumer_key == supplier_key select new { MaNCC = p.MaNCC };
        //            string ma = maNcc.ToList()[0].MaNCC;
        //            var listofHD = (from p in db.HopDongNCCs where p.MaNCC == ma select new { order_id = p.MaHD, product_id = p.MaSP, product_name = p.SanPham.TenSP, product_quantity = p.SanPham.SoLuong });
        //            return Request.CreateResponse(HttpStatusCode.OK, listofHD.ToList());
                
        //    }
        //    catch (Exception e) { return Request.CreateResponse(HttpStatusCode.NotFound); }
        //}

        [HttpGet]
        [Route("api/orders/{supplier_key}")]
        [IdentityAuthentication(true)] // enable basic for this action
        public HttpResponseMessage GetHopDongNCC(string supplier_key)
        {
            try
            {
                    var maNcc = from p in db.Oauths where p.Consumer_key == supplier_key select new { MaNCC = p.MaNCC };
                    string ma = maNcc.ToList()[0].MaNCC;
                    var listofHD = (from p in db.HopDongNCCs where p.MaNCC == ma select new { order_id = p.MaHD, product_id = p.MaSP, product_name = p.SanPham.TenSP, product_quantity = p.SanPham.SoLuong });
                    return Request.CreateResponse(HttpStatusCode.OK, listofHD.ToList());

            }
            catch (Exception e) { return Request.CreateResponse(HttpStatusCode.NotFound); }
        }

        }
    }
}