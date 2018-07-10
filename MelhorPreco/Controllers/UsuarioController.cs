using MelhorPreco.BUSINESS.Repositories;
using MelhorPreco.DATA;
using MelhorPreco.UTILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MelhorPreco.Controllers
{
    [RoutePrefix("api/Usuario")]
    public class UsuarioController : ApiController
    {
        // GET: api/Loja

        TB_USUARIO usu;

        [Authorize(Roles = "user")]
        [Route("Listar")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Lista_Compras/5
        [Authorize(Roles = "user")]
        [Route("Consultar")]
        public TB_USUARIO Get(int id)
        {
           usu = new TB_USUARIO();

           usu = (TB_USUARIO)new Usuario().ProducarPeloId(id).Objeto[0];

           return usu;

        }

        // POST: api/Lista_Compras
        //[Authorize(Roles = "user")]
        [Route("Cadastrar")]
        public int Post([FromBody]TB_USUARIO value)
        {
            
            int retorno = new Usuario().Cadastrar(value).CodigoErro;

            return retorno;
        }

        // PUT: api/Lista_Compras/5
        [Route("Update")]
        public int Put(int id, [FromBody]TB_USUARIO value)
        {
         
            int retorno = new Usuario().Atualizar(value).CodigoErro;

            return retorno;
        }

        // DELETE: api/Lista_Compras/5
        [Route("Deletar")]
        public int Delete(int id)
        {
            usu = new TB_USUARIO();

            usu = (TB_USUARIO)new Usuario().ProducarPeloId(id).Objeto[0];

            int retorno = new Usuario().Remover(usu).CodigoErro;

                return retorno;
        }
    }
}
