using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NoteFee_GSB
{
    public partial class AddNote : Form
    {
        
        private string connectionString = "Data Source=DESKTOP-TO2JDQ3\\SQLEXPRESS;Initial Catalog=notefee_gsb;Integrated Security=True;";
        private string loggedInUser;

        public AddNote()
        {
            InitializeComponent();
            
            // Récupérer l'id de l'utilisateur connecté
            int idUtilisateur = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT id_user FROM users WHERE username = @username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", Login.LoggedInUsername);
                idUtilisateur = Convert.ToInt32(cmd.ExecuteScalar());
                textBox1.Text = idUtilisateur.ToString();
            }

            //this.loggedInUser = username;

            // Afficher l'idUtilisateur dans la TextBox1
            //textBox1.Text = idUtilisateur.ToString();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Mettre à jour le champ de texte avec le chemin du fichier sélectionné
                textBox6.Text = openFileDialog.FileName;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                // Vérifier que le fichier est sélectionné
                if (textBox6.Text == "")
                {
                    MessageBox.Show("Veuillez sélectionner un fichier à envoyer.");
                    return;
                }

                // Créer le dossier "Documents" s'il n'existe pas
                string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string sendFolder = Path.Combine(documentsFolder, "Justificatif fourni");
                if (!Directory.Exists(sendFolder))
                {
                    Directory.CreateDirectory(sendFolder);
                }

                // Copier le fichier dans le dossier "SendFolder"
                string fileName = Path.GetFileName(textBox6.Text);
                string filePath = Path.Combine(sendFolder, fileName);
                //File.Copy(textBox1.Text, filePath);
                if (File.Exists(filePath))
                {
                    var result = MessageBox.Show("Le fichier existe déjà dans le dossier. Voulez-vous le remplacer ?", "Fichier existant", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        File.Delete(filePath);
                        File.Copy(textBox6.Text, filePath);
                    }
                }
                else
                {
                    File.Copy(textBox6.Text, filePath);
                }

                if (!string.IsNullOrEmpty(Login.LoggedInUsername))
                {
                    int idUtilisateur = 0;
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = "SELECT id_user FROM users WHERE username = @username";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", Login.LoggedInUsername);
                        idUtilisateur = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    string titre = textBox2.Text;
                    string description = textBox3.Text;
                    string montant = textBox4.Text;
                    string commentaire = textBox5.Text;
                    string date = DateTime.Now.ToString("yyyy-MM-dd");


                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = "INSERT INTO notes (nt_id_user, name, description, date, amount, comment, doc_name) VALUES (@nt_id_user, @name, @description, @date, @amount, @comment, @doc_name)";
                        SqlCommand command = new SqlCommand(query, conn);
                        //command.Parameters.AddWithValue("@id_note", idNote);
                        command.Parameters.AddWithValue("@nt_id_user", idUtilisateur);
                        command.Parameters.AddWithValue("@name", titre);
                        command.Parameters.AddWithValue("@description", description);
                        //command.Parameters.AddWithValue("@date", dateNote);
                        command.Parameters.AddWithValue("@amount", montant);
                        command.Parameters.AddWithValue("@comment", commentaire);
                        command.Parameters.AddWithValue("@doc_name", filePath);
                        command.Parameters.AddWithValue("@date", date);
                        //command.ExecuteNonQuery();

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("La note de frais et le fichier ont été envoyés avec succès. Vous recevrez un mail lorsque elle sera traitée.");
                        }
                        else
                        {
                            MessageBox.Show("Aucune ligne n'a été affectée. Veuillez vérifier votre requête SQL et les paramètres.");
                        }
                        //MessageBox.Show("La note de frais et le fichier ont été envoyer avec succès. Vous receverez un mail lorsque elle sera traité. ");
                    }
                    // Afficher un message de confirmation
                   
                }
                //string id_note = "SELECT id_note FROM notes";
                
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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
