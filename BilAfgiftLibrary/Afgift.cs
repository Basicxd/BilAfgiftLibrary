﻿using System.Security.Cryptography.X509Certificates;

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
        /// <returns>Returnende bilens registreringsafgift:</returns>
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

        /// <summary>
        /// Afgiften beregnes først som for en personbil.
        /// Men af denne beregnede afgift skal kun betales 20 %.
        /// </summary>
        /// <param name="pris"></param>
        /// <returns>Returnende bilens registreringsafgift med rabat på 20%</returns>
        public double ElBilAfgift(int pris)
        {
            return BilAfgift(pris) * 0.2;
        }
    }
}