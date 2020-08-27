using System;
using System.Collections.Generic;

namespace InventoryApp.Models
{
    public partial class Artikl
    {
        public int Id { get; set; }
        public string Ident { get; set; }
        public int? PocetnoStanje { get; set; }
        public int? Ulaz { get; set; }
        public int? Izlaz { get; set; }
        public int? AktualnoStanje { get; set; }
        public int? ZavrsnoStanje { get; set; }
        public string UsrChanged { get; set; }
        public int IzvedbaId { get; set; }
        public int TipId { get; set; }
        public int VrstaId { get; set; }
        public int KategorijaId { get; set; }
        public string Napomena { get; set; }

        public virtual Izvedba Izvedba { get; set; }
        public virtual Kategorija Kategorija { get; set; }
        public virtual Tip Tip { get; set; }
        public virtual Vrsta Vrsta { get; set; }
    }
}
