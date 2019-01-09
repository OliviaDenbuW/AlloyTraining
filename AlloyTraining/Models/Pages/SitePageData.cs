using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace AlloyTraining.Models.Pages
{
    public abstract class SitePageData : PageData
    {
        [CultureSpecific]
        [Display(Name = "Meta title",
                 GroupName = SiteTabNames.SEO,
                 Order = 100)]
        [StringLength(60, MinimumLength = 5)]
        public virtual string MetaTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "Meta keywords",
                 GroupName = SiteTabNames.SEO,
                 Order = 200)]
        public virtual string MetaKeywords { get; set; }

        [CultureSpecific]
        [Display(Name = "Meta description",
                 GroupName = SiteTabNames.SEO,
                 Order = 300)]
        [UIHint(UIHint.Textarea)] //Gör så man får flera rader istället för en på text
        public virtual string MetaDescription { get; set; }

        [UIHint(UIHint.Image)] //Filtrerar för att bara visa bilder
        [Display(Name = "Page imgae",
                 GroupName = SystemTabNames.Content,
                 Order = 100)]
        public virtual ContentReference PageImage { get; set; }

        //public virtual string MetaTitle { get; set; }
    }
}