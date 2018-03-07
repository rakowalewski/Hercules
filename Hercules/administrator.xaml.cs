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

namespace Hercules
{
    /// <summary>
    /// Logika interakcji dla klasy administrator.xaml
    /// </summary>
    public partial class administrator : Window
    {
        public administrator()
        {
            InitializeComponent();
        }

        private void btnKonta_Click(object sender, RoutedEventArgs e)
        {
            AdminFrame.Content = new Konta_AdminPage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminFrame.Content = new Statystyki_Admin();
        }
    }
}
