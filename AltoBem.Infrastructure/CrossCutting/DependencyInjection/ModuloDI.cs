using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltoBem.Infrastructure.CrossCutting.DependencyInjection
{
    public class ModuloDI : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationDI.Load(builder);
        }
    }
}
