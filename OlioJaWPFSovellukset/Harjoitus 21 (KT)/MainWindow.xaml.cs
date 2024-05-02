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

namespace Harjoitus_21__KT_
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

        private void Osta(object sender, RoutedEventArgs e)
        {
            // koska ostamme niin tyhjennämme ostoskorin laittamalla kaikki falseen.
            maito.IsChecked = false;
            limsa.IsChecked = false;
            kananliha.IsChecked = false;
            kananwings.IsChecked = false;
            peruna.IsChecked = false;
            renderSP(sender, e); // ja sitten renderöidään stackpanel että muutokset näkyvät

        }

        private void renderSP(object sender, RoutedEventArgs e)
        {
            // Tämä funktio toteutuu aina kun ostaa tai lisää ostoskoriin
            // se managoi mitä näet ostoskorissa.
            ostoskori.Children.Clear(); // Tyhjennä SP

            // Käytämme listaa tähän koska se on helpompi tapa toteuttaa tämä
            List<string> Ostokset = new List<string>();
            if ((bool)maito.IsChecked == true) Ostokset.Add("Maito");
            if ((bool)limsa.IsChecked == true) Ostokset.Add("Limsa");
            if ((bool)peruna.IsChecked == true) Ostokset.Add("Peruna");
            if ((bool)kananliha.IsChecked == true) Ostokset.Add("Kananliha");
            if ((bool)kananwings.IsChecked == true) Ostokset.Add("Kanan wings");
            foreach (string i in Ostokset)
            {
                // ja menemme listan läpi ja lisätään SP:hen se teksti mikä on lisätty listaan esim Maito jos se on checkattu
                TextBlock TB = new TextBlock();
                TB.Text = i;
                ostoskori.Children.Add(TB);
            }

        }

    }
}
