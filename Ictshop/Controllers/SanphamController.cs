using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ictshop.Models;

namespace Ictshop.Controllers
{
    public class SanphamController : Controller
    {
        CT25Team16Entities db = new CT25Team16Entities();

        // GET: Sanpham
        public ActionResult Adidas()
        {
            var adi = db.Sanphams.Where(n=>n.Mahang==2).Take(4).ToList();
           return PartialView(adi);
        }
        public ActionResult Gucci()
        {
            var guc = db.Sanphams.Where(n => n.Mahang == 1).Take(4).ToList();
            return PartialView(guc);
        }
        public ActionResult Tommi()
        {
            var mi = db.Sanphams.Where(n => n.Mahang == 3).Take(4).ToList();
            return PartialView(mi);
        }
        //public ActionResult dttheohang()
        //{
        //    var mi = db.Sanphams.Where(n => n.Mahang == 5).Take(4).ToList();
        //    return PartialView(mi);
        //}
        public ActionResult xemchitiet(int Masp=0)
        {
            var chitiet = db.Sanphams.SingleOrDefault(n=>n.Masp==Masp);
            if (chitiet == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chitiet);
        }

    }

}