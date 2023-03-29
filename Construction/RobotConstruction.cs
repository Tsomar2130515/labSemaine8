using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    internal class RobotConstruction : Robot
    {
        public RobotConstruction(string nom, string description, int resistance) : base(nom, description, resistance)
        {

        }
        public override void Construire(Batiment Batim)
        {
            Console.WriteLine("Construire");

        }


    }
}
