using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PPE2

{
    public partial class FormConnexion : Form
    {
        private bool ann = false;

        public FormConnexion()
        {
            InitializeComponent();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            verifCOnnexion();

        }

        private void verifCOnnexion()
        {
            // a supprimer
            this.ann = true;
            this.Close();


            // chef user and password
            SqlConnection cn = null;
            SqlCommand cm = null;
            SqlDataReader dr = null;

            string sqlcon = "Server=.\\SQLEXPRESS;Database=PPE2SQL;Trusted_Connection=True;";

            cn = new SqlConnection(sqlcon);
            cn.Open();

            string strsql = "select count(*) as nb from Utilisateur where Username = '" + textBoxUser.Text +
                "' and Mot_de_passe = '" + textBoxPwd.Text + "'";
            cm = new SqlCommand(strsql, cn);

            dr = cm.ExecuteReader();
            dr.Read();


            int nbok = Convert.ToInt32(dr["nb"].ToString());

            if (nbok > 0)
            {
                this.ann = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Identifiants incorrects", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dr.Close();
            cn.Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.ann = true;
            Application.Exit();
        }

        private void FormConnexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ann == false)
            {
                MessageBox.Show("Veuillez utiliser les boutons appropriés", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUser.Focus();
                e.Cancel = true;
            }

        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {

        }

        private void pictureUsers_Click(object sender, EventArgs e)
        {

        }
    }
}
