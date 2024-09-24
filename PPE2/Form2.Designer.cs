
namespace PPE2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.pPE2SQLDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pPE2SQLDataSet = new PPE2.PPE2SQLDataSet();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Commentaire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SiteNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MTBF = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Description = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.recherche = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pPE2SQLDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE2SQLDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pPE2SQLDataSetBindingSource
            // 
            this.pPE2SQLDataSetBindingSource.DataSource = this.pPE2SQLDataSet;
            this.pPE2SQLDataSetBindingSource.Position = 0;
            // 
            // pPE2SQLDataSet
            // 
            this.pPE2SQLDataSet.DataSetName = "PPE2SQLDataSet";
            this.pPE2SQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nom,
            this.Date,
            this.ClientNom,
            this.Commentaire,
            this.SiteNom});
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(44, 227);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1556, 374);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.recupererDonées);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 200;
            // 
            // Date
            // 
            this.Date.Text = "Date Intervention";
            this.Date.Width = 500;
            // 
            // ClientNom
            // 
            this.ClientNom.Tag = "";
            this.ClientNom.Text = "Nom Client";
            this.ClientNom.Width = 192;
            // 
            // Commentaire
            // 
            this.Commentaire.Text = "Commentaire";
            this.Commentaire.Width = 91;
            // 
            // SiteNom
            // 
            this.SiteNom.Text = "Nom Site";
            this.SiteNom.Width = 132;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(593, 756);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(485, 36);
            this.listBox1.TabIndex = 3;
            // 
            // MTBF
            // 
            this.MTBF.AutoSize = true;
            this.MTBF.Location = new System.Drawing.Point(589, 718);
            this.MTBF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MTBF.Name = "MTBF";
            this.MTBF.Size = new System.Drawing.Size(45, 17);
            this.MTBF.TabIndex = 4;
            this.MTBF.Text = "MTBF";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(64, 756);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(485, 84);
            this.listBox2.TabIndex = 5;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(60, 718);
            this.Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(79, 17);
            this.Description.TabIndex = 8;
            this.Description.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1178, 155);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(1510, 155);
            this.recherche.Margin = new System.Windows.Forms.Padding(4);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(100, 23);
            this.recherche.TabIndex = 10;
            this.recherche.Text = "recherche";
            this.recherche.UseVisualStyleBackColor = true;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(64, 69);
            this.Ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(208, 64);
            this.Ajouter.TabIndex = 11;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(352, 69);
            this.Modifier.Margin = new System.Windows.Forms.Padding(4);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(197, 64);
            this.Modifier.TabIndex = 12;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.button3_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(633, 69);
            this.Supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(179, 64);
            this.Supprimer.TabIndex = 13;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1712, 971);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.MTBF);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pPE2SQLDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE2SQLDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource pPE2SQLDataSetBindingSource;
        private PPE2SQLDataSet pPE2SQLDataSet;
        public System.Windows.Forms.ColumnHeader Nom;
        public System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader ClientNom;
        private System.Windows.Forms.ColumnHeader Commentaire;
        private System.Windows.Forms.ColumnHeader SiteNom;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Label MTBF;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button recherche;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        public System.Windows.Forms.ListView listView1;
    }
}