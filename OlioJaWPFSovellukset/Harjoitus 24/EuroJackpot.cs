using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Harjoitus_24
{
    internal class EuroJackpot
    {
        public static StackPanel Tarkistus(StackPanel gridi)
        {
            Random nr = new Random(); // randomnumeroita :3
            int kierros = 0; // tarvitaan että tiedetään milloin tulee tähtinumero
            StackPanel uusiSP = new StackPanel(); // tähän tulee vastaukset
            foreach (ComboBox combo in gridi.Children)
            {
                kierros++;
                int comboValue = int.Parse(combo.SelectedValue.ToString()); // otetaan käyttäjän valittu numero
                int rand = nr.Next(1, (kierros >= 6 ? 10 : 50)+1); // valitaan random numero. +1 että saadaan se vika numerokin siihen valinta mahdollisuudeksi
                TextBlock tb = new TextBlock(); // tehdään vastaus textblock
                if (rand == comboValue) tb.Text = $"✅ Oikein: {rand}"; // oli oikein, hyvä, lisätään se
                else tb.Text = $"❌ Vastaus: {rand} (sinä: {comboValue})"; // oli väärin, womp womp, lisätään se
                uusiSP.Children.Add(tb); // ja viimeiseksi lisätään textblock SP:hen
            }
            return uusiSP; // ja returnataan vastaukset
        }
    }
}
