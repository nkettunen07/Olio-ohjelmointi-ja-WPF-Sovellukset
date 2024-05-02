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

namespace Harjoitus_23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Kiuas kiuas = new Kiuas(true, 120, 100); // 120 lämpötila ja 100 kosteus defaultiksi nyt alkuun.
        public MainWindow()
        {
            InitializeComponent();
            if(rdb_lämpötila != null) // checkkauksia vain, jos on olemassa niin checked =true
            {
                rdb_lämpötila.IsChecked = true;
            } else if(rdb_kosteus != null)
            {
                rdb_kosteus.IsChecked = true;
            }
            RenderKiuas(null, null); // ja renderöidään null null.
            // null null koska muuten se valittaa jos ei anna mitään ja jos tyhjentää argumentit nii muu osa sovelluksesta alkaa valittaa
        }
        private void RenderKiuas(object sender, RoutedEventArgs e)
        {

            // otetaan kiukaasta arvot
            Lämpötila.Text = "Lämpötila: "+kiuas.getLämpötila().ToString();
            Kosteus.Text = "Kosteus: "+kiuas.getKosteus().ToString();
        }
        private List<int> Numerot = new List<int>(); // sisältää numerot
        private void RadioButtonManager(object sender, RoutedEventArgs e)
        {
            // tässä katsomme kumpi oli se jota clickattiin. jos oli lämpötila niin asetetaan kosteus falseen ja vice versa
            RadioButton rdb = (RadioButton)sender;
            if(rdb.Content.ToString().ToLower() == "lämpötila")
            {
                rdb_kosteus.IsChecked = false;
                rdb_lämpötila.IsChecked = true;
            } else
            {
                rdb_kosteus.IsChecked = true;
                rdb_lämpötila.IsChecked = false;
            }
            // käytin tässä hyvin epäeettisiä tapoja tehdä tämän mutta tulee helpottumaan kun lisää lisää kuraa sovellukseen.
        }

        private void NumPadManager(object sender, RoutedEventArgs e)
        {
            // katsomme mikä content buttonissa oli ja parsetamme sen ja lisäämme numerolistaan
            Button npd = (Button)sender;
            int numbertoadd = int.Parse(npd.Content.ToString().Replace(" ", ""));
            Numerot.Add(numbertoadd);
            RenderTextBox(sender, e); // ja lopuksi renderöidään tekstiboxi
        }
        private void RenderTextBox(object sender, RoutedEventArgs e)
        {
            numerot.Text = String.Join("", Numerot.ToArray()); // joinataan numerot listassa stringiin esim 1, 2, 3 => 123
        }

        private void NumPadPoista(object sender, RoutedEventArgs e)
        {
            // tein virheen käyttämällä listiä mut tääkin toimii lol
            Numerot.RemoveAt(Numerot.Count - 1);
        }

        private void NumPadEnter(object sender, RoutedEventArgs e)
        {
            int UusiMuoto;
            int.TryParse(
                String.Join(
                    "",
                    Numerot.ToArray()
                    ).ToString(), // teemme listasta string muotoisen ja sitten parsemme se
                out UusiMuoto
                ); // parsetamme numerot UusiMuoto muuttujaat
            int UusiLämpötila = rdb_lämpötila.IsChecked == true
                ? UusiMuoto
                : kiuas.getLämpötila();
            // Tarkistamme molemmissa kumpi on valittu ja jos oli valittu niin käytämme uuttamuotoa ja jos ei ollut niin fallback aiempaan numeroon
            int UusiKosteus = rdb_kosteus.IsChecked == true
                ? UusiMuoto
                : kiuas.getKosteus();
            kiuas.Lämpötila_Kosteus(UusiLämpötila, UusiKosteus); // asetamme kiukaan arvot
            RenderKiuas(sender, e); //renderöidään kiukaan arvot
            Numerot.Clear(); // tyhjennämme numerolistan
            RenderTextBox(sender, e); // renderöidään numeromanageri
        }
    }
}
