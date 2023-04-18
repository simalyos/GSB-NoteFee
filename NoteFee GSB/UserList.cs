using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteFee_GSB
{
    public partial class UserList : Form
    {
        private string connectionString = "Data Source=DESKTOP-TO2JDQ3\\SQLEXPRESS;Initial Catalog=notefee_gsb;Integrated Security=True;";

        public UserList()
        {
            InitializeComponent();
            //LoadData();
        }

        public void LoadData()
        {
            /*{
                // Charger les données à partir de la base de données
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM users", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    dataGridView1.Rows.Clear();
                    while (reader.Read())
                    {
                        int id_user = (int)reader["id_user"];
                        string username = reader["username"].ToString();
                        string passwd = reader["passwd"].ToString();
                        string email = reader["email"].ToString();
                        string fname = reader["fname"].ToString();
                        string lname = reader["lname"].ToString();
                        string city = reader["city"].ToString();
                        string phone = reader["phone"].ToString();
                        dataGridView1.Rows.Add(id_user, username, passwd, email, fname, lname, city, phone);
                    }
                }
            }*/

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'notefee_gsbDataSet6.users'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.usersTableAdapter2.Fill(this.notefee_gsbDataSet6.users);

            // TODO: cette ligne de code charge les données dans la table 'notefee_gsbDataSet4.users'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.usersTableAdapter1.Fill(this.notefee_gsbDataSet4.users);
            // TODO: cette ligne de code charge les données dans la table 'notefee_gsbDataSet3.users'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.usersTableAdapter.Fill(this.notefee_gsbDataSet3.users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Chaîne de connexion à la base de données
            string connectionString = "Data Source=DESKTOP-TO2JDQ3\\SQLEXPRESS;Initial Catalog=notefee_gsb;Integrated Security=True;";


            string username = textBox1.Text;
            string fname = textBox2.Text;
            string lname = textBox3.Text;
            string passwd = textBox4.Text;
            string email = textBox5.Text;
            string city = textBox6.Text;
            string phone = textBox7.Text;
            //string role = comboBox1.Text;
            // Créer une commande SQL d'insertion
            string insertQuery = "INSERT INTO users (username, passwd, email, fname, lname,phone, city) VALUES (@username, @passwd, @email, @fname, @lname, @phone, @city)";
            SqlCommand command = new SqlCommand(insertQuery);

            // Ajouter des paramètres à la commande SQL
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@passwd", passwd);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@fname", fname);
            command.Parameters.AddWithValue("@lname", lname);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@city", city);
            //command.Parameters.AddWithValue("@roles", role);


            // Créer une connexion à la base de données et exécuter la commande SQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("L'utilisateur a été ajouté avec succès.");
                    }
                    else
                    {
                        MessageBox.Show("Aucune ligne n'a été affectée. Veuillez vérifier votre requête SQL et les paramètres.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de l'exécution de la requête: " + ex.Message);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int id_user = Convert.ToInt32(row.Cells["id_user"].Value);
                string username = row.Cells["username"].Value.ToString();
                string passwd = row.Cells["passwd"].Value.ToString();
                string email = row.Cells["email"].Value.ToString();
                string fname = row.Cells["fname"].Value.ToString();
                string lname = row.Cells["lname"].Value.ToString();
                string city = row.Cells["city"].Value.ToString();
                string phone = row.Cells["phone"].Value.ToString();

                if (button2.Text == "Modifier")
                {
                    // Activer le mode modification
                    button2.Text = "Enregistrer";
                    dataGridView1.ReadOnly = false;
                    dataGridView1.Columns[0].ReadOnly = true; // Empêcher la modification de la première colonne (id_fichier)

                    // Activer la modification pour la ligne sélectionnée

                    row.ReadOnly = false;
                }
                else
                {
                    // Activer le mode enregistrement
                    button2.Text = "Modifier";
                    dataGridView1.ReadOnly = true;

                    // Désactiver la modification pour la ligne sélectionnée
                    row.ReadOnly = true;

                    // Enregistrer les modifications dans la base de données
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE justificatif SET type_fichier = @type_fichier, commentaire = @commentaire, nom_fichier = @nom_fichier, date_fichier = @date_fichier, statut = @statut WHERE id_fichier = @id_fichier";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@passwd", passwd);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@fname", fname);
                        command.Parameters.AddWithValue("@lname", lname);
                        command.Parameters.AddWithValue("@statut", statut);
                        command.ExecuteNonQuery();
                    }

                    // Actualiser la ligne modifiée dans le DataGridView
                    row.Cells["type_fichier"].Value = type_fichier;
                    row.Cells["commentaire"].Value = commentaire;
                    row.Cells["nom_fichier"].Value = nom_fichier;
                    row.Cells["date_fichier"].Value = date_fichier;
                    row.Cells["statut"].Value = statut;

                    MessageBox.Show("Les modifications ont été enregistrées avec succès.");

                }

            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à modifier.");
            }*/
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifier si la touche enfoncée n'est pas un chiffre
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Annuler l'événement pour empêcher l'entrée de caractères non numériques
                e.Handled = true;
            }
        }
    }
    
    
}
