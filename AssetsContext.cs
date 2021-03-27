using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MP_EF_Lavinia_Bleoca
{
    class AssetsContext : DbContext
    {

        public DbSet<Offices> Offices { get; set; }
        public DbSet<Computers> Computers { get; set; }
        public DbSet<CellPhones> CellPhones { get; set; }
       // public DbSet<OtherAssets> OtherAssets { get; set; }

        public DbSet<DiverseAssets> DiverseAssets { get; set; }


        string connectionString = "Data Source = (localdb)\\ProjectsV13; Initial Catalog = assetsdatabase; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;Trusted_Connection = True";
        protected override void OnConfiguring(DbContextOptionsBuilder OB)
        {
            OB.UseSqlServer(connectionString);
            //OB.UseSqlServer(connectionString, o => o.MigrationsAssembly("Migrations"));
        }


    }
}
