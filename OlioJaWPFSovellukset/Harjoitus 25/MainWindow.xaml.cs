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

namespace Harjoitus_25
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
        private List<Joukkue> joukkueList = new List<Joukkue>();
        private void UusiJoukkue_Click(object sender, RoutedEventArgs e)
        {
            Joukkue joukkue = new Joukkue("Uusijoukkue", "Kotikaupunki", new List<Pelaaja>());
            Pelaaja pelaaja = new Pelaaja("Etunimi", "Sukunimi", 1, joukkue);
            joukkue.LisääPelaaja(pelaaja);
            joukkueList.Add(joukkue);
            Renderöi();
        }
        private List<Joukkue> GetJoukkueet() {
            return joukkueList;
        }
        public void Renderöi()
        {
            JoukkueDG.ItemsSource = GetJoukkueet();
        }
    }
}
