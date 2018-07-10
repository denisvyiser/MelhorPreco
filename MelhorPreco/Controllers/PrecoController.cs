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
    [RoutePrefix("api/Preco")]
    public class PrecoController : ApiController
    {
        // GET: api/Preco


        TB_PRECO pre;

        [Authorize(Roles = "user")]
        [Route("Listar")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Preco/5
        [Authorize(Roles = "user")]
        [Route("Consultar")]
        public TB_PRECO Get(int id)
        {
            pre = new TB_PRECO();

            pre = (TB_PRECO)new Preco().ProducarPeloId(id).Objeto[0];

            return pre;

        }

        // POST: api/Preco
        [Authorize(Roles = "user")]
        [Route("Cadastrar")]
        public int Post([FromBody]TB_PRECO value)
        {

            int retorno = new Preco().Cadastrar(value).CodigoErro;

            return retorno;
        }

        // PUT: api/Preco/5
        [Route("Update")]
        public int Put(int id, [FromBody]TB_PRECO value)
        {

            int retorno = new Preco().Atualizar(value).CodigoErro;

            return retorno;
        }

        // DELETE: api/Preco/5
        [Route("Deletar")]
        public int Delete(int id)
        {
            pre = new TB_PRECO();

            pre = (TB_PRECO)new Preco().ProducarPeloId(id).Objeto[0];

            int retorno = new Preco().Remover(pre).CodigoErro;

            return retorno;
        }

    }
}
