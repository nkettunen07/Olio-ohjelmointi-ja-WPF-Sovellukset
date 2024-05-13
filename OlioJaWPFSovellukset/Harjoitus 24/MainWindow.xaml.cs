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

namespace Harjoitus_24
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Renderöi(); // alkurender
        }
        public void Renderöi()
        {
            // Renderöidään comboboxit comboboxgridiin comboboxmanagerin combot metodilla
            // nyt alussa kun starttaa niin tyyppi on lotto aina joten se tulee olemaan 7.
            ComboboxManager.Combot(ComboBoxGridi, ComboboxManager.Tyyppi == "lotto" ? 7 : ComboboxManager.Tyyppi == "vikinglotto" ? 6 : 7);
        }

        private void BTN_Tarkista(object sender, RoutedEventArgs e)
        {
            // Tässä tarkistamme vastaukset
            TarkistusSP.Children.Clear(); // tyhjennämme SP:n
            TextBlock tb = new TextBlock(); // tehdään tyypille textblock
            tb.Text = ComboboxManager.Tyyppi; // laitetaan teksti tyypiksi
            TarkistusSP.Children.Add(tb); // lisätään SP:hen
            StackPanel sp = 
                ComboboxManager.Tyyppi == "lotto" 
                ? Lotto.Tarkistus(ComboBoxGridi) 
                : ComboboxManager.Tyyppi == "vikinglotto" 
                ? VikingLotto.Tarkistus(ComboBoxGridi) 
                : EuroJackpot.Tarkistus(ComboBoxGridi); // nyt se isoin kohta, jos on lotto, käytetään loton tarkistusta, jos on vikinglotto... jne jne
            // käytin ? : lauseita koska sitten ei tarvitse kirjoittaa if else if else lauseita :P
            foreach(TextBlock tbs in sp.Children) { // sitten mennää tulosten läpi ja lisätään tulostekstit tarkistus SP:hen
                TextBlock copiedTB = new TextBlock();
                copiedTB.Text = tbs.Text;
                TarkistusSP.Children.Add(copiedTB); // ja sitten viimekseksi lisätään kopioitu TB toisesta TB:stä ja lisätään se tarkistus SP:hen
            }
        }
        // Nämä metodit asettavat tyypin tietyksi ja sitten renderöivät boxit. aika simppeliä.
        private void Lotto_Click(object sender, RoutedEventArgs e)
        {
            ComboboxManager.Tyyppi = "lotto";
            Renderöi();
        }

        private void VikingLotto_Click(object sender, RoutedEventArgs e)
        {
            ComboboxManager.Tyyppi = "vikinglotto";
            Renderöi();
        }

        private void EuroJackpot_Click(object sender, RoutedEventArgs e)
        {
            ComboboxManager.Tyyppi = "eurojackpot";
            Renderöi();
        }
    }
}
