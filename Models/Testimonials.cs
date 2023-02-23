﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodesWeaverNew.Models
{
    public class Testimonials
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public bool willshown { get; set; }
    
}
}
