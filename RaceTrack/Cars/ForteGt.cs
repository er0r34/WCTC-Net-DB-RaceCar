using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class ForteGt : RaceCar
    {
        public ForteGt()
        {
            Name = "Forte GT";
            TopSpeed = 85;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} starts with a low rumble!");
        }
 

        public override void Brake()
        {
            Console.WriteLine($"The {Name} slows way down!");
            base.Brake();
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name}'s engine shuts down with a low whoosh!");
        }
    }
}
