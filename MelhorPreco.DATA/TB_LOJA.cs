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
    
    public partial class TB_LOJA
    {
        public TB_LOJA()
        {
            this.TB_PRECO = new HashSet<TB_PRECO>();
            this.TB_PREFERENCIA = new HashSet<TB_PREFERENCIA>();
        }
    
        public int LOJA_ID { get; set; }
        public string LOJA_NOME { get; set; }
        public string LOJA_CNPJ { get; set; }
        public string LOJA_FONE { get; set; }
        public int LOJA_END_CEP { get; set; }
        public Nullable<int> LOJA_END_NUMERO { get; set; }
        public string LOJA_END_COMPLEMENTO { get; set; }
    
        public virtual TB_ENDERECO TB_ENDERECO { get; set; }
        public virtual ICollection<TB_PRECO> TB_PRECO { get; set; }
        public virtual ICollection<TB_PREFERENCIA> TB_PREFERENCIA { get; set; }
    }
}
