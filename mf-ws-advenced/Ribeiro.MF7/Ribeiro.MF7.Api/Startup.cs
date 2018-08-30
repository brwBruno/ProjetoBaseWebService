using Microsoft.Owin;
using Owin;
using Ribeiro.MF7.Api.App_Start;
using Ribeiro.MF7.Api.Ioc;
using Ribeiro.MF7.Api.Logger;
using SimpleInjector.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;
using System.Web.Http;

[assembly: OwinStartup(typeof(Ribeiro.MF7.Api.Startup))]

namespace Ribeiro.MF7.Api
{
    [ExcludeFromCodeCoverage]
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            SimpleInjectorContainer.Initializer();
            //AutoMapperInitializer.Initialize();
            HttpConfiguration config = new HttpConfiguration()
            {
                DependencyResolver = new SimpleInjectorWebApiDependencyResolver
                (SimpleInjectorContainer.ContainerInstance)
            };
            
            WebApiConfig.Register(config);
            
            OAuthConfig.ConfigureOAuth(app);

            config.MessageHandlers.Add(new CustomLogHandler());
            
            app.UseWebApi(config);
        }
    }
}