using System.Web;
using System.Web.Mvc;

namespace ASPNetMVC.EF6.UnityMvc3.RepositoryPattern
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
