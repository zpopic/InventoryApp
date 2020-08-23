using System;
using System.Collections.Generic;

namespace InventoryApp.Models
{
    public partial class Izvedba
    {
        public Izvedba()
        {
            Artikl = new HashSet<Artikl>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string UsrChanged { get; set; }
        public int TipId { get; set; }
        public int VrstaId { get; set; }
        public int KategorijaId { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        public virtual Tip Tip { get; set; }
        public virtual Vrsta Vrsta { get; set; }
        public virtual ICollection<Artikl> Artikl { get; set; }
    }
}
