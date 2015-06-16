using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace Alchemy.RnR.Revisor.Config
{
    /// <summary>
    /// Represents an extension element in the editor configuration for creating a context menu extension.
    /// </summary>
    public class RevisorContextMenu : ContextMenuExtension
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public RevisorContextMenu()
        {
            // This is the id which gets put on the html element for this menu (to target with css/js).
            AssignId = "RevisorContextMenu"; 
            // The name of the extension menu
            Name = "RevisorContextMenu";
            // Where to add the new menu in the current context menu.
            InsertBefore = "cm_refresh";

            //// Generate all of the context menu items...
            //AddSubMenu("cm_helloworld", "Hello World") // creates a submenu item and returns it so you can chain items to it
            //    .AddItem("cm_helloworld_error", "Error Test", "ErrorTest")         // adds following items to above submenu
            //    .AddItem("cm_helloworld_api", "Get Api Version", "GetApiVersion")
            //    .AddItem("cm_helloworld_hi", "Hi!", "HelloWorld");

            //AddSeperator("cm_sep");

            AddItem("cm_revisor", "Get Last Revisor", "Revisor");

            // We need to addd our resource group as a dependency to this extension
            Dependencies.Add<RevisorResourceGroup>();

            // Actually apply our extension to a particular view.  You can have multiple.
            Apply.ToView(Constants.Views.DashboardView);
        }
    }
}
