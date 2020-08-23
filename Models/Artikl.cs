using System.ComponentModel;

namespace InventoryApp.Models
{
    public partial class Artikl
    {
        public int Id { get; set; }
        public string Ident { get; set; }

        [DisplayName("Početno")]
        public int? PocetnoStanje { get; set; }
        [DisplayName("Aktualno")]
        public int? AktualnoStanje { get; set; }
        [DisplayName("Završno")]
        public int? ZavrsnoStanje { get; set; }
        [DisplayName("Korisnik")]
        public string UsrChanged { get; set; }
        [DisplayName("Izvedba")]
        public int IzvedbaId { get; set; }
        public int TipId { get; set; }
        public int VrstaId { get; set; }
        public int KategorijaId { get; set; }

        public virtual Izvedba Izvedba { get; set; }
        public virtual Kategorija Kategorija { get; set; }
        public virtual Tip Tip { get; set; }
        public virtual Vrsta Vrsta { get; set; }
    }
}
