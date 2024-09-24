
namespace PPE2
{
    partial class AjouterMat
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
            this.tBdescp = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.TbMTBF = new System.Windows.Forms.TextBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.Label();
            this.MTBF = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.cbSite = new System.Windows.Forms.ComboBox();
            this.Site = new System.Windows.Forms.Label();
            this.Client = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.Reset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tBdescp
            // 
            this.tBdescp.Location = new System.Drawing.Point(581, 85);
            this.tBdescp.Margin = new System.Windows.Forms.Padding(4);
            this.tBdescp.Multiline = true;
            this.tBdescp.Name = "tBdescp";
            this.tBdescp.Size = new System.Drawing.Size(296, 358);
            this.tBdescp.TabIndex = 1;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(183, 213);
            this.cbType.Margin = new System.Windows.Forms.Padding(4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(245, 24);
            this.cbType.TabIndex = 2;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TbMTBF
            // 
            this.TbMTBF.Location = new System.Drawing.Point(183, 383);
            this.TbMTBF.Margin = new System.Windows.Forms.Padding(4);
            this.TbMTBF.Name = "TbMTBF";
            this.TbMTBF.Size = new System.Drawing.Size(245, 22);
            this.TbMTBF.TabIndex = 3;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(581, 470);
            this.Ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(143, 55);
            this.Ajouter.TabIndex = 4;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(180, 184);
            this.Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(39, 16);
            this.Type.TabIndex = 6;
            this.Type.Text = "Type";
            // 
            // MTBF
            // 
            this.MTBF.AutoSize = true;
            this.MTBF.Location = new System.Drawing.Point(183, 350);
            this.MTBF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MTBF.Name = "MTBF";
            this.MTBF.Size = new System.Drawing.Size(44, 16);
            this.MTBF.TabIndex = 7;
            this.MTBF.Text = "MTBF";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(581, 62);
            this.Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(75, 16);
            this.Description.TabIndex = 8;
            this.Description.Text = "Description";
            // 
            // cbSite
            // 
            this.cbSite.FormattingEnabled = true;
            this.cbSite.Location = new System.Drawing.Point(183, 304);
            this.cbSite.Name = "cbSite";
            this.cbSite.Size = new System.Drawing.Size(245, 24);
            this.cbSite.TabIndex = 10;
            // 
            // Site
            // 
            this.Site.AutoSize = true;
            this.Site.Location = new System.Drawing.Point(183, 273);
            this.Site.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Site.Name = "Site";
            this.Site.Size = new System.Drawing.Size(30, 16);
            this.Site.TabIndex = 11;
            this.Site.Text = "Site";
            // 
            // Client
            // 
            this.Client.AutoSize = true;
            this.Client.Location = new System.Drawing.Point(183, 85);
            this.Client.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(40, 16);
            this.Client.TabIndex = 12;
            this.Client.Text = "Client";
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(183, 121);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(245, 24);
            this.cbClient.TabIndex = 13;
            this.cbClient.Validating += new System.ComponentModel.CancelEventHandler(this.cbClient_Validating);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(756, 470);
            this.Reset.Margin = new System.Windows.Forms.Padding(4);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(143, 55);
            this.Reset.TabIndex = 14;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AjouterMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.Site);
            this.Controls.Add(this.cbSite);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.MTBF);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.TbMTBF);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tBdescp);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AjouterMat";
            this.Text = "AjouterMat";
            this.Load += new System.EventHandler(this.AjouterMat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBdescp;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox TbMTBF;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label MTBF;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.ComboBox cbSite;
        private System.Windows.Forms.Label Site;
        private System.Windows.Forms.Label Client;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}