//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class EDITORA
    {
        public EDITORA()
        {
            this.LIVRO = new HashSet<LIVRO>();
        }
    
        public int ID_EDITORA { get; set; }
        public string NOME { get; set; }
        public string ENDERECO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string PAIS { get; set; }
        public string TEL_1 { get; set; }
        public string TEL_2 { get; set; }
        public string EMAIL { get; set; }
    
        public virtual ICollection<LIVRO> LIVRO { get; set; }
    }
}
