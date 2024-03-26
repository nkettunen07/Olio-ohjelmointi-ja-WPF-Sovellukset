using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus10
{
    internal class Animal
    {
        public string Name { get; set; } = "";
        public void MakeASound()
        {
            Console.WriteLine("Miau"); // :3
        }
    }
}
