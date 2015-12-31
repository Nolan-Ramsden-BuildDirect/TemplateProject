using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Microsoft.Practices.Unity;
using System.Web.Http.Dependencies;
using System.Web.Http.Controllers;

namespace WebApiTemplate
{
    using WebApiTemplate.Configuration;
    using WebApiTemplate.Service;
    using WebApiTemplate.Data;

    public static class UnityConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();

            container.RegisterConfigurationComponents();
            container.RegisterServiceComponents();
            container.RegisterDataLayerComponents();

            config.DependencyResolver = new UnityDependencyResolver(container);
        }
    }

    #region Unity Scaffolding
    class UnityDependencyResolver : UnityDependencyScope, IDependencyResolver
    {
        public UnityDependencyResolver(IUnityContainer container)
            : base(container) { }
        public IDependencyScope BeginScope()
        {
            var childContainer = Container.CreateChildContainer();
            return new UnityDependencyScope(childContainer);
        }
    }
    class UnityDependencyScope : IDependencyScope
    {
        protected IUnityContainer Container { get; private set; }
        public UnityDependencyScope(IUnityContainer container)
        {
            Container = container;
        }
        public object GetService(Type serviceType)
        {
            if (typeof(IHttpController).IsAssignableFrom(serviceType))
            {
                return Container.Resolve(serviceType);
            }
            try { return Container.Resolve(serviceType); }
            catch { return null; }
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Container.ResolveAll(serviceType);
        }
        public void Dispose()
        {
            Container.Dispose();
        }

    }
    #endregion
}