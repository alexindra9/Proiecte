using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace MDBStefanAlexandra1306B
{
    public partial class SConsultations : Form
    {
        string c = "DATA SOURCE = XE;" + "PERSIST SECURITY INFO = True; USER ID = mous; password = Soyalover_3; Pooling = False;";
        OracleConnection oracleConnection = new OracleConnection();

        List<String> listaSpec= new List<string>();
        List<String> listaData = new List<string>();
        List<String> listaOra = new List<string>();

        private void fillIdSpecialist()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                if (specialistsTab.SelectedTab == specialistsTab.TabPages["insertPage"])
                {
                    listaSpec.Clear();
                    idSpec.Items.Clear();
                    idSpec.Text = "";
                    string cmd = "SELECT id_spec FROM Specialist WHERE nume_spec = '" + numeSpec.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetInt64(0).ToString();
                        idSpec.Items.Add(sname.ToString());
                    }
                }
                else if (specialistsTab.SelectedTab == specialistsTab.TabPages["updatePage"])
                {
                    listaSpec.Clear();
                    idSpec2.Items.Clear();
                    idSpec2.Text = "";
                    string cmd = "SELECT id_spec FROM Specialist WHERE nume_spec = '" + numeSpec2.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetInt64(0).ToString();
                        idSpec2.Items.Add(sname.ToString());
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

        private void fillIdPacient()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                if (specialistsTab.SelectedTab == specialistsTab.TabPages["insertPage"])
                {
                    idPacient.Items.Clear();
                    idPacient.Text = "";
                    string cmd = "SELECT cod_asig FROM Pacient WHERE nume_pac = '" + numePac.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetOracleString(0).ToString();
                        idPacient.Items.Add(sname.ToString());
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

        private void fillIdConsultatie()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                if (specialistsTab.SelectedTab == specialistsTab.TabPages["updatePage"])
                {
                    idCons2.Items.Clear();
                    idCons2.Text = "";
                    string cmd = "SELECT id_cons FROM Consultatie WHERE cod_asig = '" + idPac2.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetInt64(0).ToString();
                        idCons2.Items.Add(sname.ToString());
                    }
                }
                else if (specialistsTab.SelectedTab == specialistsTab.TabPages["removePage"])
                {
                    idCons3.Items.Clear();
                    idCons3.Text = "";
                    string cmd = "SELECT id_cons FROM Consultatie WHERE cod_asig = '" + idPac3.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetInt64(0).ToString();
                        idCons3.Items.Add(sname.ToString());
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

        private void fillNumeSpec()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                numeSpec.Items.Clear();
                numeSpec2.Items.Clear();
                string cmd = "SELECT DISTINCT nume_spec FROM Specialist";
                OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                while (myReader.Read())
                {
                    string sname = myReader.GetString(0).ToString();
                    numeSpec.Items.Add(sname.ToString());
                    numeSpec2.Items.Add(sname.ToString());
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
                if (specialistsTab.SelectedTab == specialistsTab.TabPages["updatePage"])
                {
                    numePac2.Items.Clear();
                    string cmd = "SELECT DISTINCT p.nume_pac FROM Pacient p, Consultatie c, Specialist s " +
                        "WHERE s.id_spec = '" + idSpec2.Text.Trim().ToString() + "' " +
                        "AND s.id_spec = c.id_spec " +
                        "AND c.cod_asig = p.cod_asig";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetString(0).ToString();
                        numePac2.Items.Add(sname.ToString());
                    }
                }
                else
                {
                    numePac.Items.Clear();
                    numePac3.Items.Clear();
                    string cmd = "SELECT DISTINCT nume_pac FROM Pacient";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetString(0).ToString();
                        numePac.Items.Add(sname.ToString());
                        numePac3.Items.Add(sname.ToString());
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

        public SConsultations()
        {
            InitializeComponent();
            CenterToScreen();
            fillNumeSpec();
            fillNumePac();

            oracleConnection.ConnectionString = c;
            oracleConnection.Open();

            listaData.Clear();
            listaOra.Clear();
            listaSpec.Clear();
            string cmd = "SELECT data_orar FROM Orar";
            OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
            OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
            while (myReader.Read())
            {
                string sname = myReader.GetDateTime(0).Date.ToString("d");
                listaData.Add(sname.ToString());
            }
            cmd = "SELECT ora_orar FROM Orar";
            cmddatabase = new OracleCommand(cmd, oracleConnection);
            myReader = cmddatabase.ExecuteReader();
            while (myReader.Read())
            {
                string sname = myReader.GetDecimal(0).ToString();
                listaOra.Add(sname.ToString());
            }
            cmd = "SELECT id_spec FROM Orar";
            cmddatabase = new OracleCommand(cmd, oracleConnection);
            myReader = cmddatabase.ExecuteReader();
            while (myReader.Read())
            {
                string sname = myReader.GetInt64(0).ToString();
                listaSpec.Add(sname.ToString());
            }

            oracleConnection.Close();
        }

        private void SConsultations_Load(object sender, EventArgs e)
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
                string select = "SELECT a.id_spec \"SId \", a.nume_spec \"Specialist \"" +
                ", b.cod_asig \"PId \", b.nume_pac \"Pacient \", c.id_cons \"CId \", c.data_cons \"Date \"" +
                ", c.nr_cab \"CR \" FROM Specialist a, Pacient b, Consultatie c WHERE a.id_spec = c.id_spec " +
                "AND c.cod_asig = b.cod_asig";
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

            listaData.Clear();
            listaOra.Clear();
            listaSpec.Clear();
            string cmd = "SELECT data_orar FROM Orar";
            OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
            OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
            while (myReader.Read())
            {
                string sname = myReader.GetDateTime(0).Date.ToString("d");
                listaData.Add(sname.ToString());
            }
            cmd = "SELECT ora_orar FROM Orar";
            cmddatabase = new OracleCommand(cmd, oracleConnection);
            myReader = cmddatabase.ExecuteReader();
            while (myReader.Read())
            {
                string sname = myReader.GetDecimal(0).ToString();
                listaOra.Add(sname.ToString());
            }
            cmd = "SELECT id_spec FROM Orar";
            cmddatabase = new OracleCommand(cmd, oracleConnection);
            myReader = cmddatabase.ExecuteReader();
            while (myReader.Read())
            {
                string sname = myReader.GetInt64(0).ToString();
                listaSpec.Add(sname.ToString());
            }

            OracleCommand command = oracleConnection.CreateCommand();
            OracleTransaction transaction;
            transaction = oracleConnection.BeginTransaction();
            command.Transaction = transaction;
            try
            {
                for (int i = 0; i < listaSpec.Count; i++)
                {
                    if (listaSpec[i] == idSpec.Text.Trim().ToString() && listaData[i] == Convert.ToDateTime(DateTime.Parse(dataCons.Text.Trim().ToString())).Date.ToString("d") && listaOra[i] == Convert.ToDecimal(TimeSpan.Parse(dataCons.Text.Trim().Substring(10, 8).ToString()).TotalHours).ToString())
                    {
                        MessageBox.Show("Date already occupied!");
                        return;
                    }
                }
                command.CommandText = "INSERT INTO Orar(id_spec, data_orar, ora_orar) " +
                    "VALUES('" + idSpec.Text.Trim().ToString() + "', TO_DATE(TO_DATE('"
                    + dataCons.Text.Trim().ToString() + "', 'rrrr/mm/dd hh24:mi:ss'), 'dd/mm/rrrr'), TO_NUMBER(TO_CHAR(TO_DATE('"
                    + dataCons.Text.Trim().ToString() + "', 'rrrr/mm/dd hh24:mi:ss'), 'hh24')))";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Consultatie(data_cons, nr_cab, id_spec, cod_asig) " +
                    "VALUES(TO_DATE('" + dataCons.Text.Trim().ToString() + "', 'rrrr/mm/dd hh24:mi:ss'), '"
                    + nrCab.Text.Trim().ToString() + "', '"
                    + idSpec.Text.Trim().ToString() + "', '"
                    + idPacient.Text.Trim().ToString() + "')";
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Failed! Syntax error, missing parameter or entry already existing! Check again!");
            }
            finally
            {
                oracleConnection.Close();
            }
        }

        private void idConsL_Click(object sender, EventArgs e)
        {

        }

        private void idCons_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataConsL_Click(object sender, EventArgs e)
        {

        }

        private void dataCons_TextChanged(object sender, EventArgs e)
        {

        }

        private void idSpecL_Click(object sender, EventArgs e)
        {

        }

        private void idSpec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void idPacientL_Click(object sender, EventArgs e)
        {

        }

        private void idPacient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nrCabL_Click(object sender, EventArgs e)
        {

        }

        private void nrCab_TextChanged(object sender, EventArgs e)
        {

        }

        private void applyButton3_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();

            listaData.Clear();
            listaOra.Clear();
            listaSpec.Clear();
            string cmd = "SELECT data_orar FROM Orar";
            OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
            OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
            while (myReader.Read())
            {
                string sname = myReader.GetDateTime(0).Date.ToString("d");
                listaData.Add(sname.ToString());
            }
            cmd = "SELECT ora_orar FROM Orar";
            cmddatabase = new OracleCommand(cmd, oracleConnection);
            myReader = cmddatabase.ExecuteReader();
            while (myReader.Read())
            {
                string sname = myReader.GetDecimal(0).ToString();
                listaOra.Add(sname.ToString());
            }
            cmd = "SELECT id_spec FROM Orar";
            cmddatabase = new OracleCommand(cmd, oracleConnection);
            myReader = cmddatabase.ExecuteReader();
            while (myReader.Read())
            {
                string sname = myReader.GetInt64(0).ToString();
                listaSpec.Add(sname.ToString());
            }

            OracleCommand command = oracleConnection.CreateCommand();
            OracleTransaction transaction;
            transaction = oracleConnection.BeginTransaction();
            command.Transaction = transaction;
            try
            {
                if (columnChoice.Text.Trim().ToString() == "data_cons")
                {
                    for (int i = 0; i < listaSpec.Count; i++)
                    {
                        if (listaSpec[i] == idSpec2.Text.Trim().ToString() && listaData[i] == Convert.ToDateTime(DateTime.Parse(valueBox.Text.Trim().ToString())).Date.ToString("d") && listaOra[i] == Convert.ToDecimal(TimeSpan.Parse(valueBox.Text.Trim().Substring(10, 8).ToString()).TotalHours).ToString())
                        {
                            MessageBox.Show("Date already occupied!");
                            return;
                        }
                    }
                    command.CommandText = "UPDATE Orar SET data_orar = TO_DATE(TO_DATE('" +
                        valueBox.Text.Trim().ToString() + "', 'rrrr/mm/dd hh24:mi:ss'), 'dd/mm/rrrr') " +
                        "WHERE id_orar in (SELECT o.id_orar FROM Orar o, Consultatie c " +
                        "WHERE c.id_cons = '" + idCons2.Text.Trim().ToString() + "' " +
                        "AND c.id_spec = o.id_spec " +
                        "AND (SELECT TO_DATE(c.data_cons, 'rrrr/mm/dd') FROM Consultatie c WHERE c.id_cons = '" + idCons2.Text.Trim().ToString() + "') = TO_DATE(o.data_orar, 'rrrr/mm/dd') " +
                        "AND (SELECT TO_NUMBER(TO_CHAR(c.data_cons, 'hh24')) FROM Consultatie c WHERE c.id_cons = '" + idCons2.Text.Trim().ToString() + "') = o.ora_orar)";
                    command.ExecuteNonQuery();
                    command.CommandText = "UPDATE Consultatie SET " + columnChoice.Text.Trim().ToString() + " = TO_DATE('" + valueBox.Text.Trim().ToString() + "', 'rrrr/mm/dd hh24:mi:ss') WHERE id_cons = '" + idCons2.Text.Trim().ToString() + "'";
                    command.ExecuteNonQuery();
                    command.CommandText = "UPDATE Orar SET ora_orar = TO_NUMBER(TO_CHAR(TO_DATE('" +
                        valueBox.Text.Trim().ToString() + "', 'rrrr/mm/dd hh24:mi:ss'), 'hh24')) " +
                        "WHERE id_orar in (SELECT o.id_orar FROM Orar o, Consultatie c " +
                        "WHERE c.id_cons = '" + idCons2.Text.Trim().ToString() + "' " +
                        "AND c.id_spec = o.id_spec " +
                        "AND (SELECT TO_DATE(c.data_cons, 'rrrr/mm/dd') FROM Consultatie c WHERE c.id_cons = '" + idCons2.Text.Trim().ToString() + "') = TO_DATE(o.data_orar, 'rrrr/mm/dd'))";
                    command.ExecuteNonQuery();
                    command.CommandText = "UPDATE Consultatie SET " + columnChoice.Text.Trim().ToString() + " = TO_DATE('" + valueBox.Text.Trim().ToString() + "', 'rrrr/mm/dd hh24:mi:ss') WHERE id_cons = '" + idCons2.Text.Trim().ToString() + "'";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                else if (columnChoice.Text.Trim().ToString() == "id_spec")
                {
                    command.CommandText = "UPDATE Orar SET id_spec = '" +
                        valueBox.Text.Trim().ToString() + "' " +
                        "WHERE id_orar in (SELECT o.id_orar FROM Orar o, Consultatie c " +
                        "WHERE c.id_spec = o.id_spec " +
                        "AND (SELECT TO_DATE(c.data_cons, 'rrrr/mm/dd') FROM Consultatie c WHERE c.id_cons = '" + idCons2.Text.Trim().ToString() + "') = TO_DATE(o.data_orar, 'rrrr/mm/dd') " +
                        "AND (SELECT TO_NUMBER(TO_CHAR(c.data_cons, 'hh24')) FROM Consultatie c WHERE c.id_cons = '" + idCons2.Text.Trim().ToString() + "') = o.ora_orar " +
                        "AND c.id_cons = '" + idCons2.Text.Trim().ToString() + "')";
                    command.ExecuteNonQuery();
                    command.CommandText = "UPDATE Consultatie SET " + columnChoice.Text.Trim().ToString() + " = '" + valueBox.Text.Trim().ToString() + "' WHERE id_cons = '" + idCons2.Text.Trim().ToString() + "'";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                else
                {
                    command.CommandText = "UPDATE Consultatie SET " + columnChoice.Text.Trim().ToString() + " = '" + valueBox.Text.Trim().ToString() + "' WHERE id_cons = '" + idCons2.Text.Trim().ToString() + "'";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Failed! Syntax error, missing parameter or entry already existing! Check again!");
            }
            finally
            {
                oracleConnection.Close();
            }
        }

        private void idConsL2_Click(object sender, EventArgs e)
        {

        }

        private void idCons2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void applyButton4_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();

            listaData.Clear();
            listaOra.Clear();
            listaSpec.Clear();
            string cmd = "SELECT data_orar FROM Orar";
            OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
            OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
            while (myReader.Read())
            {
                string sname = myReader.GetDateTime(0).Date.ToString("d");
                listaData.Add(sname.ToString());
            }
            cmd = "SELECT ora_orar FROM Orar";
            cmddatabase = new OracleCommand(cmd, oracleConnection);
            myReader = cmddatabase.ExecuteReader();
            while (myReader.Read())
            {
                string sname = myReader.GetDecimal(0).ToString();
                listaOra.Add(sname.ToString());
            }
            cmd = "SELECT id_spec FROM Orar";
            cmddatabase = new OracleCommand(cmd, oracleConnection);
            myReader = cmddatabase.ExecuteReader();
            while (myReader.Read())
            {
                string sname = myReader.GetInt64(0).ToString();
                listaSpec.Add(sname.ToString());
            }

            OracleCommand command = oracleConnection.CreateCommand();
            OracleTransaction transaction;
            transaction = oracleConnection.BeginTransaction();
            command.Transaction = transaction;
            try 
            {
                command.CommandText = "DELETE FROM Orar " +
                    "WHERE id_orar in " +
                    "(SELECT o.id_orar FROM Orar o, Consultatie c " +
                    "WHERE c.id_spec = o.id_spec " +
                    "AND (SELECT TO_DATE(c.data_cons, 'rrrr/mm/dd') FROM Consultatie c WHERE c.id_cons = '" + idCons3.Text.Trim().ToString() + "') = TO_DATE(o.data_orar, 'rrrr/mm/dd') " +
                    "AND (SELECT TO_NUMBER(TO_CHAR(c.data_cons, 'hh24')) FROM Consultatie c WHERE c.id_cons = '" + idCons3.Text.Trim().ToString() + "') = o.ora_orar " +
                    "AND c.id_cons = '" + idCons3.Text.Trim().ToString() + "')";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM Consultatie WHERE id_cons = '" + idCons3.Text.Trim().ToString() + "'";
                command.ExecuteNonQuery();
                transaction.Commit(); 
            }
            catch (Exception ex) 
            {
                transaction.Rollback();
                MessageBox.Show("Failed! This record is either used by another table or doesn't exit! Check again!");
            }
            finally 
            {
                oracleConnection.Close();
            }
        }

        private void idConsL3_Click(object sender, EventArgs e)
        {

        }

        private void idCons3_SelectedIndexChanged(object sender, EventArgs e)
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

        private void numeSpecL_Click(object sender, EventArgs e)
        {

        }

        private void numeSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdSpecialist();
        }

        private void numePacL_Click(object sender, EventArgs e)
        {

        }

        private void numePac_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdPacient();
        }

        private void numePacL2_Click(object sender, EventArgs e)
        {

        }

        private void numePac2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdPacient();
        }

        private void idPacL2_Click(object sender, EventArgs e)
        {

        }

        private void idPac2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdConsultatie();
        }

        private void numePacL3_Click(object sender, EventArgs e)
        {

        }

        private void numePac3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdPacient();
        }

        private void idPacL3_Click(object sender, EventArgs e)
        {

        }

        private void idPac3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdConsultatie();
        }

        private void numeSpecL2_Click(object sender, EventArgs e)
        {

        }

        private void numeSpec2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdSpecialist();
        }

        private void idSpecL2_Click(object sender, EventArgs e)
        {

        }

        private void idSpec2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillNumePac();
        }
    }
}
