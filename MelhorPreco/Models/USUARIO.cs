using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MelhorPreco.Models
{
    public class USUARIO
    {
        public int USUARIO_ID { get; set; }
        public string USUARIO_NOME { get; set; }
        public string USUARIO_EMAIL { get; set; }
        public string USUARIO_SENHA { get; set; }
        public string USUARIO_FONE { get; set; }
        public string USUARIO_CEL { get; set; }
        public int USUARIO_END_CEP { get; set; }
        public Nullable<int> USUARIO_END_NUMERO { get; set; }
        public string USUARIO_END_COMPLEMENTO { get; set; }
    
    }
}