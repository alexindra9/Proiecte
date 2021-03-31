using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace MDBStefanAlexandra1306B
{
    public partial class SAdmissions : Form
    {
        string c = "DATA SOURCE = XE;" + "PERSIST SECURITY INFO = True; USER ID = mous; password = Soyalover_3; Pooling = False;";
        OracleConnection oracleConnection = new OracleConnection();

        private void fillIdInterventie()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                if (specialistsTab.SelectedTab == specialistsTab.TabPages["insertPage"])
                {
                    idInterventie.Items.Clear();
                    idInterventie.Text = "";
                    string cmd = "SELECT id_interv FROM Interventie WHERE nume_interv = '" + numeInterv.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetInt64(0).ToString();
                        idInterventie.Items.Add(sname.ToString());
                    }
                }
                else if (specialistsTab.SelectedTab == specialistsTab.TabPages["updatePage"])
                {
                    idInterventie2.Items.Clear();
                    idInterventie2.Text = "";
                    string cmd = "SELECT id_interv FROM Interventie WHERE nume_interv = '" + numeInterv2.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetInt64(0).ToString();
                        idInterventie2.Items.Add(sname.ToString());
                    }
                }
                else if (specialistsTab.SelectedTab == specialistsTab.TabPages["removePage"])
                {
                    idInterventie3.Items.Clear();
                    idInterventie3.Text = "";
                    string cmd = "SELECT id_interv FROM Interventie WHERE nume_interv = '" + numeInterv3.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetInt64(0).ToString();
                        idInterventie3.Items.Add(sname.ToString());
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

        private void fillIdAsis()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                 idAsis.Items.Clear();
                 idAsis.Text = "";
                 string cmd = "SELECT id_asis FROM Asistent WHERE nume_asis = '" + numeAsis.Text.Trim().ToString() + "'";
                 OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                 OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                 while (myReader.Read())
                 {
                     string sname = myReader.GetInt64(0).ToString();
                     idAsis.Items.Add(sname.ToString());
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

        private void fillIdInternare()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                if (specialistsTab.SelectedTab == specialistsTab.TabPages["updatePage"])
                {
                    idInternare2.Items.Clear();
                    idInternare2.Text = "";
                    string cmd = "SELECT id_intern FROM Internare WHERE id_interv = '" + idInterventie2.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetInt64(0).ToString();
                        idInternare2.Items.Add(sname.ToString());
                    }
                }
                else if (specialistsTab.SelectedTab == specialistsTab.TabPages["removePage"])
                {
                    idInternare3.Items.Clear();
                    idInternare3.Text = "";
                    string cmd = "SELECT id_intern FROM Internare WHERE id_interv = '" + idInterventie3.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetInt64(0).ToString();
                        idInternare3.Items.Add(sname.ToString());
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
                numePac.Items.Clear();
                numePac2.Items.Clear();
                numePac3.Items.Clear();
                string cmd = "SELECT DISTINCT nume_pac FROM Pacient";
                OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                while (myReader.Read())
                {
                    string sname = myReader.GetString(0).ToString();
                    numePac.Items.Add(sname.ToString());
                    numePac2.Items.Add(sname.ToString());
                    numePac3.Items.Add(sname.ToString());
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

        private void fillIdPac()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                if (specialistsTab.SelectedTab == specialistsTab.TabPages["insertPage"])
                {
                    idPac.Items.Clear();
                    idPac.Text = "";
                    string cmd = "SELECT cod_asig FROM Pacient WHERE nume_pac = '" + numePac.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetOracleString(0).ToString();
                        idPac.Items.Add(sname.ToString());
                    }
                }
                else if (specialistsTab.SelectedTab == specialistsTab.TabPages["updatePage"])
                {
                    idPac2.Items.Clear();
                    idPac2.Text = "";
                    string cmd = "SELECT cod_asig FROM Pacient WHERE nume_pac = '" + numePac2.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetOracleString(0).ToString();
                        idPac2.Items.Add(sname.ToString());
                    }
                }
                else if (specialistsTab.SelectedTab == specialistsTab.TabPages["removePage"])
                {
                    idPac3.Items.Clear();
                    idPac3.Text = "";
                    string cmd = "SELECT cod_asig FROM Pacient WHERE nume_pac = '" + numePac3.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetOracleString(0).ToString();
                        idPac3.Items.Add(sname.ToString());
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

        private void fillNumeInterv()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                if (specialistsTab.SelectedTab == specialistsTab.TabPages["insertPage"])
                {
                    numeInterv.Items.Clear();
                    numeInterv.Text = "";
                    string cmd = "SELECT DISTINCT nume_interv FROM Interventie WHERE cod_asig = '" + idPac.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetString(0).ToString();
                        numeInterv.Items.Add(sname.ToString());
                    }
                }
                else if (specialistsTab.SelectedTab == specialistsTab.TabPages["updatePage"])
                {
                    numeInterv2.Items.Clear();
                    numeInterv2.Text = "";
                    string cmd = "SELECT DISTINCT nume_interv FROM Interventie WHERE cod_asig = '" + idPac2.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetString(0).ToString();
                        numeInterv2.Items.Add(sname.ToString());
                    }
                }
                else if (specialistsTab.SelectedTab == specialistsTab.TabPages["removePage"])
                {
                    numeInterv3.Items.Clear();
                    numeInterv3.Text = "";
                    string cmd = "SELECT DISTINCT nume_interv FROM Interventie WHERE cod_asig = '" + idPac3.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetString(0).ToString();
                        numeInterv3.Items.Add(sname.ToString());
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
                numeAsis.Items.Clear();
                string cmd = "SELECT DISTINCT nume_asis FROM Asistent";
                OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                while (myReader.Read())
                {
                    string sname = myReader.GetString(0).ToString();
                    numeAsis.Items.Add(sname.ToString());
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

        public SAdmissions()
        {
            InitializeComponent();
            CenterToScreen();
            fillNumePac();
            fillNumeAsis();
        }       

        private void SAdmissions_Load(object sender, EventArgs e)
        {

        }
        
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Schedule go = new Schedule();
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
                string select = "SELECT d.id_interv \"IId \", a.cod_asig \"PId \"" +
               ", a.nume_pac \"Pacient \", b.id_intern \"AId \", b.nr_camera \"AR \", b.data_intern \"Admission \"" +
               ", b.data_extern \"Discharge \", c.id_asis \"MAId \", c.nume_asis \"Assistant \" FROM Pacient a, Internare b" +
               ", Asistent c, Interventie d WHERE a.cod_asig = d.cod_asig AND d.id_interv = b.id_interv " +
               "AND b.id_asis = c.id_asis";
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
                string insert = "INSERT INTO Internare(nr_camera, id_interv, id_asis, data_intern, data_extern) " +
                    "VALUES('" + nrCamera.Text.Trim().ToString() + "', '"
                    + idInterventie.Text.Trim().ToString() + "', '"
                    + idAsis.Text.Trim().ToString() + "', TO_DATE('"
                    + dataIntern.Text.Trim().ToString() + "', 'rrrr/mm/dd hh24:mi:ss'), TO_DATE('"
                    + dataExtern.Text.Trim().ToString() + "', 'rrrr/mm/dd hh24:mi:ss'))";
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

        private void idInternareL_Click(object sender, EventArgs e)
        {

        }

        private void idInternare_TextChanged(object sender, EventArgs e)
        {

        }

        private void nrCameraL_Click(object sender, EventArgs e)
        {

        }

        private void nrCamera_TextChanged(object sender, EventArgs e)
        {

        }

        private void idInterventieL_Click(object sender, EventArgs e)
        {

        }

        private void idInterventie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void idAsisL_Click(object sender, EventArgs e)
        {

        }

        private void idAsis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataInternL_Click(object sender, EventArgs e)
        {

        }

        private void dataIntern_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataExternL_Click(object sender, EventArgs e)
        {

        }

        private void dataExtern_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void applyButton3_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                if (columnChoice.Text.Trim().ToString() == "data_intern" || columnChoice.Text.Trim().ToString() == "data_extern")
                {
                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                    string update = "UPDATE Internare SET " + columnChoice.Text.Trim().ToString() + " = TO_DATE('" + valueBox.Text.Trim().ToString() + "', 'rrrr/mm/dd hh24:mi:ss') WHERE id_intern = '" + idInternare2.Text.Trim().ToString() + "'";
                    oracleDataAdapter.UpdateCommand = new OracleCommand(update, oracleConnection);
                    oracleDataAdapter.UpdateCommand.ExecuteNonQuery();

                }
                else
                {
                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                    string update = "UPDATE Internare SET " + columnChoice.Text.Trim().ToString() + " = '" + valueBox.Text.Trim().ToString() + "' WHERE id_intern = '" + idInternare2.Text.Trim().ToString() + "'";
                    oracleDataAdapter.UpdateCommand = new OracleCommand(update, oracleConnection);
                    oracleDataAdapter.UpdateCommand.ExecuteNonQuery();
                }
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
        
        private void idInternareL2_Click(object sender, EventArgs e)
        {

        }

       private void idInternare2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }            

        private void applyButton4_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try 
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string delete = "DELETE FROM Internare WHERE id_intern = '" + idInternare3.Text.Trim().ToString() + "'";
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

        private void idInternareL3_Click(object sender, EventArgs e)
        {

        }

        private void idInternare3_SelectedIndexChanged(object sender, EventArgs e)
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

        private void numeIntervL_Click(object sender, EventArgs e)
        {

        }

        private void numeInterv_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdInterventie();
        }

        private void numeAsisL_Click(object sender, EventArgs e)
        {

        }

        private void numeAsis_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdAsis();
        }

        private void numePacL_Click(object sender, EventArgs e)
        {
            
        }

        private void numePac_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdPac();
        }

        private void idPacL_Click(object sender, EventArgs e)
        {

        }

        private void idPac_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillNumeInterv();
        }

        private void numePacL2_Click(object sender, EventArgs e)
        {

        }

        private void numePac2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdPac();
        }

        private void idPacL2_Click(object sender, EventArgs e)
        {

        }

        private void idPac2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillNumeInterv();
        }

        private void numeIntervL2_Click(object sender, EventArgs e)
        {

        }

        private void numeInterv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdInterventie();
        }

        private void idInterventieL2_Click(object sender, EventArgs e)
        {

        }

        private void idInterventie2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdInternare();
        }

        private void numePacL3_Click(object sender, EventArgs e)
        {

        }

        private void numePac3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdPac();
        }

        private void idPacL3_Click(object sender, EventArgs e)
        {

        }

        private void idPac3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillNumeInterv();
        }

        private void numeIntervL3_Click(object sender, EventArgs e)
        {

        }

        private void numeInterv3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdInterventie();
        }

        private void idInterventieL3_Click(object sender, EventArgs e)
        {

        }

        private void idInterventie3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdInternare();
        }
    }
}
