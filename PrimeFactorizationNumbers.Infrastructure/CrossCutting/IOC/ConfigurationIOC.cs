using Autofac;
using PrimeFactorizationNumbers.Application;
using PrimeFactorizationNumbers.Application.Interfaces;
using PrimeFactorizationNumbers.Application.Interfaces.IMappers;
using PrimeFactorizationNumbers.Application.Mappers;
using PrimeFactorizationNumbers.Domain.Core.Interfaces.Repositories;
using PrimeFactorizationNumbers.Domain.Core.Interfaces.Services;
using PrimeFactorizationNumbers.Domain.Services;
using PrimeFactorizationNumbers.Infrastructure.Data.Repositories;

namespace PrimeFactorizationNumbers.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceUser>().As<IApplicationServiceUser>();
            builder.RegisterType<ApplicationServiceNumber>().As<IApplicationServiceNumber>();
            builder.RegisterType<ServiceUser>().As<IServiceUser>();
            builder.RegisterType<ServiceNumber>().As<IServiceNumber>();
            builder.RegisterType<RepositoryUser>().As<IRepositoryUser>();
            builder.RegisterType<RepositoryNumber>().As<IRepositoryNumber>();
            builder.RegisterType<MapperUser>().As<IMapperUser>();
            builder.RegisterType<MapperNumber>().As<IMapperNumber>();
        }

        #endregion IOC
    }
}
