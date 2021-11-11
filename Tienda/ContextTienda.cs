using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Tienda
{
    public partial class ContextTienda : DbContext
    {
        public ContextTienda()
            : base("name=ContextTienda")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
