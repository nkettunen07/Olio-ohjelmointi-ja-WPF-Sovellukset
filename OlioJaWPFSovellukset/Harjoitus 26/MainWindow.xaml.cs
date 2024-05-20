using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
using System.Timers;
using System.Threading;
namespace Harjoitus_26
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static TextBlock mrbeast_id;
        public static TextBlock tseries_id;
        public static Label diff_id;

        public MainWindow()
        {
            InitializeComponent();
            mrbeast_id = id_mrbeast; // koska jostakin syystä en voinut muokata näitä tän ulkona
            tseries_id = id_tseries;
            diff_id = id_difference;

            Render(); // tiedot

            Uudelleen(); // aina 2s välein
        }
        public void Render()
        {
            MrBeast mb = new MrBeast(); // luuuulen että kun tää on tarpeeks kauan auki voi tulla memory leak tän takia mutta........
            // koska C# on ärsyttävä, niin en jaksa etsiä koska tämäkin toimii nopeasti.
            mb.Render();
            TSeries ts = new TSeries();
            ts.Render();
            diff_id.Content = $"{(ts.tilaajat - mb.tilaajat):n0}"; // tilaaja ero
        }
        public async void Uudelleen()
        {
                for (; ; ) // ei lopu ikinä
                {
                    await Task.Delay(2000); // odotetaan 2s (2000ms)
                    Render(); // tietojen päivitys
                }
        }
    }
}
