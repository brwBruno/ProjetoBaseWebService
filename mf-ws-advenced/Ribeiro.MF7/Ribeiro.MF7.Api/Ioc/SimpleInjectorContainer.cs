using Ribeiro.MF7.Applications.Features.Authentications;
using Ribeiro.MF7.Domain.Features.Users;
using Ribeiro.MF7.Infra.ORM.Contexts;
using Ribeiro.MF7.Infra.ORM.Features.Users;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Ribeiro.MF7.Api.Ioc
{
    public class SimpleInjectorContainer
    {
        public static Container ContainerInstance { get; private set; }

        public static void Initializer()
        {
            ContainerInstance = new Container();

            ContainerInstance.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            RegisterServices();

            ContainerInstance.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            ContainerInstance.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(ContainerInstance);
        }

        public static void RegisterServices()
        {
            ContainerInstance.Register<IAuthenticationService, AuthenticationService>();
            ContainerInstance.Register<IUserRepository, UserRepository>();

            ContainerInstance.Register(() => new RibeiroMF7Context(), Lifestyle.Scoped);
        }
    }
}