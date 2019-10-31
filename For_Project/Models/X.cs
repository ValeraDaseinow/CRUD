using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using For_Project.Models;

namespace For_Project.Models
{

    public class X 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }


        public X(int id, string name, string value)
        {
            Id = id;
            Name = name;
            Value = value;
        }
    }

    
}
