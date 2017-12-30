using DataModel.Entity;
using System.Data.Entity;

namespace DataModel.Context
{
    public class PrestacionLaboralContextcs : DbContext
    {
        public PrestacionLaboralContextcs() : base("PrestacionLaboral")
        {

        }

        public DbSet<Solicitante> Solicitantes { get; set; }
       
    }
}
