using System;
using System.Collections.Generic;

namespace InventoryApp.Models
{
    public partial class Tip
    {
        public Tip()
        {
            Artikl = new HashSet<Artikl>();
            Izvedba = new HashSet<Izvedba>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string UsrChanged { get; set; }
        public int VrstaId { get; set; }
        public int KategorijaId { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        public virtual Vrsta Vrsta { get; set; }
        public virtual ICollection<Artikl> Artikl { get; set; }
        public virtual ICollection<Izvedba> Izvedba { get; set; }
    }
}
