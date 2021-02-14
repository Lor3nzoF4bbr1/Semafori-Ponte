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
        public MainWindow()
        {
            InitializeComponent();

            MyThread tr1 = new MyThread();

            Thread t1 = new Thread(new ThreadStart(tr1.MovimentoDestraSinistra));
            Thread t2 = new Thread(new ThreadStart(tr1.MovimentoSinistraDestra));

            t1.Start();
            t2.Start();
        }

        public class MyThread
        {
            public void MovimentoDestraSinistra()
            {

            }

            public void MovimentoSinistraDestra()
            {

            }
        }
    }
}
