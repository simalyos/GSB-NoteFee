using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;

namespace NoteFee_GSB
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Home : Form
    {
        //private string selectedType = Login.SelectedType;
        //private string loggedInUser = LoggedInUsername;
        private string Role = Login.Role;
        private object notefee_gsbDataSet8;

        public Home()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            // Rendre la navigation entre les onglets plus fluide
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            UpdateWelcomeLabel();

        // Disponibilité de bouton Gestion des utilisateurs uniquement si le role de l'utilisateur est de type admin,
        // Le role est recuperer depuis la classe Login à l'aide de la requete executer lors de la connexion
            if (Role == "admin")
            {
                adminToolStripMenuItem.Visible = true;
            }
            else
            {
                adminToolStripMenuItem.Visible = false;
            }

        }


        private void Home_Load(object sender, EventArgs e)
        {

        }

        //Texte de bienvenue d'utilisateur
        private void UpdateWelcomeLabel()
        {
            label3.Text = "Bienvenue dans NoteFee " + Login.LoggedInUsername;
            label3.ForeColor = Color.RoyalBlue; // Changer la couleur du texte ici
            label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size); // Changer le style du texte ici
        }

        //Bouton Ajouter une note de frais
        private void ajouterUneNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote addNoteForm = new AddNote(); // Créer une instance de la deuxième forme
            addNoteForm.TopLevel = false; // Indiquer que la deuxième forme n'est pas une fenêtre de niveau supérieur
            addNoteForm.AutoScroll = true; // Permettre le défilement automatique si la deuxième forme est plus grande que le Panel
            this.panel1.Controls.Add(addNoteForm); // Ajouter la deuxième forme au Panel
            addNoteForm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(addNoteForm);
            addNoteForm.Dock = DockStyle.Fill;
            addNoteForm.BringToFront();
            addNoteForm.Show(); // Afficher la deuxième forme

        }

        //Bouton Historique

        private void historiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History historyForm = new History(); // Créer une instance de la deuxième forme
            historyForm.TopLevel = false; 
            historyForm.AutoScroll = true; 
            this.panel1.Controls.Add(historyForm); 
            historyForm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(historyForm);
            historyForm.Dock = DockStyle.Fill;
            historyForm.BringToFront();
            historyForm.Show(); 
            /*History historyForm = new History();
            historyForm.Show();
            this.Hide();*/
        }

        //Bouton Envoyer un document
        private void envoyerUnDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendDoc SendDocForm = new SendDoc(); 
            SendDocForm.TopLevel = false; 
            SendDocForm.AutoScroll = true; 
            this.panel1.Controls.Add(SendDocForm); 
            SendDocForm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(SendDocForm);
            SendDocForm.Dock = DockStyle.Fill;
            SendDocForm.BringToFront();
            SendDocForm.Show(); 
            /*SendDoc SendDocForm = new SendDoc();
            SendDocForm.Show();
            this.Hide();*/
            SendDocForm.LoadData();
        }

        //Bouton Deconnexion
        private void decdeconnexionToolStripMenuItem_Click(object obj, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir vous déconnecter ?", "Confirmation de déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Code pour se déconnecter et revenir à la page de connexion
                Login loginPage = new Login();
                loginPage.TopLevel = false; 
                loginPage.AutoScroll = true;
                this.panel1.Controls.Add(loginPage); 
                loginPage.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Add(loginPage);
                loginPage.Dock = DockStyle.Fill;
                loginPage.BringToFront();
                loginPage.Show(); 
                menuStrip1.Visible = false;
                this.statusStrip1.Visible = false;
                //this.Hide(); // Masquer la page actuelle
            }
            else if (result == DialogResult.No)
            {
                // Rien ne se passe, on reste connecté
            }

        }

        //Bouton Gestion des utilisateurs disponible uniquement pour l'administrateur
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserList addUserForm = new UserList();
            addUserForm.TopLevel = false; 
            addUserForm.AutoScroll = true; 
            this.panel1.Controls.Add(addUserForm); 
            addUserForm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(addUserForm);
            addUserForm.Dock = DockStyle.Fill;
            addUserForm.BringToFront();
            addUserForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void utilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}