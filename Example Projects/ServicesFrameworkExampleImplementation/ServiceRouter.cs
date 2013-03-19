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
                "Engage/ServicesFrameworkExampleImplementation",
                "default with extension",
                "{controller}.ashx/{action}",
                new[] { "Engage.Dnn.ServicesFrameworkExampleImplementation" });
            mapRouteManager.MapHttpRoute(
                "Engage/ServicesFrameworkExampleImplementation",
                "default",
                "{controller}/{action}",
                new[] { "Engage.Dnn.ServicesFrameworkExampleImplementation" });
        }
    }
}