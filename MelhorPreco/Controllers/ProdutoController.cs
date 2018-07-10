using MelhorPreco.BUSINESS.Repositories;
using MelhorPreco.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MelhorPreco.UTILITIES;

namespace Melhorproco.Controllers
{
    [RoutePrefix("api/Produto")]
    public class ProdutoController : ApiController
    {
        // GET: api/Loja


        TB_PRODUTO pro;

        [Authorize(Roles = "user")]
        [Route("Listar")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Lista_Compras/5
        [Authorize(Roles = "user")]
        [Route("Consultar")]
        public TB_PRODUTO Get(int id)
        {
            pro = new TB_PRODUTO();

            pro = (TB_PRODUTO)new Produto().ProducarPeloId(id).Objeto[0];

            return pro;

        }

        // POST: api/Lista_Compras
        [Authorize(Roles = "user")]
        [Route("Cadastrar")]
        public int Post([FromBody]TB_PRODUTO value)
        {

            int retorno = new Produto().Cadastrar(value).CodigoErro;

            return retorno;
        }

        // PUT: api/Lista_Compras/5
        [Route("Update")]
        public int Put(int id, [FromBody]TB_PRODUTO value)
        {

            int retorno = new Produto().Atualizar(value).CodigoErro;

            return retorno;
        }

        // DELETE: api/Lista_Compras/5
        [Route("Deletar")]
        public int Delete(int id)
        {
            pro = new TB_PRODUTO();

            pro = (TB_PRODUTO)new Produto().ProducarPeloId(id).Objeto[0];

            int retorno = new Produto().Remover(pro).CodigoErro;

            return retorno;
        }

        [Route("Deletarvarios")]
        public int Deletevarios(int id)
        {
            pro = new TB_PRODUTO();

            Utilities result = new Produto().RemoverVarios(c => c.PRODUTO_DESCRICAO == "Coca");

            int retorno = result.CodigoErro;

            return retorno;
        }

    }
}
