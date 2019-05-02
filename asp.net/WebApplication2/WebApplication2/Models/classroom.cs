using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class classroom
    {
        public int number { get; set; }
        public string subgect { get; set; }
        public List<student> students { get; set; }
    }
}