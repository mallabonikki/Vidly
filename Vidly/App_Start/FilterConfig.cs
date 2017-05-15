using System.Web;
using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute()); // This filter redirects the user to an error page when an action throws an exception 
            filters.Add(new AuthorizeAttribute()); // Global restriction filtering to the users
        }

    }
}
