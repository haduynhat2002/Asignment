using Assignment_WAD.Data;
using Assignment_WAD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Assignment_WAD.Data.MyDbContext;

namespace Assignment_WAD.Controllers
{    
    public class HomeController : Controller
    {
        private MyDBContext myDBContext = new MyDBContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Store([Bind(Include = "MaSinhVien,HinhThucNopPhat,SoTienNopPhat")] Student student)
        {

            myDBContext.Students.Add(student);
            myDBContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}