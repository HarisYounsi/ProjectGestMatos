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
    public partial class modifieint : Form
    {
        public string idrech;

        public SqlConnection cnSQL;
        public SqlCommand cmSQL;
        public SqlDataReader drSQL;
        public string SQL;
        public string connectionString = @"Server=.\SQLEXPRESS;Initial Catalog=PPE2SQL ;integrated security = SSPI";
        public modifieint()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void modifieint_Load(object sender, EventArgs e)
        {
            try
            {
              
                cnSQL = new SqlConnection(connectionString);
                cnSQL.Open();
                string sql  = "select * from Intervention where ID_Intervention = " + this.idrech;

                SqlCommand cmsql = new SqlCommand(sql, cnSQL);
                SqlDataReader drsql = cmsql.ExecuteReader();

                while(drsql.Read())
                {
                    textBoxCommentaire.Text = drsql["Commentaire"].ToString();
                    dateTimePicker1.Text = drsql["Date"].ToString();   
                }

                drsql.Close();



                
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cnSQL = new SqlConnection(connectionString);
                cnSQL.Open();


                string SQL = "Update Intervention SET  Date ='" + dateTimePicker1.Value +
                    "', Commentaire = '" + textBoxCommentaire.Text +
                    "' Where ID_Intervention = " + this.idrech;
                SqlCommand cmSQL = new SqlCommand(SQL, cnSQL);
                cmSQL.ExecuteNonQuery();

            }
            catch (SqlException a)
            {
                MessageBox.Show(a.Message, "SQL Error");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "General Error");
            }

            finally
            {
                
                cnSQL.Close();
                cnSQL.Dispose();
            }

            {
                Close();
                Form2 Form2 = new Form2();
                Form2.Show();

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
