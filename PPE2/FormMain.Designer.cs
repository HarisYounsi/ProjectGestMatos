
namespace PPE2
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bouton_Ordinateur = new System.Windows.Forms.Button();
            this.Bouton_Toutvoir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // Bouton_Ordinateur
            // 
            this.Bouton_Ordinateur.AutoSize = true;
            this.Bouton_Ordinateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bouton_Ordinateur.Location = new System.Drawing.Point(12, 67);
            this.Bouton_Ordinateur.Name = "Bouton_Ordinateur";
            this.Bouton_Ordinateur.Size = new System.Drawing.Size(852, 313);
            this.Bouton_Ordinateur.TabIndex = 3;
            this.Bouton_Ordinateur.Text = "Liste Materiel";
            this.Bouton_Ordinateur.UseVisualStyleBackColor = true;
            this.Bouton_Ordinateur.Click += new System.EventHandler(this.Bouton_Ordinateur_Click);
            // 
            // Bouton_Toutvoir
            // 
            this.Bouton_Toutvoir.AutoSize = true;
            this.Bouton_Toutvoir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bouton_Toutvoir.Location = new System.Drawing.Point(12, 386);
            this.Bouton_Toutvoir.Name = "Bouton_Toutvoir";
            this.Bouton_Toutvoir.Size = new System.Drawing.Size(852, 295);
            this.Bouton_Toutvoir.TabIndex = 4;
            this.Bouton_Toutvoir.Text = "Voir Toutes les Interventions";
            this.Bouton_Toutvoir.UseVisualStyleBackColor = true;
            this.Bouton_Toutvoir.Click += new System.EventHandler(this.Bouton_Toutvoir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Les Matériels";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(876, 693);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bouton_Toutvoir);
            this.Controls.Add(this.Bouton_Ordinateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion 
        private System.Windows.Forms.Button Bouton_Ordinateur;
        private System.Windows.Forms.Button Bouton_Toutvoir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

