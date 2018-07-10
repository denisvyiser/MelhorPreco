using MelhorPreco.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MelhorPreco.BUSINESS.Repositories;

namespace MelhorPreco.Controllers
{
        [RoutePrefix("api/Lista_Compras")]
    public class Lista_ComprasController : ApiController
    {
        // GET: api/Lista_Compras

        TB_LISTA_COMPRAS lco;

        [Authorize(Roles = "user")]
        [Route("Listar")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Lista_Compras/5
        [Authorize(Roles = "user")]
        [Route("Consultar")]
        public TB_LISTA_COMPRAS Get(int id)
        {
            lco = new TB_LISTA_COMPRAS();

            lco = (TB_LISTA_COMPRAS)new Lista_Compras().ProducarPeloId(id).Objeto[0];

            return lco;

        }

        // POST: api/Lista_Compras
        [Authorize(Roles = "user")]
        [Route("Cadastrar")]
        public int Post([FromBody]TB_LISTA_COMPRAS value)
        {

            int retorno = new Lista_Compras().Cadastrar(value).CodigoErro;

            return retorno;
        }

        // PUT: api/Lista_Compras/5
        [Route("Update")]
        public int Put(int id, [FromBody]TB_LISTA_COMPRAS value)
        {

            int retorno = new Lista_Compras().Atualizar(value).CodigoErro;

            return retorno;
        }

        // DELETE: api/Lista_Compras/5
        [Route("Deletar")]
        public int Delete(int id)
        {
            lco = new TB_LISTA_COMPRAS();

            lco = (TB_LISTA_COMPRAS)new Lista_Compras().ProducarPeloId(id).Objeto[0];

            int retorno = new Lista_Compras().Remover(lco).CodigoErro;

            return retorno;
        }


    }
}
