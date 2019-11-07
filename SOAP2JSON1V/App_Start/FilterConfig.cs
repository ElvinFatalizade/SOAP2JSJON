using System.Web;
using System.Web.Mvc;

namespace SOAP2JSON1V
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
