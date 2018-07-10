using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelhorPreco.UTILITIES
{
    public class Utilities
    {
        public Utilities() { }

        public Utilities(int codigo, params object[] objeto)
        {
            CodigoErro = codigo;
            Objeto = objeto;
        }

        public int CodigoErro { get; set; }
        public object[] Objeto { get; set; }

    }
}
