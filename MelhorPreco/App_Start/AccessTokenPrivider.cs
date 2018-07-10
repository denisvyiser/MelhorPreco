using MelhorPreco.BUSINESS.Repositories;
using MelhorPreco.DATA;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace NOQUEUE.App_Start
{
    public class AccessTokenPrivider : OAuthAuthorizationServerProvider
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
            
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {

            var usuario = (TB_USUARIO)((new Usuario().Login(context.UserName, context.Password).Objeto))[0];


            if (usuario == null)
            {
                context.SetError("invalid_grant", "Usuário não encontrado ou senha incorreta.");
                return;
            }

            var useridentity = new ClaimsIdentity(context.Options.AuthenticationType);
            useridentity.AddClaim(new Claim("sub", context.UserName));
            useridentity.AddClaim(new Claim(ClaimTypes.Role, usuario.TB_PERFIL.PERFIL_ROLE.Trim()));

            var props = new AuthenticationProperties(new Dictionary<string, string> { 
            
                {"USUARIO_ID", usuario.USUARIO_ID.ToString()},
                {"USUARIO_NOME", usuario.USUARIO_NOME.Trim()},
                {"USUARIO_EMAIL", usuario.USUARIO_EMAIL.Trim()},
                {"USUARIO_PERFIL", usuario.TB_PERFIL.PERFIL_ROLE.Trim()}
            
            });


            var ticket = new AuthenticationTicket(useridentity, props);

            context.Validated(ticket);

            log.Info(props.Dictionary.Values);
        }

        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            foreach (KeyValuePair<string, string> property in context.Properties.Dictionary)
            {
                //removed .issued and .expires parameter
                if (!property.Key.StartsWith("."))
                    context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            
            return Task.FromResult<object>(null);
        }
    }
}