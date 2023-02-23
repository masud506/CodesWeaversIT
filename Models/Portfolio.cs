using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodesWeaverNew.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string LinkTitle { get; set; }
        public string PersonName { get; set; }
        public byte[] Image { get; set; }
        public bool willshown { get; set; }
    }
}
