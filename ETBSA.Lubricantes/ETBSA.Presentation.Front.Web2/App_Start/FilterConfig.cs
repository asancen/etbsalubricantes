using System.Web;
using System.Web.Mvc;

namespace ETBSA.Presentation.Front.Web2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
