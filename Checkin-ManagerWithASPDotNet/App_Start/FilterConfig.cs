using System.Web;
using System.Web.Mvc;

namespace Checkin_ManagerWithASPDotNet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
