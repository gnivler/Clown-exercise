using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class FunnyFunny : IClown
    {
        private string funnyThing;

        public FunnyFunny(string funnyThingIHave)
        {
            funnyThing = funnyThingIHave;
        }

        public string FunnyThingIHave
        {
            get { return funnyThing; }
        }

        public void Honk()
        {
            Console.WriteLine($"Hi kids!  I have a {funnyThing}\r\n");
        }
    }
}
