namespace NoteFee_GSB
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envoyerUnDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rolesTableAdapter = new NoteFee_GSB.notefee_gsbDataSet8TableAdapters.rolesTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.ajouterUneNoteToolStripMenuItem,
            this.historiqueToolStripMenuItem,
            this.envoyerUnDocumentToolStripMenuItem,
            this.deconnexionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1430, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.CheckOnClick = true;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(281, 44);
            this.adminToolStripMenuItem.Text = "Gestion des utilisateurs";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // ajouterUneNoteToolStripMenuItem
            // 
            this.ajouterUneNoteToolStripMenuItem.CheckOnClick = true;
            this.ajouterUneNoteToolStripMenuItem.Name = "ajouterUneNoteToolStripMenuItem";
            this.ajouterUneNoteToolStripMenuItem.Size = new System.Drawing.Size(216, 44);
            this.ajouterUneNoteToolStripMenuItem.Text = "Ajouter une note";
            this.ajouterUneNoteToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneNoteToolStripMenuItem_Click);
            // 
            // historiqueToolStripMenuItem
            // 
            this.historiqueToolStripMenuItem.CheckOnClick = true;
            this.historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            this.historiqueToolStripMenuItem.Size = new System.Drawing.Size(144, 44);
            this.historiqueToolStripMenuItem.Text = "Historique";
            this.historiqueToolStripMenuItem.Click += new System.EventHandler(this.historiqueToolStripMenuItem_Click);
            // 
            // envoyerUnDocumentToolStripMenuItem
            // 
            this.envoyerUnDocumentToolStripMenuItem.Name = "envoyerUnDocumentToolStripMenuItem";
            this.envoyerUnDocumentToolStripMenuItem.Size = new System.Drawing.Size(270, 44);
            this.envoyerUnDocumentToolStripMenuItem.Text = "Envoyer un document";
            this.envoyerUnDocumentToolStripMenuItem.Click += new System.EventHandler(this.envoyerUnDocumentToolStripMenuItem_Click);
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(175, 44);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            this.deconnexionToolStripMenuItem.Click += new System.EventHandler(this.decdeconnexionToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::NoteFee_GSB.Properties.Resources._360_F_424309320_UkOxg2z3sq7yXwGnWCO6xBXkRI4byhnI;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1430, 966);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.Home_Load);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(548, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 33);
            this.label3.TabIndex = 45;
            this.label3.Text = "Bienvenue dans NoteFee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(422, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 44;
            this.label2.Click += new System.EventHandler(this.Home_Load);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 905);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Galaxy Swiss Bourdin NoteFee v1.0";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(1049, 899);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(328, 31);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(466, 227);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1430, 1014);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem historiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envoyerUnDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ajouterUneNoteToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private notefee_gsbDataSet8TableAdapters.rolesTableAdapter rolesTableAdapter;
    }
}