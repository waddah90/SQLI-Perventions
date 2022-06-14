using LoginTemple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginTemple.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        SQLdbEntities db = new SQLdbEntities();


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(UserAccount user )
        {
          var UserAccount =  db.UserAccounts.Where(x => x.UserName == user.UserName && x.Password == user.Password).Count();

          if (UserAccount > 0)
          {
              return RedirectToAction("LoginSuccess");
          }
              else 
              {
                  return RedirectToAction("LoginFailed");

              }
        }


        public ActionResult LoginSuccess()
        {
            return View();
        }

        public ActionResult LoginFailed()
        {
            return View();
        }


        public ActionResult Register()
        {
            return View();
        }

    }
}
