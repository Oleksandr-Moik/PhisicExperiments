namespace PhisicExperiments
{
    public static class PhisicCalculating
    {
        // avogadro number
        private static double N_A = 6.02e+23;
        // universe gas constant
        private static double R = 8.31;

        public static double CalculatePressure(int Count, double Temperature, double Volume)
        {
            return Count * 1.83e-23 * Temperature / Volume;
            //Presure = (CalcMole(Count) * R * Tempreture) / (Volume);
        }

        public static double CalculateMoles(int Count)
        {
            return Count / N_A * 0.1e+24;
        }
    }
}
