using BOL.HelpModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Models
{
   public class ProjectReport
    {
        public Project ProjectInfo { get; set; }
        public decimal ProjectStateByPrecents { get; set; }
        public List<WorkerForProjectReport> Workers { get; set; }
    }
}
