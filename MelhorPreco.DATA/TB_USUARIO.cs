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
    
    public partial class TB_USUARIO
    {
        public TB_USUARIO()
        {
            this.TB_LISTA_COMPRAS = new HashSet<TB_LISTA_COMPRAS>();
            this.TB_PRECO = new HashSet<TB_PRECO>();
            this.TB_PREFERENCIA = new HashSet<TB_PREFERENCIA>();
        }
    
        public int USUARIO_ID { get; set; }
        public string USUARIO_NOME { get; set; }
        public string USUARIO_EMAIL { get; set; }
        public string USUARIO_SENHA { get; set; }
        public string USUARIO_FONE { get; set; }
        public string USUARIO_CEL { get; set; }
        public int USUARIO_END_CEP { get; set; }
        public Nullable<int> USUARIO_END_NUMERO { get; set; }
        public string USUARIO_END_COMPLEMENTO { get; set; }
        public int USUARIO_PERFIL { get; set; }
    
        public virtual TB_ENDERECO TB_ENDERECO { get; set; }
        public virtual ICollection<TB_LISTA_COMPRAS> TB_LISTA_COMPRAS { get; set; }
        public virtual ICollection<TB_PRECO> TB_PRECO { get; set; }
        public virtual ICollection<TB_PREFERENCIA> TB_PREFERENCIA { get; set; }
        public virtual TB_PERFIL TB_PERFIL { get; set; }
    }
}
