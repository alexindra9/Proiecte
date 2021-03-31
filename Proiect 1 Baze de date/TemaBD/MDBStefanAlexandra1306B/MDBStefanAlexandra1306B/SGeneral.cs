using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;


namespace MDBStefanAlexandra1306B
{
    public partial class SGeneral : Form
    {
        string c = "DATA SOURCE = XE;" + "PERSIST SECURITY INFO = True; USER ID = mous; password = Soyalover_3; Pooling = False;";
        OracleConnection oracleConnection = new OracleConnection();

        private void fillIdDepartament()
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                if (specialistsTab.SelectedTab == specialistsTab.TabPages["updatePage"])
                {
                    idModificat.Items.Clear();
                    idModificat.Text = "";
                    string cmd = "SELECT id_dept FROM Departament WHERE nume_dept = '" + numeDept2.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetInt64(0).ToString();
                        idModificat.Items.Add(sname.ToString());
                    }
                }
                else if (specialistsTab.SelectedTab == specialistsTab.TabPages["removePage"])
                {
                    idSters.Items.Clear();
                    idSters.Text = "";
                    string cmd = "SELECT id_dept FROM Departament WHERE nume_dept = '" + numeDept3.Text.Trim().ToString() + "'";
                    OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                    OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                    while (myReader.Read())
                    {
                        string sname = myReader.GetInt64(0).ToString();
                        idSters.Items.Add(sname.ToString());
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
                numeDept2.Items.Clear();
                numeDept3.Items.Clear();
                string cmd = "SELECT nume_dept FROM Departament";
                OracleCommand cmddatabase = new OracleCommand(cmd, oracleConnection);
                OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                while (myReader.Read())
                {
                    string sname = myReader.GetOracleString(0).ToString();
                    numeDept2.Items.Add(sname.ToString());
                    numeDept3.Items.Add(sname.ToString());
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

        public SGeneral()
        {
            InitializeComponent();
            CenterToScreen();
            fillNumeDept();
        }

        private void sGeneral_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                string select = "SELECT o.id_spec \"SId \", s.nume_spec \"Specialist \"" +
                    ", o.data_orar \"Date \", o.ora_orar \"Hour \" FROM Orar o, Specialist s WHERE o.id_spec = s.id_spec";
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
        private void insertPage_Click(object sender, EventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string insert = "INSERT INTO Departament(nume_dept, sef_de_sectie) " +
                    "VALUES('" + numeDept.Text.Trim().ToString() + "', '"
                    + sefSectie.Text.Trim().ToString() + "')";
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
            fillNumeDept();
        }

        private void numeDeptL_Click(object sender, EventArgs e)
        {

        }

        private void numeDept_TextChanged(object sender, EventArgs e)
        {

        }

        private void sefSectieL_Click(object sender, EventArgs e)
        {

        }

        private void sefSectie_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatePage_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string update = "UPDATE Departament SET " + columnChoice.Text.Trim().ToString() + " = '" + valueBox.Text.Trim().ToString() + "' WHERE id_dept = '" + idModificat.Text.Trim().ToString() + "'";
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
            fillNumeDept();
        }

        private void numeDeptL2_Click(object sender, EventArgs e)
        {

        }

        private void numeDept2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdDepartament();
        }

        private void idModificatL_Click(object sender, EventArgs e)
        {

        }

        private void idModificat_SelectedIndexChanged(object sender, EventArgs e)
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

        private void removePage_Click(object sender, EventArgs e)
        {
            
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string delete = "DELETE FROM Departament WHERE id_dept = '" + idSters.Text.Trim().ToString() + "'";
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
            fillNumeDept();
        }

        private void numeDeptL3_Click(object sender, EventArgs e)
        {

        }

        private void numeDept3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIdDepartament();
        }

        private void idStersL2_Click(object sender, EventArgs e)
        {

        }

        private void idSters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deptPage_Click(object sender, EventArgs e)
        {

        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            try
            {
                string select = "SELECT id_dept \"DId \", nume_dept \"Name \", sef_de_sectie \"Chief \" FROM Departament";
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(select, oracleConnection);
                DataTable d = new DataTable();
                oracleDataAdapter.Fill(d);
                dataGridView2.DataSource = d;
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
