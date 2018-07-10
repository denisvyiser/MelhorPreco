using MelhorPreco.BUSINESS.Interfaces;
using MelhorPreco.BUSINESS.Repositories;
using MelhorPreco.DATA;
using MelhorPreco.UTILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelhorPreco.BUSINESS.Repositories
{
    public class Usuario : RepositoryBase<Entities, TB_USUARIO>, IUsuario
    {
        Utilities util;
        public Utilities Login(string email, string senha)
        {
            try
            {
                util = new Utilities();

                util.Objeto = new object[] { ContextDB.TB_USUARIO.Where(c=> c.USUARIO_EMAIL.Trim().Equals(email) && c.USUARIO_SENHA.Trim().Equals(senha)).FirstOrDefault() };

                util.CodigoErro = 0;

            }
            catch (Exception ex)
            {
                util.CodigoErro = -1;
                util.Objeto = new object[] { "Não foi possível obter o ID" + ex.Message };
            }
            return util;

        }


        public Utilities VerificaExisteEmail(string email)
        {
            try
            {
                util = new Utilities();

                util.Objeto = new object[] { ContextDB.TB_USUARIO.Where(c => c.USUARIO_EMAIL.Trim().Equals(email)).FirstOrDefault() };

                util.CodigoErro = 0;

            }
            catch (Exception ex)
            {
                util.CodigoErro = -1;
                util.Objeto = new object[] { "Não foi possível verificar o e-mail" + ex.Message };
            }
            return util;
        }
    }
}
