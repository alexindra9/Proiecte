
namespace MDBStefanAlexandra1306B
{
    partial class SConsultations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SConsultations));
            this.backButton = new System.Windows.Forms.Button();
            this.specialistsTab = new System.Windows.Forms.TabControl();
            this.viewPage = new System.Windows.Forms.TabPage();
            this.applyButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertPage = new System.Windows.Forms.TabPage();
            this.numePac = new System.Windows.Forms.ComboBox();
            this.numeSpec = new System.Windows.Forms.ComboBox();
            this.numePacL = new System.Windows.Forms.Label();
            this.numeSpecL = new System.Windows.Forms.Label();
            this.idPacient = new System.Windows.Forms.ComboBox();
            this.idSpec = new System.Windows.Forms.ComboBox();
            this.applyButton2 = new System.Windows.Forms.Button();
            this.nrCab = new System.Windows.Forms.TextBox();
            this.nrCabL = new System.Windows.Forms.Label();
            this.idPacientL = new System.Windows.Forms.Label();
            this.idSpecL = new System.Windows.Forms.Label();
            this.dataCons = new System.Windows.Forms.TextBox();
            this.dataConsL = new System.Windows.Forms.Label();
            this.idCons = new System.Windows.Forms.TextBox();
            this.idConsL = new System.Windows.Forms.Label();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.numePac2 = new System.Windows.Forms.ComboBox();
            this.numePacL2 = new System.Windows.Forms.Label();
            this.idPac2 = new System.Windows.Forms.ComboBox();
            this.idPacL2 = new System.Windows.Forms.Label();
            this.idCons2 = new System.Windows.Forms.ComboBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.columnChoice = new System.Windows.Forms.ComboBox();
            this.applyButton3 = new System.Windows.Forms.Button();
            this.columnL = new System.Windows.Forms.Label();
            this.idConsL2 = new System.Windows.Forms.Label();
            this.removePage = new System.Windows.Forms.TabPage();
            this.numePac3 = new System.Windows.Forms.ComboBox();
            this.numePacL3 = new System.Windows.Forms.Label();
            this.idPac3 = new System.Windows.Forms.ComboBox();
            this.idPacL3 = new System.Windows.Forms.Label();
            this.idCons3 = new System.Windows.Forms.ComboBox();
            this.applyButton4 = new System.Windows.Forms.Button();
            this.idConsL3 = new System.Windows.Forms.Label();
            this.numeSpec2 = new System.Windows.Forms.ComboBox();
            this.numeSpecL2 = new System.Windows.Forms.Label();
            this.idSpec2 = new System.Windows.Forms.ComboBox();
            this.idSpecL2 = new System.Windows.Forms.Label();
            this.specialistsTab.SuspendLayout();
            this.viewPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.insertPage.SuspendLayout();
            this.updatePage.SuspendLayout();
            this.removePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(176)))), ((int)(((byte)(246)))));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(0, 580);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(225, 60);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // specialistsTab
            // 
            this.specialistsTab.Controls.Add(this.viewPage);
            this.specialistsTab.Controls.Add(this.insertPage);
            this.specialistsTab.Controls.Add(this.updatePage);
            this.specialistsTab.Controls.Add(this.removePage);
            this.specialistsTab.ItemSize = new System.Drawing.Size(74, 25);
            this.specialistsTab.Location = new System.Drawing.Point(225, 0);
            this.specialistsTab.Name = "specialistsTab";
            this.specialistsTab.SelectedIndex = 0;
            this.specialistsTab.Size = new System.Drawing.Size(958, 653);
            this.specialistsTab.TabIndex = 23;
            this.specialistsTab.SelectedIndexChanged += new System.EventHandler(this.specialistsTab_SelectedIndexChanged);
            // 
            // viewPage
            // 
            this.viewPage.Controls.Add(this.applyButton);
            this.viewPage.Controls.Add(this.dataGridView1);
            this.viewPage.Location = new System.Drawing.Point(4, 29);
            this.viewPage.Name = "viewPage";
            this.viewPage.Padding = new System.Windows.Forms.Padding(3);
            this.viewPage.Size = new System.Drawing.Size(950, 620);
            this.viewPage.TabIndex = 0;
            this.viewPage.Text = "View";
            this.viewPage.UseVisualStyleBackColor = true;
            this.viewPage.Click += new System.EventHandler(this.viewPage_Click);
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton.Location = new System.Drawing.Point(857, 5);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(94, 29);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(947, 579);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // insertPage
            // 
            this.insertPage.Controls.Add(this.numePac);
            this.insertPage.Controls.Add(this.numeSpec);
            this.insertPage.Controls.Add(this.numePacL);
            this.insertPage.Controls.Add(this.numeSpecL);
            this.insertPage.Controls.Add(this.idPacient);
            this.insertPage.Controls.Add(this.idSpec);
            this.insertPage.Controls.Add(this.applyButton2);
            this.insertPage.Controls.Add(this.nrCab);
            this.insertPage.Controls.Add(this.nrCabL);
            this.insertPage.Controls.Add(this.idPacientL);
            this.insertPage.Controls.Add(this.idSpecL);
            this.insertPage.Controls.Add(this.dataCons);
            this.insertPage.Controls.Add(this.dataConsL);
            this.insertPage.Controls.Add(this.idCons);
            this.insertPage.Controls.Add(this.idConsL);
            this.insertPage.Location = new System.Drawing.Point(4, 29);
            this.insertPage.Name = "insertPage";
            this.insertPage.Padding = new System.Windows.Forms.Padding(3);
            this.insertPage.Size = new System.Drawing.Size(950, 620);
            this.insertPage.TabIndex = 1;
            this.insertPage.Text = "Insert";
            this.insertPage.UseVisualStyleBackColor = true;
            this.insertPage.Click += new System.EventHandler(this.insertPage_Click);
            // 
            // numePac
            // 
            this.numePac.FormattingEnabled = true;
            this.numePac.Location = new System.Drawing.Point(305, 416);
            this.numePac.Name = "numePac";
            this.numePac.Size = new System.Drawing.Size(170, 28);
            this.numePac.TabIndex = 48;
            this.numePac.SelectedIndexChanged += new System.EventHandler(this.numePac_SelectedIndexChanged);
            // 
            // numeSpec
            // 
            this.numeSpec.FormattingEnabled = true;
            this.numeSpec.Location = new System.Drawing.Point(305, 312);
            this.numeSpec.Name = "numeSpec";
            this.numeSpec.Size = new System.Drawing.Size(170, 28);
            this.numeSpec.TabIndex = 47;
            this.numeSpec.SelectedIndexChanged += new System.EventHandler(this.numeSpec_SelectedIndexChanged);
            // 
            // numePacL
            // 
            this.numePacL.AutoSize = true;
            this.numePacL.Location = new System.Drawing.Point(111, 416);
            this.numePacL.Name = "numePacL";
            this.numePacL.Size = new System.Drawing.Size(97, 20);
            this.numePacL.TabIndex = 46;
            this.numePacL.Text = "Pacient name";
            this.numePacL.Click += new System.EventHandler(this.numePacL_Click);
            // 
            // numeSpecL
            // 
            this.numeSpecL.AutoSize = true;
            this.numeSpecL.Location = new System.Drawing.Point(111, 312);
            this.numeSpecL.Name = "numeSpecL";
            this.numeSpecL.Size = new System.Drawing.Size(113, 20);
            this.numeSpecL.TabIndex = 45;
            this.numeSpecL.Text = "Specialist name";
            this.numeSpecL.Click += new System.EventHandler(this.numeSpecL_Click);
            // 
            // idPacient
            // 
            this.idPacient.FormattingEnabled = true;
            this.idPacient.Location = new System.Drawing.Point(704, 416);
            this.idPacient.Name = "idPacient";
            this.idPacient.Size = new System.Drawing.Size(170, 28);
            this.idPacient.TabIndex = 44;
            this.idPacient.SelectedIndexChanged += new System.EventHandler(this.idPacient_SelectedIndexChanged);
            // 
            // idSpec
            // 
            this.idSpec.FormattingEnabled = true;
            this.idSpec.Location = new System.Drawing.Point(704, 312);
            this.idSpec.Name = "idSpec";
            this.idSpec.Size = new System.Drawing.Size(170, 28);
            this.idSpec.TabIndex = 43;
            this.idSpec.SelectedIndexChanged += new System.EventHandler(this.idSpec_SelectedIndexChanged);
            // 
            // applyButton2
            // 
            this.applyButton2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton2.Location = new System.Drawing.Point(857, 5);
            this.applyButton2.Name = "applyButton2";
            this.applyButton2.Size = new System.Drawing.Size(94, 29);
            this.applyButton2.TabIndex = 42;
            this.applyButton2.Text = "Apply";
            this.applyButton2.UseVisualStyleBackColor = false;
            this.applyButton2.Click += new System.EventHandler(this.applyButton2_Click);
            // 
            // nrCab
            // 
            this.nrCab.Location = new System.Drawing.Point(305, 520);
            this.nrCab.Name = "nrCab";
            this.nrCab.Size = new System.Drawing.Size(170, 27);
            this.nrCab.TabIndex = 37;
            this.nrCab.TextChanged += new System.EventHandler(this.nrCab_TextChanged);
            // 
            // nrCabL
            // 
            this.nrCabL.AutoSize = true;
            this.nrCabL.Location = new System.Drawing.Point(111, 520);
            this.nrCabL.Name = "nrCabL";
            this.nrCabL.Size = new System.Drawing.Size(104, 20);
            this.nrCabL.TabIndex = 36;
            this.nrCabL.Text = "Room number";
            this.nrCabL.Click += new System.EventHandler(this.nrCabL_Click);
            // 
            // idPacientL
            // 
            this.idPacientL.AutoSize = true;
            this.idPacientL.Location = new System.Drawing.Point(510, 416);
            this.idPacientL.Name = "idPacientL";
            this.idPacientL.Size = new System.Drawing.Size(73, 20);
            this.idPacientL.TabIndex = 34;
            this.idPacientL.Text = "Pacient Id";
            this.idPacientL.Click += new System.EventHandler(this.idPacientL_Click);
            // 
            // idSpecL
            // 
            this.idSpecL.AutoSize = true;
            this.idSpecL.Location = new System.Drawing.Point(510, 312);
            this.idSpecL.Name = "idSpecL";
            this.idSpecL.Size = new System.Drawing.Size(89, 20);
            this.idSpecL.TabIndex = 32;
            this.idSpecL.Text = "Specialist Id";
            this.idSpecL.Click += new System.EventHandler(this.idSpecL_Click);
            // 
            // dataCons
            // 
            this.dataCons.Location = new System.Drawing.Point(305, 208);
            this.dataCons.Name = "dataCons";
            this.dataCons.Size = new System.Drawing.Size(170, 27);
            this.dataCons.TabIndex = 31;
            this.dataCons.TextChanged += new System.EventHandler(this.dataCons_TextChanged);
            // 
            // dataConsL
            // 
            this.dataConsL.AutoSize = true;
            this.dataConsL.Location = new System.Drawing.Point(111, 208);
            this.dataConsL.Name = "dataConsL";
            this.dataConsL.Size = new System.Drawing.Size(97, 20);
            this.dataConsL.TabIndex = 30;
            this.dataConsL.Text = "Appointment";
            this.dataConsL.Click += new System.EventHandler(this.dataConsL_Click);
            // 
            // idCons
            // 
            this.idCons.Enabled = false;
            this.idCons.Location = new System.Drawing.Point(305, 104);
            this.idCons.Name = "idCons";
            this.idCons.Size = new System.Drawing.Size(170, 27);
            this.idCons.TabIndex = 29;
            this.idCons.TextChanged += new System.EventHandler(this.idCons_TextChanged);
            // 
            // idConsL
            // 
            this.idConsL.AutoSize = true;
            this.idConsL.Enabled = false;
            this.idConsL.Location = new System.Drawing.Point(111, 104);
            this.idConsL.Name = "idConsL";
            this.idConsL.Size = new System.Drawing.Size(22, 20);
            this.idConsL.TabIndex = 28;
            this.idConsL.Text = "Id";
            this.idConsL.Click += new System.EventHandler(this.idConsL_Click);
            // 
            // updatePage
            // 
            this.updatePage.Controls.Add(this.numeSpec2);
            this.updatePage.Controls.Add(this.numeSpecL2);
            this.updatePage.Controls.Add(this.idSpec2);
            this.updatePage.Controls.Add(this.idSpecL2);
            this.updatePage.Controls.Add(this.numePac2);
            this.updatePage.Controls.Add(this.numePacL2);
            this.updatePage.Controls.Add(this.idPac2);
            this.updatePage.Controls.Add(this.idPacL2);
            this.updatePage.Controls.Add(this.idCons2);
            this.updatePage.Controls.Add(this.valueBox);
            this.updatePage.Controls.Add(this.columnChoice);
            this.updatePage.Controls.Add(this.applyButton3);
            this.updatePage.Controls.Add(this.columnL);
            this.updatePage.Controls.Add(this.idConsL2);
            this.updatePage.Location = new System.Drawing.Point(4, 29);
            this.updatePage.Name = "updatePage";
            this.updatePage.Size = new System.Drawing.Size(950, 620);
            this.updatePage.TabIndex = 2;
            this.updatePage.Text = "Update";
            this.updatePage.UseVisualStyleBackColor = true;
            this.updatePage.Click += new System.EventHandler(this.updatePage_Click);
            // 
            // numePac2
            // 
            this.numePac2.FormattingEnabled = true;
            this.numePac2.Location = new System.Drawing.Point(305, 208);
            this.numePac2.Name = "numePac2";
            this.numePac2.Size = new System.Drawing.Size(170, 28);
            this.numePac2.TabIndex = 54;
            this.numePac2.SelectedIndexChanged += new System.EventHandler(this.numePac2_SelectedIndexChanged);
            // 
            // numePacL2
            // 
            this.numePacL2.AutoSize = true;
            this.numePacL2.Location = new System.Drawing.Point(111, 208);
            this.numePacL2.Name = "numePacL2";
            this.numePacL2.Size = new System.Drawing.Size(97, 20);
            this.numePacL2.TabIndex = 53;
            this.numePacL2.Text = "Pacient name";
            this.numePacL2.Click += new System.EventHandler(this.numePacL2_Click);
            // 
            // idPac2
            // 
            this.idPac2.FormattingEnabled = true;
            this.idPac2.Location = new System.Drawing.Point(704, 208);
            this.idPac2.Name = "idPac2";
            this.idPac2.Size = new System.Drawing.Size(170, 28);
            this.idPac2.TabIndex = 52;
            this.idPac2.SelectedIndexChanged += new System.EventHandler(this.idPac2_SelectedIndexChanged);
            // 
            // idPacL2
            // 
            this.idPacL2.AutoSize = true;
            this.idPacL2.Location = new System.Drawing.Point(510, 208);
            this.idPacL2.Name = "idPacL2";
            this.idPacL2.Size = new System.Drawing.Size(73, 20);
            this.idPacL2.TabIndex = 51;
            this.idPacL2.Text = "Pacient Id";
            this.idPacL2.Click += new System.EventHandler(this.idPacL2_Click);
            // 
            // idCons2
            // 
            this.idCons2.FormattingEnabled = true;
            this.idCons2.Location = new System.Drawing.Point(305, 312);
            this.idCons2.Name = "idCons2";
            this.idCons2.Size = new System.Drawing.Size(170, 28);
            this.idCons2.TabIndex = 50;
            this.idCons2.SelectedIndexChanged += new System.EventHandler(this.idCons2_SelectedIndexChanged);
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(704, 416);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(170, 27);
            this.valueBox.TabIndex = 49;
            this.valueBox.TextChanged += new System.EventHandler(this.valueBox_TextChanged);
            // 
            // columnChoice
            // 
            this.columnChoice.FormattingEnabled = true;
            this.columnChoice.Items.AddRange(new object[] {
            "data_cons",
            "nr_cab",
            "id_spec",
            "cod_asig"});
            this.columnChoice.Location = new System.Drawing.Point(305, 416);
            this.columnChoice.Name = "columnChoice";
            this.columnChoice.Size = new System.Drawing.Size(170, 28);
            this.columnChoice.TabIndex = 48;
            this.columnChoice.SelectedIndexChanged += new System.EventHandler(this.columnChoice_SelectedIndexChanged);
            // 
            // applyButton3
            // 
            this.applyButton3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton3.Location = new System.Drawing.Point(857, 5);
            this.applyButton3.Name = "applyButton3";
            this.applyButton3.Size = new System.Drawing.Size(94, 29);
            this.applyButton3.TabIndex = 47;
            this.applyButton3.Text = "Apply";
            this.applyButton3.UseVisualStyleBackColor = false;
            this.applyButton3.Click += new System.EventHandler(this.applyButton3_Click);
            // 
            // columnL
            // 
            this.columnL.AutoSize = true;
            this.columnL.Location = new System.Drawing.Point(111, 416);
            this.columnL.Name = "columnL";
            this.columnL.Size = new System.Drawing.Size(60, 20);
            this.columnL.TabIndex = 45;
            this.columnL.Text = "Column";
            this.columnL.Click += new System.EventHandler(this.columnL_Click);
            // 
            // idConsL2
            // 
            this.idConsL2.AutoSize = true;
            this.idConsL2.Location = new System.Drawing.Point(111, 312);
            this.idConsL2.Name = "idConsL2";
            this.idConsL2.Size = new System.Drawing.Size(22, 20);
            this.idConsL2.TabIndex = 43;
            this.idConsL2.Text = "Id";
            this.idConsL2.Click += new System.EventHandler(this.idConsL2_Click);
            // 
            // removePage
            // 
            this.removePage.Controls.Add(this.numePac3);
            this.removePage.Controls.Add(this.numePacL3);
            this.removePage.Controls.Add(this.idPac3);
            this.removePage.Controls.Add(this.idPacL3);
            this.removePage.Controls.Add(this.idCons3);
            this.removePage.Controls.Add(this.applyButton4);
            this.removePage.Controls.Add(this.idConsL3);
            this.removePage.Location = new System.Drawing.Point(4, 29);
            this.removePage.Name = "removePage";
            this.removePage.Size = new System.Drawing.Size(950, 620);
            this.removePage.TabIndex = 3;
            this.removePage.Text = "Remove";
            this.removePage.UseVisualStyleBackColor = true;
            this.removePage.Click += new System.EventHandler(this.removePage_Click);
            // 
            // numePac3
            // 
            this.numePac3.FormattingEnabled = true;
            this.numePac3.Location = new System.Drawing.Point(305, 104);
            this.numePac3.Name = "numePac3";
            this.numePac3.Size = new System.Drawing.Size(170, 28);
            this.numePac3.TabIndex = 58;
            this.numePac3.SelectedIndexChanged += new System.EventHandler(this.numePac3_SelectedIndexChanged);
            // 
            // numePacL3
            // 
            this.numePacL3.AutoSize = true;
            this.numePacL3.Location = new System.Drawing.Point(111, 104);
            this.numePacL3.Name = "numePacL3";
            this.numePacL3.Size = new System.Drawing.Size(97, 20);
            this.numePacL3.TabIndex = 57;
            this.numePacL3.Text = "Pacient name";
            this.numePacL3.Click += new System.EventHandler(this.numePacL3_Click);
            // 
            // idPac3
            // 
            this.idPac3.FormattingEnabled = true;
            this.idPac3.Location = new System.Drawing.Point(704, 104);
            this.idPac3.Name = "idPac3";
            this.idPac3.Size = new System.Drawing.Size(170, 28);
            this.idPac3.TabIndex = 56;
            this.idPac3.SelectedIndexChanged += new System.EventHandler(this.idPac3_SelectedIndexChanged);
            // 
            // idPacL3
            // 
            this.idPacL3.AutoSize = true;
            this.idPacL3.Location = new System.Drawing.Point(510, 104);
            this.idPacL3.Name = "idPacL3";
            this.idPacL3.Size = new System.Drawing.Size(73, 20);
            this.idPacL3.TabIndex = 55;
            this.idPacL3.Text = "Pacient Id";
            this.idPacL3.Click += new System.EventHandler(this.idPacL3_Click);
            // 
            // idCons3
            // 
            this.idCons3.FormattingEnabled = true;
            this.idCons3.Location = new System.Drawing.Point(305, 208);
            this.idCons3.Name = "idCons3";
            this.idCons3.Size = new System.Drawing.Size(170, 28);
            this.idCons3.TabIndex = 51;
            this.idCons3.SelectedIndexChanged += new System.EventHandler(this.idCons3_SelectedIndexChanged);
            // 
            // applyButton4
            // 
            this.applyButton4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton4.Location = new System.Drawing.Point(857, 5);
            this.applyButton4.Name = "applyButton4";
            this.applyButton4.Size = new System.Drawing.Size(94, 29);
            this.applyButton4.TabIndex = 50;
            this.applyButton4.Text = "Apply";
            this.applyButton4.UseVisualStyleBackColor = false;
            this.applyButton4.Click += new System.EventHandler(this.applyButton4_Click);
            // 
            // idConsL3
            // 
            this.idConsL3.AutoSize = true;
            this.idConsL3.Location = new System.Drawing.Point(111, 208);
            this.idConsL3.Name = "idConsL3";
            this.idConsL3.Size = new System.Drawing.Size(22, 20);
            this.idConsL3.TabIndex = 48;
            this.idConsL3.Text = "Id";
            this.idConsL3.Click += new System.EventHandler(this.idConsL3_Click);
            // 
            // numeSpec2
            // 
            this.numeSpec2.FormattingEnabled = true;
            this.numeSpec2.Location = new System.Drawing.Point(305, 104);
            this.numeSpec2.Name = "numeSpec2";
            this.numeSpec2.Size = new System.Drawing.Size(170, 28);
            this.numeSpec2.TabIndex = 58;
            this.numeSpec2.SelectedIndexChanged += new System.EventHandler(this.numeSpec2_SelectedIndexChanged);
            // 
            // numeSpecL2
            // 
            this.numeSpecL2.AutoSize = true;
            this.numeSpecL2.Location = new System.Drawing.Point(111, 104);
            this.numeSpecL2.Name = "numeSpecL2";
            this.numeSpecL2.Size = new System.Drawing.Size(113, 20);
            this.numeSpecL2.TabIndex = 57;
            this.numeSpecL2.Text = "Specialist name";
            this.numeSpecL2.Click += new System.EventHandler(this.numeSpecL2_Click);
            // 
            // idSpec2
            // 
            this.idSpec2.FormattingEnabled = true;
            this.idSpec2.Location = new System.Drawing.Point(704, 104);
            this.idSpec2.Name = "idSpec2";
            this.idSpec2.Size = new System.Drawing.Size(170, 28);
            this.idSpec2.TabIndex = 56;
            this.idSpec2.SelectedIndexChanged += new System.EventHandler(this.idSpec2_SelectedIndexChanged);
            // 
            // idSpecL2
            // 
            this.idSpecL2.AutoSize = true;
            this.idSpecL2.Location = new System.Drawing.Point(510, 104);
            this.idSpecL2.Name = "idSpecL2";
            this.idSpecL2.Size = new System.Drawing.Size(89, 20);
            this.idSpecL2.TabIndex = 55;
            this.idSpecL2.Text = "Specialist Id";
            this.idSpecL2.Click += new System.EventHandler(this.idSpecL2_Click);
            // 
            // SConsultations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.specialistsTab);
            this.Controls.Add(this.backButton);
            this.MaximizeBox = false;
            this.Name = "SConsultations";
            this.ShowIcon = false;
            this.Text = "Consultations";
            this.Load += new System.EventHandler(this.SConsultations_Load);
            this.specialistsTab.ResumeLayout(false);
            this.viewPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.insertPage.ResumeLayout(false);
            this.insertPage.PerformLayout();
            this.updatePage.ResumeLayout(false);
            this.updatePage.PerformLayout();
            this.removePage.ResumeLayout(false);
            this.removePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TabControl specialistsTab;
        private System.Windows.Forms.TabPage viewPage;
        private System.Windows.Forms.TabPage insertPage;
        private System.Windows.Forms.TabPage updatePage;
        private System.Windows.Forms.TabPage removePage;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button applyButton2;
        private System.Windows.Forms.TextBox nrCab;
        private System.Windows.Forms.Label nrCabL;
        private System.Windows.Forms.Label idPacientL;
        private System.Windows.Forms.Label idSpecL;
        private System.Windows.Forms.TextBox dataCons;
        private System.Windows.Forms.Label dataConsL;
        private System.Windows.Forms.TextBox idCons;
        private System.Windows.Forms.Label idConsL;
        private System.Windows.Forms.Button applyButton3;
        private System.Windows.Forms.Label columnL;
        private System.Windows.Forms.Label idConsL2;
        private System.Windows.Forms.ComboBox columnChoice;
        private System.Windows.Forms.Button applyButton4;
        private System.Windows.Forms.Label idConsL3;
        private System.Windows.Forms.Label columnChoiceL;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.ComboBox idPacient;
        private System.Windows.Forms.ComboBox idSpec;
        private System.Windows.Forms.ComboBox idCons2;
        private System.Windows.Forms.ComboBox idCons3;
        private System.Windows.Forms.ComboBox numePac;
        private System.Windows.Forms.ComboBox numeSpec;
        private System.Windows.Forms.Label numePacL;
        private System.Windows.Forms.Label numeSpecL;
        private System.Windows.Forms.ComboBox numePac2;
        private System.Windows.Forms.Label numePacL2;
        private System.Windows.Forms.ComboBox idPac2;
        private System.Windows.Forms.Label idPacL2;
        private System.Windows.Forms.ComboBox numePac3;
        private System.Windows.Forms.Label numePacL3;
        private System.Windows.Forms.ComboBox idPac3;
        private System.Windows.Forms.Label idPacL3;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.ComboBox numeSpec2;
        private System.Windows.Forms.Label numeSpecL2;
        private System.Windows.Forms.ComboBox idSpec2;
        private System.Windows.Forms.Label idSpecL2;
    }
}