using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WT.TourPackageDL;
using WT.TourPackageEntities;
using WT.TourPackageModels;

/*Tour Package Business Logic Layer*/
namespace WT.TourPackageBL
{
    public class TourPackageBLL
    {
        TourPackageDAL TourDatabaseDAL = new TourPackageDAL();

        public List<TourPackageModel> GetDestinationList()
        {
            try
            {
                var destinations = TourDatabaseDAL.GetDestinations()
                    .ToList();
                List<TourPackageModel> TourPackageDestinations = new List<TourPackageModel>();

                foreach (var result in destinations)
                {
                    TourPackageModel item = new TourPackageModel();
                    item.DestinationID = result.DestinationID;
                    item.DestinationName = result.DestinationName;

                    TourPackageDestinations.Add(item);
                }
                return TourPackageDestinations;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public List<TourPackageModel> GetPackagePerDestinationList(int DestinationID)
        {
            try
            {
                List<TourPackageModel> PackageDetailsList = new List<TourPackageModel>();
                var packagePerDestination = TourDatabaseDAL.GetPackagePerDestination(DestinationID).ToList();

                foreach (var result in packagePerDestination)
                {
                    TourPackageModel packageDetails = new TourPackageModel();
                    packageDetails.PackageTourID = result.PackageTourID;
                    packageDetails.PackageTourName = result.PackageTourName;
                    packageDetails.PackageDescription = result.PackageDescription;
                    packageDetails.PackagePrice = result.PackagePrice;
                    packageDetails.PersonPerPackage = result.PersonPerPackage;
                    packageDetails.PackageImage = result.PackageImage;

                    PackageDetailsList.Add(packageDetails);
                }
                return PackageDetailsList;
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
