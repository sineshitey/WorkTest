using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WT.TourPackageEntities;

namespace WT.TourPackageEF
{
    public class TourPackageDB : DbContext
    {
        public TourPackageDB() : this("TourPackageDB")
        {
            Database.SetInitializer<TourPackageDB>(new CreateDatabaseIfNotExists<TourPackageDB>());
        }

        public TourPackageDB(string nameOrConnectionString) : base(nameOrConnectionString)
        {

        }

        public DbSet<Destination> Destination { get; set; }
        public DbSet<DestinationPackage> DestinationPackage { get; set; }
        public DbSet<PackageDetails> PackageDetails { get; set; }
    }
}
