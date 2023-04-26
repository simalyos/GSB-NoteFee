using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteFee_GSB
{
    public partial class History : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            // Charger l'image en arrière-plan
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Charger l'image à partir du disque dur
            //Image backgroundImage = Image.FromFile("chemin/de/l'image");

            // Ajouter l'image à la liste des résultats
           // e.Result = backgroundImage;
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Afficher l'image de fond dans le contrôle parent
            //this.BackgroundImage = (Image)e.Result;
        }
        public History()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            // Rendre la navigation entre les onglets plus fluide
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }

        private void History_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'notefee_gsbDataSet1.notes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.notesTableAdapter.Fill(this.notefee_gsbDataSet1.notes);


        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.notesTableAdapter.FillBy1(this.notefee_gsbDataSet1.notes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.notesTableAdapter.FillBy(this.notefee_gsbDataSet1.notes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Exécuter la requête de sélection et remplir à nouveau le DataSet
            // Remplacer 'yourDataAdapter' par le nom de votre DataAdapter et 'yourDataSet' par le nom de votre DataSet
            this.notesTableAdapter.Fill(this.notefee_gsbDataSet1.notes);

            // Actualiser les données dans le DataGridView
            notesBindingSource.ResetBindings(false);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
