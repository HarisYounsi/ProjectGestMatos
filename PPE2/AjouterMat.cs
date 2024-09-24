using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PPE2
{
  



    public partial class AjouterMat : Form
    {

        public SqlConnection cnSQL;
        public SqlCommand cmSQL;
        public SqlDataReader drSQL;
        public string SQL;
        public string connectionString = @"Server=.\SQLEXPRESS;Initial Catalog=PPE2SQL ;integrated security = SSPI";
        private object cmSQLClient;

        public AjouterMat()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AjouterMat_Load(object sender, EventArgs e)
        {
            cnSQL = new SqlConnection(connectionString);
            cnSQL.Open();

            try //essaye
            {
                SQL = "SELECT * FROM Type";
                cmSQL = new SqlCommand(SQL, cnSQL);
                drSQL = cmSQL.ExecuteReader();


                while (drSQL.Read()) //Tant que lire. Boucle
                {
                    //comboBox = liste déroulante
                    /*cbType.Items.Add(drSQL["Nom_Type"].ToString());*/
                    string nomType = drSQL["Nom_Type"].ToString();

                    ComboboxItem nomprenom = new ComboboxItem();
                    nomprenom.Text = nomType;
                    nomprenom.Value = drSQL["ID_Type"].ToString();

                    cbType.Items.Add(nomType);

                }


            }

            catch (SqlException a) //spécifique. un sous type de Exception
            {
                MessageBox.Show(a.Message, "Une erreur SQL est parvenue, merci de vérifier votre requete");
            }
            catch (Exception a) // Générique
            {
                MessageBox.Show(a.Message, "General Error");
            }
            finally
            {
                drSQL.Close();
                cmSQL.Dispose(); //libère la mémoire
            }

            

            try
            {
                SQL = "SELECT * FROM Client";
                cmSQL = new SqlCommand(SQL, cnSQL);
                drSQL = cmSQL.ExecuteReader();

            while (drSQL.Read())
                {
                     string nomClient = drSQL["Nom_Client"].ToString();
                     string nomMajuscules = nomClient.ToUpper();

                     string item = drSQL["Civilite_Client"].ToString() + " " +
                                    drSQL["Prenom_Client"].ToString() + " " +
                                    nomMajuscules;


                    cbClient.Items.Add(item);

                    /*string item = drSQL["Nom_Materiel"].ToString();

                    ComboboxItem nomprenom= new ComboboxItem();
                    nomprenom.Text = item;
                    nomprenom.Value = drSQL["ID_Materiel"].ToString();

                    cbClient.Items.Add(nomprenom);*/


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
                cmSQL.Dispose();
            }



           /* try
            {
                SQL = "SELECT * FROM Client";
                cmSQL = new SqlCommand(SQL, cnSQL);
                drSQL = cmSQL.ExecuteReader();


                while (drSQL.Read())
                {
                    comboBox2.Items.Add(drSQL["Nom_Client"].ToString());
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
                cmSQL.Dispose();
            }*/

            try
            {
                SQL = "SELECT * FROM Site";
                cmSQL = new SqlCommand(SQL, cnSQL);
                drSQL = cmSQL.ExecuteReader();


                while (drSQL.Read())
                {
                    /*cBSite.Items.Add(drSQL["Nom_Site"].ToString());*/

                    string nomSite = drSQL["Nom_Site"].ToString();

                    ComboboxItem nomprenom = new ComboboxItem();
                    nomprenom.Text = nomSite;
                    nomprenom.Value = drSQL["ID_Site"].ToString();

                    cbSite.Items.Add(nomSite);
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
                cmSQL.Dispose();
            }


            cnSQL.Close();
            cnSQL.Dispose(); //libère la mémoire
        }


         /*while (drSQL.Read())
                {
                    string prenomClient = drSQL["Prenom_Client"].ToString();
        string prenomMajuscule = CONCAT(UPPER(SUBSTRING(prenomClient, 1, 1)), LOWER(SUBSTRING(prenomClient, 2)));

        string nomClient = drSQL["Nom_Client"].ToString();
        string nomMajuscules = nomClient.ToUpper();

        string item = drSQL["Civilite_Client"].ToString() + " " +
                      prenomMajuscule + " " +
                      nomMajuscules;

        comboBox1.Items.Add(item);
                }*/

    /*private string CONCAT(object v1, object v2)
    {
        throw new NotImplementedException();
    }

    private object UPPER(object v)
    {
        throw new NotImplementedException();
    }

    private object SUBSTRING(string prenomClient, int v, int v1)
    {
        throw new NotImplementedException();
    }

    private object LOWER(object value)
    {
        throw new NotImplementedException();
    }*/

    private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                cnSQL = new SqlConnection(connectionString);
                cnSQL.Open();


                string SQL3 = "SELECT ID_Type FROM Type WHERE Nom_Type = '" + cbType.Text + "'";
                SqlCommand cmSQL3 = new SqlCommand(SQL3, cnSQL);
                SqlDataReader result = cmSQL3.ExecuteReader();
                result.Read();
                string idtype = result["ID_Type"].ToString();
                result.Close();



                string idclient = (cbClient.SelectedItem as ComboboxItem).Value.ToString();


                /*string SQLClient = "SELECT ID_Client FROM Client WHERE Prenom_Client = '" + comboBox1.Text + "'";
                SqlCommand cmSQLClient = new SqlCommand(SQLClient, cnSQL);
                SqlDataReader resultClient = cmSQLClient.ExecuteReader();
                resultClient.Read();
                string idclient = resultClient["ID_Client"].ToString();
                resultClient.Close();*/


                /*string SQLClient1 = "SELECT ID_Client FROM Client WHERE Prenom_Client = '" + comboBox1.Text + "'";
                SqlCommand cmSQLClient1 = new SqlCommand(SQLClient, cnSQL);
                SqlDataReader resultClient1 = cmSQLClient.ExecuteReader();
                resultClient.Read();
                string idclient1 = resultClient["ID_Client"].ToString();
                resultClient.Close();*/


                string SQLSite = "SELECT ID_Site FROM Site WHERE Nom_Site = '" + cbSite.Text + "'";
                SqlCommand cmSQLSite = new SqlCommand(SQLSite, cnSQL);
                SqlDataReader resultSite = cmSQLSite.ExecuteReader();
                resultSite.Read();
                string idSite = resultSite["ID_Site"].ToString();
                resultSite.Close();




                string SQL2 = "INSERT INTO Materiel (Nom_Materiel , MTBF_Materiel , Description_Materiel, ID_Type, ID_Client, ID_Site) VALUES " +
                        "('" + cbClient.Text + "','" + TbMTBF.Text + "','" + tBdescp.Text + "','" + idtype + "','" + idclient + "','" + idSite + "')";
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
                Form3 Form3 = new Form3();
                Form3.Show();
            }

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(tBdescp.Text, "Demo App - Message!");
            }
        }

        
      

     

        private void Reset_Click(object sender, EventArgs e)
        {
            // Réinitialiser les valeurs des contrôles à leur état initial
            cbClient.Text = string.Empty;
            cbType.Text = string.Empty;
            cbSite.Text = string.Empty;
            TbMTBF.Text = string.Empty;
            tBdescp.Text = string.Empty;

        }


        private void cbClient_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbClient.Text))
            {
                e.Cancel = true;
                cbClient.Focus();
                errorProvider1.SetError(cbClient, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbClient, "");
            }
        }
    }
}
