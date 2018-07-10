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
    [RoutePrefix("api/Loja")]
    public class LojaController : ApiController
    {
        // GET: api/Loja

        TB_LOJA loj;

        [Authorize(Roles = "user")]
        [Route("Listar")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Loja/5
        [Authorize(Roles = "user")]
        [Route("Consultar")]
        public TB_LOJA Get(int id)
        {
            loj = new TB_LOJA();

            loj = (TB_LOJA)new Loja().ProducarPeloId(id).Objeto[0];

            return loj;

        }

        // POST: api/Loja
        [Authorize(Roles = "user")]
        [Route("Cadastrar")]
        public int Post([FromBody]TB_LOJA value)
        {

            int retorno = new Loja().Cadastrar(value).CodigoErro;

            return retorno;
        }

        // PUT: api/Loja/5
        [Route("Update")]
        public int Put(int id, [FromBody]TB_LOJA value)
        {

            int retorno = new Loja().Atualizar(value).CodigoErro;

            return retorno;
        }

        // DELETE: api/Loja/5
        [Route("Deletar")]
        public int Delete(int id)
        {
            loj = new TB_LOJA();

            loj = (TB_LOJA)new Loja().ProducarPeloId(id).Objeto[0];

            int retorno = new Loja().Remover(loj).CodigoErro;

            return retorno;
        }

    }
}
