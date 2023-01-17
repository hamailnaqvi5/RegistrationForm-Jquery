using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserRegistration.Models;

namespace UserRegistration.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            db_user userModel = new db_user();
            return View(userModel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(db_user userModel)       
        {
            using (Model1 db_user = new Model1())
            {
              db_user.db_user.Add(userModel);
                db_user.SaveChanges();
                //return View(db_user);
            }
            return View();
        }

    }
}
