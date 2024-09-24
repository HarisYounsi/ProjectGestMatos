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
using DocumentFormat.OpenXml.Office2010.Excel;

namespace PPE2
{
    public partial class Form3 : Form
    {
        private ListViewColumnSorter lvwColumnSorter;
        public SqlConnection cnSQL;
        public SqlCommand cmSQL;
        public SqlDataReader drSQL;
        public string SQL;
        public string SQLrecherche;
        public string connectionString = @"Server=.\SQLEXPRESS;Initial Catalog=PPE2SQL ;integrated security = SSPI";
       

        public Form3()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter;
        }

        public void ListeMateriel()
        {
            
            try
            {
                cnSQL = new SqlConnection(connectionString);
                cnSQL.Open();
                SQL = "SELECT Materiel.ID_Materiel as IDMat, Materiel.Nom_Materiel as NomMat, Materiel.Description_Materiel as DesMat, Materiel.MTBF_Materiel as MTBFMat, Type.Nom_Type as NomType FROM Materiel join Type on Materiel.ID_Type = Type.ID_Type";
                cmSQL = new SqlCommand(SQL, cnSQL);
                drSQL = cmSQL.ExecuteReader();


                while (drSQL.Read())
                {

                    ListViewItem Materiel = new ListViewItem(new[] { drSQL["IDMat"].ToString(), drSQL["NomMat"].ToString(), drSQL["DesMat"].ToString(), drSQL["MTBFMat"].ToString(), drSQL["NomType"].ToString() });
                    listView1.Items.Add(Materiel);

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

        private void Form3_Load(object sender, EventArgs e)
        {
            ListeMateriel();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

            


            try
            {
                cnSQL = new SqlConnection(connectionString);
                cnSQL.Open();
                SQL = "SELECT Materiel.ID_Materiel as IDMat, Materiel.Nom_Materiel as NomMat," +
                                " Materiel.Description_Materiel as DesMat, Materiel.MTBF_Materiel as MTBFMat," +
                                " Type.Nom_Type as NomType FROM Materiel join Type on Materiel.ID_Type = Type.ID_Type" +
                                " where Materiel.Nom_Materiel like '" + textBox1.Text + "%'"; 
                
                cmSQL = new SqlCommand(SQL, cnSQL);
                drSQL = cmSQL.ExecuteReader();
                listView1.Items.Clear();

                while (drSQL.Read())
                {

                    ListViewItem Materiel = new ListViewItem(new[] { drSQL["IDMat"].ToString(), drSQL["NomMat"].ToString(), drSQL["DesMat"].ToString(), drSQL["MTBFMat"].ToString(), drSQL["NomType"].ToString() });
                    listView1.Items.Add(Materiel);

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

        private void recherche_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Form Ajouter = new AjouterMat();
            Ajouter.Show();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order != System.Windows.Forms.SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
                }
                else
                {
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Descending;
                }
            }

            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Descending;
            }

            // Perform the sort with these new sort options.
            this.listView1.Sort();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Veuillez selectionner une ligne !!", "warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

 

            {
                Close();
                Form3 Form3 = new Form3();
                Form3.Show();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (listView1.SelectedItems.Count != 1)
                {
                    MessageBox.Show("Veuillez selectionner une ligne !!", "warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                ListViewItem id = listView1.SelectedItems[0];
                ModifierMat modifier = new ModifierMat();
                modifier.idrech = listView1.SelectedItems[0].Text;
                modifier.Show();

            }
        }
    }
}
