using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTemplate.Service
{
    public static class UnityConfig
    {
        public static void RegisterServiceComponents(this IUnityContainer container)
        {
            container.RegisterType<ISmileyService, SmileyService>();
        }
    }
}
