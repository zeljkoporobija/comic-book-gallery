using ComicBookGallery.Data;
using ComicBookGallery.Models;
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
        private ComicBookRepository _comicBookRepository = null; //naming convention for private fields

        public ComicBooksController()//constructor - no return type; the name is like a class name
        {
            _comicBookRepository = new ComicBookRepository();
        }
        //Action method - every public method on a controller
        //public ContentResult Detail(), changed to
        public ActionResult Detail(int? id)//int is set to nullable
        {
            //PASSING THE DATA TO VIEW W/OUT VIEWBAG - OBJECT INITIALIZER SYNTAX:
            //var comicBook = new ComicBook()//necessarily to press the light bulb and give directive use CommicBookGallery.Models
            //{
            //    SeriesTitle = "The Amazing Spider-Man",
            //    IssueNumber = 700,
            //    DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
            //    Artists = new Artist[]
            //    {
            //        new Artist() { Name = "Dan Slott", Role = "Script" },
            //        new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
            //        new Artist() { Name = "Vicot Olazaba", Role = "Inks" },
            //        new Artist() { Name = "Edgar Delgado", Role = "Colors" },
            //        new Artist() { Name = "Chris Eliopoulos", Role = "Letters" }
            //    }

            //}; -> MOVED TO ComicBookRepository.cs!!!

            //OLD VERSION OF DATA
            //var seriesTitle = "The Amazing Spider-Man"; we put ViewBag object here and the variable's name is capitalized
            //ViewBag.SeriesTitle = "The Amazing Spider-Man";//ViewBag is dynamic
            //ViewBag.IssueNumber = 700;
            //ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            //ViewBag.Artists = new string[]
            //{
            //    "Script: Dan Slott",
            //    "Pencils: Humberto Ramos",
            //    "Inks: Victor Olazaba",
            //    "Colors: Edgar Delgado",
            //    "Letters: Chris Eliopoulos"
            //};
            /*if(DateTime.Today.DayOfWeek == DayOfWeek.Thursday)//(today is Thursday, and by typing ComicBooks/Details we are redirected to the HomePage
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
            //return Content("Hello from the Comic books controller");
            //since all of the code in { } belongs to View, the only thing we need to write here is:
            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookRepository.GetComicBook((int)id);//explicit cast; the other option is (id.Value)

            return View(comicBook);
           }
        }
}