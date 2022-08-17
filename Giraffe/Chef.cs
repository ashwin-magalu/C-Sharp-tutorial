using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Chef
    {
        public void MakeChicken() {
            Console.WriteLine("The chef makes Chicken");
        }

        public void MakeSalad() {
            Console.WriteLine("The chef makes Salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes bbq ribs");
        }
    }
}
