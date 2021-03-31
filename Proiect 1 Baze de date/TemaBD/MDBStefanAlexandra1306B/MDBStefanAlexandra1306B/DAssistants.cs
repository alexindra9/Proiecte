using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace MDBStefanAlexandra1306B
{
    public partial class DAssistants : Form
    {
        string c = "DATA SOURCE = XE;" + "PERSIST SECURITY INFO = True; USER ID = mous; password = Soyalover_3; Pooling = False;";
        OracleConnection oracleConnection = new OracleConnection();

        private void fillIdAsis()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                if (specialistsTab.SelectedTab == specialistsTab.TabPages["updatePage"])
                {
                    idAsis2.Items.Clear();
                    idAsis2.Text = "";
                    string cmd = "SELECT id_asis FROM Asistent WHERE nume_asis = '" + numeAsis2.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetInt64(0).ToString();
                        idAsis2.Items.Add(sname.ToString());
                    }
                }
                else if (specialistsTab.SelectedTab == specialistsTab.TabPages["removePage"])
                {
                    idAsis3.Items.Clear();
                    idAsis3.Text = "";
                    string cmd = "SELECT id_asis FROM Asistent WHERE nume_asis = '" + numeAsis3.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetInt64(0).ToString();
                        idAsis3.Items.Add(sname.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed! The table might not exist! Check again!");
            }
            finally
            {
                oracleConnection.Close();
            }
        }

        private void fillNumeAsis()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();           
            try
            {
                numeAsis2.Items.Clear();
                numeAsis3.Items.Clear();
                string cmd = "SELECT DISTINCT nume_asis FROM Asistent";
                OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                while (myReader.Read())
                {
                    string sname = myReader.GetString(0).ToString();
                    numeAsis2.Items.Add(sname.ToString());
                    numeAsis3.Items.Add(sname.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed! The table might not exist! Check again!");
            }
            finally
            {
                oracleConnection.Close();
            }
        }

        public DAssistants()
        {
            InitializeComponent();
            CenterToScreen();
            fillNumeAsis();
        }

        private void DAssistants_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data go = new Data();
            go.ShowDialog();
            this.Close();
        }

        private void specialistsTab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewPage_Click(object sender, EventArgs e)
        {

        }

        private void insertPage_Click(object sender, EventArgs e)
        {

        }

        private void updatePage_Click(object sender, EventArgs e)
        {

        }

        private void removePage_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try 
            {
                string select = "SELECT id_asis \"MAId \", nume_asis \"Assistant \"" +
                    ", statut_asis \"Certification \", tel_asis \"Phone \", salariu_asis \"Salary \" FROM Asistent ORDER BY id_asis";
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(select, oracleConnection);
                DataTable d = new DataTable();
                oracleDataAdapter.Fill(d);
                dataGridView1.DataSource = d;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Failed! The table might not exist! Check again!");
            }
            finally 
            {
                oracleConnection.Close();
            }
        }

        private void applyButton2_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try 
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string insert = "INSERT INTO Asistent(nume_asis, statut_asis, tel_asis, salariu_asis) " +
                    "VALUES('" + numeAsis.Text.Trim().ToString() + "', '" 
                    + statutAsis.Text.Trim().ToString() + "', '" 
                    + telAsis.Text.Trim().ToString() + "', '" 
                    + salariuAsis.Text.Trim().ToString() + "')";
                oracleDataAdapter.InsertCommand = new OracleCommand(insert, oracleConnection);
                oracleDataAdapter.InsertCommand.ExecuteNonQuery();                 
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Failed! Syntax error, missing parameter or entry already existing! Check again!"); 
            }
            finally 
            {
                oracleConnection.Close();
            }
            fillNumeAsis();
        }

        private void idAsisL_Click(object sender, EventArgs e)
        {

        }

        private void isAsis_TextChanged(object sender, EventArgs e)
        {

        }

        private void numeAsisL_Click(object sender, EventArgs e)
        {

        }

        private void numeAsis_TextChanged(object sender, EventArgs e)
        {

        }

        private void telAsisL_Click(object sender, EventArgs e)
        {

        }

        private void telAsis_TextChanged(object sender, EventArgs e)
        {

        }

        private void salariuAsisL_Click(object sender, EventArgs e)
        {

        }

        private void salariuAsis_TextChanged(object sender, EventArgs e)
        {

        }

        private void statutAsisL_Click(object sender, EventArgs e)
        {

        }

        private void statutAsis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void applyButton3_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string update = "UPDATE Asistent SET " + columnChoice.Text.Trim().ToString() + " = '" + valueBox.Text.Trim().ToString() + "' WHERE id_asis = '" + idAsis2.Text.Trim().ToString() + "'";
                oracleDataAdapter.UpdateCommand = new OracleCommand(update, oracleConnection);
                oracleDataAdapter.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed! Syntax error, missing parameter or entry already existing! Check again!");
            }
            finally
            {
                oracleConnection.Close();
            }
            fillNumeAsis();
        }

        private void idAsisL2_Click(object sender, EventArgs e)
        {

        }

        private void idAsis2_TextChanged(object sender, EventArgs e)
        {

        }

        private void applyButton4_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try 
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string delete = "DELETE FROM Asistent WHERE id_asis = '" + idAsis3.Text.Trim().ToString() + "'";
                oracleDataAdapter.DeleteCommand = new OracleCommand(delete, oracleConnection);
                oracleDataAdapter.DeleteCommand.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Failed! This record is either used by another table or doesn't exit! Check again!");
            }
            finally 
            {
                oracleConnection.Close();
            }
            fillNumeAsis();
        }

        private void idAsisL3_Click(object sender, EventArgs e)
        {

        }

        private void idAsis3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void columnL_Click(object sender, EventArgs e)
        {

        }

        private void columnChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void valueBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numeAsisL2_Click(object sender, EventArgs e)
        {

        }

        private void numeAsis2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdAsis();
        }

        private void numeAsisL3_Click(object sender, EventArgs e)
        {

        }

        private void numeAsis3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdAsis();
        }
    }
}
