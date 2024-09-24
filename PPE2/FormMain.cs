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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        

        private void Bouton_Toutvoir_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormConnexion frmnc = new FormConnexion();
            frmnc.ShowDialog();
        }

        private void Bouton_Ordinateur_Click(object sender, EventArgs e)
        {
            Form Form3 = new Form3();
            Form3.Show();
        }
    }
}
