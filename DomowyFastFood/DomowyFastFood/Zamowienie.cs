//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomowyFastFood
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zamowienie
    {
        public int ID_Zamowienia { get; set; }
        public int ID_Restauracji { get; set; }
        public int ID_Klienta { get; set; }
    
        public virtual Klient Klient { get; set; }
        public virtual Restauracja Restauracja { get; set; }
    }
}