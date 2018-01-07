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

        private void btnAddPhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "image files |*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == true)
            {
                imgKlient.Source = new BitmapImage(new Uri(ofd.FileName));
            }


        }

        private void btnAddClient_Click(object sender, RoutedEventArgs e)
        {
            //Podłączenie się do bazy danych
            try
            {
                Klient klient = new Klient();

                var connectionString = @"Data Source=RAFAL-PC;initial catalog=FITNES;integrated security=True";
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    klient.Imie = tbxImie.Text;
                    klient.Nazwisko = tbxNazwisko.Text;
                    klient.Pesel = tbxPesel.Text;
                    klient.Adres = tbxAdres.Text;
                    klient.Telefon = tbxTelefon.Text;
                    klient.Email = tbxEmail.Text;
                    if (rbKobieta.IsChecked == true)
                    {
                        klient.Plec = "Kobieta";
                    }
                    else if (rbMezczyzna.IsChecked == true)
                    {
                        klient.Plec = "Mężczyzna";
                    }

                    string query = "INSERT INTO Klient(Imie, Nazwisko, Pesel, Adres, Telefon, Email, Plec, Zdjecie)VALUES (@imie, @nazwisko, @pesel, @adres, @telefon, @email, @plec, @zdjecie);";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@imie", klient.Imie));
                    cmd.Parameters.Add(new SqlParameter("@nazwisko", klient.Nazwisko));
                    cmd.Parameters.Add(new SqlParameter("@pesel", klient.Pesel));
                    cmd.Parameters.Add(new SqlParameter("@adres", klient.Adres));
                    cmd.Parameters.Add(new SqlParameter("@telefon", klient.Telefon));
                    cmd.Parameters.Add(new SqlParameter("@email", klient.Email));
                    cmd.Parameters.Add(new SqlParameter("@plec", klient.Plec));
                    cmd.Parameters.Add(new SqlParameter("@zdjecie", imgKlient.Source));
                    

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
