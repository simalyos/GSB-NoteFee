using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NoteFee_GSB
{
    public partial class AddUser : Form
    {
        private string connectionString = "Data Source=DESKTOP-TO2JDQ3\\SQLEXPRESS;Initial Catalog=notefee_gsb;Integrated Security=True;";

        public AddUser()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Chaîne de connexion à la base de données
            using (SqlConnection conn = new SqlConnection(connectionString))

            // Créer une commande SQL d'insertion
            conn.Open();

            string query = "INSERT INTO users (username, password, email) VALUES (@username, @password, @email)";
            SqlCommand command = new SqlCommand(query);

            // Ajouter des paramètres à la commande SQL
            command.Parameters.AddWithValue("@username", "test");
            command.Parameters.AddWithValue("@password", "test");
            command.Parameters.AddWithValue("@email", "johndoe@example.com");

            // Créer une connexion à la base de données et exécuter la commande SQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'notefee_gsbDataSet2.users'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.usersTableAdapter.Fill(this.notefee_gsbDataSet2.users);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
