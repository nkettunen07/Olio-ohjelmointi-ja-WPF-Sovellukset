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

namespace Harjoitus_17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float lämpötila;
        bool keittiöValot;
        bool olohuoneenValot;
        bool oviLukossa;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AsetaTeksti()
        {
            // Tehdään string tekstit että voidaan asettaa taloteksti
            string keittiövalot = (keittiöValot == true) ? "päällä" : "pois";
            string olohuoneenvalot = (olohuoneenValot == true) ? "päällä" : "pois";
            string ovilukossa = (oviLukossa == true) ? "on lukossa" : "ei ole lukossa";
            // Käytimme tersereitä että ei tarvitse if-else lauseita
            TaloTeksti.Text = $"Lämpötila {lämpötila} celsius, Keittiövalot {keittiövalot}, Olohuoneen valot {olohuoneenvalot}, Ovi {ovilukossa}";
        }
        private void KeittiöValot_PäällePois(object sender, RoutedEventArgs e)
        {
            // Asetetaan keittiövalot true tai false
            keittiöValot = (bool)KeittiöValot.IsChecked;
            AsetaTeksti();
        }

        private void OlohuoneenValot_PäällePois(object sender, RoutedEventArgs e)
        {
            // Asetetaan olohuoneenValot true tai false
            olohuoneenValot = (bool)OlohuoneenValot.IsChecked;
            AsetaTeksti();
        }

        private void OviLukossa_PäällePois(object sender, RoutedEventArgs e)
        {
            // Asetetaan oviLukossa true tai false
            oviLukossa = (bool)OviLukossa.IsChecked;
            AsetaTeksti();
        }

        private void Lämpötila_TextChange(object sender, TextChangedEventArgs e)
        {
            if (TaloTeksti?.Text == null) return; // Yleensä tää funktio runnaa alussa jolloin TaloTeksti on null, niin pitää checkkaa että se EI ole null
            if (float.TryParse(Lämpötila.Text, out lämpötila)) AsetaTeksti(); // TryParsetaan se numero ja asetetaan lämpötila muuttuja numeroksi jos se toimii.
        }
        // Ja aina lopuksi AsetaTeksti();
    }
}
