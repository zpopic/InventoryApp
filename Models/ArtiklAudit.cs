using System;
using System.Collections.Generic;

namespace InventoryApp.Models
{
    public partial class ArtiklAudit
    {
        public int? PocetnoStanje { get; set; }
        public int? Ulaz { get; set; }
        public int? Izlaz { get; set; }
        public int? AktualnoStanje { get; set; }
        public int? ZavrsnoStanje { get; set; }
        public string UsrChanged { get; set; }
        public DateTimeOffset? EditTime { get; set; }
        public string ChangeType { get; set; }
        public string Napomena { get; set; }
    }
}
