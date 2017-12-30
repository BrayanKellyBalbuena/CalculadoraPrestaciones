using System;
using System.Collections.Generic;

namespace DataModel.Entity
{
    public sealed class RegistroSolicitantes
    {
        private static readonly RegistroSolicitantes instance = new RegistroSolicitantes();
        public List<Solicitante> Solicitantes = new List<Solicitante>();

        private RegistroSolicitantes() { }

        public static RegistroSolicitantes Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
