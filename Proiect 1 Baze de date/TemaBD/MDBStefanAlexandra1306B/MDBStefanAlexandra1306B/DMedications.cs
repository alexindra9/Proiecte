using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace MDBStefanAlexandra1306B
{
    public partial class DMedications : Form
    {
        string c = "DATA SOURCE = XE;" + "PERSIST SECURITY INFO = True; USER ID = mous; password = Soyalover_3; Pooling = False;";
        OracleConnection oracleConnection = new OracleConnection();

        private void fillIdTratament()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                if (specialistsTab.SelectedTab == specialistsTab.TabPages["updatePage"])
                {
                    idTrat2.Items.Clear();
                    idTrat2.Text = "";
                    string cmd = "SELECT cod_trat FROM Tratament WHERE nume_trat = '" + numeTrat2.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetInt64(0).ToString();
                        idTrat2.Items.Add(sname.ToString());
                    }
                }
                else if (specialistsTab.SelectedTab == specialistsTab.TabPages["removePage"])
                {
                    idTrat3.Items.Clear();
                    idTrat3.Text = "";
                    string cmd = "SELECT cod_trat FROM Tratament WHERE nume_trat = '" + numeTrat3.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetInt64(0).ToString();
                        idTrat3.Items.Add(sname.ToString());
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

        private void fillIdInternare()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                idIntern.Items.Clear();
                string cmd = "SELECT id_intern FROM Internare";
                OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                while (myReader.Read())
                {
                    string sname = myReader.GetInt64(0).ToString();
                    idIntern.Items.Add(sname.ToString());
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

        private void fillNumeTrat()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                numeTrat2.Items.Clear();
                numeTrat3.Items.Clear();
                string cmd = "SELECT DISTINCT nume_trat FROM Tratament";
                OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                while (myReader.Read())
                {
                    string sname = myReader.GetString(0).ToString();
                    numeTrat2.Items.Add(sname.ToString());
                    numeTrat3.Items.Add(sname.ToString());
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

        public DMedications()
        {
            InitializeComponent();
            CenterToScreen();
            fillIdInternare();
            fillNumeTrat();
        }

        private void DMedications_Load(object sender, EventArgs e)
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
                string select = "SELECT cod_trat \"MId \", nume_trat \"Medication \"" +
                ", marca_trat \"Brand \", descriere_trat \"Description \", id_intern \"AId \", ora_admin \"Hour \"" +
                ", dozaj_zilnic \"Dosage \", per_admin \"Period \" FROM Tratament ORDER BY cod_trat";
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
                string insert = "INSERT INTO Tratament(nume_trat, marca_trat, descriere_trat, id_intern, ora_admin, dozaj_zilnic, per_admin) " +
                    "VALUES('" + numeTrat.Text.Trim().ToString() + "', '"
                    + marcaTrat.Text.Trim().ToString() + "', '"
                    + descrTrat.Text.Trim().ToString() + "', '"
                    + idIntern.Text.Trim().ToString() + "', '"
                    + oraAdm.Text.Trim().ToString() + "', '"
                    + doza.Text.Trim().ToString() + "', '"
                    + perioadaAdm.Text.Trim().ToString() + "')";
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
            fillNumeTrat();
        }

        private void idTratL_Click(object sender, EventArgs e)
        {

        }

        private void idTrat_TextChanged(object sender, EventArgs e)
        {

        }

        private void numeTratL_Click(object sender, EventArgs e)
        {

        }

        private void numeTrat_TextChanged(object sender, EventArgs e)
        {

        }

        private void marcaTratL_Click(object sender, EventArgs e)
        {

        }

        private void marcaTrat_TextChanged(object sender, EventArgs e)
        {

        }

        private void descrTratL_Click(object sender, EventArgs e)
        {

        }

        private void descrTrat_TextChanged(object sender, EventArgs e)
        {

        }
        private void idInternL_Click(object sender, EventArgs e)
        {

        }

        private void idIntern_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void oraAdmL_Click(object sender, EventArgs e)
        {

        }

        private void oraAdm_TextChanged(object sender, EventArgs e)
        {

        }

        private void dozaL_Click(object sender, EventArgs e)
        {

        }

        private void doza_TextChanged(object sender, EventArgs e)
        {

        }

        private void perioadaAdmL_Click(object sender, EventArgs e)
        {

        }

        private void perioadaAdm_TextChanged(object sender, EventArgs e)
        {

        }

        private void applyButton3_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string update = "UPDATE Tratament SET " + columnChoice.Text.Trim().ToString() + " = '" + valueBox.Text.Trim().ToString() + "' WHERE cod_trat = '" + idTrat2.Text.Trim().ToString() + "'";
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
            fillNumeTrat();
        }

        private void idTratL2_Click(object sender, EventArgs e)
        {

        }

        private void idTrat2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void applyButton4_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try 
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string delete = "DELETE FROM Tratament WHERE cod_trat = '" + idTrat3.Text.Trim().ToString() + "'";
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
            fillNumeTrat();
        }

        private void idTratL3_Click(object sender, EventArgs e)
        {

        }

        private void idTrat3_SelectedIndexChanged(object sender, EventArgs e)
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

        private void numeTratL2_Click(object sender, EventArgs e)
        {

        }

        private void numeTrat2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdTratament();
        }

        private void numeTratL3_Click(object sender, EventArgs e)
        {

        }

        private void numeTrat3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdTratament();
        }
    }
}
