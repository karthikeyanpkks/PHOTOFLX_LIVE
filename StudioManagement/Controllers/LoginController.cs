using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudioManagement.Models;
namespace StudioManagement.Controllers
{
    public class StugMngController : Controller
    {
        //
        // GET: /Login/
        private StudioMng db = new StudioMng();
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult CheckValidate(Login log)
        {
            StudioReg studioreg = db.Database.SqlQuery<StudioReg>("select * from StudioRegs where Email='"+log.Email+"'").FirstOrDefault();
            if (studioreg == null || studioreg.ToString().Length==0)
            {
                return Content("We are sorry User Name and Password wrong !!");
            }
            return RedirectToAction("Index", "User");
        }

    }
}
