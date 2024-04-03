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

namespace Harjoitus_15
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

        // Kuorma-autojen ja henkilöautojen muuttujat
        private int KuormaAutot = 0;
        private int HenkilöAutot = 0;
        private void KuormaAutoButton_onClick(object sender, RoutedEventArgs e)
        {
            // +1 kuorma-autoihin koska sen nappulaa painettiin
            KuormaAutot++;
            // Asetetaan kuorma-auto teksti uuteen numeroon.
            KuormaAutoText.Text = KuormaAutot.ToString();
        }

        private void HenkilöAutoButton_onClick(object sender, RoutedEventArgs e)
        {
            // +1 henkilöautoihin koska sen nappulaa painettiin
            HenkilöAutot++;
            // Asetetaan henkilöauto teksti uuteen numeroon.
            HenkilöAutoText.Text = HenkilöAutot.ToString();
        }
    }
}
