using NitinChandraMVC.DataConnections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NitinChandraMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        Db_Contexts Dbusers = new Db_Contexts();
        public ActionResult Index()
        {
            var detailitem = Dbusers.Users.ToList();
            return View(detailitem);
        }

      
    
    }
}