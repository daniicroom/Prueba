using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Prueba
{
    public partial class ContextPrueba : DbContext
    {
        public ContextPrueba()
            : base("name=ContextPrueba")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
