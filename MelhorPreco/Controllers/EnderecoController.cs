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
    [RoutePrefix("api/Endereco")]
    public class EnderecoController : ApiController
    {
        // GET: api/Endereco

        TB_ENDERECO end;

        [Authorize(Roles = "user")]
        [Route("Listar")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Lista_Compras/5
        [Authorize(Roles = "user")]
        [Route("Consultar")]
        public TB_ENDERECO Get(int id)
        {
            end = new TB_ENDERECO();

            end = (TB_ENDERECO)new Endereco().ProducarPeloId(id).Objeto[0];

            return end;

        }

        // POST: api/Lista_Compras
        [Authorize(Roles = "user")]
        [Route("Cadastrar")]
        public int Post([FromBody]TB_ENDERECO value)
        {

            int retorno = new Endereco().Cadastrar(value).CodigoErro;

            return retorno;
        }

        // PUT: api/Lista_Compras/5
        [Route("Update")]
        public int Put(int id, [FromBody]TB_ENDERECO value)
        {

            int retorno = new Endereco().Atualizar(value).CodigoErro;

            return retorno;
        }

        // DELETE: api/Lista_Compras/5
        [Route("Deletar")]
        public int Delete(int id)
        {
            end = new TB_ENDERECO();

            end = (TB_ENDERECO)new Endereco().ProducarPeloId(id).Objeto[0];

            int retorno = new Endereco().Remover(end).CodigoErro;

            return retorno;
        }


    }
}
