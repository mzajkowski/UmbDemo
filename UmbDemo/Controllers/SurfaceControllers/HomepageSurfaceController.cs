using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace UmbDemo.Controllers.SurfaceControllers
{
    /*

        Default routing for this type of controllers is:

            /umbraco/surface/{controllername}/{action}/{id}

        Possible to use also with [PluginController("MyPluginName")] attributes.
        Then routing for plugin based controller will look like that:

            /umbraco/{pluginname}/{controllername}/{action}/{id}

    */
    public class HomepageSurfaceController : SurfaceController
    {
        public ActionResult Index()
        {
            return Content("Hello from the other side....");
        }
    }
}