using DataModel.Entity;
using Utility;

namespace Core
{
    public class Calculadora
    {

        /// <summary>
        /// metodo que permite calcular la sumatoria de los salarios
        /// </summary>
        /// <param name="salarios"></param>
        /// <returns>sumTotal</returns>
        private decimal CalcularSumatoriaDeSalarios(decimal[] salarios)
        {
            decimal sumaTotal = 0;
            foreach (int salario in salarios)
            {
                sumaTotal += salario;
            }
            return sumaTotal;
        }

        /// <summary>
        /// metodo que permite calcular el salario promedio diaro o salario base
        /// </summary>
        /// <param name="salarioPromedioMensual"></param>
        /// <returns>decimal salario promedio diario </returns>
        private decimal CalcularSalarioPromedioDiario(decimal salarioPromedioMensual)
        {
            return salarioPromedioMensual / 23.83M;
        }

        private decimal CalcularPreaviso(decimal salarioPromedioDiario, int year, int meses)
        {
            if (year >= 1)
            {
                return salarioPromedioDiario * 28M;
            }
            else if ((meses >= 6) && (meses < 12))
            {
                return salarioPromedioDiario * 14M;
            }
            else if ((meses >= 3) && (meses < 6))
            {
                return salarioPromedioDiario * 7M;
            }
            else
            {
                return 0;
            }
        }

        private decimal CalcularCesantia(decimal salarioPromedioDiario, int year, int meses)
        {
            if (year >= 5)
            {
                return salarioPromedioDiario * 23M * year;
            }
            else if (year >= 1 && year < 5)
            {
                return salarioPromedioDiario * 21M * year;
            }
            else if ((meses >= 6) && (meses < 12))
            {
                return salarioPromedioDiario * 13M;
            }
            else if ((meses >= 3) && (meses < 6))
            {
                return salarioPromedioDiario * 6M;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Metodo que permite calcular el benefico por vacaciones
        /// </summary>
        /// <param name="anos"></param>
        /// <param name="salarioPromedioDiario"></param>
        /// <returns>el beneficon por vacacion</returns>
        private decimal CalcularVacaciones(decimal salarioPromedioDiario, int anos, int meses)
        {
            decimal vacacion = 0;
            if (anos < 5 && anos > 0)
            {
                vacacion = salarioPromedioDiario * 14M;
            }
            else if (anos > 5)
            {
                vacacion = salarioPromedioDiario * 18M;
            }
            else
            {
                switch(meses)
                {
                    case 11:
                        vacacion = salarioPromedioDiario * 12M;
                        break;

                    case 10:
                        vacacion = salarioPromedioDiario * 11M;
                        break;

                    case 9:
                        vacacion = salarioPromedioDiario * 10M;
                        break;

                    case 8:
                        vacacion = salarioPromedioDiario * 9M;
                        break;

                    case 7:
                        vacacion = salarioPromedioDiario * 8M;
                        break;

                    case 6:
                        vacacion = salarioPromedioDiario * 7M;
                        break;
                    case 5:
                        vacacion = salarioPromedioDiario * 6M;
                        break;
                }
            }
            return vacacion;
        }


        /// <summary>
        /// Metodo que permite calcular el salario de navidad
        /// </summary>
        /// <param name="salarioPromedioMensual"></param>
        /// <param name="meses"></param>
        /// <param name="dias"></param>
        /// <returns>el salario de navidad</returns>
        private decimal CalcularSalarioNavidad(decimal salarioPromedioMensual, int meses, int dias)
        {
            if ((meses > 0) && dias > 0)
            {
                return (salarioPromedioMensual * meses + salarioPromedioMensual / 31 * dias) / 12;
            }
            else if ((meses > 0) && (dias < 1))
            {
                return (salarioPromedioMensual * meses) / 12;
            }
            else
            {
                return 0;
            }
        }

        private decimal CalcularTotal(Prestacion prestacion)
        {
            return prestacion.Preaviso + prestacion.Cesantia +
                prestacion.Vacaciones + prestacion.SalarioNavidad;
        }


        /// <summary>
        /// Metodo que inicia el calculo del solicitante 
        /// </summary>
        /// <param name="solicitante"></param>
        public void CalcularDatos(Solicitante solicitante)
        {
            // calculamos el tiempo trabajado el que sera mostrado
            solicitante.TiempoLaborado =
                solicitante.FechaSalida.IntervaloEntreFechas(solicitante.FechaIngreso);

            //calculamos el tiempo trabajado de manera individual para efectuar los
            // calculos mas adelante
            solicitante.AnosDiferencia =
                solicitante.FechaSalida.YearDifference(solicitante.FechaIngreso);
            solicitante.MesDiferencia =
                solicitante.FechaSalida.MonthDifference(solicitante.FechaIngreso);
            solicitante.DiasDiferencia =
                solicitante.FechaSalida.DaysDifference(solicitante.FechaIngreso);

            //calculamos la sumatoria de salarios
            solicitante.SumatoriaDeSalarios =
                CalcularSumatoriaDeSalarios(solicitante.Salarios);

            //calculamos el salario promedio mensual
            solicitante.SalarioPromedioMensual =
                solicitante.SumatoriaDeSalarios / solicitante.Salarios.Length;

            // calculamos el salario promedio diario o base
            solicitante.SalarioPromedioDiario =
                CalcularSalarioPromedioDiario(solicitante.SalarioPromedioMensual);

            // calculamos las vacaciones
            if (!solicitante.HaTomadoVacaciones)
            {
                solicitante.MyPrestacion.Vacaciones = 
                    CalcularVacaciones( solicitante.SalarioPromedioDiario,
                    solicitante.AnosDiferencia, solicitante.MesDiferencia);
            }

            //calculamos el preaviso
            if (!solicitante.HaSidoPreavisado)
            {
                solicitante.MyPrestacion.Preaviso =
                    CalcularPreaviso(solicitante.SalarioPromedioDiario,
                    solicitante.AnosDiferencia, solicitante.MesDiferencia);
            }

            //calculamos la cesantia
            if (solicitante.DeSeaIncluirCesantia)
            {
                solicitante.MyPrestacion.Cesantia = 
                    CalcularCesantia(solicitante.SalarioPromedioDiario,
                    solicitante.AnosDiferencia, solicitante.MesDiferencia);
            }

            // calculamos el salario navidad
            if (solicitante.IncluyeSalarioNavidad)
            {
                solicitante.MyPrestacion.SalarioNavidad = 
                    CalcularSalarioNavidad(solicitante.SalarioPromedioMensual,
                    solicitante.MesDiferencia, solicitante.DiasDiferencia);
            }



            // Por ultimo calculamos el total a devengar
            solicitante.MyPrestacion.Total = CalcularTotal(solicitante.MyPrestacion);
        }
    }
}
