using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinicApplication.MVVM.Model
{

    /// <summary>
    /// connecting with sql db
    /// </summary>
    class AppDBContext : DbContext
    {
        string connectionstring = @"Data Source=DESKTOP-5PGQVC6\SQLEXPRESS; Initial Catalog=VETCLINICDB; Integrated Security=True;";
        public DbSet<Animal> Animals { get; set; }
      
        public DbSet<Chip> Chips { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<ClientAddress> ClientAddresses { get; set; }

        public DbSet<MedProcedureList> MedProceduresList { get; set; }

        public DbSet<RabiesVaccination> RabiesVaccinations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder modelBuilder)
        {
            modelBuilder.UseSqlServer(connectionstring);
        }
    }
}
