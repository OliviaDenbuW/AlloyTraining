using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using EPiServer.Security;


namespace AlloyTraining
{
    [GroupDefinitions]
    public static class SiteTabNames
    {
        //The user must have "Edit access" to be able to see this tab = (Change access rights)
        [Display(Order = 10)] //För att sortera horisontella tabbar
        [RequiredAccess(AccessLevel.Edit)]
        public const string SEO = "SEO";

        //The user must have "Administer" access level to see this tab
        [Display(Order = 20)]
        [RequiredAccess(AccessLevel.Administer)]
        public const string SiteSettings = "Site Settings";
    }
}