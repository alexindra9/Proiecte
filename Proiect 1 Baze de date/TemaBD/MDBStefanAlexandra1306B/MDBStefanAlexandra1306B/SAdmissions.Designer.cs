
namespace MDBStefanAlexandra1306B
{
    partial class SAdmissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAdmissions));
            this.backButton = new System.Windows.Forms.Button();
            this.specialistsTab = new System.Windows.Forms.TabControl();
            this.viewPage = new System.Windows.Forms.TabPage();
            this.applyButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertPage = new System.Windows.Forms.TabPage();
            this.numeAsis = new System.Windows.Forms.ComboBox();
            this.numeInterv = new System.Windows.Forms.ComboBox();
            this.numeAsisL = new System.Windows.Forms.Label();
            this.numeIntervL = new System.Windows.Forms.Label();
            this.idAsis = new System.Windows.Forms.ComboBox();
            this.idInterventie = new System.Windows.Forms.ComboBox();
            this.dataExtern = new System.Windows.Forms.TextBox();
            this.dataExternL = new System.Windows.Forms.Label();
            this.dataIntern = new System.Windows.Forms.TextBox();
            this.dataInternL = new System.Windows.Forms.Label();
            this.idAsisL = new System.Windows.Forms.Label();
            this.idInterventieL = new System.Windows.Forms.Label();
            this.nrCamera = new System.Windows.Forms.TextBox();
            this.nrCameraL = new System.Windows.Forms.Label();
            this.idInternare = new System.Windows.Forms.TextBox();
            this.idInternareL = new System.Windows.Forms.Label();
            this.applyButton2 = new System.Windows.Forms.Button();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.idInternare2 = new System.Windows.Forms.ComboBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.applyButton3 = new System.Windows.Forms.Button();
            this.columnChoice = new System.Windows.Forms.ComboBox();
            this.columnL = new System.Windows.Forms.Label();
            this.idInternareL2 = new System.Windows.Forms.Label();
            this.removePage = new System.Windows.Forms.TabPage();
            this.idInternare3 = new System.Windows.Forms.ComboBox();
            this.applyButton4 = new System.Windows.Forms.Button();
            this.idInternareL3 = new System.Windows.Forms.Label();
            this.numePac = new System.Windows.Forms.ComboBox();
            this.numePacL = new System.Windows.Forms.Label();
            this.idPac = new System.Windows.Forms.ComboBox();
            this.idPacL = new System.Windows.Forms.Label();
            this.numePac2 = new System.Windows.Forms.ComboBox();
            this.numePacL2 = new System.Windows.Forms.Label();
            this.idPac2 = new System.Windows.Forms.ComboBox();
            this.idPacL2 = new System.Windows.Forms.Label();
            this.numeInterv2 = new System.Windows.Forms.ComboBox();
            this.numeIntervL2 = new System.Windows.Forms.Label();
            this.idInterventie2 = new System.Windows.Forms.ComboBox();
            this.idInterventieL2 = new System.Windows.Forms.Label();
            this.numePac3 = new System.Windows.Forms.ComboBox();
            this.numePacL3 = new System.Windows.Forms.Label();
            this.idPac3 = new System.Windows.Forms.ComboBox();
            this.idPacL3 = new System.Windows.Forms.Label();
            this.numeInterv3 = new System.Windows.Forms.ComboBox();
            this.numeIntervL3 = new System.Windows.Forms.Label();
            this.idInterventie3 = new System.Windows.Forms.ComboBox();
            this.idInterventieL3 = new System.Windows.Forms.Label();
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
            this.applyButton.TabIndex = 7;
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
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // insertPage
            // 
            this.insertPage.Controls.Add(this.numePac);
            this.insertPage.Controls.Add(this.numePacL);
            this.insertPage.Controls.Add(this.idPac);
            this.insertPage.Controls.Add(this.idPacL);
            this.insertPage.Controls.Add(this.numeAsis);
            this.insertPage.Controls.Add(this.numeInterv);
            this.insertPage.Controls.Add(this.numeAsisL);
            this.insertPage.Controls.Add(this.numeIntervL);
            this.insertPage.Controls.Add(this.idAsis);
            this.insertPage.Controls.Add(this.idInterventie);
            this.insertPage.Controls.Add(this.dataExtern);
            this.insertPage.Controls.Add(this.dataExternL);
            this.insertPage.Controls.Add(this.dataIntern);
            this.insertPage.Controls.Add(this.dataInternL);
            this.insertPage.Controls.Add(this.idAsisL);
            this.insertPage.Controls.Add(this.idInterventieL);
            this.insertPage.Controls.Add(this.nrCamera);
            this.insertPage.Controls.Add(this.nrCameraL);
            this.insertPage.Controls.Add(this.idInternare);
            this.insertPage.Controls.Add(this.idInternareL);
            this.insertPage.Controls.Add(this.applyButton2);
            this.insertPage.Location = new System.Drawing.Point(4, 29);
            this.insertPage.Name = "insertPage";
            this.insertPage.Padding = new System.Windows.Forms.Padding(3);
            this.insertPage.Size = new System.Drawing.Size(950, 620);
            this.insertPage.TabIndex = 1;
            this.insertPage.Text = "Insert";
            this.insertPage.UseVisualStyleBackColor = true;
            this.insertPage.Click += new System.EventHandler(this.insertPage_Click);
            // 
            // numeAsis
            // 
            this.numeAsis.FormattingEnabled = true;
            this.numeAsis.Location = new System.Drawing.Point(305, 360);
            this.numeAsis.Name = "numeAsis";
            this.numeAsis.Size = new System.Drawing.Size(170, 28);
            this.numeAsis.TabIndex = 71;
            this.numeAsis.SelectedIndexChanged += new System.EventHandler(this.numeAsis_SelectedIndexChanged);
            // 
            // numeInterv
            // 
            this.numeInterv.FormattingEnabled = true;
            this.numeInterv.Location = new System.Drawing.Point(305, 288);
            this.numeInterv.Name = "numeInterv";
            this.numeInterv.Size = new System.Drawing.Size(170, 28);
            this.numeInterv.TabIndex = 70;
            this.numeInterv.SelectedIndexChanged += new System.EventHandler(this.numeInterv_SelectedIndexChanged);
            // 
            // numeAsisL
            // 
            this.numeAsisL.AutoSize = true;
            this.numeAsisL.Location = new System.Drawing.Point(111, 360);
            this.numeAsisL.Name = "numeAsisL";
            this.numeAsisL.Size = new System.Drawing.Size(108, 20);
            this.numeAsisL.TabIndex = 69;
            this.numeAsisL.Text = "Assistant name";
            this.numeAsisL.Click += new System.EventHandler(this.numeAsisL_Click);
            // 
            // numeIntervL
            // 
            this.numeIntervL.AutoSize = true;
            this.numeIntervL.Location = new System.Drawing.Point(111, 288);
            this.numeIntervL.Name = "numeIntervL";
            this.numeIntervL.Size = new System.Drawing.Size(129, 20);
            this.numeIntervL.TabIndex = 68;
            this.numeIntervL.Text = "Intervention name";
            this.numeIntervL.Click += new System.EventHandler(this.numeIntervL_Click);
            // 
            // idAsis
            // 
            this.idAsis.FormattingEnabled = true;
            this.idAsis.Location = new System.Drawing.Point(704, 360);
            this.idAsis.Name = "idAsis";
            this.idAsis.Size = new System.Drawing.Size(170, 28);
            this.idAsis.TabIndex = 67;
            this.idAsis.SelectedIndexChanged += new System.EventHandler(this.idAsis_SelectedIndexChanged);
            // 
            // idInterventie
            // 
            this.idInterventie.FormattingEnabled = true;
            this.idInterventie.Location = new System.Drawing.Point(704, 288);
            this.idInterventie.Name = "idInterventie";
            this.idInterventie.Size = new System.Drawing.Size(170, 28);
            this.idInterventie.TabIndex = 66;
            this.idInterventie.SelectedIndexChanged += new System.EventHandler(this.idInterventie_SelectedIndexChanged);
            // 
            // dataExtern
            // 
            this.dataExtern.Location = new System.Drawing.Point(305, 504);
            this.dataExtern.Name = "dataExtern";
            this.dataExtern.Size = new System.Drawing.Size(170, 27);
            this.dataExtern.TabIndex = 65;
            this.dataExtern.TextChanged += new System.EventHandler(this.dataExtern_TextChanged);
            // 
            // dataExternL
            // 
            this.dataExternL.AutoSize = true;
            this.dataExternL.Location = new System.Drawing.Point(111, 504);
            this.dataExternL.Name = "dataExternL";
            this.dataExternL.Size = new System.Drawing.Size(75, 20);
            this.dataExternL.TabIndex = 64;
            this.dataExternL.Text = "Discharge";
            this.dataExternL.Click += new System.EventHandler(this.dataExternL_Click);
            // 
            // dataIntern
            // 
            this.dataIntern.Location = new System.Drawing.Point(305, 432);
            this.dataIntern.Name = "dataIntern";
            this.dataIntern.Size = new System.Drawing.Size(170, 27);
            this.dataIntern.TabIndex = 63;
            this.dataIntern.TextChanged += new System.EventHandler(this.dataIntern_TextChanged);
            // 
            // dataInternL
            // 
            this.dataInternL.AutoSize = true;
            this.dataInternL.Location = new System.Drawing.Point(111, 432);
            this.dataInternL.Name = "dataInternL";
            this.dataInternL.Size = new System.Drawing.Size(78, 20);
            this.dataInternL.TabIndex = 62;
            this.dataInternL.Text = "Admission";
            this.dataInternL.Click += new System.EventHandler(this.dataInternL_Click);
            // 
            // idAsisL
            // 
            this.idAsisL.AutoSize = true;
            this.idAsisL.Location = new System.Drawing.Point(510, 360);
            this.idAsisL.Name = "idAsisL";
            this.idAsisL.Size = new System.Drawing.Size(84, 20);
            this.idAsisL.TabIndex = 60;
            this.idAsisL.Text = "Assistant Id";
            this.idAsisL.Click += new System.EventHandler(this.idAsisL_Click);
            // 
            // idInterventieL
            // 
            this.idInterventieL.AutoSize = true;
            this.idInterventieL.Location = new System.Drawing.Point(510, 288);
            this.idInterventieL.Name = "idInterventieL";
            this.idInterventieL.Size = new System.Drawing.Size(105, 20);
            this.idInterventieL.TabIndex = 58;
            this.idInterventieL.Text = "Intervention Id";
            this.idInterventieL.Click += new System.EventHandler(this.idInterventieL_Click);
            // 
            // nrCamera
            // 
            this.nrCamera.Location = new System.Drawing.Point(305, 144);
            this.nrCamera.Name = "nrCamera";
            this.nrCamera.Size = new System.Drawing.Size(170, 27);
            this.nrCamera.TabIndex = 57;
            this.nrCamera.TextChanged += new System.EventHandler(this.nrCamera_TextChanged);
            // 
            // nrCameraL
            // 
            this.nrCameraL.AutoSize = true;
            this.nrCameraL.Location = new System.Drawing.Point(111, 144);
            this.nrCameraL.Name = "nrCameraL";
            this.nrCameraL.Size = new System.Drawing.Size(104, 20);
            this.nrCameraL.TabIndex = 56;
            this.nrCameraL.Text = "Room number";
            this.nrCameraL.Click += new System.EventHandler(this.nrCameraL_Click);
            // 
            // idInternare
            // 
            this.idInternare.Enabled = false;
            this.idInternare.Location = new System.Drawing.Point(305, 72);
            this.idInternare.Name = "idInternare";
            this.idInternare.Size = new System.Drawing.Size(170, 27);
            this.idInternare.TabIndex = 55;
            this.idInternare.TextChanged += new System.EventHandler(this.idInternare_TextChanged);
            // 
            // idInternareL
            // 
            this.idInternareL.AutoSize = true;
            this.idInternareL.Enabled = false;
            this.idInternareL.Location = new System.Drawing.Point(111, 72);
            this.idInternareL.Name = "idInternareL";
            this.idInternareL.Size = new System.Drawing.Size(22, 20);
            this.idInternareL.TabIndex = 54;
            this.idInternareL.Text = "Id";
            this.idInternareL.Click += new System.EventHandler(this.idInternareL_Click);
            // 
            // applyButton2
            // 
            this.applyButton2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton2.Location = new System.Drawing.Point(857, 5);
            this.applyButton2.Name = "applyButton2";
            this.applyButton2.Size = new System.Drawing.Size(94, 29);
            this.applyButton2.TabIndex = 53;
            this.applyButton2.Text = "Apply";
            this.applyButton2.UseVisualStyleBackColor = false;
            this.applyButton2.Click += new System.EventHandler(this.applyButton2_Click);
            // 
            // updatePage
            // 
            this.updatePage.Controls.Add(this.numePac2);
            this.updatePage.Controls.Add(this.numePacL2);
            this.updatePage.Controls.Add(this.idPac2);
            this.updatePage.Controls.Add(this.idPacL2);
            this.updatePage.Controls.Add(this.numeInterv2);
            this.updatePage.Controls.Add(this.numeIntervL2);
            this.updatePage.Controls.Add(this.idInterventie2);
            this.updatePage.Controls.Add(this.idInterventieL2);
            this.updatePage.Controls.Add(this.idInternare2);
            this.updatePage.Controls.Add(this.valueBox);
            this.updatePage.Controls.Add(this.applyButton3);
            this.updatePage.Controls.Add(this.columnChoice);
            this.updatePage.Controls.Add(this.columnL);
            this.updatePage.Controls.Add(this.idInternareL2);
            this.updatePage.Location = new System.Drawing.Point(4, 29);
            this.updatePage.Name = "updatePage";
            this.updatePage.Size = new System.Drawing.Size(950, 620);
            this.updatePage.TabIndex = 2;
            this.updatePage.Text = "Update";
            this.updatePage.UseVisualStyleBackColor = true;
            this.updatePage.Click += new System.EventHandler(this.updatePage_Click);
            // 
            // idInternare2
            // 
            this.idInternare2.FormattingEnabled = true;
            this.idInternare2.Location = new System.Drawing.Point(305, 216);
            this.idInternare2.Name = "idInternare2";
            this.idInternare2.Size = new System.Drawing.Size(170, 28);
            this.idInternare2.TabIndex = 71;
            this.idInternare2.SelectedIndexChanged += new System.EventHandler(this.idInternare2_SelectedIndexChanged);
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(704, 288);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(170, 27);
            this.valueBox.TabIndex = 70;
            this.valueBox.TextChanged += new System.EventHandler(this.valueBox_TextChanged);
            // 
            // applyButton3
            // 
            this.applyButton3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton3.Location = new System.Drawing.Point(857, 5);
            this.applyButton3.Name = "applyButton3";
            this.applyButton3.Size = new System.Drawing.Size(94, 29);
            this.applyButton3.TabIndex = 69;
            this.applyButton3.Text = "Apply";
            this.applyButton3.UseVisualStyleBackColor = false;
            this.applyButton3.Click += new System.EventHandler(this.applyButton3_Click);
            // 
            // columnChoice
            // 
            this.columnChoice.FormattingEnabled = true;
            this.columnChoice.Items.AddRange(new object[] {
            "nr_camera",
            "id_interv",
            "id_asis",
            "data_intern",
            "data_extern"});
            this.columnChoice.Location = new System.Drawing.Point(305, 288);
            this.columnChoice.Name = "columnChoice";
            this.columnChoice.Size = new System.Drawing.Size(170, 28);
            this.columnChoice.TabIndex = 68;
            this.columnChoice.SelectedIndexChanged += new System.EventHandler(this.columnChoice_SelectedIndexChanged);
            // 
            // columnL
            // 
            this.columnL.AutoSize = true;
            this.columnL.Location = new System.Drawing.Point(111, 288);
            this.columnL.Name = "columnL";
            this.columnL.Size = new System.Drawing.Size(60, 20);
            this.columnL.TabIndex = 67;
            this.columnL.Text = "Column";
            this.columnL.Click += new System.EventHandler(this.columnL_Click);
            // 
            // idInternareL2
            // 
            this.idInternareL2.AutoSize = true;
            this.idInternareL2.Location = new System.Drawing.Point(111, 216);
            this.idInternareL2.Name = "idInternareL2";
            this.idInternareL2.Size = new System.Drawing.Size(22, 20);
            this.idInternareL2.TabIndex = 54;
            this.idInternareL2.Text = "Id";
            this.idInternareL2.Click += new System.EventHandler(this.idInternareL2_Click);
            // 
            // removePage
            // 
            this.removePage.Controls.Add(this.numePac3);
            this.removePage.Controls.Add(this.numePacL3);
            this.removePage.Controls.Add(this.idPac3);
            this.removePage.Controls.Add(this.idPacL3);
            this.removePage.Controls.Add(this.numeInterv3);
            this.removePage.Controls.Add(this.numeIntervL3);
            this.removePage.Controls.Add(this.idInterventie3);
            this.removePage.Controls.Add(this.idInterventieL3);
            this.removePage.Controls.Add(this.idInternare3);
            this.removePage.Controls.Add(this.applyButton4);
            this.removePage.Controls.Add(this.idInternareL3);
            this.removePage.Location = new System.Drawing.Point(4, 29);
            this.removePage.Name = "removePage";
            this.removePage.Size = new System.Drawing.Size(950, 620);
            this.removePage.TabIndex = 3;
            this.removePage.Text = "Remove";
            this.removePage.UseVisualStyleBackColor = true;
            this.removePage.Click += new System.EventHandler(this.removePage_Click);
            // 
            // idInternare3
            // 
            this.idInternare3.FormattingEnabled = true;
            this.idInternare3.Location = new System.Drawing.Point(305, 216);
            this.idInternare3.Name = "idInternare3";
            this.idInternare3.Size = new System.Drawing.Size(170, 28);
            this.idInternare3.TabIndex = 67;
            this.idInternare3.SelectedIndexChanged += new System.EventHandler(this.idInternare3_SelectedIndexChanged);
            // 
            // applyButton4
            // 
            this.applyButton4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton4.Location = new System.Drawing.Point(857, 5);
            this.applyButton4.Name = "applyButton4";
            this.applyButton4.Size = new System.Drawing.Size(94, 29);
            this.applyButton4.TabIndex = 66;
            this.applyButton4.Text = "Apply";
            this.applyButton4.UseVisualStyleBackColor = false;
            this.applyButton4.Click += new System.EventHandler(this.applyButton4_Click);
            // 
            // idInternareL3
            // 
            this.idInternareL3.AutoSize = true;
            this.idInternareL3.Location = new System.Drawing.Point(111, 216);
            this.idInternareL3.Name = "idInternareL3";
            this.idInternareL3.Size = new System.Drawing.Size(22, 20);
            this.idInternareL3.TabIndex = 54;
            this.idInternareL3.Text = "Id";
            this.idInternareL3.Click += new System.EventHandler(this.idInternareL3_Click);
            // 
            // numePac
            // 
            this.numePac.FormattingEnabled = true;
            this.numePac.Location = new System.Drawing.Point(305, 216);
            this.numePac.Name = "numePac";
            this.numePac.Size = new System.Drawing.Size(170, 28);
            this.numePac.TabIndex = 75;
            this.numePac.SelectedIndexChanged += new System.EventHandler(this.numePac_SelectedIndexChanged);
            // 
            // numePacL
            // 
            this.numePacL.AutoSize = true;
            this.numePacL.Location = new System.Drawing.Point(111, 216);
            this.numePacL.Name = "numePacL";
            this.numePacL.Size = new System.Drawing.Size(97, 20);
            this.numePacL.TabIndex = 74;
            this.numePacL.Text = "Pacient name";
            this.numePacL.Click += new System.EventHandler(this.numePacL_Click);
            // 
            // idPac
            // 
            this.idPac.FormattingEnabled = true;
            this.idPac.Location = new System.Drawing.Point(704, 216);
            this.idPac.Name = "idPac";
            this.idPac.Size = new System.Drawing.Size(170, 28);
            this.idPac.TabIndex = 73;
            this.idPac.SelectedIndexChanged += new System.EventHandler(this.idPac_SelectedIndexChanged);
            // 
            // idPacL
            // 
            this.idPacL.AutoSize = true;
            this.idPacL.Location = new System.Drawing.Point(510, 216);
            this.idPacL.Name = "idPacL";
            this.idPacL.Size = new System.Drawing.Size(73, 20);
            this.idPacL.TabIndex = 72;
            this.idPacL.Text = "Pacient Id";
            this.idPacL.Click += new System.EventHandler(this.idPacL_Click);
            // 
            // numePac2
            // 
            this.numePac2.FormattingEnabled = true;
            this.numePac2.Location = new System.Drawing.Point(305, 72);
            this.numePac2.Name = "numePac2";
            this.numePac2.Size = new System.Drawing.Size(170, 28);
            this.numePac2.TabIndex = 83;
            this.numePac2.SelectedIndexChanged += new System.EventHandler(this.numePac2_SelectedIndexChanged);
            // 
            // numePacL2
            // 
            this.numePacL2.AutoSize = true;
            this.numePacL2.Location = new System.Drawing.Point(111, 72);
            this.numePacL2.Name = "numePacL2";
            this.numePacL2.Size = new System.Drawing.Size(97, 20);
            this.numePacL2.TabIndex = 82;
            this.numePacL2.Text = "Pacient name";
            this.numePacL2.Click += new System.EventHandler(this.numePacL2_Click);
            // 
            // idPac2
            // 
            this.idPac2.FormattingEnabled = true;
            this.idPac2.Location = new System.Drawing.Point(704, 72);
            this.idPac2.Name = "idPac2";
            this.idPac2.Size = new System.Drawing.Size(170, 28);
            this.idPac2.TabIndex = 81;
            this.idPac2.SelectedIndexChanged += new System.EventHandler(this.idPac2_SelectedIndexChanged);
            // 
            // idPacL2
            // 
            this.idPacL2.AutoSize = true;
            this.idPacL2.Location = new System.Drawing.Point(510, 72);
            this.idPacL2.Name = "idPacL2";
            this.idPacL2.Size = new System.Drawing.Size(73, 20);
            this.idPacL2.TabIndex = 80;
            this.idPacL2.Text = "Pacient Id";
            this.idPacL2.Click += new System.EventHandler(this.idPacL2_Click);
            // 
            // numeInterv2
            // 
            this.numeInterv2.FormattingEnabled = true;
            this.numeInterv2.Location = new System.Drawing.Point(305, 144);
            this.numeInterv2.Name = "numeInterv2";
            this.numeInterv2.Size = new System.Drawing.Size(170, 28);
            this.numeInterv2.TabIndex = 79;
            this.numeInterv2.SelectedIndexChanged += new System.EventHandler(this.numeInterv2_SelectedIndexChanged);
            // 
            // numeIntervL2
            // 
            this.numeIntervL2.AutoSize = true;
            this.numeIntervL2.Location = new System.Drawing.Point(111, 144);
            this.numeIntervL2.Name = "numeIntervL2";
            this.numeIntervL2.Size = new System.Drawing.Size(129, 20);
            this.numeIntervL2.TabIndex = 78;
            this.numeIntervL2.Text = "Intervention name";
            this.numeIntervL2.Click += new System.EventHandler(this.numeIntervL2_Click);
            // 
            // idInterventie2
            // 
            this.idInterventie2.FormattingEnabled = true;
            this.idInterventie2.Location = new System.Drawing.Point(704, 144);
            this.idInterventie2.Name = "idInterventie2";
            this.idInterventie2.Size = new System.Drawing.Size(170, 28);
            this.idInterventie2.TabIndex = 77;
            this.idInterventie2.SelectedIndexChanged += new System.EventHandler(this.idInterventie2_SelectedIndexChanged);
            // 
            // idInterventieL2
            // 
            this.idInterventieL2.AutoSize = true;
            this.idInterventieL2.Location = new System.Drawing.Point(510, 144);
            this.idInterventieL2.Name = "idInterventieL2";
            this.idInterventieL2.Size = new System.Drawing.Size(105, 20);
            this.idInterventieL2.TabIndex = 76;
            this.idInterventieL2.Text = "Intervention Id";
            this.idInterventieL2.Click += new System.EventHandler(this.idInterventieL2_Click);
            // 
            // numePac3
            // 
            this.numePac3.FormattingEnabled = true;
            this.numePac3.Location = new System.Drawing.Point(305, 72);
            this.numePac3.Name = "numePac3";
            this.numePac3.Size = new System.Drawing.Size(170, 28);
            this.numePac3.TabIndex = 91;
            this.numePac3.SelectedIndexChanged += new System.EventHandler(this.numePac3_SelectedIndexChanged);
            // 
            // numePacL3
            // 
            this.numePacL3.AutoSize = true;
            this.numePacL3.Location = new System.Drawing.Point(111, 72);
            this.numePacL3.Name = "numePacL3";
            this.numePacL3.Size = new System.Drawing.Size(97, 20);
            this.numePacL3.TabIndex = 90;
            this.numePacL3.Text = "Pacient name";
            this.numePacL3.Click += new System.EventHandler(this.numePacL3_Click);
            // 
            // idPac3
            // 
            this.idPac3.FormattingEnabled = true;
            this.idPac3.Location = new System.Drawing.Point(704, 72);
            this.idPac3.Name = "idPac3";
            this.idPac3.Size = new System.Drawing.Size(170, 28);
            this.idPac3.TabIndex = 89;
            this.idPac3.SelectedIndexChanged += new System.EventHandler(this.idPac3_SelectedIndexChanged);
            // 
            // idPacL3
            // 
            this.idPacL3.AutoSize = true;
            this.idPacL3.Location = new System.Drawing.Point(510, 72);
            this.idPacL3.Name = "idPacL3";
            this.idPacL3.Size = new System.Drawing.Size(73, 20);
            this.idPacL3.TabIndex = 88;
            this.idPacL3.Text = "Pacient Id";
            this.idPacL3.Click += new System.EventHandler(this.idPacL3_Click);
            // 
            // numeInterv3
            // 
            this.numeInterv3.FormattingEnabled = true;
            this.numeInterv3.Location = new System.Drawing.Point(305, 144);
            this.numeInterv3.Name = "numeInterv3";
            this.numeInterv3.Size = new System.Drawing.Size(170, 28);
            this.numeInterv3.TabIndex = 87;
            this.numeInterv3.SelectedIndexChanged += new System.EventHandler(this.numeInterv3_SelectedIndexChanged);
            // 
            // numeIntervL3
            // 
            this.numeIntervL3.AutoSize = true;
            this.numeIntervL3.Location = new System.Drawing.Point(111, 144);
            this.numeIntervL3.Name = "numeIntervL3";
            this.numeIntervL3.Size = new System.Drawing.Size(129, 20);
            this.numeIntervL3.TabIndex = 86;
            this.numeIntervL3.Text = "Intervention name";
            this.numeIntervL3.Click += new System.EventHandler(this.numeIntervL3_Click);
            // 
            // idInterventie3
            // 
            this.idInterventie3.FormattingEnabled = true;
            this.idInterventie3.Location = new System.Drawing.Point(704, 144);
            this.idInterventie3.Name = "idInterventie3";
            this.idInterventie3.Size = new System.Drawing.Size(170, 28);
            this.idInterventie3.TabIndex = 85;
            this.idInterventie3.SelectedIndexChanged += new System.EventHandler(this.idInterventie3_SelectedIndexChanged);
            // 
            // idInterventieL3
            // 
            this.idInterventieL3.AutoSize = true;
            this.idInterventieL3.Location = new System.Drawing.Point(510, 144);
            this.idInterventieL3.Name = "idInterventieL3";
            this.idInterventieL3.Size = new System.Drawing.Size(105, 20);
            this.idInterventieL3.TabIndex = 84;
            this.idInterventieL3.Text = "Intervention Id";
            this.idInterventieL3.Click += new System.EventHandler(this.idInterventieL3_Click);
            // 
            // SAdmissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.specialistsTab);
            this.Controls.Add(this.backButton);
            this.MaximizeBox = false;
            this.Name = "SAdmissions";
            this.ShowIcon = false;
            this.Text = "Admissions";
            this.Load += new System.EventHandler(this.SAdmissions_Load);
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
        private System.Windows.Forms.Label idInternareL2;
        private System.Windows.Forms.Button applyButton4;
        private System.Windows.Forms.Label idInternareL3;
        private System.Windows.Forms.ComboBox columnChoice;
        private System.Windows.Forms.Label columnL;
        private System.Windows.Forms.Button applyButton3;
        private System.Windows.Forms.TextBox dataExtern;
        private System.Windows.Forms.Label dataExternL;
        private System.Windows.Forms.TextBox dataIntern;
        private System.Windows.Forms.Label dataInternL;
        private System.Windows.Forms.Label idAsisL;
        private System.Windows.Forms.Label idInterventieL;
        private System.Windows.Forms.TextBox nrCamera;
        private System.Windows.Forms.Label nrCameraL;
        private System.Windows.Forms.TextBox idInternare;
        private System.Windows.Forms.Label idInternareL;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.ComboBox idAsis;
        private System.Windows.Forms.ComboBox idInterventie;
        private System.Windows.Forms.ComboBox idInternare2;
        private System.Windows.Forms.ComboBox idInternare3;
        private System.Windows.Forms.ComboBox numeAsis;
        private System.Windows.Forms.ComboBox numeInterv;
        private System.Windows.Forms.Label numeAsisL;
        private System.Windows.Forms.Label numeIntervL;
        private System.Windows.Forms.ComboBox numePac;
        private System.Windows.Forms.Label numePacL;
        private System.Windows.Forms.ComboBox idPac;
        private System.Windows.Forms.Label idPacL;
        private System.Windows.Forms.ComboBox numePac2;
        private System.Windows.Forms.Label numePacL2;
        private System.Windows.Forms.ComboBox idPac2;
        private System.Windows.Forms.Label idPacL2;
        private System.Windows.Forms.ComboBox numeInterv2;
        private System.Windows.Forms.Label numeIntervL2;
        private System.Windows.Forms.ComboBox idInterventie2;
        private System.Windows.Forms.Label idInterventieL2;
        private System.Windows.Forms.ComboBox numePac3;
        private System.Windows.Forms.Label numePacL3;
        private System.Windows.Forms.ComboBox idPac3;
        private System.Windows.Forms.Label idPacL3;
        private System.Windows.Forms.ComboBox numeInterv3;
        private System.Windows.Forms.Label numeIntervL3;
        private System.Windows.Forms.ComboBox idInterventie3;
        private System.Windows.Forms.Label idInterventieL3;
    }
}