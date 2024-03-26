using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus10
{
    internal interface ICanFly
    {
        public int WingSize { get; set; }
        public void Fly();
    }
}
