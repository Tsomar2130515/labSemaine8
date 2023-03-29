using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Construction
{
    class Program
    {
        

        static void Main(string[] args)
        {
            laSimulation simul = new laSimulation("Simulation");
            simul.Simuler();
            Console.ReadKey();

            
           


        }

    }
}
