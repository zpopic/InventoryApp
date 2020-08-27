using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.Controllers
{
    public class Kalkulacije
    {
        int pocetnoStanje { get; set; }
        int ulaz { get; set; }
        int izlaz { get; set; }
        int aktualnoStanje { get; set; }
        int zavrsnoStanje { get; set; }


        public int kalkulacijaAktualnogStanja(int pocetnoStanje, int aktualnoStanje, int ulaz, int izlaz)
        {
            pocetnoStanje = 0;
            aktualnoStanje = 0;
            ulaz = 0;
            izlaz = 0;

            if (izlaz == 0)
            {
               pocetnoStanje = aktualnoStanje = ulaz;

            }
            else
            {
                aktualnoStanje = (pocetnoStanje + ulaz) - izlaz;
            }

            return aktualnoStanje;
        }

        public int kalkulacijaZavrsnogStanja(int aktualnoStanje, int zavrsnoStanje)
        {


            zavrsnoStanje = pocetnoStanje - aktualnoStanje;

            return zavrsnoStanje;
        }

    }

}
