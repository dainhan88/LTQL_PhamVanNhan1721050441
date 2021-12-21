using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQL_1721050441.Models
{
    public partial class PVN1721050441DbContext : DbContext
    {
        public PVN1721050441DbContext()
            : base("name=PVN1721050441DbContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
