using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTTPClientProject.Models
{
 

    public class APIDataModel
    {
        public string status { get; set; }
        public Datum[] data { get; set; }
        public string message { get; set; }
    }


}
