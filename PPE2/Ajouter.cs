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
using System.Data.Common;

namespace PPE2
{
    public partial class AjouterInt : Form
    {
        public SqlConnection cnSQL;
        public SqlCommand cmSQL;
        public SqlDataReader drSQL;
        public string SQL;
        public string connectionString = @"Server=.\SQLEXPRESS;Initial Catalog=PPE2SQL ;integrated security = SSPI";
        public AjouterInt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Ajouter_Load(object sender, EventArgs e)
        {
            try
            {
                cnSQL = new SqlConnection(connectionString);
                cnSQL.Open();
                SQL = "SELECT Nom_Materiel FROM Materiel";
                cmSQL = new SqlCommand(SQL, cnSQL);
                drSQL = cmSQL.ExecuteReader();


                while (drSQL.Read())
                {
                    comboBox1.Items.Add(drSQL["Nom_Materiel"].ToString());
                }


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
                drSQL.Close();
                cnSQL.Close();
                cmSQL.Dispose();
                cnSQL.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cnSQL = new SqlConnection(connectionString);
                cnSQL.Open();


                string SQL3 = "SELECT ID_Materiel FROM Materiel WHERE Nom_Materiel = '" + comboBox1.Text + "'";
                SqlCommand cmSQL3 = new SqlCommand(SQL3, cnSQL);
                SqlDataReader result = cmSQL3.ExecuteReader();
                result.Read();
                string idmat = result["ID_Materiel"].ToString();
                result.Close();




                string SQL2 = "INSERT INTO Intervention (ID_Materiel , Date , Commentaire) VALUES " +
                        "('" + idmat + "','" + Convert.ToDateTime(dateTimePicker1.Text) + "','" + textBox4.Text + "')";
                SqlCommand cmSQL2 = new SqlCommand(SQL2, cnSQL);
                cmSQL2.ExecuteNonQuery();

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
                Close();
                Form2 Form2 = new Form2();
                Form2.Show();
            }
        }
    }
    }

