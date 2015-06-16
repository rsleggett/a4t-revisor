using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace Alchemy.RnR.Revisor.Config
{
    /// <summary>
    /// Represents the <commandset /> gui ext configuration element for your extension. Contains references
    /// to your command js files.
    /// </summary>
    /// <remarks>
    /// If you use the suger syntax for creating commands via Alchemy.command(), or if you ensure your command
    /// namespaces follow the Alchemy naming rules (Alchemy.Plugins.{YourPluginName}.Commands, you only need to
    /// AddCommand() with the name of your command only.
    /// 
    /// If your command uses another namespace convention, you'll have to use the 2nd argument to pass in your full
    /// interface name.
    /// </remarks>
    public class RevisorCommandSet : CommandSet
    {
        public RevisorCommandSet()
        {
            AddCommand("Revisor");
        }
    }
}
