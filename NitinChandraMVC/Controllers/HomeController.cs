using NitinChandraMVC.DataConnections;
using NitinChandraMVC.Models;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;



namespace NitinChandraMVC.Controllers
{
    public class HomeController : Controller
    {
        Db_Contexts Db = new Db_Contexts();
        public ActionResult Index()
        {
            //var avg = Db.Books.Sum(x => x.Book_Price);
            //ViewBag.NoOfClassesMoreThanAvg = Db.Books.Count(x => x.Book_Price > avg);

            //TempData["kk"] = Db.Books.Count(m => m.BookId > );

            //ViewBag.add = ViewBag.NoOfClassesMoreThanAvg + 2;

            return View();
        }

        public ActionResult Table()
        {
            var data = Db.Books.ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(UserModel e)
        {
            UserModel obj = new UserModel();
            Db.Users.Add(e);
            Db.SaveChanges();

            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserModel lg)
        {
            var username = Db.Users.Where(model => model.Name == lg.Name).FirstOrDefault();
            var pass = Db.Users.Where(model => model.Password == lg.Password).FirstOrDefault();

            if (username == null && pass == null)
            {
                TempData["name1"] = "Your Name is Wrong:-";
                TempData["name2"] = "Your Password is Wrong:-";
            }
            else
            {
                if (username.Name == lg.Name && username.Password == lg.Password)
                {
                    FormsAuthentication.SetAuthCookie(username.Name, false);
                    Session["Useremail"] = username.Name;
                    Session["Userpassword"] = username.Password;

                    return RedirectToAction("Table", "Home");
                }
            }
            return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        public ActionResult MyProfile()
        {

            var item = Db.Users.ToList();

            return View(item);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}