using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WT.TourPackageEF;
using WT.TourPackageEntities;

/*Tour Package Data Access Layer
 Gets data from Entitiy Framework*/

namespace WT.TourPackageDL
{
    public class TourPackageDAL
    {
        public TourPackageDB TourDatabase;
        public List<Destination> GetDestinations()
        {
            try
            {
                using (TourDatabase = new TourPackageDB())
                {
                    return TourDatabase.Destination
                        .ToList();
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public List<PackageDetails> GetPackagePerDestination(int destinationID)
        {
            try
            {
                using (TourDatabase = new TourPackageDB())
                {
                    var result = (from p in TourDatabase.PackageDetails
                                  join dp in TourDatabase.DestinationPackage
                                  on p.PackageTourID equals dp.PackageTourID
                                  where dp.DestinationID == destinationID
                                  select p).ToList();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}