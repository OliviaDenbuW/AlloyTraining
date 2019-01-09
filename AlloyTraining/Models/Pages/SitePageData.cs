using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;

namespace AlloyTraining.Models.Pages
{
    public abstract class SitePageData : PageData
    {
        public virtual string MetaTitle { get; set; }

        public virtual string MetaKeywords { get; set; }

        public virtual string MetaDescription { get; set; }

        public virtual ContentReference PageImage { get; set; }

        //public virtual string MetaTitle { get; set; }
    }
}