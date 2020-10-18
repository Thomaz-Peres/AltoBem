using AltoBem.Application;
using AltoBem.Application.Interfaces;
using AltoBem.Application.Interfaces.Mappers;
using AltoBem.Application.Mappers;
using AltoBem.Domain.Core.Interfaces.Repositorys;
using AltoBem.Domain.Core.Interfaces.Services;
using AltoBem.Domain.Services;
using AltoBem.Infrastructure.Data.Repositorys;
using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace AltoBem.Infrastructure.CrossCutting.DependencyInjection
{
    public class ConfigurationDI
    {
        public static void Load(ContainerBuilder builder)
        {
            //  application
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProdutos>().As<IApplicationServiceProduto>();
            builder.RegisterType<ApplicationServiceCategoria>().As<IApplicationServiceCategoria>();
            //  application

            //  services
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<ServiceCategoria>().As<IServiceCategoria>();
            //  services

            //  repository
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProdutos>().As<IRepositoryProdutos>();
            builder.RegisterType<RepositoryCategoria>().As<IRepositoryCategoria>();
            //  repository

            //  mapper
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProdutos>().As<IMapperProdutos>();
            builder.RegisterType<MapperCategoria>().As<IMapperCategoria>();
            //  mapper
        }
    }
}
