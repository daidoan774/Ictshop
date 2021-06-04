using Ictshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ictshop.Controllers
{
    public class ThanhToanController : Controller
    {
        CT25Team16Entities db = new CT25Team16Entities();
        // GET: ThanhToan
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Thanhtoan(ThanhToan thanhtoan)
        {
            try
            {
                // Them ten nguoi mua vao db
                db.ThanhToans.Add(thanhtoan);
                // Lưu lại vào cơ sở dữ liệu
                db.SaveChanges();
                // Nếu dữ liệu đúng thì trả về trang đăng nhập
                if (ModelState.IsValid)
                {
                    return RedirectToAction("DangNhap");
                }
                return View("ThanhToan");

            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Thanhtoan(FormCollection paylog)
        {
            string fName = paylog["HoVaTen"].ToString();
            string diaChi = paylog["DiaChi"].ToString();
            string email = paylog["Email"].ToString();
            int sdt = paylog["SDT"].Count();

          
            if (ModelState.IsValid )
            {
                return View(paylog);
            }
           else
            {
                return View("DangNhap");
            }    
        }
    }
   
}
