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
using System.Data.SqlClient;

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
        private string [] LoadComboBoxData() //data to combobox
        {
            string[] strArray =
            {
                "Administrator",
                "Trener",
                "Recepcja"
            };
            return strArray;
        }

        private void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {
            //Podłączenie do bazy danych


            try
            {
                var connectionString = @"Data Source=RAFAL-PC;initial catalog=FITNES;integrated security=True";  //Łączenie do bazy danych
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string txtUser = tbxLogin.Text;
                    string txtPasswd = pbPassword.Password.ToString();
                    string cbPermission = cboxPermissions.Text;

                    string query = "SELECT * FROM Konta WHERE Login=@user AND Haslo=@paswd AND Przywileje=@perm";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@user", txtUser));
                    cmd.Parameters.Add(new SqlParameter("@paswd", txtPasswd));
                    cmd.Parameters.Add(new SqlParameter("@perm", cbPermission));
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        
                        if (cbPermission == "Trener")
                        {
                            trener tr = new trener();
                            tr.ShowDialog();
                           
                        }
                        else if (cbPermission == "Recepcja")
                        {
                            recepcja rc = new recepcja();
                            rc.ShowDialog();
                        }
                        else
                        {
                            administrator ad = new administrator();
                            ad.ShowDialog();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Invalid Login");
                    }
                    con.Close();

                    /*
                     * Na tą chwile działa podłączenie.
                     * Pojawia się już okno prawidłowo
                     * Okna pojawiają się w zależności od pracownika
                       */


                }
            }
            catch (Exception)
            {

                throw;
            }









        }
    }
}
