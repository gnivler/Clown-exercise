using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingIhave, int numberOfScaryThings) : base (funnyThingIhave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        private int numberOfScaryThings { get; set; }
        public string ScaryThingIHave
        {
            get
            {
                return $"{numberOfScaryThings} spiders!\r\n";
            }
        }
        public void ScareLittleChildren()
        {
            Console.WriteLine("Boo!  Gotcha!");
        }
    }
}
