using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTemplate.Data
{
    public static class UnityConfig
    {
        public static void RegisterDataLayerComponents(this IUnityContainer container)
        {
            container.RegisterType<IDbConnection, SqlConnection>("Phoenix",
                new InjectionConstructor(ConfigurationManager.ConnectionStrings["Phoenix"].ConnectionString));
            container.RegisterType<ISmileyData, SmileyData>();
        }
    }
}
