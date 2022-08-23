using customerloggersupport.DBModels;
using customerloggersupport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace customerloggersupport.Controllers
{
    public class AccountController : Controller
    {
        CustomerEntities objRamaEntities = new CustomerEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            LoginModel objLoginModel = new LoginModel();
            return View();
        }

        public ActionResult Register()
        {
            CustLogInfoModel objUserModel = new CustLogInfoModel();
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}