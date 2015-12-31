using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTemplate.Configuration
{
    public static class UnityConfig
    {
        public static void RegisterConfigurationComponents(this IUnityContainer container)
        {
            container.RegisterType<IConfiguration, AppSettingsConfiguration>();
        }
    }
}
