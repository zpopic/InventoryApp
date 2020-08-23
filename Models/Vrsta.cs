using System;
using System.Collections.Generic;

namespace InventoryApp.Models
{
    public partial class Vrsta
    {
        public Vrsta()
        {
            Artikl = new HashSet<Artikl>();
            Izvedba = new HashSet<Izvedba>();
            Tip = new HashSet<Tip>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string UsrChanged { get; set; }
        public int KategorijaId { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        public virtual ICollection<Artikl> Artikl { get; set; }
        public virtual ICollection<Izvedba> Izvedba { get; set; }
        public virtual ICollection<Tip> Tip { get; set; }
    }
}
