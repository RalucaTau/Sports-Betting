using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW.entities
{
    public class RezultatMeci
    {
        public string Echipa1 { get; set; }
        public string Echipa2 { get; set; }
        public int ScorEchipa1 { get; set; }
        public int ScorEchipa2 { get; set; }
        public bool Castigat { get; set; }
        public int NumarGoluri { get; set; }
    }

}
