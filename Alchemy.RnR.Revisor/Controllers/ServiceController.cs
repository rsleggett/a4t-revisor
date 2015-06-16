using Alchemy4Tridion.Plugins;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tridion.ContentManager.CoreService.Client;

namespace Alchemy.RnR.Revisor.Controllers
{
    /// <summary>
    /// A WebAPI web service controller that can be consumed by your front end.
    /// </summary>
    /// <remarks>
    /// The following conditions apply:
    ///     1.) Must have AlchemyRoutePrefix attribute. You pass in the type of your AlchemyPlugin (the one that inherits AlchemyPluginBase).
    ///     2.) Must inherit AlchemyApiController.
    ///     3.) All Action methods must have an Http Verb attribute on it as well as a RouteAttribute (otherwise it won't generate a js proxy).
    /// </remarks>
    [AlchemyRoutePrefix(typeof(AlchemyPlugin), "Service")]
    public class ServiceController : AlchemyApiController
    {
        [HttpGet]
        [Route("Revisor/{id}")]
        public string Revisor(string id)
        {
            using (var client = new SessionAwareCoreServiceClient("netTcp_2013"))
            {
                client.Impersonate("TRAIN1\\Administrator");
                var item = (IdentifiableObjectData)client.Read("tcm:" + id, null);

                //check the username who last modified the component 
                var versionInfo = (FullVersionInfo)item.VersionInfo;
                LinkToUserData revisor = versionInfo.Revisor;
                return revisor.Title;
            }
        }
    }
}
