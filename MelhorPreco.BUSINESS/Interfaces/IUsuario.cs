using MelhorPreco.UTILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelhorPreco.BUSINESS.Interfaces
{
    public interface IUsuario
    {
        Utilities Login(string email, string senha);

        Utilities VerificaExisteEmail(string email);
    }
}
