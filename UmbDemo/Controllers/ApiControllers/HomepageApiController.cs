using System.Collections.Generic;
using Umbraco.Web.WebApi;

namespace UmbDemo.Controllers.ApiControllers
{
    /*

        Default routing for this type of controllers is:

            /umbraco/api/{controllername}/{action}

        Possible to use also with [PluginController("MyPluginName")] attributes.
        Then routing for plugin based controller will look like that:

            /umbraco/{pluginname}/{controllername}/{action}

    */
    public class HomepageApiController : UmbracoApiController
    {
        public IEnumerable<string> GetAllProducts()
        {
            return new[] { "Snowboard", "Bindings", "Boots", "Wax", "Goggles" };
        }
    }
}