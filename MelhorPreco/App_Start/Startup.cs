using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.OAuth;
using System.Web.Http;
using Microsoft.Owin.Cors;
using MelhorPreco;

[assembly: OwinStartup(typeof(NOQUEUE.App_Start.Startup))]

namespace NOQUEUE.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();


            TokenAcesso(app);

            WebApiConfig.Register(config);
                        
            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(config);


        }

        private void TokenAcesso(IAppBuilder app)
        {

            var opcoesConfiguracaoToken = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/api/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(24),
                Provider = new AccessTokenPrivider(),
                
            };

            app.UseOAuthAuthorizationServer(opcoesConfiguracaoToken);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}
