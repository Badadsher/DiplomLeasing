﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leasing.Model
{
    public class LeaseViewModel
    {
        public int LeaseID { get; set; }    
        public int CarId { get; set; } 
        public string Name { get; set; }
        public byte[] Images { get; set; }
        public int MothlyPrice { get; set; }
        public int CarID { get; set; }
        public int ClientID { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
      
       
        public string Status { get; set; }
    }
}
