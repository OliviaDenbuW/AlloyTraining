using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "EditorialBlock",
                 GUID = "d67c04c9-b1eb-4010-9f73-e80e74e53ff6",
                 Description = "Use this for a rich editorial text that will be reused in multiple places")]
    [SiteBlockIcon]
    public class EditorialBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Main body",
                 Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                 GroupName = SystemTabNames.Content,
                 Order = 10)]
        public virtual XhtmlString MainBody { get; set; }
    /*
            [CultureSpecific]
            [Display(
                Name = "Name",
                Description = "Name field's description",
                GroupName = SystemTabNames.Content,
                Order = 1)]
            public virtual string Name { get; set; }
     */
}
}