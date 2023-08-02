using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW.entities
{
    public class Meci
    {
        public string Nume { get; set; }
        public DateTime Data { get; set; } 
        public override string ToString()
        {
            return Nume;
        }

        public static List<Meci> GetListaMeciuri()
        {
            List<Meci> listaMeciuri = new List<Meci>();

            listaMeciuri.Add(new Meci { Nume = "Rapid Bucuresti - Universitatea Craiova", Data = new DateTime(2023, 6, 14) });
            listaMeciuri.Add(new Meci { Nume = "Farul Constanta - Universitatea Craiova", Data = new DateTime(2023, 6, 15) });
            listaMeciuri.Add(new Meci { Nume = "Rapid Bucuresti - Farul Constanta", Data = new DateTime(2023, 6, 16) });
            listaMeciuri.Add(new Meci { Nume = "FCSB - Rapid Bucuresti", Data = new DateTime(2023, 6, 17) });

            return listaMeciuri;
        }

    }
}
