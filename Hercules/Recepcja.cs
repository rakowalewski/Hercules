//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hercules
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recepcja
    {
        public int IdRecepcja { get; set; }
        public Nullable<int> IdPrzywileje { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
    
        public virtual Przywileje Przywileje { get; set; }
    }
}