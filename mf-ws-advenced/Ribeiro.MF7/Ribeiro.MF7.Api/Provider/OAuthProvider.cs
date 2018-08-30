using Microsoft.Owin.Security.OAuth;
using Ribeiro.MF7.Api.Ioc;
using Ribeiro.MF7.Applications.Features.Authentications;
using Ribeiro.MF7.Domain.Features.Users;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace Ribeiro.MF7.Api.Provider
{
    public class OAuthProvider : OAuthAuthorizationServerProvider
    {
        public OAuthProvider() : base()
        {

        }

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
            return Task.FromResult<object>(null);
        }

        public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Acess-Control-Allow-Origin", new[] { "*" });
            var user = default(User);
            try
            {
                using (AsyncScopedLifestyle.BeginScope(SimpleInjectorContainer.ContainerInstance))
                {
                    var authService = SimpleInjectorContainer.ContainerInstance.GetInstance<IAuthenticationService>();
                    user = authService.Login(context.UserName, context.Password);
                }
            }
            catch (Exception ex)
            {
                context.SetError("invalid_grant", ex.Message);
                return Task.FromResult<object>(null);
            }

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            context.Validated(identity);

            return Task.FromResult<object>(null);
        }
    }
}