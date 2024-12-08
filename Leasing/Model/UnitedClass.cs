using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leasing.Model
{
    public class LeaseViewModel
    {
        public int CarId { get; set; } 
        public string Name { get; set; }
        public byte[] Images { get; set; }
        public int MothlyPrice { get; set; }
        public int CarID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
    }
}
