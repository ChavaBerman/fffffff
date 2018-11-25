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
<<<<<<< HEAD
        public Project ProjectInfo { get; set; }
        public decimal ProjectStateByPrecents { get; set; }
        public List<WorkerForProjectReport> Workers { get; set; }
=======
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public decimal ReservingHours { get; set; }
        public decimal GivenHours { get; set; }
>>>>>>> cefbea1ebe43b7c294cdbb0a1fc2a8aabadfaf2d
    }
}
