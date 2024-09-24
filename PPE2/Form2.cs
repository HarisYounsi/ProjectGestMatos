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
    public partial class Form2 : Form
    {
        private ListViewColumnSorter lvwColumnSorter;
        public SqlConnection cnSQL;
        public SqlCommand cmSQL;
        public SqlDataReader drSQL;
        public string SQL;
        public string connectionString = @"Server=.\SQLEXPRESS;Initial Catalog=PPE2SQL ;integrated security = SSPI";
        



        public Form2()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            MatExection();
       
        }


        public void MatExection()
        {

            try
            {
                cnSQL = new SqlConnection(connectionString);
                cnSQL.Open();
                SQL = "SELECT ID_Intervention as IDInt, Materiel.Nom_Materiel as NomMat, Client.Nom_Client as NomCli, Site.Nom_Site as NomSite, Date as DateInt, Commentaire as ComInt FROM Intervention join Materiel on Intervention.ID_Materiel = Materiel.ID_Materiel join Site on Materiel.ID_Site = Site.ID_Site join Client on Materiel.ID_Client = Client.ID_Client";
                cmSQL = new SqlCommand(SQL, cnSQL);
                drSQL = cmSQL.ExecuteReader();
                

                while (drSQL.Read())
                {
                    
                    ListViewItem Materiel = new ListViewItem(new[] { drSQL["IDInt"].ToString(), drSQL["NomMat"].ToString(), drSQL["DateInt"].ToString(), drSQL["NomCli"].ToString(), drSQL["ComInt"].ToString(), drSQL["NomSite"].ToString(), });
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

        private void recupererDonées(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            try
            {
                cnSQL = new SqlConnection(connectionString);
                cnSQL.Open();
                SQL = "SELECT Materiel.MTBF_Materiel as MTBFMat FROM Intervention join Materiel on Intervention.ID_Materiel = Materiel.ID_Materiel WHERE ID_Intervention = " + listView1.SelectedItems[0].Text;
                cmSQL = new SqlCommand(SQL, cnSQL);
                drSQL = cmSQL.ExecuteReader();
                if (drSQL.Read())
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(drSQL["MTBFMat"] + " Jours");
                }
            }

            catch (SqlException a)
            {
                MessageBox.Show(a.Message, "SQL Error");
            }
            finally
            {
                drSQL.Close();
                cnSQL.Close();
                cmSQL.Dispose();
                cnSQL.Dispose();
            }

            try
            {
                cnSQL = new SqlConnection(connectionString);
                cnSQL.Open();
                SQL = "SELECT Materiel.Description_Materiel as DescMat FROM Intervention join Materiel on Intervention.ID_Materiel = Materiel.ID_Materiel WHERE ID_Intervention = " + listView1.SelectedItems[0].Text;
                cmSQL = new SqlCommand(SQL, cnSQL);
                drSQL = cmSQL.ExecuteReader();
                if (drSQL.Read())
                {
                    listBox2.Items.Clear();
                    listBox2.Items.Add(drSQL["DescMat"]);
                }
            }

            catch (SqlException a)
            {
                MessageBox.Show(a.Message, "SQL Error");
            }
            finally
            {
                drSQL.Close();
                cnSQL.Close();
                cmSQL.Dispose();
                cnSQL.Dispose();
            }








        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cnSQL = new SqlConnection(connectionString);
                cnSQL.Open();
                SQL = "SELECT ID_Intervention as IDInt, Materiel.Nom_Materiel as NomMat, Client.Nom_Client as NomCli, Site.Nom_Site as NomSite," +
                    " Date as DateInt, Commentaire as ComInt FROM Intervention" +
                    " join Materiel on Intervention.ID_Materiel = Materiel.ID_Materiel join Site on Materiel.ID_Site = Site.ID_Site" +
                    " join Client on Materiel.ID_Client = Client.ID_Client WHERE Materiel.Nom_Materiel LIKE '" + textBox1.Text + "%'";
                cmSQL = new SqlCommand(SQL, cnSQL);
                drSQL = cmSQL.ExecuteReader();
                listView1.Items.Clear();

                while (drSQL.Read())
                {

                    ListViewItem Materiel = new ListViewItem(new[] { drSQL["IDInt"].ToString(), drSQL["NomMat"].ToString(), drSQL["DateInt"].ToString(), drSQL["NomCli"].ToString(), drSQL["ComInt"].ToString(), drSQL["NomSite"].ToString() });
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

        private void Ajouter_Click(object sender, EventArgs e)
        {
            AjouterInt ajouter = new AjouterInt();
            ajouter.Show();
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

        private void button3_Click(object sender, EventArgs e)
            
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Veuillez selectionner une ligne !!", "warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
               
            }
            ListViewItem id = listView1.SelectedItems[0];
            modifieint modifier = new modifieint();
            modifier.idrech = listView1.SelectedItems[0].Text;
            modifier.Show();
            Close();
        }
        

        private void Supprimer_Click(object sender, EventArgs e) 
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Veuillez selectionner une ligne !!", "warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = listView1.SelectedItems[0].SubItems[0].Text;
            MessageBox.Show("Supprimer");
            cnSQL = new SqlConnection(connectionString);
            cnSQL.Open();
            SQL = "Delete From Intervention Where ID_Intervention = " + listView1.SelectedItems[0].SubItems[0].Text;
            cmSQL = new SqlCommand(SQL, cnSQL);
            cmSQL.ExecuteNonQuery();
            cnSQL.Close();

           
            {
                Close();
                Form2 Form2 = new Form2();
                Form2.Show();
                
            }
        }
        
}

}
    

