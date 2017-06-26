using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WT.TourPackageModels
{
    public class TourPackageModel
    {
        public int DestinationID { get; set; }
        public string DestinationName { get; set; }
        public int DestinationPackageID { get; set; }
        public int PackageTourID { get; set; }
        public string PackageTourName { get; set; }
        public string PackageDescription { get; set; }
        public int PersonPerPackage { get; set; }
        public float PackagePrice { get; set; }
        public string PackageImage { get; set; }
    }
}
