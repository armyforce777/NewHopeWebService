using NewHopeWebService.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewHopeWebService.Controllers
{
    public class UserController : Controller
    {
        // GET: User

        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAllUsers()
        {
            ArrayList users = new ArrayList();

            //Get all users
            using (NewHopeDBEntities db = new NewHopeDBEntities())
            {
                foreach(TblUser user in db.TblUsers)
                {
                    users.Add(user);
                }
            }

            return new JsonResult { Data = users, JsonRequestBehavior = JsonRequestBehavior.AllowGet};
        }
    }
}