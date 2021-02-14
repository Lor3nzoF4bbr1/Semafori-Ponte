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
using System.Threading;

namespace Semafori_Ponte
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Uri uriMacchinaDestra = new Uri("Macchina-destra.png", UriKind.Relative);
        static int posMacchinaDestra = 634;
        readonly Uri uriMacchinaSinistra = new Uri("Macchina-sinistra.png", UriKind.Relative);
        static int posMacchinaSinistra = 624;

        private static object x = new object();

        public MainWindow()
        {
            InitializeComponent();

            ImageSource imgDx = new BitmapImage(uriMacchinaSinistra);
            imgMacchinaSinistra.Source = imgDx;
            ImageSource imgSx = new BitmapImage(uriMacchinaDestra);
            imgMacchinaDestra.Source = imgSx;

            Thread t1 = new Thread(new ThreadStart(MovimentoDestraSinistra));
            Thread t2 = new Thread(new ThreadStart(MovimentoSinistraDestra));

            t1.Start();
            t2.Start();
        }

        public void MovimentoDestraSinistra()
        {
            lock (x)
            {
                while (posMacchinaDestra > -463)
                {
                    posMacchinaDestra -= 2;

                    Thread.Sleep(TimeSpan.FromMilliseconds(7));

                    this.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        imgMacchinaDestra.Margin = new Thickness(posMacchinaDestra, 55, 0, 231);
                    }));
                }
            }
        }

        public void MovimentoSinistraDestra()
        {
            lock (x)
            {
                while (posMacchinaSinistra > -463)
                {
                    posMacchinaSinistra -= 2;

                    Thread.Sleep(TimeSpan.FromMilliseconds(7));

                    this.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        imgMacchinaSinistra.Margin = new Thickness(0, 127, posMacchinaSinistra, 169);
                    }));
                }
            }
        }
    }
}
