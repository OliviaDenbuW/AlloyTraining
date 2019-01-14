using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "Teaser",
                 GUID = "26ce6606-7fe1-41a0-a6ea-4c68411d2034",
                 Description = "Use this for rich text with heading, image and page link that will be reused in multiple places")]
    [SiteBlockIcon]
    public class TeaserBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Heading",
                 GroupName = SystemTabNames.PageHeader,
                 Order = 10)]
        public virtual string TeaserHeading { get; set; }

        [CultureSpecific]
        [Display(Name = "Rich text",
                Order = 20)]
        public virtual XhtmlString TeaserText { get; set; }

        [Display(Name = "Image",
                 GroupName = SystemTabNames.PageHeader,
                 Order = 30)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference TeaserImage { get; set; }

        [Display(Name = "Link",
                 GroupName = SystemTabNames.PageHeader,
                 Order = 40)]
        public virtual PageReference TeaserLink { get; set; }
    }
}       