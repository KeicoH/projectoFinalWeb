using System.Web.Mvc;

namespace project.Areas.book
{
    public class bookAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "book";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "book_default",
                "book/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}