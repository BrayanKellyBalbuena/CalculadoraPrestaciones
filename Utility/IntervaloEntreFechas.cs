using System;

namespace Utility
{
    public static class DateIntervaloEntreFechas
    {
        /// <summary>
        /// Metodo que calcula el tiempo laborado 
        /// </summary>
        /// <param name="fechaFinal"></param>
        /// <param name="fechaInicial"></param>
        /// <returns>un string de el tiempo laborado</returns>
        public static string IntervaloEntreFechas(this DateTime fechaFinal, DateTime fechaInicial)
        {
            DateTime fi = fechaInicial;
            DateTime ft = fechaFinal;

            int AntDias = 0, AntMeses = 0, AntAños = 0;

            int DiasFI = fi.Day, MesFI = fi.Month, AñoFI = fi.Year;
            int DiasFT = ft.Day, MesFT = ft.Month, AñoFT = ft.Year;

            if (DiasFT < DiasFI)
            {
                DiasFT += 30;
                MesFT -= 1;
            }

            // calcula dias de antiguedad
            AntDias = DiasFT - DiasFI;

            if (MesFT < MesFI)
            {
                MesFT += 12;
                AñoFT -= 1;
            }

            // calcula meses de antiguedad
            AntMeses = MesFT - MesFI;

            // calcula años antiguedad
            AntAños = AñoFT - AñoFI;

            return String.Format("{0} {1} {2} {3} {4} {5}", AntAños, AntAños == 1 ? "Año" : "Años",
                                  AntMeses, AntMeses == 1 ? "Mes" : "Meses",
                                  AntDias, AntDias == 1 ? "Dia" : "Dias");
        }


        /// <summary>
        /// Metodo que permite deterinar la diferencia de años
        /// </summary>
        /// <param name="fechaFinal"></param>
        /// <param name="fechaInicial"></param>
        /// <returns> un int de la diferencia de años</returns>
        public static int YearDifference(this DateTime fechaFinal, DateTime fechaInicial)
        {
            DateTime fi = fechaInicial;
            DateTime ft = fechaFinal;

            int AntDias = 0, AntMeses = 0, AntAños = 0;

            int DiasFI = fi.Day, MesFI = fi.Month, AñoFI = fi.Year;
            int DiasFT = ft.Day, MesFT = ft.Month, AñoFT = ft.Year;

            if (DiasFT < DiasFI)
            {
                DiasFT += 30;
                MesFT -= 1;
            }

            // calcula dias de antiguedad
            AntDias = DiasFT - DiasFI;

            if (MesFT < MesFI)
            {
                MesFT += 12;
                AñoFT -= 1;
            }

            // calcula meses de antiguedad
            AntMeses = MesFT - MesFI;

            // calcula años antiguedad
            AntAños = AñoFT - AñoFI;
            return AntAños;
        }

        /// <summary>
        /// Metodo que permite determinar de meses entre dos fechas
        /// </summary>
        /// <param name="fechaFinal"></param>
        /// <param name="fechaInicial"></param>
        /// <returns> un int de la diferencia de meses</returns>
        public static int MonthDifference(this DateTime fechaFinal, DateTime fechaInicial)
        {
            DateTime fi = fechaInicial;
            DateTime ft = fechaFinal;

            int AntDias = 0, AntMeses = 0, AntAños = 0;

            int DiasFI = fi.Day, MesFI = fi.Month, AñoFI = fi.Year;
            int DiasFT = ft.Day, MesFT = ft.Month, AñoFT = ft.Year;

            if (DiasFT < DiasFI)
            {
                DiasFT += 30;
                MesFT -= 1;
            }

            // calcula dias de antiguedad
            AntDias = DiasFT - DiasFI;

            if (MesFT < MesFI)
            {
                MesFT += 12;
                AñoFT -= 1;
            }

            // calcula meses de antiguedad
            AntMeses = MesFT - MesFI;

            // calcula años antiguedad
            AntAños = AñoFT - AñoFI;
            return AntMeses;
        }

        /// <summary>
        /// Metodo que permite determinar la diferencia de dias entre dos fechas
        /// </summary>
        /// <param name="fechaFinal"></param>
        /// <param name="fechaInicial"></param>
        /// <returns> un int de la diferencia de años</returns>
        public static int DaysDifference(this DateTime fechaFinal, DateTime fechaInicial)
        {
            DateTime fi = fechaInicial;
            DateTime ft = fechaFinal;

            int AntDias = 0, AntMeses = 0, AntAños = 0;

            int DiasFI = fi.Day, MesFI = fi.Month, AñoFI = fi.Year;
            int DiasFT = ft.Day, MesFT = ft.Month, AñoFT = ft.Year;

            if (DiasFT < DiasFI)
            {
                DiasFT += 30;
                MesFT -= 1;
            }

            // calcula dias de antiguedad
            AntDias = DiasFT - DiasFI;

            if (MesFT < MesFI)
            {
                MesFT += 12;
                AñoFT -= 1;
            }

            // calcula meses de antiguedad
            AntMeses = MesFT - MesFI;

            // calcula años antiguedad
            AntAños = AñoFT - AñoFI;
            return AntDias;
        }
    }
}
