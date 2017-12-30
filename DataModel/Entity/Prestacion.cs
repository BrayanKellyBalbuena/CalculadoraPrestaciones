using System;
using System.Collections.Generic;

namespace DataModel.Entity
{
    public class Prestacion
    {   
        public int PrestacionId { get; set; }
        public decimal Preaviso { get; set; }
        public decimal Cesantia { get; set; }
        public decimal Vacaciones { get; set; }
        public decimal SalarioNavidad { get; set; }
        public decimal Total { get; set; }

        public override string ToString()
        {
            return String.Format(@"===Datos de la Prestacion Laboral===
            Preaviso: {0:C}
            Cesantia: {1:C}
            Vaciones: {2:C}
            Salario Navidad {3:C}
            Total: {4:C}", Preaviso,
            Cesantia, Vacaciones,
            SalarioNavidad, Total);
            
        }
    }
}
