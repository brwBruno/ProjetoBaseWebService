using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using Ribeiro.MF7.Api.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ribeiro.MF7.Api.App_Start
{
    public static class OAuthConfig
    {
        public static void ConfigureOAuth(IAppBuilder app)
        {
            ConfigureOAuthTokenGeneration(app);
        }

        private static void ConfigureOAuthTokenGeneration(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(2),
                Provider = new OAuthProvider(),
            };
            
            app.UseOAuthAuthorizationServer(OAuthServerOptions);

            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}