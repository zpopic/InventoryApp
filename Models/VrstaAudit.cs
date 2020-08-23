using System;
using System.Collections.Generic;

namespace InventoryApp.Models
{
    public partial class VrstaAudit
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string UsrChanged { get; set; }
        public DateTimeOffset? EditTime { get; set; }
        public string ChangeType { get; set; }
    }
}
