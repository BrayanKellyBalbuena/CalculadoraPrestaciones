using System;
using System.Collections.Generic;
using DataModel.Entity;
using DataModel.Context;
using System.Windows.Forms;


namespace Core
{
    public sealed class Mantenimiento
    {

        private static readonly Mantenimiento instance = new Mantenimiento();
        private RegistroSolicitantes registros = RegistroSolicitantes.Instance;
        private PrestacionLaboralContextcs context = new PrestacionLaboralContextcs();
          

        private Mantenimiento() {

            
        }

        public static Mantenimiento Instance
        {
            get
            {
                return instance;
            }
        }

        public void AgregarSolicitante(Solicitante solicitante)
        {
            
            if (solicitante != null)
            {   
                registros.Solicitantes.Add(solicitante);
                context.Solicitantes.Add(solicitante);
                context.SaveChanges();
                
                
            }
        }

        public void MostrarSolicitantes()
        {
            if (registros.Solicitantes.Count == 0)
            {
                throw new InvalidOperationException("La lista no hay solicitantes agregados");
            }
            else
            {
                int index = 1;
                Console.WriteLine("Numero de solicitantes Registrados:{0}  ",
                                  registros.Solicitantes.Count);
                foreach (Solicitante solicitante in registros.Solicitantes)
                {
                    MessageBox.Show("\nSolicitante "+ index++ +"\n"+ solicitante);
                    
                }
            }

        }

        public List<Solicitante> ObternerRegistro()
        {
            return registros.Solicitantes;
        }
    }
}
