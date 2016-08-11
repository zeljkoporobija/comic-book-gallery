using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller 
        //we had to add directive using Syste.Web.Mvc; the class has to be public and it needs to inherit ControllerBase Class
    {
        //Action method - every public method on a controller
        //public ContentResult Detail(), changed to
        public ActionResult Detail()
        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Thursday)//(today is Thursday, and by typing ComicBooks/Details we are redirected to the HomePage
            {
                //return new RedirectResult("/");//press CTRL+F12 to see its base class (ActionResult); now it can be replaced with
                return Redirect("/");
            }
            /*instead of return string Detail()
             * return "Hello from the Comic books controler";
             * Yet, since we need to instantiate ContentResult Class, we write
            */
            //return new ContentResult()//CTRL+F12 -its base class is also ActionResult
            //thus, in the end, we write:
            return Content("Hello from the Comic books controller");
           }
        }
}