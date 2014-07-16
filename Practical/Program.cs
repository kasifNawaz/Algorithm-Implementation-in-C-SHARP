using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical
{
    class Program
    {
       
        static void Main(string[] args)
        {

            List<car> cars = new List<car>();

            car c = new car();
            c.name="tata"
            c.owner.name="kasif";
        }
       
    }

     public class people
     {
         public string name { get; set; }
     }
     public class car
     {
         public string name { get; set; }
         public people owner { get; set; }
     }


}
