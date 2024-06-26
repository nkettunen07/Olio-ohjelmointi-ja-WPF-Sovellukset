﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus7
{
    internal class Hissi
    {
        private static int _kerros { get; set; }
        private int Kerros
        {
            get 
            { 
                return _kerros;
            }
            set
            {
                if(value >= 1 && value <= 6)
                {
                    // Hissi hyväksyi. asetetaan kerros uuteen.
                    _kerros = value;
                    Console.WriteLine($"Hissi on nyt kerroksessa {_kerros}");
                } else
                {
                    // Hissi EI hyväksyny. loggaa konsoliin.
                    Console.WriteLine($"Antamasi kerros ei ole valitettavasti toimiva kerros. Anna kerros väliltä 1-6");
                }
            }
        }
        public void Asetakerros(int _krs)
        {
            Kerros = _krs; // koitetaan asettaa kerros antamaan numeroon
        }
        public int kerrokset() { return _kerros; } // Viimeisin hyväksytty kerros
    }
}
