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

namespace Hercules
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cboxPermissions.ItemsSource = LoadComboBoxData();
        }
        private string [] LoadComboBoxData()
        {
            string[] strArray =
            {
                "Administrator",
                "Trainer",
                "Reception"
            };
            return strArray;
        }

        private void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {
            //Podłączenie do bazy danych
            string val = cboxPermissions.SelectedItem.ToString();
            string t = "Trainer";
            MessageBox.Show(cboxPermissions.SelectedItem.ToString());
           
        }
    }
}
