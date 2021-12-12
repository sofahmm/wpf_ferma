using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFerma.Models
{
    public class Horse_health
    {
        public int ID { get; set; }
        public int ID_Horse { get; set; }
        public int Weight { get; set; }
        public int Body_temperature{ get; set; }
        public string Dental_condition { get; set; }
        public DateTime DataReport { get; set; }
    }
}
