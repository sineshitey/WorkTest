using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkTestTourPackage.Models;
using System.Web.Mvc;
using WT.TourPackageBL;
using WT.TourPackageModels;

namespace WorkTestTourPackage.Controllers
{
    public class TourPackageController : Controller
    {
        public ActionResult GetDestinationList()
        {
            List<TourPackageModel> destinationList;

            TourPackageBLL TourPackageBL = new TourPackageBLL();
            destinationList = TourPackageBL.GetDestinationList();
            return View(destinationList);
        }

        public ActionResult GetPackagePerDestination(int destinationID)
        {
            List<TourPackageModel> packagePerDestinationList;
            TourPackageBLL TourPackageBL = new TourPackageBLL();
            packagePerDestinationList = TourPackageBL.GetPackagePerDestinationList(destinationID);
            return View(packagePerDestinationList);
        }

    }
}