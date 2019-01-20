using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Party2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
//        public ActionResult Index()
//        {
//            return View();
//        }

/*        //第一个版本，返回一个字串
        //路由：/或/home指向HomeControler
        //index或空，指向Index
        //所以这个可以用/,/home,/home/index访问到
        public string Index()
        {
            return "Hello World";
        }*/

        /*
         * 批二个版本，指向一个视图。
         * 视图的名字也是约定
         */
        /*public ViewResult Index()
        {
            return View();
        }*/

/*
 * 第三个版本，动态数据
 */
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        /*
         * 第四个版本，增加一个表单视图
         */
        public ViewResult RsvpForm()
        {
            return View();

        }

    }
}