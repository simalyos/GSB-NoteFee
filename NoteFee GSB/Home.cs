using System;
using System.Windows.Controls;
using System.Windows.Forms;

namespace NoteFee_GSB
{
    public partial class Home : Form
    {
        //private string selectedType = Login.SelectedType;
        //private string loggedInUser = LoggedInUsername;
        private string Role = Login.Role;
        private object notefee_gsbDataSet8;

        public Home()
        {
            InitializeComponent();
            
            if (Role == "admin")
            {
                adminToolStripMenuItem.Visible = true;
            } else
            {
                adminToolStripMenuItem.Visible = false;
            }



            //label3.Text = "Bienvenue dans NoteFee " + Login.utilisateur;
        }


        private void Home_Load(object sender, EventArgs e)
        {
            // Afficher le nom d'utilisateur dans le label de bienvenue
            label3.Text = "Bienvenue dans NoteFee " + Login.LoggedInUsername;
        }


    

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
            /*AddNote addNoteForm = new AddNote();

            // Afficher le formulaire "AddNote" en tant que fenêtre non modale
            addNoteForm.Show();
            this.Hide(); */
        }

        private void historiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History historyForm = new History(); // Créer une instance de la deuxième forme
            historyForm.TopLevel = false; // Indiquer que la deuxième forme n'est pas une fenêtre de niveau supérieur
            historyForm.AutoScroll = true; // Permettre le défilement automatique si la deuxième forme est plus grande que le Panel
            this.panel1.Controls.Add(historyForm); // Ajouter la deuxième forme au Panel
            historyForm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(historyForm);
            historyForm.Dock = DockStyle.Fill;
            historyForm.BringToFront();
            historyForm.Show(); // Afficher la deuxième forme
            /*History historyForm = new History();

            historyForm.Show();
            this.Hide();*/
        }

        private void envoyerUnDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendDoc SendDocForm = new SendDoc(); // Créer une instance de la deuxième forme
            SendDocForm.TopLevel = false; // Indiquer que la deuxième forme n'est pas une fenêtre de niveau supérieur
            SendDocForm.AutoScroll = true; // Permettre le défilement automatique si la deuxième forme est plus grande que le Panel
            this.panel1.Controls.Add(SendDocForm); // Ajouter la deuxième forme au Panel
            SendDocForm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(SendDocForm);
            SendDocForm.Dock = DockStyle.Fill;
            SendDocForm.BringToFront();
            SendDocForm.Show(); // Afficher la deuxième forme
            /*SendDoc SendDocForm = new SendDoc();

            SendDocForm.Show();
            this.Hide();*/
            SendDocForm.LoadData();
        }


        private void decdeconnexionToolStripMenuItem_Click(object obj, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir vous déconnecter ?", "Confirmation de déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Code pour se déconnecter et revenir à la page de connexion
                // ...
                // Par exemple, revenir à la page de connexion :
                Login loginPage = new Login();
                loginPage.TopLevel = false; // Indiquer que la deuxième forme n'est pas une fenêtre de niveau supérieur
                loginPage.AutoScroll = true; // Permettre le défilement automatique si la deuxième forme est plus grande que le Panel
                this.panel1.Controls.Add(loginPage); // Ajouter la deuxième forme au Panel
                loginPage.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Add(loginPage);
                loginPage.Dock = DockStyle.Fill;
                loginPage.BringToFront();
                loginPage.Show(); // Afficher la deuxième forme
                //this.Hide(); // Masquer la page actuelle
            }
            else if (result == DialogResult.No)
            {
                // Rien ne se passe, on reste connecté
            }

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

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UserList addUserForm = new UserList();
            addUserForm.TopLevel = false; // Indiquer que la deuxième forme n'est pas une fenêtre de niveau supérieur
            addUserForm.AutoScroll = true; // Permettre le défilement automatique si la deuxième forme est plus grande que le Panel
            this.panel1.Controls.Add(addUserForm); // Ajouter la deuxième forme au Panel
            addUserForm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(addUserForm);
            addUserForm.Dock = DockStyle.Fill;
            addUserForm.BringToFront();
            addUserForm.Show(); 
            
            /*if (selectedType == "admin")
            {
                UserList AddUserForm = new UserList();
                AddUserForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vous n'avez pas les autorisations nécessaires pour accéder à cette fonctionnalité.");
            }*/
        }

        private void utilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /*private void Home_Load_1(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'notefee_gsbDataSet8.roles'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.rolesTableAdapter.Fill(this.notefee_gsbDataSet8.roles);

        }*/
    }

    /*private void ajouterUneNoteToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
        AddNote addNoteForm = new AddNote();

        // Afficher le formulaire "AddNote" en tant que fenêtre modale
        addNoteForm.ShowDialog();
    }*/

}
