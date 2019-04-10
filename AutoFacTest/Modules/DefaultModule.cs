using Autofac;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IService;
using Domain;

namespace AutoFacTest.Modules
{
    public class DefaultModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //base.Load(builder);
            //注入测试服务
            builder.RegisterType<TestService>().As<ITestService>();
        }

    }
}
