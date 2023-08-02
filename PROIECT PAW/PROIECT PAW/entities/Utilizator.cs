using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW.entities
{
    public class Utilizator
    {
        public string Nume { get; set; }
        public string Id { get; set; }
        public float Sold { get; set; }

        private List<BetClasa> _bets;
        private List<BetClasa> bets
        {
            get { return _bets; }
        }
        public Utilizator() {
            Sold = 0;
        }
        public Utilizator(string nume, string id, float sold)
        {
            this.Nume = nume;
            this.Id = id;
            this.Sold = sold;
            _bets = new List<BetClasa>();
        }

        public float GetSold()
        {
            return Sold;
        }
        public void ScadeSold(float suma)
        {
            Sold -= suma;
        }


        public override string ToString()
        {
            return Sold.ToString("F2");
        }

        public void AdaugaSold(float soldAdaugat)
        {
            Sold += soldAdaugat;
        }


    }
}
