using System.Web;
using System.Web.Mvc;

namespace Silverstone_Software_Technical_Test
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
