using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace Alchemy.RnR.Revisor.Config
{
    public class RevisorPageViewGroup : ResourceGroup
    {
        public RevisorPageViewGroup()
            : base("PageView")
        {
            Dependencies.AddAlchemyCore();
            Dependencies.AddLibraryJQuery();
            AddFile("RevisorPage.js");
            AddFile("RevisorPage.css");
            AddWebApiProxy();
        }
    }
}
