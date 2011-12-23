using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProductList.Models;

namespace MyProductList.Controllers
{ 
    public class HomeController : Controller
    {
        private ProductContext db = new ProductContext();

        //
        // GET: /Home/

        public ViewResult Index()
        {
            //return View(db.Products.ToList());
            using (var db = new ProductContext())
            {
                return View(db.Products.ToList());//does it
            }
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}