using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using sheet3_MVC_modelAndViewScaffolding.Models;

namespace sheet3_MVC_modelAndViewScaffolding.Controllers
{
    public class HomeController : Controller
    {



        // GET: Home
        public ActionResult Index()
        {
            DBManager dbm = new DBManager();
            var list = dbm.getAll();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User u)
        {
            DBManager dbm = new DBManager();
            dbm.addRecord(u);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(User u)
        {
            DBManager dbm = new DBManager();
            dbm.deleteRecord(u);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id) {
            DBManager dbm = new DBManager();
           var rec= dbm.details(id);
            return View(rec);
        }

        [HttpPost]
        public ActionResult Edit(User u)
        {
            DBManager dbm = new DBManager();
            dbm.editRecord(u);
            return RedirectToAction("Index");

        }

        public ActionResult Detail(int id) {
            DBManager dbm = new DBManager();
            var curr_record = dbm.details(id);
            return View(curr_record);

        }
    }
}