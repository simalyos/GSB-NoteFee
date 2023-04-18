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
            //comboBox1.SelectedIndex = 2;
        }

        public static class Session
        {
            public static string LoggedInUser { get; set; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string username = textBoxUsername.Text;
            //string passwd = textBoxPassword.Text;
            //tring selectedType = comboBox1.SelectedItem.ToString();
            // Authentification de l'utilisateur
           // string loggedInUser = comboBox1.SelectedItem.ToString();
            //Session.LoggedInUser = loggedInUser;

            
            SqlConnection connection = new SqlConnection(connectionString);
            {
                string username = textBoxUsername.Text;
                string passwd = textBoxPassword.Text;

                //SqlConnection connection = new SqlConnection(connectionString);

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
                        LoggedInUsername = username;

                        if (Role == "admin")
                        {
                            // Utilisateur authentifié en tant qu'Admin, ouvrir l'application principale
                            Home mainForm = new Home();
                            mainForm.Show();
                            this.Hide();
                        }
                        else if (Role == "utilisateur")
                        {
                            // Utilisateur authentifié en tant qu'Utilisateur, ouvrir l'application principale
                            Home mainForm = new Home();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Afficher un message d'erreur
                            MessageBox.Show("Rôle non reconnu.");
                        }

                        // Utilisateur authentifié, ouvrir l'application principale
                        //Home mainForm = new Home();
                        //mainForm.Show();
                        //this.Hide();
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
            //string userType = comboBox1.SelectedItem.ToString(); // récupérer le type d'utilisateur sélectionné dans la liste déroulante
            /*{
                connection.Open();

                string query = "SELECT users.id, roles.role_name FROM users INNER JOIN roles ON users.role_id = roles.id WHERE username=@username AND passwd=@passwd";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@passwd", passwd);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    idUtilisateur = reader.GetInt32(0);
                    Role = reader.GetString(1);

                    // Utilisateur authentifié, ouvrir l'application principale
                    Home mainForm = new Home();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    // Afficher un message d'erreur
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
                }
            }*/
            /*try
            {
                connection.Open();

                string query = "";

                if (Login.userType == "admin")
                {
                    query = "SELECT COUNT(*) FROM users WHERE username=@username AND passwd=@passwd";
                }
                else
                {
                    query = "SELECT COUNT(*) FROM users WHERE username=@username AND passwd=@passwd";
                }

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@passwd", passwd);
                idUtilisateur = Convert.ToInt32(command.ExecuteScalar());

                int count = (int)command.ExecuteScalar();

                if (count == 1)
                {
                    if (selectedType == "admin")
                    //if (!string.IsNullOrEmpty(userType))
                    {
                        utilisateur = textBoxUsername.Text;
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                        // Rediriger vers l'onglet de administration des utilisateurs pour les admins
                        //UserList AddUserForm = new UserList();
                        //AddUserForm.Show();
                        //this.Hide();
                    }
                    else if (selectedType == "utilisateur")
                    {

                        utilisateur = textBoxUsername.Text;
                        
                        // Rediriger vers la page d'accueil pour les utilisateurs
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                }
                else
                {
                    // Afficher un message d'erreur
                    MessageBox.Show("Nom d'utilisateur, mot de passe ou type d'utilisateur incorrect.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }*/
        }

            /*SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Siméon ALYOSHEV\\Documents\\notefee.mdf; Integrated Security = True; Connect Timeout = 30");
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username=@username AND passwd=@passwd";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@passwd", passwd);
                int count = (int)command.ExecuteScalar();
                if (count == 1)
                {
                    // Utilisateur authentifié, ouvrir l'application principale
                    Home mainForm = new Home();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    // Afficher un message d'erreur
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
                }
            } */

            /*
             //Test de la connexion
            try
            {
                connection.Open();
                MessageBox.Show("Connexion réussie !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
           */

        

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
