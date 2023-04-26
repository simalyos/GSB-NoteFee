using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace NoteFee_GSB
{
    public partial class Login : Form
    {
        public static int idUtilisateur;

        //public string Role { get; private set; }
        public static string Role { get; private set; }
        public static string LoggedInUsername { get; private set; }
        public static string utilisateur;
        public static string userType;
        private string connectionString = "Data Source=DESKTOP-TO2JDQ3\\SQLEXPRESS;Initial Catalog=notefee_gsb;Integrated Security=True;";
        //private string selectedType;

        public static string SelectedType { get; internal set; }

        public Login()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            //comboBox1.SelectedIndex = 2;
        }

        public static class Session
        {
            public static string LoggedInUser { get; set; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection(connectionString);
            {
                string username = textBoxUsername.Text;
                string passwd = textBoxPassword.Text;

                try
                {
                    connection.Open();

                    string query = "SELECT users.id_user, roles.role_name FROM users INNER JOIN roles ON users.role_id = roles.id WHERE username=@username AND passwd=@passwd";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@passwd", passwd);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        idUtilisateur = reader.GetInt32(0);
                        Role = reader.GetString(1);
                        Console.WriteLine(Role);
                        LoggedInUsername = username;

                        ShowHome();
                    }
                    else
                    {
                        // Afficher un message d'erreur
                        MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

        }

        private void ShowHome()
        {
            Home mainForm = new Home();
            mainForm.TopLevel = false;
            mainForm.Dock = DockStyle.Fill;

            if (Role == "admin")
            {
                mainForm.FormBorderStyle = FormBorderStyle.None;
            }
            else if (Role == "utilisateur")
            {
                mainForm.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                MessageBox.Show("Rôle non reconnu.");
                return;
            }

            panel1.Controls.Clear();
            panel1.Controls.Add(mainForm);
            mainForm.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'notefee_gsbDataSet7.roles'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.rolesTableAdapter.Fill(this.notefee_gsbDataSet7.roles);

        }
    }

}
