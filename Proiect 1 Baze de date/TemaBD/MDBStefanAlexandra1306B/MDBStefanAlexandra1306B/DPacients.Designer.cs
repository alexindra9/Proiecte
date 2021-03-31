
namespace MDBStefanAlexandra1306B
{
    partial class DPacients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DPacients));
            this.backButton = new System.Windows.Forms.Button();
            this.specialistsTab = new System.Windows.Forms.TabControl();
            this.viewPage = new System.Windows.Forms.TabPage();
            this.applyButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertPage = new System.Windows.Forms.TabPage();
            this.telPacient = new System.Windows.Forms.TextBox();
            this.idPacientL = new System.Windows.Forms.Label();
            this.idPacient = new System.Windows.Forms.TextBox();
            this.adresaL = new System.Windows.Forms.Label();
            this.SSNL = new System.Windows.Forms.Label();
            this.telPacientL = new System.Windows.Forms.Label();
            this.numePacientL = new System.Windows.Forms.Label();
            this.adresa = new System.Windows.Forms.TextBox();
            this.numePacient = new System.Windows.Forms.TextBox();
            this.SSN = new System.Windows.Forms.TextBox();
            this.applyButton2 = new System.Windows.Forms.Button();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.idPacient2 = new System.Windows.Forms.ComboBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.columnChoice = new System.Windows.Forms.ComboBox();
            this.columnL = new System.Windows.Forms.Label();
            this.idPacientL2 = new System.Windows.Forms.Label();
            this.applyButton3 = new System.Windows.Forms.Button();
            this.removePage = new System.Windows.Forms.TabPage();
            this.idPacient3 = new System.Windows.Forms.ComboBox();
            this.idPacientL3 = new System.Windows.Forms.Label();
            this.applyButton4 = new System.Windows.Forms.Button();
            this.numePacientL2 = new System.Windows.Forms.Label();
            this.numePacientL3 = new System.Windows.Forms.Label();
            this.numePacient2 = new System.Windows.Forms.ComboBox();
            this.numePacient3 = new System.Windows.Forms.ComboBox();
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
            this.specialistsTab.TabIndex = 22;
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
            this.applyButton.TabIndex = 9;
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
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // insertPage
            // 
            this.insertPage.Controls.Add(this.telPacient);
            this.insertPage.Controls.Add(this.idPacientL);
            this.insertPage.Controls.Add(this.idPacient);
            this.insertPage.Controls.Add(this.adresaL);
            this.insertPage.Controls.Add(this.SSNL);
            this.insertPage.Controls.Add(this.telPacientL);
            this.insertPage.Controls.Add(this.numePacientL);
            this.insertPage.Controls.Add(this.adresa);
            this.insertPage.Controls.Add(this.numePacient);
            this.insertPage.Controls.Add(this.SSN);
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
            // telPacient
            // 
            this.telPacient.Location = new System.Drawing.Point(305, 520);
            this.telPacient.Name = "telPacient";
            this.telPacient.Size = new System.Drawing.Size(170, 27);
            this.telPacient.TabIndex = 45;
            this.telPacient.TextChanged += new System.EventHandler(this.telPacient_TextChanged);
            // 
            // idPacientL
            // 
            this.idPacientL.AutoSize = true;
            this.idPacientL.Location = new System.Drawing.Point(111, 104);
            this.idPacientL.Name = "idPacientL";
            this.idPacientL.Size = new System.Drawing.Size(73, 20);
            this.idPacientL.TabIndex = 44;
            this.idPacientL.Text = "Pacient Id";
            this.idPacientL.Click += new System.EventHandler(this.idPacientL_Click);
            // 
            // idPacient
            // 
            this.idPacient.Location = new System.Drawing.Point(305, 104);
            this.idPacient.Name = "idPacient";
            this.idPacient.Size = new System.Drawing.Size(170, 27);
            this.idPacient.TabIndex = 43;
            this.idPacient.TextChanged += new System.EventHandler(this.idPacient_TextChanged);
            // 
            // adresaL
            // 
            this.adresaL.AutoSize = true;
            this.adresaL.Location = new System.Drawing.Point(111, 416);
            this.adresaL.Name = "adresaL";
            this.adresaL.Size = new System.Drawing.Size(62, 20);
            this.adresaL.TabIndex = 42;
            this.adresaL.Text = "Address";
            this.adresaL.Click += new System.EventHandler(this.adresaL_Click);
            // 
            // SSNL
            // 
            this.SSNL.AutoSize = true;
            this.SSNL.Location = new System.Drawing.Point(111, 208);
            this.SSNL.Name = "SSNL";
            this.SSNL.Size = new System.Drawing.Size(36, 20);
            this.SSNL.TabIndex = 41;
            this.SSNL.Text = "SSN";
            this.SSNL.Click += new System.EventHandler(this.SSNL_Click);
            // 
            // telPacientL
            // 
            this.telPacientL.AutoSize = true;
            this.telPacientL.Location = new System.Drawing.Point(111, 520);
            this.telPacientL.Name = "telPacientL";
            this.telPacientL.Size = new System.Drawing.Size(50, 20);
            this.telPacientL.TabIndex = 40;
            this.telPacientL.Text = "Phone";
            this.telPacientL.Click += new System.EventHandler(this.telPacientL_Click);
            // 
            // numePacientL
            // 
            this.numePacientL.AutoSize = true;
            this.numePacientL.Location = new System.Drawing.Point(111, 312);
            this.numePacientL.Name = "numePacientL";
            this.numePacientL.Size = new System.Drawing.Size(148, 20);
            this.numePacientL.TabIndex = 39;
            this.numePacientL.Text = "First name, last name";
            this.numePacientL.Click += new System.EventHandler(this.numePacientL_Click);
            // 
            // adresa
            // 
            this.adresa.Location = new System.Drawing.Point(305, 416);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(170, 27);
            this.adresa.TabIndex = 37;
            this.adresa.TextChanged += new System.EventHandler(this.adresa_TextChanged);
            // 
            // numePacient
            // 
            this.numePacient.Location = new System.Drawing.Point(305, 312);
            this.numePacient.Name = "numePacient";
            this.numePacient.Size = new System.Drawing.Size(170, 27);
            this.numePacient.TabIndex = 36;
            this.numePacient.TextChanged += new System.EventHandler(this.numePacient_TextChanged);
            // 
            // SSN
            // 
            this.SSN.Location = new System.Drawing.Point(305, 208);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(170, 27);
            this.SSN.TabIndex = 35;
            this.SSN.TextChanged += new System.EventHandler(this.SSN_TextChanged);
            // 
            // applyButton2
            // 
            this.applyButton2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton2.Location = new System.Drawing.Point(857, 5);
            this.applyButton2.Name = "applyButton2";
            this.applyButton2.Size = new System.Drawing.Size(94, 29);
            this.applyButton2.TabIndex = 34;
            this.applyButton2.Text = "Apply";
            this.applyButton2.UseVisualStyleBackColor = false;
            this.applyButton2.Click += new System.EventHandler(this.applyButton2_Click);
            // 
            // updatePage
            // 
            this.updatePage.Controls.Add(this.numePacient2);
            this.updatePage.Controls.Add(this.numePacientL2);
            this.updatePage.Controls.Add(this.idPacient2);
            this.updatePage.Controls.Add(this.valueBox);
            this.updatePage.Controls.Add(this.columnChoice);
            this.updatePage.Controls.Add(this.columnL);
            this.updatePage.Controls.Add(this.idPacientL2);
            this.updatePage.Controls.Add(this.applyButton3);
            this.updatePage.Location = new System.Drawing.Point(4, 29);
            this.updatePage.Name = "updatePage";
            this.updatePage.Size = new System.Drawing.Size(950, 620);
            this.updatePage.TabIndex = 2;
            this.updatePage.Text = "Update";
            this.updatePage.UseVisualStyleBackColor = true;
            this.updatePage.Click += new System.EventHandler(this.updatePage_Click);
            // 
            // idPacient2
            // 
            this.idPacient2.FormattingEnabled = true;
            this.idPacient2.Location = new System.Drawing.Point(704, 104);
            this.idPacient2.Name = "idPacient2";
            this.idPacient2.Size = new System.Drawing.Size(170, 28);
            this.idPacient2.TabIndex = 59;
            this.idPacient2.SelectedIndexChanged += new System.EventHandler(this.idPacient2_SelectedIndexChanged);
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(704, 208);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(170, 27);
            this.valueBox.TabIndex = 58;
            this.valueBox.TextChanged += new System.EventHandler(this.valueBox_TextChanged);
            // 
            // columnChoice
            // 
            this.columnChoice.FormattingEnabled = true;
            this.columnChoice.Items.AddRange(new object[] {
            "cod_asig",
            "cnp_pac",
            "nume_pac",
            "adresa_pac",
            "tel_pac"});
            this.columnChoice.Location = new System.Drawing.Point(305, 208);
            this.columnChoice.Name = "columnChoice";
            this.columnChoice.Size = new System.Drawing.Size(170, 28);
            this.columnChoice.TabIndex = 57;
            this.columnChoice.SelectedIndexChanged += new System.EventHandler(this.columnChoice_SelectedIndexChanged);
            // 
            // columnL
            // 
            this.columnL.AutoSize = true;
            this.columnL.Location = new System.Drawing.Point(111, 208);
            this.columnL.Name = "columnL";
            this.columnL.Size = new System.Drawing.Size(60, 20);
            this.columnL.TabIndex = 56;
            this.columnL.Text = "Column";
            this.columnL.Click += new System.EventHandler(this.columnL_Click);
            // 
            // idPacientL2
            // 
            this.idPacientL2.AutoSize = true;
            this.idPacientL2.Location = new System.Drawing.Point(510, 104);
            this.idPacientL2.Name = "idPacientL2";
            this.idPacientL2.Size = new System.Drawing.Size(73, 20);
            this.idPacientL2.TabIndex = 55;
            this.idPacientL2.Text = "Pacient Id";
            this.idPacientL2.Click += new System.EventHandler(this.idPacientL2_Click);
            // 
            // applyButton3
            // 
            this.applyButton3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton3.Location = new System.Drawing.Point(857, 5);
            this.applyButton3.Name = "applyButton3";
            this.applyButton3.Size = new System.Drawing.Size(94, 29);
            this.applyButton3.TabIndex = 46;
            this.applyButton3.Text = "Apply";
            this.applyButton3.UseVisualStyleBackColor = false;
            this.applyButton3.Click += new System.EventHandler(this.applyButton3_Click);
            // 
            // removePage
            // 
            this.removePage.Controls.Add(this.numePacient3);
            this.removePage.Controls.Add(this.numePacientL3);
            this.removePage.Controls.Add(this.idPacient3);
            this.removePage.Controls.Add(this.idPacientL3);
            this.removePage.Controls.Add(this.applyButton4);
            this.removePage.Location = new System.Drawing.Point(4, 29);
            this.removePage.Name = "removePage";
            this.removePage.Size = new System.Drawing.Size(950, 620);
            this.removePage.TabIndex = 3;
            this.removePage.Text = "Remove";
            this.removePage.UseVisualStyleBackColor = true;
            this.removePage.Click += new System.EventHandler(this.removePage_Click);
            // 
            // idPacient3
            // 
            this.idPacient3.FormattingEnabled = true;
            this.idPacient3.Location = new System.Drawing.Point(704, 104);
            this.idPacient3.Name = "idPacient3";
            this.idPacient3.Size = new System.Drawing.Size(170, 28);
            this.idPacient3.TabIndex = 56;
            this.idPacient3.SelectedIndexChanged += new System.EventHandler(this.idPacient3_SelectedIndexChanged);
            // 
            // idPacientL3
            // 
            this.idPacientL3.AutoSize = true;
            this.idPacientL3.Location = new System.Drawing.Point(510, 104);
            this.idPacientL3.Name = "idPacientL3";
            this.idPacientL3.Size = new System.Drawing.Size(73, 20);
            this.idPacientL3.TabIndex = 55;
            this.idPacientL3.Text = "Pacient Id";
            this.idPacientL3.Click += new System.EventHandler(this.idPacientL3_Click);
            // 
            // applyButton4
            // 
            this.applyButton4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton4.Location = new System.Drawing.Point(857, 5);
            this.applyButton4.Name = "applyButton4";
            this.applyButton4.Size = new System.Drawing.Size(94, 29);
            this.applyButton4.TabIndex = 46;
            this.applyButton4.Text = "Apply";
            this.applyButton4.UseVisualStyleBackColor = false;
            this.applyButton4.Click += new System.EventHandler(this.applyButton4_Click);
            // 
            // numePacientL2
            // 
            this.numePacientL2.AutoSize = true;
            this.numePacientL2.Location = new System.Drawing.Point(111, 105);
            this.numePacientL2.Name = "numePacientL2";
            this.numePacientL2.Size = new System.Drawing.Size(148, 20);
            this.numePacientL2.TabIndex = 61;
            this.numePacientL2.Text = "First name, last name";
            this.numePacientL2.Click += new System.EventHandler(this.numePacientL2_Click);
            // 
            // numePacientL3
            // 
            this.numePacientL3.AutoSize = true;
            this.numePacientL3.Location = new System.Drawing.Point(111, 104);
            this.numePacientL3.Name = "numePacientL3";
            this.numePacientL3.Size = new System.Drawing.Size(148, 20);
            this.numePacientL3.TabIndex = 58;
            this.numePacientL3.Text = "First name, last name";
            this.numePacientL3.Click += new System.EventHandler(this.numePacientL3_Click);
            // 
            // numePacient2
            // 
            this.numePacient2.FormattingEnabled = true;
            this.numePacient2.Items.AddRange(new object[] {
            "cod_asig",
            "cnp_pac",
            "nume_pac",
            "adresa_pac",
            "tel_pac"});
            this.numePacient2.Location = new System.Drawing.Point(305, 104);
            this.numePacient2.Name = "numePacient2";
            this.numePacient2.Size = new System.Drawing.Size(170, 28);
            this.numePacient2.TabIndex = 62;
            this.numePacient2.SelectedIndexChanged += new System.EventHandler(this.numePacient2_SelectedIndexChanged);
            // 
            // numePacient3
            // 
            this.numePacient3.FormattingEnabled = true;
            this.numePacient3.Items.AddRange(new object[] {
            "cod_asig",
            "cnp_pac",
            "nume_pac",
            "adresa_pac",
            "tel_pac"});
            this.numePacient3.Location = new System.Drawing.Point(305, 104);
            this.numePacient3.Name = "numePacient3";
            this.numePacient3.Size = new System.Drawing.Size(170, 28);
            this.numePacient3.TabIndex = 59;
            this.numePacient3.SelectedIndexChanged += new System.EventHandler(this.numePacient3_SelectedIndexChanged);
            // 
            // DPacients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.specialistsTab);
            this.Controls.Add(this.backButton);
            this.MaximizeBox = false;
            this.Name = "DPacients";
            this.ShowIcon = false;
            this.Text = "Pacients";
            this.Load += new System.EventHandler(this.DPacients_Load);
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
        private System.Windows.Forms.TextBox telPacient;
        private System.Windows.Forms.Label idPacientL;
        private System.Windows.Forms.TextBox idPacient;
        private System.Windows.Forms.Label adresaL;
        private System.Windows.Forms.Label SSNL;
        private System.Windows.Forms.Label telPacientL;
        private System.Windows.Forms.Label numePacientL;
        private System.Windows.Forms.TextBox adresa;
        private System.Windows.Forms.TextBox numePacient;
        private System.Windows.Forms.TextBox SSN;
        private System.Windows.Forms.Button applyButton2;
        private System.Windows.Forms.Label idPacientL2;
        private System.Windows.Forms.Button applyButton3;
        private System.Windows.Forms.Label idPacientL3;
        private System.Windows.Forms.Button applyButton4;
        private System.Windows.Forms.ComboBox columnChoice;
        private System.Windows.Forms.Label columnL;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.ComboBox idPacient2;
        private System.Windows.Forms.ComboBox idPacient3;
        private System.Windows.Forms.Label numePacientL2;
        private System.Windows.Forms.Label numePacientL3;
        private System.Windows.Forms.ComboBox numePacient2;
        private System.Windows.Forms.ComboBox numePacient3;
    }
}