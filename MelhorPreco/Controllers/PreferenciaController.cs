using MelhorPreco.BUSINESS.Repositories;
using MelhorPreco.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MelhorPreco.Controllers
{
    [RoutePrefix("api/Preferencia")]
    public class PreferenciaController : ApiController
    {
        // GET: api/Loja

        TB_PREFERENCIA pre;

        [Authorize(Roles = "user")]
        [Route("Listar")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Lista_Compras/5
        [Authorize(Roles = "user")]
        [Route("Consultar")]
        public TB_PREFERENCIA Get(int id)
        {
            pre = new TB_PREFERENCIA();

            pre = (TB_PREFERENCIA)new Preferencia().ProducarPeloId(id).Objeto[0];

            return pre;

        }

        // POST: api/Lista_Compras
        [Authorize(Roles = "user")]
        [Route("Cadastrar")]
        public int Post([FromBody]TB_PREFERENCIA value)
        {

            int retorno = new Preferencia().Cadastrar(value).CodigoErro;

            return retorno;
        }

        // PUT: api/Lista_Compras/5
        [Route("Update")]
        public int Put(int id, [FromBody]TB_PREFERENCIA value)
        {

            int retorno = new Preferencia().Atualizar(value).CodigoErro;

            return retorno;
        }

        // DELETE: api/Lista_Compras/5
        [Route("Deletar")]
        public int Delete(int id)
        {
            pre = new TB_PREFERENCIA();

            pre = (TB_PREFERENCIA)new Preferencia().ProducarPeloId(id).Objeto[0];

            int retorno = new Preferencia().Remover(pre).CodigoErro;

            return retorno;
        }

    }
}
