using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WT.TourPackageEntities
{
    public class DestinationPackage
    {
        public int DestinationPackageID { get; set; }
        public int DestinationID { get; set; }
        public int PackageTourID { get; set; }
    }
}
