using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace MDBStefanAlexandra1306B
{
    public partial class DSpecialists : Form
    {
        string c = "DATA SOURCE = XE;" + "PERSIST SECURITY INFO = True; USER ID = mous; password = Soyalover_3; Pooling = False;";
        OracleConnection oracleConnection = new OracleConnection();

        private void fillIdDept()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                idDept.Items.Clear();
                idDept.Text = "";
                string cmd = "SELECT id_dept FROM Departament WHERE nume_dept = '" + numeDept.Text.Trim().ToString() + "'";
                OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                while (myReader.Read())
                {
                    string sname = myReader.GetInt64(0).ToString();
                    idDept.Items.Add(sname.ToString());
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

        private void fillIdSpecialist()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                if (specialistsTab.SelectedTab == specialistsTab.TabPages["updatePage"])
                {
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
                else if (specialistsTab.SelectedTab == specialistsTab.TabPages["removePage"])
                {
                    idSpec3.Items.Clear();
                    idSpec3.Text = "";
                    string cmd = "SELECT id_spec FROM Specialist WHERE nume_spec = '" + numeSpec3.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetInt64(0).ToString();
                        idSpec3.Items.Add(sname.ToString());
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

        private void fillNumeDept()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                numeDept.Items.Clear();
                string cmd = "SELECT DISTINCT nume_dept FROM Departament";
                OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                while (myReader.Read())
                {
                    string sname = myReader.GetString(0).ToString();
                     numeDept.Items.Add(sname.ToString());
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
                numeSpec2.Items.Clear();
                numeSpec3.Items.Clear();
                string cmd = "SELECT DISTINCT nume_spec FROM Specialist";
                OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                while (myReader.Read())
                {
                    string sname = myReader.GetString(0).ToString();
                    numeSpec2.Items.Add(sname.ToString());
                    numeSpec3.Items.Add(sname.ToString());
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

        public DSpecialists()
        {
            InitializeComponent();
            CenterToScreen();
            fillNumeDept();
            fillNumeSpec();
        }

        private void DSpecialists_Load(object sender, EventArgs e)
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
                string select = "SELECT s.id_spec \"SId \", s.nume_spec \"Specialist \"" +
                ", s.email_spec \"Email \", s.tel_spec \"Phone \", s.salariu_spec \"Salary \", s.id_dept \"DId \"" +
                ", d.nume_dept \"Department \", d.sef_de_sectie \"Chief \" FROM Specialist s, Departament d " +
                "WHERE s.id_dept = d.id_dept ORDER BY s.id_spec";
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
                string insert = "INSERT INTO Specialist(nume_spec, email_spec, tel_spec, salariu_spec, id_dept) " +
                    "VALUES('" + numeSpec.Text.Trim().ToString() + "', '"
                    + emailSpec.Text.Trim().ToString() + "', '"
                    + telSpec.Text.Trim().ToString() + "', '"
                    + salariuSpec.Text.Trim().ToString() + "', '"
                    + idDept.Text.Trim().ToString() + "')";
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
            fillNumeSpec();
        }

        private void idSpecL_Click(object sender, EventArgs e)
        {

        }

        private void idSpec_TextChanged(object sender, EventArgs e)
        {

        }

        private void numeSpecL_Click(object sender, EventArgs e)
        {

        }

        private void numeSpec_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailSpecL_Click(object sender, EventArgs e)
        {

        }

        private void emailSpec_TextChanged(object sender, EventArgs e)
        {

        }

        private void telSpecL_Click(object sender, EventArgs e)
        {

        }

        private void telSpec_TextChanged(object sender, EventArgs e)
        {

        }

        private void salariuSpecL_Click(object sender, EventArgs e)
        {

        }

        private void salariuSpec_TextChanged(object sender, EventArgs e)
        {

        }

        private void idDeptL_Click(object sender, EventArgs e)
        {

        }

        private void idDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void applyButton3_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string update = "UPDATE Specialist SET " + columnChoice.Text.Trim().ToString() + " = '" + valueBox.Text.Trim().ToString() + "' WHERE id_spec = '" + idSpec2.Text.Trim().ToString() + "'";
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
            fillNumeSpec();
        }

        private void idSpecL2_Click(object sender, EventArgs e)
        {

        }

        private void idSpec2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void applyButton4_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try 
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string delete = "DELETE FROM Specialist WHERE id_spec = '" + idSpec3.Text.Trim().ToString() + "'";
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
            fillNumeSpec();
        }

        private void idSpecL3_Click(object sender, EventArgs e)
        {

        }

        private void idSpec3_SelectedIndexChanged(object sender, EventArgs e)
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

        private void numeDeptL_Click(object sender, EventArgs e)
        {

        }

        private void numeDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdDept();
        }

        private void numeSpecL2_Click(object sender, EventArgs e)
        {

        }

        private void numeSpec2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdSpecialist();
        }

        private void numeSpecL3_Click(object sender, EventArgs e)
        {

        }

        private void numeSpec3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdSpecialist();
        }
    }
}
