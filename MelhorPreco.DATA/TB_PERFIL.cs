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
    
    public partial class TB_PERFIL
    {
        public TB_PERFIL()
        {
            this.TB_USUARIO = new HashSet<TB_USUARIO>();
        }
    
        public int PERFIL_ID { get; set; }
        public string PERFIL_ROLE { get; set; }
    
        public virtual ICollection<TB_USUARIO> TB_USUARIO { get; set; }
    }
}
