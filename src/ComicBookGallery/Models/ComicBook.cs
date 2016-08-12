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

        public string DisplayText //a string value that will uniquely identify the comic book for our users; read-only, cannot be changed, so there's no a setter
        {
            get
            {
                return SeriesTitle + "#" + IssueNumber;
            }
        }
        //all image titles follow the pattern series-title-issuenumber.jpg
        public string CoverImageFileName
        {
            get
            {   //func Replace - what to replace and which value replaces (in order to get the title with -
                return SeriesTitle.Replace(" ", "-")
                    .ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
    }
}