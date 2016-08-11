using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller //we had to add directive using Syste.Web.Mvc; the class has to be public
    {
        //Action method
        public string Detail()
        {
            return "Hello from the Comic books controller";//we get again the error 404, but when we typed in the address bar http://localhost:60567/ComicBooks/Detail we see the message
        }
    }
}