//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MelhorPreco.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_ENDERECO
    {
        public TB_ENDERECO()
        {
            this.TB_LOJA = new HashSet<TB_LOJA>();
            this.TB_USUARIO = new HashSet<TB_USUARIO>();
        }
    
        public int ENDERECO_CEP { get; set; }
        public string ENDERECO_DESCRICAO { get; set; }
        public string ENDERECO_BAIRRO { get; set; }
        public string ENDERECO_CIDADE { get; set; }
        public string ENDERECO_ESTADO { get; set; }
    
        public virtual ICollection<TB_LOJA> TB_LOJA { get; set; }
        public virtual ICollection<TB_USUARIO> TB_USUARIO { get; set; }
    }
}
