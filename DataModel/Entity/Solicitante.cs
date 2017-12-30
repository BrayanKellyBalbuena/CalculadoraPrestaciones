using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entity
{
    public class Solicitante
    {   
        public int SolicitanteId { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string LugarDeTrabajo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public string TiempoLaborado { get; set; }
        public int AnosDiferencia { get; set; }
        public int MesDiferencia { get; set; }
        public int DiasDiferencia { get; set; }
        public decimal[] Salarios { get; set; }
        public decimal SumatoriaDeSalarios { get; set; }
        public decimal SalarioPromedioMensual { get; set; }
        public decimal SalarioPromedioDiario { get; set; }
        public Prestacion MyPrestacion { get; set; }
        public bool HaSidoPreavisado { get; set; }
        public bool HaTomadoVacaciones { get; set; }
        public bool DeSeaIncluirCesantia { get; set; }
        public bool IncluyeSalarioNavidad { get; private set; }

        public Solicitante(string cedula, string nombre, string lugarTrabajo, DateTime fechaIngreso, DateTime fechaSalida,
                            decimal[] salarios,bool haSidoPreavisado, bool salarioNavidad ,bool haTomadoVacaciones,
                            bool deSeaIncluirCesantia)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.LugarDeTrabajo = lugarTrabajo;
            this.FechaIngreso = fechaIngreso;
            this.FechaSalida = fechaSalida;
            this.Salarios = salarios;
            this.MyPrestacion = new Prestacion();
            this.HaSidoPreavisado = haSidoPreavisado;
            this.IncluyeSalarioNavidad = salarioNavidad;
            this.HaTomadoVacaciones = haTomadoVacaciones;
            this.DeSeaIncluirCesantia = deSeaIncluirCesantia;
        }

        public override string ToString()
        {

            return String.Format(@"===Solicitante Agregado===
            Cedula: {0}
            Nombre:{1}
            Fecha Ingreso: {2}
            Fecha Salida: {3}
            Tiempo Laborado: {4}
            Sumatoria de salarios: {5:C}
            Salario Promadio Mensual: {6:C}
            Salario Promedio Diario: {7:C}
            {8}", Cedula,
            Nombre, FechaIngreso, FechaSalida, TiempoLaborado,
            SumatoriaDeSalarios, SalarioPromedioMensual,
            SalarioPromedioDiario, MyPrestacion);

            

        }
    }
}
