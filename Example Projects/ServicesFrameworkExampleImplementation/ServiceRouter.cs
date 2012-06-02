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
                "E",
                "{controller}.ashx/{action}/{id}",
                new { controller = "Example", action = "Index", id = string.Empty },
                new[] { "E" });
        }
    }
}