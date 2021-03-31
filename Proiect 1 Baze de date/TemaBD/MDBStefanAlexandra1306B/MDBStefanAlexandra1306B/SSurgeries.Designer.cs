
namespace MDBStefanAlexandra1306B
{
    partial class SSurgeries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SSurgeries));
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
            this.idCons = new System.Windows.Forms.ComboBox();
            this.idPacient = new System.Windows.Forms.ComboBox();
            this.idSpec = new System.Windows.Forms.ComboBox();
            this.idConsL = new System.Windows.Forms.Label();
            this.applyButton2 = new System.Windows.Forms.Button();
            this.idPacientL = new System.Windows.Forms.Label();
            this.idSpecL = new System.Windows.Forms.Label();
            this.nrSala = new System.Windows.Forms.TextBox();
            this.nrSalaL = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.TextBox();
            this.costL = new System.Windows.Forms.Label();
            this.dataFinal = new System.Windows.Forms.TextBox();
            this.dataFinalL = new System.Windows.Forms.Label();
            this.dataInterv = new System.Windows.Forms.TextBox();
            this.dataIntervL = new System.Windows.Forms.Label();
            this.numeInterventie = new System.Windows.Forms.TextBox();
            this.numeInterventieL = new System.Windows.Forms.Label();
            this.idInterventie = new System.Windows.Forms.TextBox();
            this.idInterventieL = new System.Windows.Forms.Label();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.numeInterventie2 = new System.Windows.Forms.ComboBox();
            this.numeInterventieL2 = new System.Windows.Forms.Label();
            this.numePac2 = new System.Windows.Forms.ComboBox();
            this.numePacL2 = new System.Windows.Forms.Label();
            this.idPacient2 = new System.Windows.Forms.ComboBox();
            this.idPacientL2 = new System.Windows.Forms.Label();
            this.idInterventie2 = new System.Windows.Forms.ComboBox();
            this.columnChoice = new System.Windows.Forms.ComboBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.applyButton3 = new System.Windows.Forms.Button();
            this.columnL = new System.Windows.Forms.Label();
            this.idInterventieL2 = new System.Windows.Forms.Label();
            this.removePage = new System.Windows.Forms.TabPage();
            this.numeInterventie3 = new System.Windows.Forms.ComboBox();
            this.numeInterventieL3 = new System.Windows.Forms.Label();
            this.numePac3 = new System.Windows.Forms.ComboBox();
            this.numePacL3 = new System.Windows.Forms.Label();
            this.idPacient3 = new System.Windows.Forms.ComboBox();
            this.idPacientL3 = new System.Windows.Forms.Label();
            this.idInterventie3 = new System.Windows.Forms.ComboBox();
            this.applyButton4 = new System.Windows.Forms.Button();
            this.idInterventieL3 = new System.Windows.Forms.Label();
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
            this.applyButton.TabIndex = 3;
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
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // insertPage
            // 
            this.insertPage.Controls.Add(this.numePac);
            this.insertPage.Controls.Add(this.numeSpec);
            this.insertPage.Controls.Add(this.numePacL);
            this.insertPage.Controls.Add(this.numeSpecL);
            this.insertPage.Controls.Add(this.idCons);
            this.insertPage.Controls.Add(this.idPacient);
            this.insertPage.Controls.Add(this.idSpec);
            this.insertPage.Controls.Add(this.idConsL);
            this.insertPage.Controls.Add(this.applyButton2);
            this.insertPage.Controls.Add(this.idPacientL);
            this.insertPage.Controls.Add(this.idSpecL);
            this.insertPage.Controls.Add(this.nrSala);
            this.insertPage.Controls.Add(this.nrSalaL);
            this.insertPage.Controls.Add(this.cost);
            this.insertPage.Controls.Add(this.costL);
            this.insertPage.Controls.Add(this.dataFinal);
            this.insertPage.Controls.Add(this.dataFinalL);
            this.insertPage.Controls.Add(this.dataInterv);
            this.insertPage.Controls.Add(this.dataIntervL);
            this.insertPage.Controls.Add(this.numeInterventie);
            this.insertPage.Controls.Add(this.numeInterventieL);
            this.insertPage.Controls.Add(this.idInterventie);
            this.insertPage.Controls.Add(this.idInterventieL);
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
            this.numePac.Location = new System.Drawing.Point(305, 512);
            this.numePac.Name = "numePac";
            this.numePac.Size = new System.Drawing.Size(170, 28);
            this.numePac.TabIndex = 58;
            this.numePac.SelectedIndexChanged += new System.EventHandler(this.numePac_SelectedIndexChanged);
            // 
            // numeSpec
            // 
            this.numeSpec.FormattingEnabled = true;
            this.numeSpec.Location = new System.Drawing.Point(305, 448);
            this.numeSpec.Name = "numeSpec";
            this.numeSpec.Size = new System.Drawing.Size(170, 28);
            this.numeSpec.TabIndex = 57;
            this.numeSpec.SelectedIndexChanged += new System.EventHandler(this.numeSpec_SelectedIndexChanged);
            // 
            // numePacL
            // 
            this.numePacL.AutoSize = true;
            this.numePacL.Location = new System.Drawing.Point(111, 512);
            this.numePacL.Name = "numePacL";
            this.numePacL.Size = new System.Drawing.Size(97, 20);
            this.numePacL.TabIndex = 56;
            this.numePacL.Text = "Pacient name";
            this.numePacL.Click += new System.EventHandler(this.numePacL_Click);
            // 
            // numeSpecL
            // 
            this.numeSpecL.AutoSize = true;
            this.numeSpecL.Location = new System.Drawing.Point(111, 448);
            this.numeSpecL.Name = "numeSpecL";
            this.numeSpecL.Size = new System.Drawing.Size(113, 20);
            this.numeSpecL.TabIndex = 55;
            this.numeSpecL.Text = "Specialist name";
            this.numeSpecL.Click += new System.EventHandler(this.numeSpecL_Click);
            // 
            // idCons
            // 
            this.idCons.FormattingEnabled = true;
            this.idCons.Location = new System.Drawing.Point(704, 64);
            this.idCons.Name = "idCons";
            this.idCons.Size = new System.Drawing.Size(170, 28);
            this.idCons.TabIndex = 54;
            this.idCons.SelectedIndexChanged += new System.EventHandler(this.idCons_SelectedIndexChanged);
            // 
            // idPacient
            // 
            this.idPacient.FormattingEnabled = true;
            this.idPacient.Location = new System.Drawing.Point(704, 512);
            this.idPacient.Name = "idPacient";
            this.idPacient.Size = new System.Drawing.Size(170, 28);
            this.idPacient.TabIndex = 53;
            this.idPacient.SelectedIndexChanged += new System.EventHandler(this.idPacient_SelectedIndexChanged);
            // 
            // idSpec
            // 
            this.idSpec.FormattingEnabled = true;
            this.idSpec.Location = new System.Drawing.Point(704, 448);
            this.idSpec.Name = "idSpec";
            this.idSpec.Size = new System.Drawing.Size(170, 28);
            this.idSpec.TabIndex = 52;
            this.idSpec.SelectedIndexChanged += new System.EventHandler(this.idSpec_SelectedIndexChanged);
            // 
            // idConsL
            // 
            this.idConsL.AutoSize = true;
            this.idConsL.Location = new System.Drawing.Point(510, 64);
            this.idConsL.Name = "idConsL";
            this.idConsL.Size = new System.Drawing.Size(109, 20);
            this.idConsL.TabIndex = 45;
            this.idConsL.Text = "Consultation Id";
            this.idConsL.Click += new System.EventHandler(this.idConsL_Click);
            // 
            // applyButton2
            // 
            this.applyButton2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton2.Location = new System.Drawing.Point(857, 5);
            this.applyButton2.Name = "applyButton2";
            this.applyButton2.Size = new System.Drawing.Size(94, 29);
            this.applyButton2.TabIndex = 44;
            this.applyButton2.Text = "Apply";
            this.applyButton2.UseVisualStyleBackColor = false;
            this.applyButton2.Click += new System.EventHandler(this.applyButton2_Click);
            // 
            // idPacientL
            // 
            this.idPacientL.AutoSize = true;
            this.idPacientL.Location = new System.Drawing.Point(510, 512);
            this.idPacientL.Name = "idPacientL";
            this.idPacientL.Size = new System.Drawing.Size(73, 20);
            this.idPacientL.TabIndex = 42;
            this.idPacientL.Text = "Pacient Id";
            this.idPacientL.Click += new System.EventHandler(this.idPacientL_Click);
            // 
            // idSpecL
            // 
            this.idSpecL.AutoSize = true;
            this.idSpecL.Location = new System.Drawing.Point(510, 448);
            this.idSpecL.Name = "idSpecL";
            this.idSpecL.Size = new System.Drawing.Size(89, 20);
            this.idSpecL.TabIndex = 40;
            this.idSpecL.Text = "Specialist Id";
            this.idSpecL.Click += new System.EventHandler(this.idSpecL_Click);
            // 
            // nrSala
            // 
            this.nrSala.Location = new System.Drawing.Point(305, 384);
            this.nrSala.Name = "nrSala";
            this.nrSala.Size = new System.Drawing.Size(170, 27);
            this.nrSala.TabIndex = 39;
            this.nrSala.TextChanged += new System.EventHandler(this.nrSala_TextChanged);
            // 
            // nrSalaL
            // 
            this.nrSalaL.AutoSize = true;
            this.nrSalaL.Location = new System.Drawing.Point(111, 384);
            this.nrSalaL.Name = "nrSalaL";
            this.nrSalaL.Size = new System.Drawing.Size(104, 20);
            this.nrSalaL.TabIndex = 38;
            this.nrSalaL.Text = "Room number";
            this.nrSalaL.Click += new System.EventHandler(this.nrSalaL_Click);
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(305, 320);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(170, 27);
            this.cost.TabIndex = 37;
            this.cost.TextChanged += new System.EventHandler(this.cost_TextChanged);
            // 
            // costL
            // 
            this.costL.AutoSize = true;
            this.costL.Location = new System.Drawing.Point(111, 320);
            this.costL.Name = "costL";
            this.costL.Size = new System.Drawing.Size(38, 20);
            this.costL.TabIndex = 36;
            this.costL.Text = "Cost";
            this.costL.Click += new System.EventHandler(this.costL_Click);
            // 
            // dataFinal
            // 
            this.dataFinal.Location = new System.Drawing.Point(305, 256);
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.Size = new System.Drawing.Size(170, 27);
            this.dataFinal.TabIndex = 35;
            this.dataFinal.TextChanged += new System.EventHandler(this.dataFinal_TextChanged);
            // 
            // dataFinalL
            // 
            this.dataFinalL.AutoSize = true;
            this.dataFinalL.Location = new System.Drawing.Point(111, 256);
            this.dataFinalL.Name = "dataFinalL";
            this.dataFinalL.Size = new System.Drawing.Size(34, 20);
            this.dataFinalL.TabIndex = 34;
            this.dataFinalL.Text = "End";
            this.dataFinalL.Click += new System.EventHandler(this.dataFinalL_Click);
            // 
            // dataInterv
            // 
            this.dataInterv.Location = new System.Drawing.Point(305, 192);
            this.dataInterv.Name = "dataInterv";
            this.dataInterv.Size = new System.Drawing.Size(170, 27);
            this.dataInterv.TabIndex = 33;
            this.dataInterv.TextChanged += new System.EventHandler(this.dataInterv_TextChanged);
            // 
            // dataIntervL
            // 
            this.dataIntervL.AutoSize = true;
            this.dataIntervL.Location = new System.Drawing.Point(111, 192);
            this.dataIntervL.Name = "dataIntervL";
            this.dataIntervL.Size = new System.Drawing.Size(76, 20);
            this.dataIntervL.TabIndex = 32;
            this.dataIntervL.Text = "Beginning";
            this.dataIntervL.Click += new System.EventHandler(this.dataIntervL_Click);
            // 
            // numeInterventie
            // 
            this.numeInterventie.Location = new System.Drawing.Point(305, 128);
            this.numeInterventie.Name = "numeInterventie";
            this.numeInterventie.Size = new System.Drawing.Size(170, 27);
            this.numeInterventie.TabIndex = 31;
            this.numeInterventie.TextChanged += new System.EventHandler(this.numeInterventie_TextChanged);
            // 
            // numeInterventieL
            // 
            this.numeInterventieL.AutoSize = true;
            this.numeInterventieL.Location = new System.Drawing.Point(111, 128);
            this.numeInterventieL.Name = "numeInterventieL";
            this.numeInterventieL.Size = new System.Drawing.Size(49, 20);
            this.numeInterventieL.TabIndex = 30;
            this.numeInterventieL.Text = "Name";
            this.numeInterventieL.Click += new System.EventHandler(this.numeInterventieL_Click);
            // 
            // idInterventie
            // 
            this.idInterventie.Enabled = false;
            this.idInterventie.Location = new System.Drawing.Point(305, 64);
            this.idInterventie.Name = "idInterventie";
            this.idInterventie.Size = new System.Drawing.Size(170, 27);
            this.idInterventie.TabIndex = 29;
            this.idInterventie.TextChanged += new System.EventHandler(this.idInterventie_TextChanged);
            // 
            // idInterventieL
            // 
            this.idInterventieL.AutoSize = true;
            this.idInterventieL.Enabled = false;
            this.idInterventieL.Location = new System.Drawing.Point(111, 64);
            this.idInterventieL.Name = "idInterventieL";
            this.idInterventieL.Size = new System.Drawing.Size(22, 20);
            this.idInterventieL.TabIndex = 28;
            this.idInterventieL.Text = "Id";
            this.idInterventieL.Click += new System.EventHandler(this.idInterventieL_Click);
            // 
            // updatePage
            // 
            this.updatePage.Controls.Add(this.numeSpec2);
            this.updatePage.Controls.Add(this.numeSpecL2);
            this.updatePage.Controls.Add(this.idSpec2);
            this.updatePage.Controls.Add(this.idSpecL2);
            this.updatePage.Controls.Add(this.numeInterventie2);
            this.updatePage.Controls.Add(this.numeInterventieL2);
            this.updatePage.Controls.Add(this.numePac2);
            this.updatePage.Controls.Add(this.numePacL2);
            this.updatePage.Controls.Add(this.idPacient2);
            this.updatePage.Controls.Add(this.idPacientL2);
            this.updatePage.Controls.Add(this.idInterventie2);
            this.updatePage.Controls.Add(this.columnChoice);
            this.updatePage.Controls.Add(this.valueBox);
            this.updatePage.Controls.Add(this.applyButton3);
            this.updatePage.Controls.Add(this.columnL);
            this.updatePage.Controls.Add(this.idInterventieL2);
            this.updatePage.Location = new System.Drawing.Point(4, 29);
            this.updatePage.Name = "updatePage";
            this.updatePage.Size = new System.Drawing.Size(950, 620);
            this.updatePage.TabIndex = 2;
            this.updatePage.Text = "Update";
            this.updatePage.UseVisualStyleBackColor = true;
            this.updatePage.Click += new System.EventHandler(this.updatePage_Click);
            // 
            // numeInterventie2
            // 
            this.numeInterventie2.FormattingEnabled = true;
            this.numeInterventie2.Location = new System.Drawing.Point(305, 192);
            this.numeInterventie2.Name = "numeInterventie2";
            this.numeInterventie2.Size = new System.Drawing.Size(170, 28);
            this.numeInterventie2.TabIndex = 65;
            this.numeInterventie2.SelectedIndexChanged += new System.EventHandler(this.numeInterventie2_SelectedIndexChanged);
            // 
            // numeInterventieL2
            // 
            this.numeInterventieL2.AutoSize = true;
            this.numeInterventieL2.Location = new System.Drawing.Point(111, 192);
            this.numeInterventieL2.Name = "numeInterventieL2";
            this.numeInterventieL2.Size = new System.Drawing.Size(49, 20);
            this.numeInterventieL2.TabIndex = 64;
            this.numeInterventieL2.Text = "Name";
            this.numeInterventieL2.Click += new System.EventHandler(this.numeInterventieL2_Click);
            // 
            // numePac2
            // 
            this.numePac2.FormattingEnabled = true;
            this.numePac2.Location = new System.Drawing.Point(305, 128);
            this.numePac2.Name = "numePac2";
            this.numePac2.Size = new System.Drawing.Size(170, 28);
            this.numePac2.TabIndex = 63;
            this.numePac2.SelectedIndexChanged += new System.EventHandler(this.numePac2_SelectedIndexChanged);
            // 
            // numePacL2
            // 
            this.numePacL2.AutoSize = true;
            this.numePacL2.Location = new System.Drawing.Point(111, 128);
            this.numePacL2.Name = "numePacL2";
            this.numePacL2.Size = new System.Drawing.Size(97, 20);
            this.numePacL2.TabIndex = 62;
            this.numePacL2.Text = "Pacient name";
            this.numePacL2.Click += new System.EventHandler(this.numePacL2_Click);
            // 
            // idPacient2
            // 
            this.idPacient2.FormattingEnabled = true;
            this.idPacient2.Location = new System.Drawing.Point(704, 128);
            this.idPacient2.Name = "idPacient2";
            this.idPacient2.Size = new System.Drawing.Size(170, 28);
            this.idPacient2.TabIndex = 61;
            this.idPacient2.SelectedIndexChanged += new System.EventHandler(this.idPacient2_SelectedIndexChanged);
            // 
            // idPacientL2
            // 
            this.idPacientL2.AutoSize = true;
            this.idPacientL2.Location = new System.Drawing.Point(510, 128);
            this.idPacientL2.Name = "idPacientL2";
            this.idPacientL2.Size = new System.Drawing.Size(73, 20);
            this.idPacientL2.TabIndex = 60;
            this.idPacientL2.Text = "Pacient Id";
            this.idPacientL2.Click += new System.EventHandler(this.idPacientL2_Click);
            // 
            // idInterventie2
            // 
            this.idInterventie2.FormattingEnabled = true;
            this.idInterventie2.Location = new System.Drawing.Point(704, 192);
            this.idInterventie2.Name = "idInterventie2";
            this.idInterventie2.Size = new System.Drawing.Size(170, 28);
            this.idInterventie2.TabIndex = 59;
            this.idInterventie2.SelectedIndexChanged += new System.EventHandler(this.idInterventie2_SelectedIndexChanged);
            // 
            // columnChoice
            // 
            this.columnChoice.FormattingEnabled = true;
            this.columnChoice.Items.AddRange(new object[] {
            "nume_interv",
            "data_interv",
            "data_final",
            "cost_total",
            "nr_sala",
            "id_spec",
            "cod_asig",
            "id_cons"});
            this.columnChoice.Location = new System.Drawing.Point(305, 256);
            this.columnChoice.Name = "columnChoice";
            this.columnChoice.Size = new System.Drawing.Size(170, 28);
            this.columnChoice.TabIndex = 58;
            this.columnChoice.SelectedIndexChanged += new System.EventHandler(this.columnChoice_SelectedIndexChanged);
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(704, 256);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(170, 27);
            this.valueBox.TabIndex = 57;
            this.valueBox.TextChanged += new System.EventHandler(this.valueBox_TextChanged);
            // 
            // applyButton3
            // 
            this.applyButton3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton3.Location = new System.Drawing.Point(857, 5);
            this.applyButton3.Name = "applyButton3";
            this.applyButton3.Size = new System.Drawing.Size(94, 29);
            this.applyButton3.TabIndex = 53;
            this.applyButton3.Text = "Apply";
            this.applyButton3.UseVisualStyleBackColor = false;
            this.applyButton3.Click += new System.EventHandler(this.applyButton3_Click);
            // 
            // columnL
            // 
            this.columnL.AutoSize = true;
            this.columnL.Location = new System.Drawing.Point(111, 256);
            this.columnL.Name = "columnL";
            this.columnL.Size = new System.Drawing.Size(60, 20);
            this.columnL.TabIndex = 51;
            this.columnL.Text = "Column";
            this.columnL.Click += new System.EventHandler(this.columnL_Click);
            // 
            // idInterventieL2
            // 
            this.idInterventieL2.AutoSize = true;
            this.idInterventieL2.Location = new System.Drawing.Point(510, 192);
            this.idInterventieL2.Name = "idInterventieL2";
            this.idInterventieL2.Size = new System.Drawing.Size(22, 20);
            this.idInterventieL2.TabIndex = 49;
            this.idInterventieL2.Text = "Id";
            this.idInterventieL2.Click += new System.EventHandler(this.idInterventieL2_Click);
            // 
            // removePage
            // 
            this.removePage.Controls.Add(this.numeInterventie3);
            this.removePage.Controls.Add(this.numeInterventieL3);
            this.removePage.Controls.Add(this.numePac3);
            this.removePage.Controls.Add(this.numePacL3);
            this.removePage.Controls.Add(this.idPacient3);
            this.removePage.Controls.Add(this.idPacientL3);
            this.removePage.Controls.Add(this.idInterventie3);
            this.removePage.Controls.Add(this.applyButton4);
            this.removePage.Controls.Add(this.idInterventieL3);
            this.removePage.Location = new System.Drawing.Point(4, 29);
            this.removePage.Name = "removePage";
            this.removePage.Size = new System.Drawing.Size(950, 620);
            this.removePage.TabIndex = 3;
            this.removePage.Text = "Remove";
            this.removePage.UseVisualStyleBackColor = true;
            this.removePage.Click += new System.EventHandler(this.removePage_Click);
            // 
            // numeInterventie3
            // 
            this.numeInterventie3.FormattingEnabled = true;
            this.numeInterventie3.Location = new System.Drawing.Point(305, 128);
            this.numeInterventie3.Name = "numeInterventie3";
            this.numeInterventie3.Size = new System.Drawing.Size(170, 28);
            this.numeInterventie3.TabIndex = 69;
            this.numeInterventie3.SelectedIndexChanged += new System.EventHandler(this.numeInterventie3_SelectedIndexChanged);
            // 
            // numeInterventieL3
            // 
            this.numeInterventieL3.AutoSize = true;
            this.numeInterventieL3.Location = new System.Drawing.Point(111, 128);
            this.numeInterventieL3.Name = "numeInterventieL3";
            this.numeInterventieL3.Size = new System.Drawing.Size(49, 20);
            this.numeInterventieL3.TabIndex = 68;
            this.numeInterventieL3.Text = "Name";
            this.numeInterventieL3.Click += new System.EventHandler(this.numeInterventieL3_Click);
            // 
            // numePac3
            // 
            this.numePac3.FormattingEnabled = true;
            this.numePac3.Location = new System.Drawing.Point(305, 64);
            this.numePac3.Name = "numePac3";
            this.numePac3.Size = new System.Drawing.Size(170, 28);
            this.numePac3.TabIndex = 67;
            this.numePac3.SelectedIndexChanged += new System.EventHandler(this.numePac3_SelectedIndexChanged);
            // 
            // numePacL3
            // 
            this.numePacL3.AutoSize = true;
            this.numePacL3.Location = new System.Drawing.Point(111, 64);
            this.numePacL3.Name = "numePacL3";
            this.numePacL3.Size = new System.Drawing.Size(97, 20);
            this.numePacL3.TabIndex = 66;
            this.numePacL3.Text = "Pacient name";
            this.numePacL3.Click += new System.EventHandler(this.numePacL3_Click);
            // 
            // idPacient3
            // 
            this.idPacient3.FormattingEnabled = true;
            this.idPacient3.Location = new System.Drawing.Point(704, 64);
            this.idPacient3.Name = "idPacient3";
            this.idPacient3.Size = new System.Drawing.Size(170, 28);
            this.idPacient3.TabIndex = 65;
            this.idPacient3.SelectedIndexChanged += new System.EventHandler(this.idPacient3_SelectedIndexChanged);
            // 
            // idPacientL3
            // 
            this.idPacientL3.AutoSize = true;
            this.idPacientL3.Location = new System.Drawing.Point(510, 64);
            this.idPacientL3.Name = "idPacientL3";
            this.idPacientL3.Size = new System.Drawing.Size(73, 20);
            this.idPacientL3.TabIndex = 64;
            this.idPacientL3.Text = "Pacient Id";
            this.idPacientL3.Click += new System.EventHandler(this.idPacientL3_Click);
            // 
            // idInterventie3
            // 
            this.idInterventie3.FormattingEnabled = true;
            this.idInterventie3.Location = new System.Drawing.Point(704, 128);
            this.idInterventie3.Name = "idInterventie3";
            this.idInterventie3.Size = new System.Drawing.Size(170, 28);
            this.idInterventie3.TabIndex = 57;
            this.idInterventie3.SelectedIndexChanged += new System.EventHandler(this.idInterventie3_SelectedIndexChanged);
            // 
            // applyButton4
            // 
            this.applyButton4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton4.Location = new System.Drawing.Point(857, 5);
            this.applyButton4.Name = "applyButton4";
            this.applyButton4.Size = new System.Drawing.Size(94, 29);
            this.applyButton4.TabIndex = 56;
            this.applyButton4.Text = "Apply";
            this.applyButton4.UseVisualStyleBackColor = false;
            this.applyButton4.Click += new System.EventHandler(this.applyButton4_Click);
            // 
            // idInterventieL3
            // 
            this.idInterventieL3.AutoSize = true;
            this.idInterventieL3.Location = new System.Drawing.Point(510, 128);
            this.idInterventieL3.Name = "idInterventieL3";
            this.idInterventieL3.Size = new System.Drawing.Size(22, 20);
            this.idInterventieL3.TabIndex = 54;
            this.idInterventieL3.Text = "Id";
            this.idInterventieL3.Click += new System.EventHandler(this.idInterventieL3_Click);
            // 
            // numeSpec2
            // 
            this.numeSpec2.FormattingEnabled = true;
            this.numeSpec2.Location = new System.Drawing.Point(305, 64);
            this.numeSpec2.Name = "numeSpec2";
            this.numeSpec2.Size = new System.Drawing.Size(170, 28);
            this.numeSpec2.TabIndex = 69;
            this.numeSpec2.SelectedIndexChanged += new System.EventHandler(this.numeSpec2_SelectedIndexChanged);
            // 
            // numeSpecL2
            // 
            this.numeSpecL2.AutoSize = true;
            this.numeSpecL2.Location = new System.Drawing.Point(111, 64);
            this.numeSpecL2.Name = "numeSpecL2";
            this.numeSpecL2.Size = new System.Drawing.Size(113, 20);
            this.numeSpecL2.TabIndex = 68;
            this.numeSpecL2.Text = "Specialist name";
            this.numeSpecL2.Click += new System.EventHandler(this.numeSpecL2_Click);
            // 
            // idSpec2
            // 
            this.idSpec2.FormattingEnabled = true;
            this.idSpec2.Location = new System.Drawing.Point(704, 64);
            this.idSpec2.Name = "idSpec2";
            this.idSpec2.Size = new System.Drawing.Size(170, 28);
            this.idSpec2.TabIndex = 67;
            this.idSpec2.SelectedIndexChanged += new System.EventHandler(this.idSpec2_SelectedIndexChanged);
            // 
            // idSpecL2
            // 
            this.idSpecL2.AutoSize = true;
            this.idSpecL2.Location = new System.Drawing.Point(510, 64);
            this.idSpecL2.Name = "idSpecL2";
            this.idSpecL2.Size = new System.Drawing.Size(89, 20);
            this.idSpecL2.TabIndex = 66;
            this.idSpecL2.Text = "Specialist Id";
            this.idSpecL2.Click += new System.EventHandler(this.idSpecL2_Click);
            // 
            // SSurgeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.specialistsTab);
            this.Controls.Add(this.backButton);
            this.MaximizeBox = false;
            this.Name = "SSurgeries";
            this.ShowIcon = false;
            this.Text = "Surgeries";
            this.Load += new System.EventHandler(this.SSurgeries_Load);
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
        private System.Windows.Forms.Label idConsL;
        private System.Windows.Forms.Button applyButton2;
        private System.Windows.Forms.Label idPacientL;
        private System.Windows.Forms.Label idSpecL;
        private System.Windows.Forms.TextBox nrSala;
        private System.Windows.Forms.Label nrSalaL;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Label costL;
        private System.Windows.Forms.TextBox dataFinal;
        private System.Windows.Forms.Label dataFinalL;
        private System.Windows.Forms.TextBox dataInterv;
        private System.Windows.Forms.Label dataIntervL;
        private System.Windows.Forms.TextBox numeInterventie;
        private System.Windows.Forms.Label numeInterventieL;
        private System.Windows.Forms.TextBox idInterventie;
        private System.Windows.Forms.Label idInterventieL;
        private System.Windows.Forms.ComboBox columnChoice;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Button applyButton3;
        private System.Windows.Forms.Label columnL;
        private System.Windows.Forms.Label idInterventieL2;
        private System.Windows.Forms.Button applyButton4;
        private System.Windows.Forms.Label idInterventieL3;
        private System.Windows.Forms.ComboBox idCons;
        private System.Windows.Forms.ComboBox idPacient;
        private System.Windows.Forms.ComboBox idSpec;
        private System.Windows.Forms.ComboBox idInterventie2;
        private System.Windows.Forms.ComboBox idInterventie3;
        private System.Windows.Forms.ComboBox numePac;
        private System.Windows.Forms.ComboBox numeSpec;
        private System.Windows.Forms.Label numePacL;
        private System.Windows.Forms.Label numeSpecL;
        private System.Windows.Forms.ComboBox numePac2;
        private System.Windows.Forms.Label numePacL2;
        private System.Windows.Forms.ComboBox idPacient2;
        private System.Windows.Forms.Label idPacientL2;
        private System.Windows.Forms.ComboBox numeInterventie2;
        private System.Windows.Forms.Label numeInterventieL2;
        private System.Windows.Forms.ComboBox numeInterventie3;
        private System.Windows.Forms.Label numeInterventieL3;
        private System.Windows.Forms.ComboBox numePac3;
        private System.Windows.Forms.Label numePacL3;
        private System.Windows.Forms.ComboBox idPacient3;
        private System.Windows.Forms.Label idPacientL3;
        private System.Windows.Forms.ComboBox numeSpec2;
        private System.Windows.Forms.Label numeSpecL2;
        private System.Windows.Forms.ComboBox idSpec2;
        private System.Windows.Forms.Label idSpecL2;
    }
}