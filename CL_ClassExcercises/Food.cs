using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_ClassExcercises
{
    class Food
    {
        public int CupCakes { get; set; };
        public int eatCupCakes() { CupCakes += -1; Console.WriteLine("You have " + CupCakes + " cupcakes left."); };
    }
}
