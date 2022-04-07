using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace LJBPDemo.Infraestructure.Crosscutting.IOC
{
    public class ModuleIOC: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           ConfigurationIOC.Load(builder);
            base.Load(builder);
        }
    }
}
