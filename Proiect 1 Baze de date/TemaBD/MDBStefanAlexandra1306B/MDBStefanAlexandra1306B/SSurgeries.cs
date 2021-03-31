using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace MDBStefanAlexandra1306B
{
    public partial class SSurgeries : Form
    {
        string c = "DATA SOURCE = XE;" + "PERSIST SECURITY INFO = True; USER ID = mous; password = Soyalover_3; Pooling = False;";
        OracleConnection oracleConnection = new OracleConnection();

        List<String> listaSpec = new List<string>();
        List<String> listaData = new List<string>();
        List<String> listaOra = new List<string>();

        private void fillIdSpec()
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
                    idPacient2.Items.Clear();
                    idPacient2.Text = "";
                    string cmd = "SELECT cod_asig FROM Pacient WHERE nume_pac = '" + numePac2.Text.Trim().ToString() + "'";
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
                    string cmd = "SELECT cod_asig FROM Pacient WHERE nume_pac = '" + numePac3.Text.Trim().ToString() + "'";
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

        private void fillIdConsultatie()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                idCons.Items.Clear();
                idCons.Text = "";
                string cmd = "SELECT id_cons FROM Consultatie WHERE cod_asig = '" + idPacient.Text.Trim().ToString() + "'";
                OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                while (myReader.Read())
                {
                    string sname = myReader.GetInt64(0).ToString();
                    idCons.Items.Add(sname.ToString());
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

        private void fillIdInterventie()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {              
                if (specialistsTab.SelectedTab == specialistsTab.TabPages["updatePage"])
                {
                    idInterventie2.Items.Clear();
                    idInterventie2.Text = "";
                    string cmd = "SELECT id_interv FROM Interventie WHERE nume_interv = '" + numeInterventie2.Text.Trim().ToString() + "'";
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
                    string cmd = "SELECT id_interv FROM Interventie WHERE nume_interv = '" + numeInterventie3.Text.Trim().ToString() + "'";
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
                    string cmd = "SELECT DISTINCT p.nume_pac FROM Pacient p, Interventie i, Specialist s " +
                        "WHERE s.id_spec = '" + idSpec2.Text.Trim().ToString() + "' " +
                        "AND s.id_spec = i.id_spec " +
                        "AND i.cod_asig = p.cod_asig";
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
                    string cmd = "SELECT nume_pac FROM Pacient";
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

        private void fillNumeInterventie()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                if (specialistsTab.SelectedTab == specialistsTab.TabPages["updatePage"])
                {
                    numeInterventie2.Items.Clear();
                    numeInterventie2.Text = "";
                    string cmd = "SELECT nume_interv FROM Interventie WHERE cod_asig = '" + idPacient2.Text.Trim().ToString() + "' " +
                        "AND id_spec = " + idSpec2.Text.Trim().ToString();
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetOracleString(0).ToString();
                        numeInterventie2.Items.Add(sname.ToString());
                    }
                }
                else if (specialistsTab.SelectedTab == specialistsTab.TabPages["removePage"])
                {
                    numeInterventie3.Items.Clear();
                    numeInterventie3.Text = "";
                    string cmd = "SELECT nume_interv FROM Interventie WHERE cod_asig = '" + idPacient3.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetOracleString(0).ToString();
                        numeInterventie3.Items.Add(sname.ToString());
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

        public SSurgeries()
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

        private void SSurgeries_Load(object sender, EventArgs e)
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
                    ", b.cod_asig \"PId \", b.nume_pac \"Pacient \", c.id_interv \"IId \", c.nume_interv \"Intervention \"" +
                    ", c.data_interv \"Beginning \", c.data_final \"End \", c.cost_total \"Cost \", c.nr_sala \"OR \" " +
                    "FROM Specialist a, Pacient b, Interventie c WHERE a.id_spec = c.id_spec " +
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
                    if (listaSpec[i] == idSpec.Text.Trim().ToString() && listaData[i] == Convert.ToDateTime(DateTime.Parse(dataInterv.Text.Trim().ToString())).Date.ToString("d") && listaOra[i] == Convert.ToDecimal(TimeSpan.Parse(dataInterv.Text.Trim().Substring(10, 8).ToString()).TotalHours).ToString())
                    {
                        MessageBox.Show("Date already occupied!");
                        return;
                    }
                }
                command.CommandText = "INSERT INTO Orar(id_spec, data_orar, ora_orar) " +
                    "VALUES('" + idSpec.Text.Trim().ToString() + "', TO_DATE(TO_DATE('"
                    + dataInterv.Text.Trim().ToString() + "', 'rrrr/mm/dd hh24:mi:ss'), 'dd/mm/rrrr'), TO_NUMBER(TO_CHAR(TO_DATE('"
                    + dataInterv.Text.Trim().ToString() + "', 'rrrr/mm/dd hh24:mi:ss'), 'hh24')))";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Interventie(nume_interv, data_interv, data_final, cost_total, nr_sala, id_spec, cod_asig, id_cons) " +
                    "VALUES('" + numeInterventie.Text.Trim().ToString() + "', TO_DATE('"
                    + dataInterv.Text.Trim().ToString() + "', 'rrrr/mm/dd hh24:mi:ss'), TO_DATE('"
                    + dataFinal.Text.Trim().ToString() + "', 'rrrr/mm/dd hh24:mi:ss'), '"
                    + cost.Text.Trim().ToString() + "', '"
                    + nrSala.Text.Trim().ToString() + "', '"
                    + idSpec.Text.Trim().ToString() + "', '"
                    + idPacient.Text.Trim().ToString() + "', '"
                    + idCons.Text.Trim().ToString() + "')";
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

        private void idInterventieL_Click(object sender, EventArgs e)
        {

        }

        private void idInterventie_TextChanged(object sender, EventArgs e)
        {

        }

        private void numeInterventieL_Click(object sender, EventArgs e)
        {

        }

        private void numeInterventie_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataIntervL_Click(object sender, EventArgs e)
        {

        }

        private void dataInterv_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataFinalL_Click(object sender, EventArgs e)
        {

        }

        private void dataFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void costL_Click(object sender, EventArgs e)
        {

        }

        private void cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void nrSalaL_Click(object sender, EventArgs e)
        {

        }

        private void nrSala_TextChanged(object sender, EventArgs e)
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
            fillIdConsultatie();
        }

        private void idConsL_Click(object sender, EventArgs e)
        {

        }

        private void idCons_SelectedIndexChanged(object sender, EventArgs e)
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
                if (columnChoice.Text.Trim().ToString() == "data_interv")
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
                        "WHERE id_orar in (SELECT o.id_orar FROM Orar o, Interventie i " +
                        "WHERE i.id_interv = '" + idInterventie2.Text.Trim().ToString() + "' " +
                        "AND i.id_spec = o.id_spec " +
                        "AND (SELECT TO_DATE(i.data_interv, 'rrrr/mm/dd') FROM Interventie i WHERE i.id_interv = '" + idInterventie2.Text.Trim().ToString() + "') = TO_DATE(o.data_orar, 'rrrr/mm/dd') " +
                        "AND (SELECT TO_NUMBER(TO_CHAR(i.data_interv, 'hh24')) FROM Interventie i WHERE i.id_interv = '" + idInterventie2.Text.Trim().ToString() + "') = o.ora_orar)";
                    command.ExecuteNonQuery();
                    command.CommandText = "UPDATE Interventie SET " + columnChoice.Text.Trim().ToString() + " = TO_DATE('" + valueBox.Text.Trim().ToString() + "', 'rrrr/mm/dd hh24:mi:ss') WHERE id_interv = '" + idInterventie2.Text.Trim().ToString() + "'";
                    command.ExecuteNonQuery();
                    command.CommandText = "UPDATE Orar SET ora_orar = TO_NUMBER(TO_CHAR(TO_DATE('" +
                        valueBox.Text.Trim().ToString() + "', 'rrrr/mm/dd hh24:mi:ss'), 'hh24')) " +
                        "WHERE id_orar in (SELECT o.id_orar FROM Orar o, Interventie i " +
                        "WHERE i.id_interv = '" + idInterventie2.Text.Trim().ToString() + "' " +
                        "AND i.id_spec = o.id_spec " +
                        "AND (SELECT TO_DATE(i.data_interv, 'rrrr/mm/dd') FROM Interventie i WHERE i.id_interv = '" + idInterventie2.Text.Trim().ToString() + "') = TO_DATE(o.data_orar, 'rrrr/mm/dd'))";
                    command.ExecuteNonQuery();
                    command.CommandText = "UPDATE Interventie SET " + columnChoice.Text.Trim().ToString() + " = TO_DATE('" + valueBox.Text.Trim().ToString() + "', 'rrrr/mm/dd hh24:mi:ss') WHERE id_interv = '" + idInterventie2.Text.Trim().ToString() + "'";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                else if (columnChoice.Text.Trim().ToString() == "id_spec")
                {
                    command.CommandText = "UPDATE Orar SET " + columnChoice.Text.Trim().ToString() + " = '" +
                        valueBox.Text.Trim().ToString() + "' " +
                        "WHERE id_orar in (SELECT o.id_orar FROM Orar o, Interventie i " +
                        " WHERE i.id_spec = o.id_spec " +
                        " AND (SELECT TO_DATE(i.data_interv, 'rrrr/mm/dd') FROM Interventie i WHERE i.id_interv = '" + idInterventie2.Text.Trim().ToString() + "') = TO_DATE(o.data_orar, 'rrrr/mm/dd') " +
                        " AND (SELECT TO_NUMBER(TO_CHAR(i.data_interv, 'hh24')) FROM Interventie i WHERE i.id_interv = '" + idInterventie2.Text.Trim().ToString() + "') = o.ora_orar " +
                        " AND i.id_interv = '" + idInterventie2.Text.Trim().ToString() + "')";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    command.CommandText = "UPDATE Interventie SET " + columnChoice.Text.Trim().ToString() + " = '" + valueBox.Text.Trim().ToString() + "' WHERE id_interv = '" + idInterventie2.Text.Trim().ToString() + "'";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                else if (columnChoice.Text.Trim().ToString() == "data_final")
                {
                    command.CommandText = "UPDATE Interventie SET " + columnChoice.Text.Trim().ToString() + " = TO_DATE('" + valueBox.Text.Trim().ToString() + "', 'rrrr/mm/dd hh24:mi:ss') WHERE id_interv = '" + idInterventie2.Text.Trim().ToString() + "'";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                else
                {
                    command.CommandText = "UPDATE Interventie SET " + columnChoice.Text.Trim().ToString() + " = '" + valueBox.Text.Trim().ToString() + "' WHERE id_interv = '" + idInterventie2.Text.Trim().ToString() + "'";
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

        private void idInterventieL2_Click(object sender, EventArgs e)
        {

        }

        private void idInterventie2_SelectedIndexChanged(object sender, EventArgs e)
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
                    "(SELECT o.id_orar FROM Orar o, Interventie i " +
                    "WHERE i.id_spec = i.id_spec " +
                    "AND (SELECT TO_DATE(i.data_interv, 'rrrr/mm/dd') FROM Interventie i WHERE i.id_interv = '" + idInterventie3.Text.Trim().ToString() + "') = TO_DATE(o.data_orar, 'rrrr/mm/dd') " +
                    "AND (SELECT TO_NUMBER(TO_CHAR(i.data_interv, 'HH24')) FROM Interventie i WHERE i.id_interv = '" + idInterventie3.Text.Trim().ToString() + "') = o.ora_orar " +
                    "AND i.id_interv = '" + idInterventie3.Text.Trim().ToString() + "')";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM Interventie WHERE id_interv = '" + idInterventie3.Text.Trim().ToString() + "'";
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

        private void idInterventieL3_Click(object sender, EventArgs e)
        {

        }

        private void idInterventie3_SelectedIndexChanged(object sender, EventArgs e)
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
            fillIdSpec();
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

        private void idPacientL2_Click(object sender, EventArgs e)
        {

        }

        private void idPacient2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillNumeInterventie();
        }

        private void numeInterventieL2_Click(object sender, EventArgs e)
        {

        }

        private void numeInterventie2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdInterventie();
        }

        private void numePacL3_Click(object sender, EventArgs e)
        {

        }

        private void numePac3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdPacient();
        }

        private void idPacientL3_Click(object sender, EventArgs e)
        {

        }

        private void idPacient3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillNumeInterventie();
        }

        private void numeInterventieL3_Click(object sender, EventArgs e)
        {

        }

        private void numeInterventie3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdInterventie();
        }

        private void numeSpecL2_Click(object sender, EventArgs e)
        {

        }

        private void numeSpec2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdSpec();
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
