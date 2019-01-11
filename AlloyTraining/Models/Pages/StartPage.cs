﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Start",
                 GUID = "6e202f38-481c-488c-90c5-d79092f83b40",
                 GroupName = SiteGroupNames.Specialized,
                 Order = 10,
                 Description = "The home page for a website with an area blocks and partial pages.")]
    [SiteStartIcon]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage) })]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "If the page heading is not set, it will fallback to Name",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(Name = "Main content area",
                 Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
                 GroupName = SystemTabNames.Content,
                 Order = 30)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData), typeof(ImageData), typeof(ContentFolder))]
        public virtual ContentArea MainContentArea { get; set; }

        [CultureSpecific]
        [Display(Name = "Footer text",
                 Description = "The footer text will be shown at the bottom of every page.",
                 GroupName = SiteTabNames.SiteSettings, Order = 10)]
        public virtual string FooterText { get; set; }
    }
}