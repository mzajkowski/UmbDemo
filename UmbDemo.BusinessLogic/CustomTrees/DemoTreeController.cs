using System;
using System.Net.Http.Formatting;
using Umbraco.Web.Models.Trees;
using Umbraco.Web.Mvc;
using Umbraco.Web.Trees;

namespace UmbDemo.BusinessLogic.CustomTrees
{
    [Tree("demoSection", "demoTree", "Demo Tree")]
    [PluginController("Demo")]
    public class DemoTreeController : TreeController
    {
        protected override TreeNodeCollection GetTreeNodes(string id, FormDataCollection queryStrings)
        {
            if (id != "-1") throw new NotSupportedException();

            var nodes = new TreeNodeCollection
            {
                CreateTreeNode("demo", id, new FormDataCollection(""), "Demo")
            };
            return nodes;
        }

        protected override MenuItemCollection GetMenuForNode(string id, FormDataCollection queryStrings)
        {
            return null;
        }
    }
}
