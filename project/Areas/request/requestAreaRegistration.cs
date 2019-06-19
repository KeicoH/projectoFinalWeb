using System.Web.Mvc;

namespace project.Areas.request
{
    public class requestAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "request";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "request_default",
                "request/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}