using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Harjoitus_19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Hissi hissi = new Hissi();
        public MainWindow()
        {
            InitializeComponent();
        }
        // Kävin katsoo ratkaisun ja mitä v---. tän miten tein, saa näin helposti tehtyä mut sit ratkaisu on noin pitkä.
        // ohhoh..............................................................
        // HEI SE TOIMII MITEN HALUTTIIN!
        private void HissiKerrosTB_Valid(object sender, TextCompositionEventArgs e)
        {
            // Jos on INT, niin koitetaan asettaa kerros siihen:
            if (int.TryParse(e.Text, out int _) == true)
            {
                // koitetaan asettaa kerros:
                hissi.Asetakerros(int.Parse(e.Text));
                // jos se muuttu, niin asetetaan hissikerros teksti siihen.
                HissiKerros.Text = hissi.kerrokset().ToString();
                e.Handled = true; // ei anneta käyttäjän tekstin näkyvän;
                HissiKerrosTB.Text = hissi.kerrokset().ToString(); // asetetaan käyttäjän kirjoittaman tekstin päälle se numero minkä hissi hyväksyi
            }
            else
            {
                // ei ollut oikea numero
                HissiKerros.Text = "Oikea numero kiitos.";
                e.Handled = true; // tämä että ei pidetä sitä kirjainta
                HissiKerrosTB.Text = hissi.kerrokset().ToString(); // ja ylikirjoitetaan käyttäjän kirjoittama teksti hissin viimeisemmällä hyväksymällä numerolla.
            }
        }

    }
}
