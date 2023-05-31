using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanThuoc.Models;
using WebBanThuoc.Models.EF;

namespace WebBanThuoc.Areas.Admin.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Category
        public ActionResult Index()
        {
            var items = db.Categories;
            return View(items);
        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Category model)
        {
            if (ModelState.IsValid)
            {
                model.NgayTao = DateTime.Now;
                model.NgaySua = DateTime.Now;
                model.KiHieu = WebBanThuoc.Models.Common.Filter.FilterChar(model.Ten);
                db.Categories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var item = db.Categories.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category model)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Attach(model);
                model.NgaySua = DateTime.Now;
                model.KiHieu = WebBanThuoc.Models.Common.Filter.FilterChar(model.Ten);
                db.Entry(model).Property(x => x.Ten).IsModified = true;
                db.Entry(model).Property(x => x.MoTa).IsModified = true;
                //db.Entry(model).Property(x => x.Link).IsModified = true;
                db.Entry(model).Property(x => x.KiHieu).IsModified = true;
                db.Entry(model).Property(x => x.SeoMoTa).IsModified = true;
                db.Entry(model).Property(x => x.SeoKey).IsModified = true;
                db.Entry(model).Property(x => x.SeoTen).IsModified = true;
                db.Entry(model).Property(x => x.ThuTu).IsModified = true;
                db.Entry(model).Property(x => x.NgaySua).IsModified = true;
                db.Entry(model).Property(x => x.NguoiSua).IsModified = true;
               
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.Categories.Find(id);
            if (item != null)
            {
                var DeleteItem = db.Categories.Attach(item);
                db.Categories.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}