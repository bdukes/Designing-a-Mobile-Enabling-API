using System.Linq;

namespace Engage.Dnn.ServicesFrameworkExampleImplementation
{
    using DotNetNuke.Web.Api;

    using Engage.Annotations;

    [UsedImplicitly]
    public class ServiceRouter : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute(
                moduleFolderName: "Engage/ServicesFrameworkExampleImplementation",
                routeName: "default with extension",
                url: "{controller}.ashx",
                namespaces: new[] { "Engage.Dnn.ServicesFrameworkExampleImplementation" });
            mapRouteManager.MapHttpRoute(
                "Engage/ServicesFrameworkExampleImplementation",
                "default",
                "{controller}",
                new[] { "Engage.Dnn.ServicesFrameworkExampleImplementation" });
        }
    }
}