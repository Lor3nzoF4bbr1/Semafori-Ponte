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

       private int macchineSinistra;
       private int macchineDestra;

        private static object x = new object();

        public MainWindow()
        {
            InitializeComponent();

            ImageSource imgDx = new BitmapImage(uriMacchinaSinistra);
            imgMacchinaSinistra.Source = imgDx;
            ImageSource imgSx = new BitmapImage(uriMacchinaDestra);
            imgMacchinaDestra.Source = imgSx;

            imgMacchinaDestra.Visibility = Visibility.Hidden;
            imgMacchinaSinistra.Visibility = Visibility.Hidden;
        }

        public void MovimentoDestraSinistra()
        {
            int j;
            for (int k = macchineDestra; k > 0; k -= 10)
            {
                j = 10;
                macchineDestra = k;

                if (k < 10)
                {
                    j = k;
                }

                lock (x)
                {
                    for (int i = 0; i < macchineDestra; i++)
                    {
                        while (posMacchinaDestra > -463)
                        {
                            posMacchinaDestra -= 100;

                            Thread.Sleep(TimeSpan.FromMilliseconds(20));

                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgMacchinaDestra.Margin = new Thickness(posMacchinaDestra, 55, 0, 231);
                            }));
                        }

                        if (posMacchinaDestra <= -463)
                        {
                            posMacchinaDestra = 634;
                        }
                    }
                }
            }
        }

        public void MovimentoSinistraDestra()
        {
            int j;
            for(int k = macchineSinistra; k > 0; k -= 10)
            {
                j = 10;
                macchineSinistra = k;

                if (k < 10)
                {
                    j = k;
                }

                lock (x)
                {
                    for (int i = 0; i < j; i++)
                    {
                        while (posMacchinaSinistra > -463)
                        {
                            posMacchinaSinistra -= 100;

                            Thread.Sleep(TimeSpan.FromMilliseconds(20));

                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgMacchinaSinistra.Margin = new Thickness(0, 127, posMacchinaSinistra, 169);
                            }));
                        }

                        if (posMacchinaSinistra <= -463)
                        {
                            posMacchinaSinistra = 624;
                        }
                    }
                }
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                macchineSinistra = int.Parse(txtNMacchineSinistra.Text);
                macchineDestra = int.Parse(txtNMacchineDestra.Text);

                if (macchineDestra > 0)
                {
                    imgMacchinaDestra.Visibility = Visibility.Visible;
                }

                if (macchineSinistra> 0)
                {
                    imgMacchinaSinistra.Visibility = Visibility.Visible;
                }

                Thread t1 = new Thread(new ThreadStart(MovimentoDestraSinistra));
                Thread t2 = new Thread(new ThreadStart(MovimentoSinistraDestra));

                Random rnd = new Random();
                int r = rnd.Next(1);

                t1.Start();
                t2.Start();

                /*
                switch (r)
                {
                    case 0:
                        t1.Start();
                        break;

                    case 1:
                        t2.Start();
                        break;
                }
                */

                MessageBox.Show("Macchine create");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
