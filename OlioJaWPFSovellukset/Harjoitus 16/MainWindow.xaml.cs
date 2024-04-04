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

namespace Harjoitus_16
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
        private static double Maileiksi(double km)
        {
            return km * 0.621371;
        }
        private static double Kilometreiksi(double ml)
        {
            return ml / 0.621371;
        }
        // Käytämme näitä kahta niin tiedämme mikä on muutettu.
        private string AiempiKM;
        private string AiempiML;
        private void btnKmToMiles_Click(object sender, RoutedEventArgs e)
        {
            // parsetaan doubleina:
            double kilometrit;
            double mailit;
            // Yritetään parsee (aina ei ehkä toimi)
            double.TryParse(Mailit.Text, out mailit);
            double.TryParse(Kilometrit.Text, out kilometrit);


            // Onko KM boksi muutettu?
            if(AiempiKM != Kilometrit.Text)
            {
                // Oli joten asetetaan maili boksi:
                AiempiKM = Kilometrit.Text;
                Mailit.Text = Maileiksi(kilometrit).ToString();
                AiempiML = Mailit.Text;
            } else if(AiempiML != Mailit.Text) // Onko ML boksi muutettu?
            {
                // Oli joten asetetaan kilometri boksi:
                AiempiML = Mailit.Text;
                Kilometrit.Text = Kilometreiksi(mailit).ToString();
                AiempiKM = Kilometrit.Text;
            }
        }
    }
}
