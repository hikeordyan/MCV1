using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Collections;
namespace MvcApplication1.Models
{
    public class Test
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
        
        public Test(int ID,string Name,string address)
        {
            this.ID = ID;
            this.Name = Name;
            this.address = address;
        }

        public Test()
        {
            // TODO: Complete member initialization
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2};", ID, Name , address);
        }

        
    }

    
}