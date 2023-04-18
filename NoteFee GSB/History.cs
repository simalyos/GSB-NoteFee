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
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'notefee_gsbDataSet1.notes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.notesTableAdapter.Fill(this.notefee_gsbDataSet1.notes);

        }
    }
}
