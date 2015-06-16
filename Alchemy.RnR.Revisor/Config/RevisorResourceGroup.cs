using Alchemy4Tridion.Plugins.GUI.Configuration;
using Alchemy4Tridion.Plugins.GUI.Configuration.Elements;

namespace Alchemy.RnR.Revisor.Config
{
    /// <summary>
    /// Represents the ResourceGroup element within the editor configuration that contains this plugin's files
    /// and references.
    /// </summary>
    public class RevisorResourceGroup : ResourceGroup
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public RevisorResourceGroup()
        {
            
            // When adding files you only need to specify the filename and not full path
            //AddFile("ErrorTestCommand.js");
            //AddFile("GetApiVersionCommand.js");
            //AddFile("HelloWorldCommand.js");
            AddFile("RevisorCommand.js");
            AddFile("ShowRevisorPageCommand.js");

            //AddFile("Hello.css");

            // When referencing commandsets you can just use the generic AddFile with your CommandSet as the type.
            AddFile<RevisorCommandSet>();

            // The above is just a convinient way of doing the following...
            // AddFile(FileTypes.Reference, "Alchemy.Plugins.HelloWorld.Commands.HelloCommandSet");
            
            // If you want this resource group to contain the js proxies to call your webservice, call AddWebApiProxy()
            AddWebApiProxy();
        }
    }
}
