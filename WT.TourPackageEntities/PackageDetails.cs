using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WT.TourPackageEntities
{
    public class PackageDetails
    {
        [Key]
        public int PackageTourID { get; set; }
        public string PackageTourName { get; set; }
        public string PackageDescription { get; set; }
        public int PersonPerPackage { get; set; }
        public float PackagePrice { get; set; }
        public string PackageImage { get; set; }
    }
}
