
namespace MDBStefanAlexandra1306B
{
    partial class DAssistants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DAssistants));
            this.backButton = new System.Windows.Forms.Button();
            this.specialistsTab = new System.Windows.Forms.TabControl();
            this.viewPage = new System.Windows.Forms.TabPage();
            this.applyButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertPage = new System.Windows.Forms.TabPage();
            this.idAsisL = new System.Windows.Forms.Label();
            this.isAsis = new System.Windows.Forms.TextBox();
            this.statutAsisL = new System.Windows.Forms.Label();
            this.salariuAsisL = new System.Windows.Forms.Label();
            this.telAsisL = new System.Windows.Forms.Label();
            this.numeAsisL = new System.Windows.Forms.Label();
            this.statutAsis = new System.Windows.Forms.ComboBox();
            this.salariuAsis = new System.Windows.Forms.TextBox();
            this.telAsis = new System.Windows.Forms.TextBox();
            this.numeAsis = new System.Windows.Forms.TextBox();
            this.applyButton2 = new System.Windows.Forms.Button();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.idAsis2 = new System.Windows.Forms.ComboBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.columnChoice = new System.Windows.Forms.ComboBox();
            this.columnL = new System.Windows.Forms.Label();
            this.idAsisL2 = new System.Windows.Forms.Label();
            this.applyButton3 = new System.Windows.Forms.Button();
            this.removePage = new System.Windows.Forms.TabPage();
            this.idAsis3 = new System.Windows.Forms.ComboBox();
            this.idAsisL3 = new System.Windows.Forms.Label();
            this.applyButton4 = new System.Windows.Forms.Button();
            this.numeAsisL2 = new System.Windows.Forms.Label();
            this.numeAsis2 = new System.Windows.Forms.ComboBox();
            this.numeAsis3 = new System.Windows.Forms.ComboBox();
            this.numeAsisL3 = new System.Windows.Forms.Label();
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
            this.insertPage.Controls.Add(this.idAsisL);
            this.insertPage.Controls.Add(this.isAsis);
            this.insertPage.Controls.Add(this.statutAsisL);
            this.insertPage.Controls.Add(this.salariuAsisL);
            this.insertPage.Controls.Add(this.telAsisL);
            this.insertPage.Controls.Add(this.numeAsisL);
            this.insertPage.Controls.Add(this.statutAsis);
            this.insertPage.Controls.Add(this.salariuAsis);
            this.insertPage.Controls.Add(this.telAsis);
            this.insertPage.Controls.Add(this.numeAsis);
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
            // idAsisL
            // 
            this.idAsisL.AutoSize = true;
            this.idAsisL.Enabled = false;
            this.idAsisL.Location = new System.Drawing.Point(111, 104);
            this.idAsisL.Name = "idAsisL";
            this.idAsisL.Size = new System.Drawing.Size(22, 20);
            this.idAsisL.TabIndex = 33;
            this.idAsisL.Text = "Id";
            this.idAsisL.Click += new System.EventHandler(this.idAsisL_Click);
            // 
            // isAsis
            // 
            this.isAsis.Enabled = false;
            this.isAsis.Location = new System.Drawing.Point(305, 104);
            this.isAsis.Name = "isAsis";
            this.isAsis.Size = new System.Drawing.Size(170, 27);
            this.isAsis.TabIndex = 32;
            this.isAsis.TextChanged += new System.EventHandler(this.isAsis_TextChanged);
            // 
            // statutAsisL
            // 
            this.statutAsisL.AutoSize = true;
            this.statutAsisL.Location = new System.Drawing.Point(111, 520);
            this.statutAsisL.Name = "statutAsisL";
            this.statutAsisL.Size = new System.Drawing.Size(90, 20);
            this.statutAsisL.TabIndex = 18;
            this.statutAsisL.Text = "Certification";
            this.statutAsisL.Click += new System.EventHandler(this.statutAsisL_Click);
            // 
            // salariuAsisL
            // 
            this.salariuAsisL.AutoSize = true;
            this.salariuAsisL.Location = new System.Drawing.Point(111, 416);
            this.salariuAsisL.Name = "salariuAsisL";
            this.salariuAsisL.Size = new System.Drawing.Size(49, 20);
            this.salariuAsisL.TabIndex = 17;
            this.salariuAsisL.Text = "Salary";
            this.salariuAsisL.Click += new System.EventHandler(this.salariuAsisL_Click);
            // 
            // telAsisL
            // 
            this.telAsisL.AutoSize = true;
            this.telAsisL.Location = new System.Drawing.Point(111, 312);
            this.telAsisL.Name = "telAsisL";
            this.telAsisL.Size = new System.Drawing.Size(50, 20);
            this.telAsisL.TabIndex = 16;
            this.telAsisL.Text = "Phone";
            this.telAsisL.Click += new System.EventHandler(this.telAsisL_Click);
            // 
            // numeAsisL
            // 
            this.numeAsisL.AutoSize = true;
            this.numeAsisL.Location = new System.Drawing.Point(111, 208);
            this.numeAsisL.Name = "numeAsisL";
            this.numeAsisL.Size = new System.Drawing.Size(148, 20);
            this.numeAsisL.TabIndex = 15;
            this.numeAsisL.Text = "First name, last name";
            this.numeAsisL.Click += new System.EventHandler(this.numeAsisL_Click);
            // 
            // statutAsis
            // 
            this.statutAsis.FormattingEnabled = true;
            this.statutAsis.Items.AddRange(new object[] {
            "",
            "debutant",
            "integrat",
            "principal"});
            this.statutAsis.Location = new System.Drawing.Point(305, 520);
            this.statutAsis.Name = "statutAsis";
            this.statutAsis.Size = new System.Drawing.Size(170, 28);
            this.statutAsis.TabIndex = 14;
            this.statutAsis.SelectedIndexChanged += new System.EventHandler(this.statutAsis_SelectedIndexChanged);
            // 
            // salariuAsis
            // 
            this.salariuAsis.Location = new System.Drawing.Point(305, 416);
            this.salariuAsis.Name = "salariuAsis";
            this.salariuAsis.Size = new System.Drawing.Size(170, 27);
            this.salariuAsis.TabIndex = 13;
            this.salariuAsis.TextChanged += new System.EventHandler(this.salariuAsis_TextChanged);
            // 
            // telAsis
            // 
            this.telAsis.Location = new System.Drawing.Point(305, 312);
            this.telAsis.Name = "telAsis";
            this.telAsis.Size = new System.Drawing.Size(170, 27);
            this.telAsis.TabIndex = 12;
            this.telAsis.TextChanged += new System.EventHandler(this.telAsis_TextChanged);
            // 
            // numeAsis
            // 
            this.numeAsis.Location = new System.Drawing.Point(305, 208);
            this.numeAsis.Name = "numeAsis";
            this.numeAsis.Size = new System.Drawing.Size(170, 27);
            this.numeAsis.TabIndex = 11;
            this.numeAsis.TextChanged += new System.EventHandler(this.numeAsis_TextChanged);
            // 
            // applyButton2
            // 
            this.applyButton2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton2.Location = new System.Drawing.Point(857, 5);
            this.applyButton2.Name = "applyButton2";
            this.applyButton2.Size = new System.Drawing.Size(94, 29);
            this.applyButton2.TabIndex = 10;
            this.applyButton2.Text = "Apply";
            this.applyButton2.UseVisualStyleBackColor = false;
            this.applyButton2.Click += new System.EventHandler(this.applyButton2_Click);
            // 
            // updatePage
            // 
            this.updatePage.Controls.Add(this.numeAsis2);
            this.updatePage.Controls.Add(this.numeAsisL2);
            this.updatePage.Controls.Add(this.idAsis2);
            this.updatePage.Controls.Add(this.valueBox);
            this.updatePage.Controls.Add(this.columnChoice);
            this.updatePage.Controls.Add(this.columnL);
            this.updatePage.Controls.Add(this.idAsisL2);
            this.updatePage.Controls.Add(this.applyButton3);
            this.updatePage.Location = new System.Drawing.Point(4, 29);
            this.updatePage.Name = "updatePage";
            this.updatePage.Size = new System.Drawing.Size(950, 620);
            this.updatePage.TabIndex = 2;
            this.updatePage.Text = "Update";
            this.updatePage.UseVisualStyleBackColor = true;
            this.updatePage.Click += new System.EventHandler(this.updatePage_Click);
            // 
            // idAsis2
            // 
            this.idAsis2.FormattingEnabled = true;
            this.idAsis2.Location = new System.Drawing.Point(704, 104);
            this.idAsis2.Name = "idAsis2";
            this.idAsis2.Size = new System.Drawing.Size(170, 28);
            this.idAsis2.TabIndex = 36;
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(704, 208);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(170, 27);
            this.valueBox.TabIndex = 34;
            this.valueBox.TextChanged += new System.EventHandler(this.valueBox_TextChanged);
            // 
            // columnChoice
            // 
            this.columnChoice.FormattingEnabled = true;
            this.columnChoice.Items.AddRange(new object[] {
            "nume_asis",
            "statut_asis",
            "tel_asis",
            "salariu_asis"});
            this.columnChoice.Location = new System.Drawing.Point(305, 208);
            this.columnChoice.Name = "columnChoice";
            this.columnChoice.Size = new System.Drawing.Size(170, 28);
            this.columnChoice.TabIndex = 33;
            this.columnChoice.SelectedIndexChanged += new System.EventHandler(this.columnChoice_SelectedIndexChanged);
            // 
            // columnL
            // 
            this.columnL.AutoSize = true;
            this.columnL.Location = new System.Drawing.Point(111, 208);
            this.columnL.Name = "columnL";
            this.columnL.Size = new System.Drawing.Size(60, 20);
            this.columnL.TabIndex = 32;
            this.columnL.Text = "Column";
            this.columnL.Click += new System.EventHandler(this.columnL_Click);
            // 
            // idAsisL2
            // 
            this.idAsisL2.AutoSize = true;
            this.idAsisL2.Location = new System.Drawing.Point(510, 104);
            this.idAsisL2.Name = "idAsisL2";
            this.idAsisL2.Size = new System.Drawing.Size(22, 20);
            this.idAsisL2.TabIndex = 31;
            this.idAsisL2.Text = "Id";
            this.idAsisL2.Click += new System.EventHandler(this.idAsisL2_Click);
            // 
            // applyButton3
            // 
            this.applyButton3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton3.Location = new System.Drawing.Point(857, 5);
            this.applyButton3.Name = "applyButton3";
            this.applyButton3.Size = new System.Drawing.Size(94, 29);
            this.applyButton3.TabIndex = 21;
            this.applyButton3.Text = "Apply";
            this.applyButton3.UseVisualStyleBackColor = false;
            this.applyButton3.Click += new System.EventHandler(this.applyButton3_Click);
            // 
            // removePage
            // 
            this.removePage.Controls.Add(this.numeAsis3);
            this.removePage.Controls.Add(this.numeAsisL3);
            this.removePage.Controls.Add(this.idAsis3);
            this.removePage.Controls.Add(this.idAsisL3);
            this.removePage.Controls.Add(this.applyButton4);
            this.removePage.Location = new System.Drawing.Point(4, 29);
            this.removePage.Name = "removePage";
            this.removePage.Size = new System.Drawing.Size(950, 620);
            this.removePage.TabIndex = 3;
            this.removePage.Text = "Remove";
            this.removePage.UseVisualStyleBackColor = true;
            this.removePage.Click += new System.EventHandler(this.removePage_Click);
            // 
            // idAsis3
            // 
            this.idAsis3.FormattingEnabled = true;
            this.idAsis3.Location = new System.Drawing.Point(704, 104);
            this.idAsis3.Name = "idAsis3";
            this.idAsis3.Size = new System.Drawing.Size(170, 28);
            this.idAsis3.TabIndex = 37;
            this.idAsis3.SelectedIndexChanged += new System.EventHandler(this.idAsis3_SelectedIndexChanged);
            // 
            // idAsisL3
            // 
            this.idAsisL3.AutoSize = true;
            this.idAsisL3.Location = new System.Drawing.Point(510, 104);
            this.idAsisL3.Name = "idAsisL3";
            this.idAsisL3.Size = new System.Drawing.Size(22, 20);
            this.idAsisL3.TabIndex = 42;
            this.idAsisL3.Text = "Id";
            this.idAsisL3.Click += new System.EventHandler(this.idAsisL3_Click);
            // 
            // applyButton4
            // 
            this.applyButton4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton4.Location = new System.Drawing.Point(857, 5);
            this.applyButton4.Name = "applyButton4";
            this.applyButton4.Size = new System.Drawing.Size(94, 29);
            this.applyButton4.TabIndex = 34;
            this.applyButton4.Text = "Apply";
            this.applyButton4.UseVisualStyleBackColor = false;
            this.applyButton4.Click += new System.EventHandler(this.applyButton4_Click);
            // 
            // numeAsisL2
            // 
            this.numeAsisL2.AutoSize = true;
            this.numeAsisL2.Location = new System.Drawing.Point(111, 104);
            this.numeAsisL2.Name = "numeAsisL2";
            this.numeAsisL2.Size = new System.Drawing.Size(148, 20);
            this.numeAsisL2.TabIndex = 37;
            this.numeAsisL2.Text = "First name, last name";
            this.numeAsisL2.Click += new System.EventHandler(this.numeAsisL2_Click);
            // 
            // numeAsis2
            // 
            this.numeAsis2.FormattingEnabled = true;
            this.numeAsis2.Location = new System.Drawing.Point(305, 104);
            this.numeAsis2.Name = "numeAsis2";
            this.numeAsis2.Size = new System.Drawing.Size(170, 28);
            this.numeAsis2.TabIndex = 38;
            this.numeAsis2.SelectedIndexChanged += new System.EventHandler(this.numeAsis2_SelectedIndexChanged);
            // 
            // numeAsis3
            // 
            this.numeAsis3.FormattingEnabled = true;
            this.numeAsis3.Location = new System.Drawing.Point(305, 104);
            this.numeAsis3.Name = "numeAsis3";
            this.numeAsis3.Size = new System.Drawing.Size(170, 28);
            this.numeAsis3.TabIndex = 44;
            this.numeAsis3.SelectedIndexChanged += new System.EventHandler(this.numeAsis3_SelectedIndexChanged);
            // 
            // numeAsisL3
            // 
            this.numeAsisL3.AutoSize = true;
            this.numeAsisL3.Location = new System.Drawing.Point(111, 104);
            this.numeAsisL3.Name = "numeAsisL3";
            this.numeAsisL3.Size = new System.Drawing.Size(148, 20);
            this.numeAsisL3.TabIndex = 43;
            this.numeAsisL3.Text = "First name, last name";
            this.numeAsisL3.Click += new System.EventHandler(this.numeAsisL3_Click);
            // 
            // DAssistants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.specialistsTab);
            this.Controls.Add(this.backButton);
            this.MaximizeBox = false;
            this.Name = "DAssistants";
            this.ShowIcon = false;
            this.Text = "Assistants";
            this.Load += new System.EventHandler(this.DAssistants_Load);
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
        private System.Windows.Forms.ComboBox statutAsis;
        private System.Windows.Forms.TextBox salariuAsis;
        private System.Windows.Forms.TextBox telAsis;
        private System.Windows.Forms.TextBox numeAsis;
        private System.Windows.Forms.Label statutAsisL;
        private System.Windows.Forms.Label salariuAsisL;
        private System.Windows.Forms.Label telAsisL;
        private System.Windows.Forms.Label numeAsisL;
        private System.Windows.Forms.Label idAsisL2;
        private System.Windows.Forms.Button applyButton3;
        private System.Windows.Forms.Label idAsisL3;
        private System.Windows.Forms.Button applyButton4;
        private System.Windows.Forms.Label idAsisL;
        private System.Windows.Forms.TextBox isAsis;
        private System.Windows.Forms.ComboBox columnChoice;
        private System.Windows.Forms.Label columnL;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.ComboBox idAsis2;
        private System.Windows.Forms.ComboBox idAsis3;
        private System.Windows.Forms.ComboBox numeAsis2;
        private System.Windows.Forms.Label numeAsisL2;
        private System.Windows.Forms.ComboBox numeAsis3;
        private System.Windows.Forms.Label numeAsisL3;
    }
}