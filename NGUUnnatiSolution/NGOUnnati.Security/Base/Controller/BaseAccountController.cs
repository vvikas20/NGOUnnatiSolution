using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace NGOUnnati.Security.Base.Controller
{
    public class BaseAccountController : BaseController
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
    }
}
