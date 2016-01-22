using System.Collections.Generic;
using Umbraco.Web.WebApi;

namespace UmbDemo.Controllers
{
    public class BackofficeController : UmbracoAuthorizedApiController
    {
        /*
        
            Those methods requires authentication in backoffice.

        */
        public IEnumerable<string> GetAllProducts()
        {
            return new[] { "Snowboard", "Bindings", "Boots", "Wax", "Goggles" };
        }
    }
}