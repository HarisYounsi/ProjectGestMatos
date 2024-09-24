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
    public partial class ModifierMat : Form
    {

        public string idrech;

        public SqlConnection cnSQL;
        public SqlCommand cmSQL;
        public SqlDataReader drSQL;
        public string SQL;
        public string connectionString = @"Server=.\SQLEXPRESS;Initial Catalog=PPE2SQL ;integrated security = SSPI";

        public ModifierMat()
        {
            InitializeComponent();
        }

        private void ModifierMat_Load(object sender, EventArgs e)
        {
            try
            {

                cnSQL = new SqlConnection(connectionString);
                cnSQL.Open();

                string SQLtype = "SELECT * FROM Type";
                SqlCommand cmSQLtype = new SqlCommand(SQLtype, cnSQL);
                SqlDataReader drSQLtype = cmSQLtype.ExecuteReader();


                while (drSQLtype.Read())
                {
                    comboBox1.Items.Add(drSQLtype["Nom_Type"].ToString());
                }

                drSQLtype.Close();

                string SQLmat = "select * from Materiel where ID_Materiel = " + this.idrech;

                SqlCommand cmSQLmat = new SqlCommand(SQLmat, cnSQL);
                SqlDataReader drSQLmat = cmSQLmat.ExecuteReader();

                while (drSQLmat.Read())
                {
                    textBox1.Text = drSQLmat["Nom_Materiel"].ToString();
                    textBox3.Text = drSQLmat["Description_Materiel"].ToString();
                    textBox2.Text = drSQLmat["MTBF_Materiel"].ToString();
                }

                drSQLmat.Close();




            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cnSQL = new SqlConnection(connectionString);
                cnSQL.Open();
                string SQL3 = "SELECT ID_Type FROM Type WHERE Nom_Type = '" + comboBox1.Text + "'";
                SqlCommand cmSQL3 = new SqlCommand(SQL3, cnSQL);
                SqlDataReader result = cmSQL3.ExecuteReader();
                result.Read();
                string idtype = result["ID_Type"].ToString();
                result.Close();

                string SQL = "Update Materiel SET Nom_Materiel = '" + textBox1.Text +
                    "', MTBF_Materiel = '" + textBox2.Text +
                    "', Description_Materiel = '" + textBox3.Text +
                    "', ID_Type = '" + idtype +
                    "' Where ID_Materiel = " + this.idrech;
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
                Form3 Form3 = new Form3();
                Form3.Show();

            }
        }
    }
    }

