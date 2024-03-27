using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibVillageois
{
    public class Potions
    {
        private int dose;

        public Potions(int dose)
        {
            this.dose = dose;
        }

        public void ajouterdose(int nbdose)
        {
            dose = nbdose + dose;
        }

        public int getdose()
        {
            return dose;
        }
    }
}
