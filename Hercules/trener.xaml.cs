using Microsoft.Win32;
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
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Hercules
{
    /// <summary>
    /// Logika interakcji dla klasy trener.xaml
    /// </summary>
    public partial class trener : Window
    {
        public trener()
        {
            InitializeComponent();
            
            
        }

        

      

        private void BtnTrening_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnKlient_Click(object sender, RoutedEventArgs e)
        {
            Klient_Trener klient = new Klient_Trener();
            klient.ShowDialog();
        }
    }
}
