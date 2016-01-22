using System.Linq;
using Umbraco.Core;
using Umbraco.Core.Services;

namespace UmbDemo.BusinessLogic.Handlers
{
    public class UmbracoEvents : IApplicationEventHandler
    {
        public void OnApplicationInitialized(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            /*
            
                Those are only events related with ContentService.
                Check all available events and services here:

                https://our.umbraco.org/Documentation/Reference/Events/

            */
            //ContentService.Created += ContentService_New;
            //ContentService.Saving += ContentService_Saving;
            //ContentService.Saved += ContentService_Saved;
            //ContentService.Published += Content_Published;
            //ContentService.Publishing += ContentService_Publishing;
            //ContentService.UnPublished += Content_Unpublished;
            //ContentService.Moved += Content_Moved;
            //ContentService.Trashed += Content_Trashed;
            //ContentService.Deleted += Content_Deleted;
            ContentService.Saving += ContentService_Saving;
        }

        private void ContentService_Saving(IContentService sender, Umbraco.Core.Events.SaveEventArgs<Umbraco.Core.Models.IContent> e)
        {
            foreach (var content in e.SavedEntities)
            //foreach (var content in e.SavedEntities.Where(x => x.IsNewEntity())) //// A lot more possibilities than that!
            {
                if (!content.HasProperty("bodyText") || !content.HasProperty("excerpt")) continue;

                var bodyText = content.GetValue<string>("bodyText");
                content.SetValue("excerpt", bodyText == null 
                    ? string.Empty
                    : string.Join("", bodyText.StripHtml().StripNewLines().Take(200)));
            }
        }

        public void OnApplicationStarting(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
        }

        public void OnApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
        }
    }
}
