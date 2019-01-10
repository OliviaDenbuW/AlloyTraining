using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Business.SelectionFactories;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Product",
                 GroupName = SiteGroupNames.Specialized,
                 Order = 20,
                 GUID = "aa2bd08b-e52e-486a-a135-532802296fc8",
                 Description = "Use this for software products that Alloy sells")]
    [SiteCommerceIcon]
    public class ProductPage : StandardPage
    {
        [SelectOne(SelectionFactoryType = typeof(ThemeSelectionFactory))]
        [Display(Name = "Color theme",
                 GroupName = SystemTabNames.Content,
                 Order = 310)]
        public virtual string Theme { get; set; }

        [CultureSpecific]
        [Display(Name = "Unique selling points",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        [Required]
        public virtual IList<string> UniqueSellingPoints { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);

            Theme = "theme1";
        }
    }
}