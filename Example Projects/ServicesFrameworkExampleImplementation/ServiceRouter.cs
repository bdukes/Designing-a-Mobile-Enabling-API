using System.Linq;

namespace Engage.Dnn.ServicesFrameworkExampleImplementation
{
    using DotNetNuke.Web.Services;

    using Engage.Annotations;

    [UsedImplicitly]
    public class ServiceRouter : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapRoute(
                "Engage/ServicesFrameworkExampleImplementation",
                "{controller}.ashx/{action}",
                new[] { "Engage.Dnn.ServicesFrameworkExampleImplementation" });
            mapRouteManager.MapRoute(
                "Engage/ServicesFrameworkExampleImplementation",
                "{controller}/{action}",
                new[] { "Engage.Dnn.ServicesFrameworkExampleImplementation" });
        }
    }
}