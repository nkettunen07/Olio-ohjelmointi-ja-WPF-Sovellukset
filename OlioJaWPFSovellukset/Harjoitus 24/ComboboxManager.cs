using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Harjoitus_24
{
    internal class ComboboxManager
    {
        public static string Tyyppi = "lotto"; // hallitsee kaikkia tyyppejä, voi olla lotto | vikinglotto | eurojackpot
        public static void Set(ComboBox combox, int NumeroAloitus, int NumeroLopetus)
        {
            combox.Items.Clear(); // tyhjennetään comboboxi
            for(int i = NumeroAloitus; i <= NumeroLopetus; i++)
            {
                combox.Items.Add(i.ToString()); // lisätään numeroita comboboxiin esim 1-40 väliltä
            }
        }
        public static void Combot(StackPanel gridi, int monta)
        {
            gridi.Children.Clear(); // Tyhjennetään StackPanel (OK TIEDÄN ETTÄ SE ON NIMELLÄ GRID. SE OLIKIN GRID ENNEN MUTTA MUUTIN SEN KOSKA SP TOIMI JA GRIDI EI)
            for (int i = 0; i < monta; i++) // Mennään kierroksia
            {
                ComboBox combo = new ComboBox(); // tehdään combobox
                ComboBox tähti = new ComboBox(); // tehdään tähti combobox (tätä käytetään vain kun on eurojackpot
                Set(combo, 1, Tyyppi == "lotto" ? 40 : Tyyppi == "vikinglotto" ? 48 : 50); // Asetetaan combo-boxiin väliltä 1-40/48/50
                Set(tähti, 1, 10); // ja asetetaan tähti-boxiin  väliltä 1-10. Tätä käytetään vain kun on eurojackpot
                if (i >= 5 && Tyyppi == "eurojackpot") gridi.Children.Add(tähti); // jos on jo 6 tai 7 numero ja on eurojackpot, niin lisätään tähti boxi
                else gridi.Children.Add(combo); // muuten se normaali lisätään siihen SP:hen
            }

        } 
    }
}
