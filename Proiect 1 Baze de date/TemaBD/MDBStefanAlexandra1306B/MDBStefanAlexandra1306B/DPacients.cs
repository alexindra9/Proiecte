using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace MDBStefanAlexandra1306B
{
    public partial class DPacients : Form
    {
        string c = "DATA SOURCE = XE;" + "PERSIST SECURITY INFO = True; USER ID = mous; password = Soyalover_3; Pooling = False;";
        OracleConnection oracleConnection = new OracleConnection();

        private void fillIdPacient()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                if (specialistsTab.SelectedTab == specialistsTab.TabPages["updatePage"])
                {
                    idPacient2.Items.Clear();
                    idPacient2.Text = "";
                    string cmd = "SELECT cod_asig FROM Pacient WHERE nume_pac = '" + numePacient2.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetOracleString(0).ToString();
                        idPacient2.Items.Add(sname.ToString());
                    }
                }
                else if (specialistsTab.SelectedTab == specialistsTab.TabPages["removePage"])
                {
                    idPacient3.Items.Clear();
                    idPacient3.Text = "";
                    string cmd = "SELECT cod_asig FROM Pacient WHERE nume_pac = '" + numePacient3.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetOracleString(0).ToString();
                        idPacient3.Items.Add(sname.ToString());
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

        private void fillNumePac()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                numePacient2.Items.Clear();
                numePacient3.Items.Clear();
                string cmd = "SELECT DISTINCT nume_pac FROM Pacient";
                OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                while (myReader.Read())
                {
                    string sname = myReader.GetString(0).ToString();
                    numePacient2.Items.Add(sname.ToString());
                    numePacient3.Items.Add(sname.ToString());
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

        public DPacients()
        {
            InitializeComponent();
            CenterToScreen();
            fillNumePac();
        }

        private void DPacients_Load(object sender, EventArgs e)
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
                string select = "SELECT cod_asig \"PId \", cnp_pac \"SSN \"" +
                ", nume_pac \"Pacient \", adresa_pac \"Address \", tel_pac \"Phone \" FROM Pacient ORDER BY nume_pac";
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
                string insert = "INSERT INTO Pacient(cod_asig, cnp_pac, nume_pac, adresa_pac, tel_pac) " +
                    "VALUES('" + idPacient.Text.Trim().ToString() + "', '"
                    + SSN.Text.Trim().ToString() + "', '"
                    + numePacient.Text.Trim().ToString() + "', '"
                    + adresa.Text.Trim().ToString() + "', '"
                    + telPacient.Text.Trim().ToString() + "')";
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
            fillNumePac();
        }

        private void idPacientL_Click(object sender, EventArgs e)
        {

        }

        private void idPacient_TextChanged(object sender, EventArgs e)
        {

        }

        private void SSNL_Click(object sender, EventArgs e)
        {

        }

        private void SSN_TextChanged(object sender, EventArgs e)
        {

        }

        private void numePacientL_Click(object sender, EventArgs e)
        {

        }

        private void numePacient_TextChanged(object sender, EventArgs e)
        {

        }

        private void adresaL_Click(object sender, EventArgs e)
        {

        }

        private void adresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void telPacientL_Click(object sender, EventArgs e)
        {

        }

        private void telPacient_TextChanged(object sender, EventArgs e)
        {

        }

        private void applyButton3_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string update = "UPDATE Pacient SET " + columnChoice.Text.Trim().ToString() + " = '" + valueBox.Text.Trim().ToString() + "' WHERE cod_asig = '" + idPacient2.Text.Trim().ToString() + "'";
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
            fillNumePac();
        }

        private void idPacientL2_Click(object sender, EventArgs e)
        {

        }

        private void idPacient2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void applyButton4_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try 
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string delete = "DELETE FROM Pacient WHERE cod_asig = '" + idPacient3.Text.Trim().ToString() + "'";
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
            fillNumePac();
        }

        private void idPacientL3_Click(object sender, EventArgs e)
        {

        }

        private void idPacient3_SelectedIndexChanged(object sender, EventArgs e)
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

        private void numePacientL2_Click(object sender, EventArgs e)
        {

        }

        private void numePacient2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdPacient();
        }

        private void numePacientL3_Click(object sender, EventArgs e)
        {

        }

        private void numePacient3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdPacient();
        }
    }
}
