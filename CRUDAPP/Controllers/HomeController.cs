using CRUDAPP.ContextDB;
using CRUDAPP.ContextDB.EntityData;
using CRUDAPP.Models;
using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDAPP.Controllers
{
    public class HomeController : Controller
    {
        CRUD_V1Entities db = new CRUD_V1Entities();
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
        //httpget


        [HttpPost]
        public ActionResult GetDataAll()
        {
            var Data = db.tblCURDs.ToList();
            return Json(Data);
        }
        
        [HttpPost]
        public ActionResult Create(UserEntity user)
        {
            var fnCreate = new UserController();
            var status = fnCreate.insert(user);
            return Json(status);
        }

        [HttpPost]
        public ActionResult Del(UserEntity user)
        { 
            var fnDel = new UserController();
            var status = fnDel.DelData(user);
            return Json(status);
        }
        public ActionResult Update(UserEntity user)
        {
            var fnUpdate = new UserController();
            var status = fnUpdate.update(user);
            return Json(status);
        }
    }
}