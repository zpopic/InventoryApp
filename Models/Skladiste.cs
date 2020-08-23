using System;
using System.Collections.Generic;

namespace InventoryApp.Models
{
    public partial class Skladiste
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string UsrChanged { get; set; }
    }
}
