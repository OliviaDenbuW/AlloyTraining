using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlloyTraining
{
    public class SiteContentIcons
    {
    }

    public class SiteImageUrlAttribute : ImageUrlAttribute
    {
        public SiteImageUrlAttribute()
            : base("~/Static/contenticons/epi-edu-icon.jpg") { }

        public SiteImageUrlAttribute(string path)
            : base(path) { }
    }
}