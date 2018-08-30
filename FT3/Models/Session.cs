using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FT3.Models
{
    public class Session
    {
        public int ID { get; set; }
        public int ExID { get; set; }

        public List<Set> Sets { get; set; }
    }
}
