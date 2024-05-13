using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Harjoitus_24
{
    internal class Lotto
    {
        public static StackPanel Tarkistus(StackPanel gridi)
        {
            Random nr = new Random();
            StackPanel uusiSP = new StackPanel();
            foreach(ComboBox combo in gridi.Children)
            {
                // selitykset löytynee EuroJackpot.cs tiedostosta. Tämä on aima samanlaita joten en kommentoi.
                int comboValue = int.Parse(combo.SelectedValue.ToString());
                int rand = nr.Next(1, 40+1);
                TextBlock tb = new TextBlock();
                if (rand == comboValue) tb.Text = $"✅ Oikein: {rand}";
                else tb.Text = $"❌ Vastaus: {rand} (sinä: {comboValue})";
                uusiSP.Children.Add(tb);
            }
            return uusiSP;
        }
    }
}
