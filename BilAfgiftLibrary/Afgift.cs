using System.Security.Cryptography.X509Certificates;

namespace BilAfgiftLibrary
{
    public class Afgift
    {
        /// <summary>
        /// Beregner bilens registreringsafgift:
        /// Når Prisen er mindre end eller lig med 200000 kr så er det 85% af prisen.
        /// Når Prisen er større end 200000 kr så er det 150% af prisen.
        /// </summary>
        /// <param name="pris"></param>
        /// <returns></returns>
        public double BilAfgift(int pris)
        {
            if (pris > 200000)
            {
                return (pris * 1.5) - 130000;
            }
            else
            {
                return pris * 0.85;
            }
        }

        public double ElBilAfgift(int pris)
        {
            return BilAfgift(pris) * 0.2;
        }
    }
}