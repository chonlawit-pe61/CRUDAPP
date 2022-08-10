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
        private readonly UserController _Controller; 
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
            try
            {
                var DataUserAll  = _Controller.getData();
                return Json(DataUserAll);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
        
        [HttpPost]
        public ActionResult Create()
        {
            try
            {
                _Controller.insert();
                return Json("Insert Data is Sucess");
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Del()
        {
            try
            {
                _Controller.DelDataUser();
                return Json("Del Data is Sucess");
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
        public ActionResult Update()
        {
            try
            {
                _Controller.UpDateDbUser();
                return Json("Updata Data is Sucess");
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
    }
}