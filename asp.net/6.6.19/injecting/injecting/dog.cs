using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace injecting
{
    public class dog
    {
        //[Compare("kofiko")]
        public string name { get; set; }
        public int age { get; set; }
        public string type { get; set; }
        [Range(21,200)]
        public int lifeExpectency { get; set; }
    }
}
