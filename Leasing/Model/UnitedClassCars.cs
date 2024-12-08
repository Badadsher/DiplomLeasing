using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leasing.Model
{
    public class CarView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MonthCount { get; set; }
        public int CarPrice { get; set; }
        public int Avance { get; set; }
        public int MothlyPrice { get; set; }
        public int AllAmount { get; set; }
        public string Status { get; set; }
        public byte[] Images { get; set; }
    }
}
