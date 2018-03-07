using Hercules.Klasy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Logika interakcji dla klasy Konta_AdminPage.xaml
    /// </summary>
    public partial class Konta_AdminPage : Page
    {
        public Konta_AdminPage()
        {
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void addUserBtn_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                Pracownik pracownik = new Pracownik();
                var connectionString = @"Data Source=RAFAL-PC;initial catalog=FITNES;integrated security=True";
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    pracownik.Imie = imieTB.Text;
                    pracownik.Nazwisko = nazwiskoTB.Text;
                    pracownik.Login = loginTB.Text;
                    pracownik.Haslo = hasloTB.Text;
                    string stanowisko = stanowiskoCB.Text;

                    if (stanowisko == "Administrator")
                    {
                        pracownik.IdPrzywilej = 3;
                        string query = "INSERT INTO Administrator( IdPrzywileje, Imie, Nazwisko, Login, Haslo)VALUES (@id, @imie,@nazwisko, @login, @haslo);";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@id", pracownik.IdPrzywilej));
                        cmd.Parameters.Add(new SqlParameter("@imie", pracownik.Imie));
                        cmd.Parameters.Add(new SqlParameter("@nazwisko", pracownik.Nazwisko));
                        cmd.Parameters.Add(new SqlParameter("@login", pracownik.Login));
                        cmd.Parameters.Add(new SqlParameter("@haslo", pracownik.Haslo));
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();

                        string query1 = "INSERT INTO Konta( Przywileje, Login, Haslo)VALUES ( @stanowisko, @login, @haslo);";
                        SqlCommand cmd1 = new SqlCommand(query1, con);
                        cmd1.Parameters.Add(new SqlParameter("@stanowisko", stanowiskoCB.Text));
                        cmd1.Parameters.Add(new SqlParameter("@login", pracownik.Login));
                        cmd1.Parameters.Add(new SqlParameter("@haslo", pracownik.Haslo));
                        cmd1.CommandType = CommandType.Text;
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Dodano użytkownika");
                    }
                    else if (stanowisko == "Trener")
                    {
                        pracownik.IdPrzywilej = 1;
                        string query = "INSERT INTO Trener( IdPrzywileje, Imie, Nazwisko, Login, Haslo)VALUES (@id, @imie,@nazwisko, @login, @haslo);";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@id", pracownik.IdPrzywilej));
                        cmd.Parameters.Add(new SqlParameter("@imie", pracownik.Imie));
                        cmd.Parameters.Add(new SqlParameter("@nazwisko", pracownik.Nazwisko));
                        cmd.Parameters.Add(new SqlParameter("@login", pracownik.Login));
                        cmd.Parameters.Add(new SqlParameter("@haslo", pracownik.Haslo));
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();

                        string query1 = "INSERT INTO Konta( Przywileje, Login, Haslo)VALUES ( @stanowisko, @login, @haslo);";
                        SqlCommand cmd1 = new SqlCommand(query1, con);
                        cmd1.Parameters.Add(new SqlParameter("@stanowisko", stanowiskoCB.Text));
                        cmd1.Parameters.Add(new SqlParameter("@login", pracownik.Login));
                        cmd1.Parameters.Add(new SqlParameter("@haslo", pracownik.Haslo));
                        cmd1.CommandType = CommandType.Text;
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Dodano użytkownika");
                    }
                    else
                    {
                        pracownik.IdPrzywilej = 2;
                        string query = "INSERT INTO Recepcja( IdPrzywileje, Imie, Nazwisko, Login, Haslo)VALUES (@id, @imie,@nazwisko, @login, @haslo);";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@id", pracownik.IdPrzywilej));
                        cmd.Parameters.Add(new SqlParameter("@imie", pracownik.Imie));
                        cmd.Parameters.Add(new SqlParameter("@nazwisko", pracownik.Nazwisko));
                        cmd.Parameters.Add(new SqlParameter("@login", pracownik.Login));
                        cmd.Parameters.Add(new SqlParameter("@haslo", pracownik.Haslo));
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();

                        string query1 = "INSERT INTO Konta( Przywileje, Login, Haslo)VALUES ( @stanowisko, @login, @haslo);";
                        SqlCommand cmd1 = new SqlCommand(query1, con);
                        cmd1.Parameters.Add(new SqlParameter("@stanowisko", stanowiskoCB.Text));
                        cmd1.Parameters.Add(new SqlParameter("@login", pracownik.Login));
                        cmd1.Parameters.Add(new SqlParameter("@haslo", pracownik.Haslo));
                        cmd1.CommandType = CommandType.Text;
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Dodano użytkownika");
                    }

                    con.Close();   
                }
             }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadDataBtn_Click(object sender, RoutedEventArgs e)
        {
            var connectionString = @"Data Source=RAFAL-PC;initial catalog=FITNES;integrated security=True";
            using (var con = new SqlConnection(connectionString))
            {

                if (adminRB.IsChecked == true)
                {
                    con.Open();
                    string query = "select Login from Administrator";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        kontoCB.Items.Add(dr["Login"].ToString());
                    }
                    con.Close();
                    
                }
                else if (trenerRB.IsChecked == true)
                {
                    con.Open();
                    string query = "select * from Trener";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        kontoCB.Items.Add(dr["Login"].ToString());
                    }
                    con.Close();
                }
                else if (recepcjaRB.IsChecked == true)
                {
                    con.Open();
                    string query = "select * from Recepcja";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        kontoCB.Items.Add(dr["Login"].ToString());
                    }
                    con.Close();
                }
                

                
            }
        }

        private void changeDataBTN_Click(object sender, RoutedEventArgs e)
        {
            Pracownik pracownik = new Pracownik();
            try
            {
                var connectionString = @"Data Source=RAFAL-PC;initial catalog=FITNES;integrated security=True";
                using (var con = new SqlConnection(connectionString))
                {
                    pracownik.Login = kontoCB.Text;
                    string baza;
                    if (adminRB.IsChecked == true)
                    {
                        baza = "Administrator";
                    }
                    else if (trenerRB.IsChecked == true)
                    {
                        baza = "Trener";
                    }
                    else if (recepcjaRB.IsChecked == true)
                    {
                        baza = "Recepcja";
                    }
                    DataTable dt = new DataTable();
                    //con.Open();
                    //SqlDataReader myReader = null;
                    //SqlCommand myCommand = new SqlCommand("");
                    string query = "Select Imie, Nazwisko, Login, Haslo from @baza Where Login = @login";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.Parameters.Add(new SqlParameter("@baza", baza));
                    cmd.Parameters.Add(new SqlParameter("@login", kontoCB.Text));
                    // dowiedzieć się jak dane wrzucić do textbox z bazy
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
