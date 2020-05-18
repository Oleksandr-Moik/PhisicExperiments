using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisicExperiments
{
    public static class PhisicCalc
    {
        /// avogadro number
        private static double N_A = 6.02e+23;
        /// universe gas constant
        private static double R = 8.31;

        public static double CalcPresure(int Count, double Temperature, double Volume)
        {
            return Count * 1.83e-23 * Temperature / Volume;
            //Presure = (CalcMole(Count) * R * Tempreture) / (Volume);
        }

        public static double CalcMole(int Count)
        {
            return Count / N_A * 0.1e+25;
        }
    }
}
