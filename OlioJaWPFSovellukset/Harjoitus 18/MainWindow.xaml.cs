using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Harjoitus_18
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Summa_Click(object sender, RoutedEventArgs e)
        {
            // Käytämme TryParsea koska tässä vaiheessa ei ole vielä opetettu sitä että voi vain numeroita kirjoittaa
            // Jonka takia käytän sitten TryParsea koska voi kirjoittaa mitä tahansa.
            float lasku1;
            float lasku2;
            float.TryParse(Lasku1.Text, out lasku1);
            float.TryParse(Lasku2.Text, out lasku2);

            Vastaus.Text = $"Vastaus: {Laskin.Summa(lasku1, lasku2)}";
        }
        private void Erotus_Click(object sender, RoutedEventArgs e)
        {
            // Käytämme TryParsea koska tässä vaiheessa ei ole vielä opetettu sitä että voi vain numeroita kirjoittaa
            // Jonka takia käytän sitten TryParsea koska voi kirjoittaa mitä tahansa.

            // Nämä metodit executeavat kun niiden buttoneita clickataan
            float lasku1;
            float lasku2;
            float.TryParse(Lasku1.Text, out lasku1);
            float.TryParse(Lasku2.Text, out lasku2);

            Vastaus.Text = $"Vastaus: {Laskin.Erotus(lasku1, lasku2)}";
        }
        private void Kerto_Click(object sender, RoutedEventArgs e)
        {
            // Olisi paljon helpompi tapa tehdä tämä mutta...
            float lasku1;
            float lasku2;
            float.TryParse(Lasku1.Text, out lasku1);
            float.TryParse(Lasku2.Text, out lasku2);

            Vastaus.Text = $"Vastaus: {Laskin.Kertolasku(lasku1, lasku2)}";
        }
        private void Jako_Click(object sender, RoutedEventArgs e)
        {
            // Ehkä myöhemmin.
            float lasku1;
            float lasku2;
            float.TryParse(Lasku1.Text, out lasku1);
            float.TryParse(Lasku2.Text, out lasku2);

            Vastaus.Text = $"Vastaus: {Laskin.Jako(lasku1, lasku2)}";
        }
    }
}
