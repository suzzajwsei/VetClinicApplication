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
    public class AppDBContext : DbContext
    {
        string connectionstring = @"Data Source=DESKTOP-5PGQVC6\SQLEXPRESS; Initial Catalog=VETCLINICDB; Integrated Security=True;";
        public DbSet<Animal> Animals { get; set; }
      
        public DbSet<Chip> Chips { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<ClientAddress> ClientAddresses { get; set; }

        public DbSet<MedProcedureList> MedProceduresList { get; set; }

        public DbSet<RabiesVaccination> RabiesVaccinations { get; set; }
        /// <summary>
        /// configuration of connection with db
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder modelBuilder)
        {
            modelBuilder.UseSqlServer(connectionstring);
        }
        /// <summary>
        /// Key definition in database
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chip>()
                .HasNoKey();

            modelBuilder.Entity<ClientAddress>()
                .HasNoKey();

            //modelBuilder.Entity<Animal>()
            //    .HasNoKey();

            //modelBuilder.Entity<MedProcedureList>()
            //    .HasNoKey();

            modelBuilder.Entity<RabiesVaccination>()
                .HasNoKey();

            //modelBuilder.Entity<Client>()
            //    .HasNoKey();
        }
    }
}
