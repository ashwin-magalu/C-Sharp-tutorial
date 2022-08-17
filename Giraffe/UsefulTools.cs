using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    // If I add static infront of class name, we can't create instance of this class.
    internal class UsefulTools 
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
