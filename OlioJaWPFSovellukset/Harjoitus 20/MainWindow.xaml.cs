using Harjoitus_20;
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

namespace Harjoitus_20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Kokoelma OppilasKokoelma = new Kokoelma();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSaveToFile_Click(object sender, RoutedEventArgs e)
        {
            // Tallenna
            OppilasKokoelma.Tallenna();  // Tallenna tiedostoon
            this.RenderoiSP();
        }

        private void btnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            // jep :DD
            OppilasKokoelma.Lue(this.RenderoiSP); // Lue ja re-renderöi
        }

        private void RenderoiSP()
        {
            opiskelijatSP.Children.Clear(); // Tyhjennä SP
            foreach (Opiskelija opiskelija in OppilasKokoelma.Kaikki().Values)
            { // Lue kaikki opiskelijat ja lisää uusi TextBlock opiskelijatSP:seen
                TextBlock OpiskelijaTB = new TextBlock();
                OpiskelijaTB.Text = $"{opiskelija.Etunimi} {opiskelija.Sukunimi} {opiskelija.OpiskelijaID} {opiskelija.Sähköposti} {opiskelija.Puhelinnumero}";
                opiskelijatSP.Children.Add(OpiskelijaTB);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Lisää opiskelija (ainakin koita)
            OppilasKokoelma.Lisää(Etunimi.Text, Sukunimi.Text, OpiskelijaID.Text, Sähköposti.Text, Puhelinnumero.Text);

            // sitten katsotaan onko se siellä:
            bool check = OppilasKokoelma.Hae(OpiskelijaID.Text);
            if(check==false)
            {
                // eip
                return;
            }
            this.RenderoiSP();
        }
    }
}
