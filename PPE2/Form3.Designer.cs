
namespace PPE2
{
    partial class Form3
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MTBF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Listemat = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.recherche = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nom,
            this.Description,
            this.MTBF,
            this.Type});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 97);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(760, 328);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 46;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 123;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 222;
            // 
            // MTBF
            // 
            this.MTBF.Text = "MTBF";
            this.MTBF.Width = 125;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 120;
            // 
            // Listemat
            // 
            this.Listemat.AutoSize = true;
            this.Listemat.Location = new System.Drawing.Point(13, 78);
            this.Listemat.Name = "Listemat";
            this.Listemat.Size = new System.Drawing.Size(69, 13);
            this.Listemat.TabIndex = 1;
            this.Listemat.Text = "Liste Materiel";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(494, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(715, 72);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(75, 19);
            this.recherche.TabIndex = 3;
            this.recherche.Text = "Recherche";
            this.recherche.UseVisualStyleBackColor = true;
            this.recherche.Click += new System.EventHandler(this.recherche_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(16, 27);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(145, 32);
            this.Ajouter.TabIndex = 4;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(201, 27);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(145, 32);
            this.Supprimer.TabIndex = 14;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(392, 27);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(145, 32);
            this.Modifier.TabIndex = 15;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Listemat);
            this.Controls.Add(this.listView1);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader MTBF;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.Label Listemat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button recherche;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Modifier;
    }
}