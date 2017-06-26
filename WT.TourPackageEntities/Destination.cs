using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WT.TourPackageEntities
{
    public class Destination
    {
        [Key]
        public int DestinationID { get; set; }
        public string DestinationName { get; set; }
    }
}
