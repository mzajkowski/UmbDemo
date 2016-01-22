using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace UmbDemo.Controllers.HijackControllers
{
    public class HomepageController : RenderMvcController
    {
        /* 
            
            Gets a page with Template name "Homepage" 
            and DocumentType "Homepage" (naming in Controller name).

        */
        public ActionResult Homepage(RenderModel model)
        {
            //// Other logic required here...
            //// if(model.Something) { ... } else { ... }
            return CurrentTemplate(model);
        }
    }
}