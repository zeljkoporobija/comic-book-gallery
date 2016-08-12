using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }//it contains HTML content in Controller
        public Artist[] Artists { get; set; }//a new class has to be made, since it has two values - role and name; the array is no longer string[] but Artist[]
        public bool Favorite { get; set; }
    }
}