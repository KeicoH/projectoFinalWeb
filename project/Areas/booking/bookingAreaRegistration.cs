using System.Web.Mvc;

namespace project.Areas.booking
{
    public class bookingAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "booking";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "booking_default",
                "booking/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}