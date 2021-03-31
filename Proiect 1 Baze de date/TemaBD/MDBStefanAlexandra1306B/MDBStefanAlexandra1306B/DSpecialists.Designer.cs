
namespace MDBStefanAlexandra1306B
{
    partial class DSpecialists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSpecialists));
            this.backButton = new System.Windows.Forms.Button();
            this.specialistsTab = new System.Windows.Forms.TabControl();
            this.viewPage = new System.Windows.Forms.TabPage();
            this.applyButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertPage = new System.Windows.Forms.TabPage();
            this.idDept = new System.Windows.Forms.ComboBox();
            this.applyButton2 = new System.Windows.Forms.Button();
            this.idDeptL = new System.Windows.Forms.Label();
            this.salariuSpec = new System.Windows.Forms.TextBox();
            this.salariuSpecL = new System.Windows.Forms.Label();
            this.telSpec = new System.Windows.Forms.TextBox();
            this.telSpecL = new System.Windows.Forms.Label();
            this.emailSpec = new System.Windows.Forms.TextBox();
            this.emailSpecL = new System.Windows.Forms.Label();
            this.numeSpec = new System.Windows.Forms.TextBox();
            this.numeSpecL = new System.Windows.Forms.Label();
            this.idSpec = new System.Windows.Forms.TextBox();
            this.idSpecL = new System.Windows.Forms.Label();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.idSpec2 = new System.Windows.Forms.ComboBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.columnChoice = new System.Windows.Forms.ComboBox();
            this.columnL = new System.Windows.Forms.Label();
            this.applyButton3 = new System.Windows.Forms.Button();
            this.idSpecL2 = new System.Windows.Forms.Label();
            this.removePage = new System.Windows.Forms.TabPage();
            this.idSpec3 = new System.Windows.Forms.ComboBox();
            this.applyButton4 = new System.Windows.Forms.Button();
            this.idSpecL3 = new System.Windows.Forms.Label();
            this.numeDept = new System.Windows.Forms.ComboBox();
            this.numeDeptL = new System.Windows.Forms.Label();
            this.numeSpec2 = new System.Windows.Forms.ComboBox();
            this.numeSpecL2 = new System.Windows.Forms.Label();
            this.numeSpec3 = new System.Windows.Forms.ComboBox();
            this.numeSpecL3 = new System.Windows.Forms.Label();
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
            this.specialistsTab.TabIndex = 21;
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
            this.insertPage.Controls.Add(this.numeDept);
            this.insertPage.Controls.Add(this.numeDeptL);
            this.insertPage.Controls.Add(this.idDept);
            this.insertPage.Controls.Add(this.applyButton2);
            this.insertPage.Controls.Add(this.idDeptL);
            this.insertPage.Controls.Add(this.salariuSpec);
            this.insertPage.Controls.Add(this.salariuSpecL);
            this.insertPage.Controls.Add(this.telSpec);
            this.insertPage.Controls.Add(this.telSpecL);
            this.insertPage.Controls.Add(this.emailSpec);
            this.insertPage.Controls.Add(this.emailSpecL);
            this.insertPage.Controls.Add(this.numeSpec);
            this.insertPage.Controls.Add(this.numeSpecL);
            this.insertPage.Controls.Add(this.idSpec);
            this.insertPage.Controls.Add(this.idSpecL);
            this.insertPage.Location = new System.Drawing.Point(4, 29);
            this.insertPage.Name = "insertPage";
            this.insertPage.Padding = new System.Windows.Forms.Padding(3);
            this.insertPage.Size = new System.Drawing.Size(950, 620);
            this.insertPage.TabIndex = 1;
            this.insertPage.Text = "Insert";
            this.insertPage.UseVisualStyleBackColor = true;
            this.insertPage.Click += new System.EventHandler(this.insertPage_Click);
            // 
            // idDept
            // 
            this.idDept.FormattingEnabled = true;
            this.idDept.Location = new System.Drawing.Point(704, 504);
            this.idDept.Name = "idDept";
            this.idDept.Size = new System.Drawing.Size(170, 28);
            this.idDept.TabIndex = 41;
            this.idDept.SelectedIndexChanged += new System.EventHandler(this.idDept_SelectedIndexChanged);
            // 
            // applyButton2
            // 
            this.applyButton2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton2.Location = new System.Drawing.Point(857, 5);
            this.applyButton2.Name = "applyButton2";
            this.applyButton2.Size = new System.Drawing.Size(94, 29);
            this.applyButton2.TabIndex = 40;
            this.applyButton2.Text = "Apply";
            this.applyButton2.UseVisualStyleBackColor = false;
            this.applyButton2.Click += new System.EventHandler(this.applyButton2_Click);
            // 
            // idDeptL
            // 
            this.idDeptL.AutoSize = true;
            this.idDeptL.Location = new System.Drawing.Point(510, 504);
            this.idDeptL.Name = "idDeptL";
            this.idDeptL.Size = new System.Drawing.Size(106, 20);
            this.idDeptL.TabIndex = 38;
            this.idDeptL.Text = "Department Id";
            this.idDeptL.Click += new System.EventHandler(this.idDeptL_Click);
            // 
            // salariuSpec
            // 
            this.salariuSpec.Location = new System.Drawing.Point(305, 420);
            this.salariuSpec.Name = "salariuSpec";
            this.salariuSpec.Size = new System.Drawing.Size(170, 27);
            this.salariuSpec.TabIndex = 37;
            this.salariuSpec.TextChanged += new System.EventHandler(this.salariuSpec_TextChanged);
            // 
            // salariuSpecL
            // 
            this.salariuSpecL.AutoSize = true;
            this.salariuSpecL.Location = new System.Drawing.Point(111, 420);
            this.salariuSpecL.Name = "salariuSpecL";
            this.salariuSpecL.Size = new System.Drawing.Size(49, 20);
            this.salariuSpecL.TabIndex = 36;
            this.salariuSpecL.Text = "Salary";
            this.salariuSpecL.Click += new System.EventHandler(this.salariuSpecL_Click);
            // 
            // telSpec
            // 
            this.telSpec.Location = new System.Drawing.Point(305, 336);
            this.telSpec.Name = "telSpec";
            this.telSpec.Size = new System.Drawing.Size(170, 27);
            this.telSpec.TabIndex = 35;
            this.telSpec.TextChanged += new System.EventHandler(this.telSpec_TextChanged);
            // 
            // telSpecL
            // 
            this.telSpecL.AutoSize = true;
            this.telSpecL.Location = new System.Drawing.Point(111, 336);
            this.telSpecL.Name = "telSpecL";
            this.telSpecL.Size = new System.Drawing.Size(50, 20);
            this.telSpecL.TabIndex = 34;
            this.telSpecL.Text = "Phone";
            this.telSpecL.Click += new System.EventHandler(this.telSpecL_Click);
            // 
            // emailSpec
            // 
            this.emailSpec.Location = new System.Drawing.Point(305, 252);
            this.emailSpec.Name = "emailSpec";
            this.emailSpec.Size = new System.Drawing.Size(170, 27);
            this.emailSpec.TabIndex = 33;
            this.emailSpec.TextChanged += new System.EventHandler(this.emailSpec_TextChanged);
            // 
            // emailSpecL
            // 
            this.emailSpecL.AutoSize = true;
            this.emailSpecL.Location = new System.Drawing.Point(111, 252);
            this.emailSpecL.Name = "emailSpecL";
            this.emailSpecL.Size = new System.Drawing.Size(46, 20);
            this.emailSpecL.TabIndex = 32;
            this.emailSpecL.Text = "Email";
            this.emailSpecL.Click += new System.EventHandler(this.emailSpecL_Click);
            // 
            // numeSpec
            // 
            this.numeSpec.Location = new System.Drawing.Point(305, 168);
            this.numeSpec.Name = "numeSpec";
            this.numeSpec.Size = new System.Drawing.Size(170, 27);
            this.numeSpec.TabIndex = 31;
            this.numeSpec.TextChanged += new System.EventHandler(this.numeSpec_TextChanged);
            // 
            // numeSpecL
            // 
            this.numeSpecL.AutoSize = true;
            this.numeSpecL.Location = new System.Drawing.Point(111, 168);
            this.numeSpecL.Name = "numeSpecL";
            this.numeSpecL.Size = new System.Drawing.Size(49, 20);
            this.numeSpecL.TabIndex = 30;
            this.numeSpecL.Text = "Name";
            this.numeSpecL.Click += new System.EventHandler(this.numeSpecL_Click);
            // 
            // idSpec
            // 
            this.idSpec.Enabled = false;
            this.idSpec.Location = new System.Drawing.Point(305, 84);
            this.idSpec.Name = "idSpec";
            this.idSpec.Size = new System.Drawing.Size(170, 27);
            this.idSpec.TabIndex = 29;
            this.idSpec.TextChanged += new System.EventHandler(this.idSpec_TextChanged);
            // 
            // idSpecL
            // 
            this.idSpecL.AutoSize = true;
            this.idSpecL.Enabled = false;
            this.idSpecL.Location = new System.Drawing.Point(111, 84);
            this.idSpecL.Name = "idSpecL";
            this.idSpecL.Size = new System.Drawing.Size(22, 20);
            this.idSpecL.TabIndex = 28;
            this.idSpecL.Text = "Id";
            this.idSpecL.Click += new System.EventHandler(this.idSpecL_Click);
            // 
            // updatePage
            // 
            this.updatePage.Controls.Add(this.numeSpec2);
            this.updatePage.Controls.Add(this.numeSpecL2);
            this.updatePage.Controls.Add(this.idSpec2);
            this.updatePage.Controls.Add(this.valueBox);
            this.updatePage.Controls.Add(this.columnChoice);
            this.updatePage.Controls.Add(this.columnL);
            this.updatePage.Controls.Add(this.applyButton3);
            this.updatePage.Controls.Add(this.idSpecL2);
            this.updatePage.Location = new System.Drawing.Point(4, 29);
            this.updatePage.Name = "updatePage";
            this.updatePage.Size = new System.Drawing.Size(950, 620);
            this.updatePage.TabIndex = 2;
            this.updatePage.Text = "Update";
            this.updatePage.UseVisualStyleBackColor = true;
            this.updatePage.Click += new System.EventHandler(this.updatePage_Click);
            // 
            // idSpec2
            // 
            this.idSpec2.FormattingEnabled = true;
            this.idSpec2.Location = new System.Drawing.Point(704, 84);
            this.idSpec2.Name = "idSpec2";
            this.idSpec2.Size = new System.Drawing.Size(170, 28);
            this.idSpec2.TabIndex = 57;
            this.idSpec2.SelectedIndexChanged += new System.EventHandler(this.idSpec2_SelectedIndexChanged);
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(704, 168);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(170, 27);
            this.valueBox.TabIndex = 56;
            this.valueBox.TextChanged += new System.EventHandler(this.valueBox_TextChanged);
            // 
            // columnChoice
            // 
            this.columnChoice.FormattingEnabled = true;
            this.columnChoice.Items.AddRange(new object[] {
            "nume_spec",
            "email_spec",
            "tel_spec",
            "salariu_spec",
            "id_dept"});
            this.columnChoice.Location = new System.Drawing.Point(305, 168);
            this.columnChoice.Name = "columnChoice";
            this.columnChoice.Size = new System.Drawing.Size(170, 28);
            this.columnChoice.TabIndex = 55;
            this.columnChoice.SelectedIndexChanged += new System.EventHandler(this.columnChoice_SelectedIndexChanged);
            // 
            // columnL
            // 
            this.columnL.AutoSize = true;
            this.columnL.Location = new System.Drawing.Point(111, 168);
            this.columnL.Name = "columnL";
            this.columnL.Size = new System.Drawing.Size(60, 20);
            this.columnL.TabIndex = 54;
            this.columnL.Text = "Column";
            this.columnL.Click += new System.EventHandler(this.columnL_Click);
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
            // idSpecL2
            // 
            this.idSpecL2.AutoSize = true;
            this.idSpecL2.Location = new System.Drawing.Point(510, 84);
            this.idSpecL2.Name = "idSpecL2";
            this.idSpecL2.Size = new System.Drawing.Size(22, 20);
            this.idSpecL2.TabIndex = 41;
            this.idSpecL2.Text = "Id";
            this.idSpecL2.Click += new System.EventHandler(this.idSpecL2_Click);
            // 
            // removePage
            // 
            this.removePage.Controls.Add(this.numeSpec3);
            this.removePage.Controls.Add(this.numeSpecL3);
            this.removePage.Controls.Add(this.idSpec3);
            this.removePage.Controls.Add(this.applyButton4);
            this.removePage.Controls.Add(this.idSpecL3);
            this.removePage.Location = new System.Drawing.Point(4, 29);
            this.removePage.Name = "removePage";
            this.removePage.Size = new System.Drawing.Size(950, 620);
            this.removePage.TabIndex = 3;
            this.removePage.Text = "Remove";
            this.removePage.UseVisualStyleBackColor = true;
            this.removePage.Click += new System.EventHandler(this.removePage_Click);
            // 
            // idSpec3
            // 
            this.idSpec3.FormattingEnabled = true;
            this.idSpec3.Location = new System.Drawing.Point(704, 84);
            this.idSpec3.Name = "idSpec3";
            this.idSpec3.Size = new System.Drawing.Size(170, 28);
            this.idSpec3.TabIndex = 54;
            this.idSpec3.SelectedIndexChanged += new System.EventHandler(this.idSpec3_SelectedIndexChanged);
            // 
            // applyButton4
            // 
            this.applyButton4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton4.Location = new System.Drawing.Point(857, 5);
            this.applyButton4.Name = "applyButton4";
            this.applyButton4.Size = new System.Drawing.Size(94, 29);
            this.applyButton4.TabIndex = 53;
            this.applyButton4.Text = "Apply";
            this.applyButton4.UseVisualStyleBackColor = false;
            this.applyButton4.Click += new System.EventHandler(this.applyButton4_Click);
            // 
            // idSpecL3
            // 
            this.idSpecL3.AutoSize = true;
            this.idSpecL3.Location = new System.Drawing.Point(510, 84);
            this.idSpecL3.Name = "idSpecL3";
            this.idSpecL3.Size = new System.Drawing.Size(22, 20);
            this.idSpecL3.TabIndex = 41;
            this.idSpecL3.Text = "Id";
            this.idSpecL3.Click += new System.EventHandler(this.idSpecL3_Click);
            // 
            // numeDept
            // 
            this.numeDept.FormattingEnabled = true;
            this.numeDept.Location = new System.Drawing.Point(305, 501);
            this.numeDept.Name = "numeDept";
            this.numeDept.Size = new System.Drawing.Size(170, 28);
            this.numeDept.TabIndex = 43;
            this.numeDept.SelectedIndexChanged += new System.EventHandler(this.numeDept_SelectedIndexChanged);
            // 
            // numeDeptL
            // 
            this.numeDeptL.AutoSize = true;
            this.numeDeptL.Location = new System.Drawing.Point(111, 501);
            this.numeDeptL.Name = "numeDeptL";
            this.numeDeptL.Size = new System.Drawing.Size(130, 20);
            this.numeDeptL.TabIndex = 42;
            this.numeDeptL.Text = "Department name";
            this.numeDeptL.Click += new System.EventHandler(this.numeDeptL_Click);
            // 
            // numeSpec2
            // 
            this.numeSpec2.FormattingEnabled = true;
            this.numeSpec2.Location = new System.Drawing.Point(305, 84);
            this.numeSpec2.Name = "numeSpec2";
            this.numeSpec2.Size = new System.Drawing.Size(170, 28);
            this.numeSpec2.TabIndex = 59;
            this.numeSpec2.SelectedIndexChanged += new System.EventHandler(this.numeSpec2_SelectedIndexChanged);
            // 
            // numeSpecL2
            // 
            this.numeSpecL2.AutoSize = true;
            this.numeSpecL2.Location = new System.Drawing.Point(111, 84);
            this.numeSpecL2.Name = "numeSpecL2";
            this.numeSpecL2.Size = new System.Drawing.Size(49, 20);
            this.numeSpecL2.TabIndex = 58;
            this.numeSpecL2.Text = "Name";
            this.numeSpecL2.Click += new System.EventHandler(this.numeSpecL2_Click);
            // 
            // numeSpec3
            // 
            this.numeSpec3.FormattingEnabled = true;
            this.numeSpec3.Location = new System.Drawing.Point(305, 84);
            this.numeSpec3.Name = "numeSpec3";
            this.numeSpec3.Size = new System.Drawing.Size(170, 28);
            this.numeSpec3.TabIndex = 61;
            this.numeSpec3.SelectedIndexChanged += new System.EventHandler(this.numeSpec3_SelectedIndexChanged);
            // 
            // numeSpecL3
            // 
            this.numeSpecL3.AutoSize = true;
            this.numeSpecL3.Location = new System.Drawing.Point(111, 84);
            this.numeSpecL3.Name = "numeSpecL3";
            this.numeSpecL3.Size = new System.Drawing.Size(49, 20);
            this.numeSpecL3.TabIndex = 60;
            this.numeSpecL3.Text = "Name";
            this.numeSpecL3.Click += new System.EventHandler(this.numeSpecL3_Click);
            // 
            // DSpecialists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.specialistsTab);
            this.Controls.Add(this.backButton);
            this.MaximizeBox = false;
            this.Name = "DSpecialists";
            this.ShowIcon = false;
            this.Text = "Specialists";
            this.Load += new System.EventHandler(this.DSpecialists_Load);
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
        private System.Windows.Forms.Label idDeptL;
        private System.Windows.Forms.TextBox salariuSpec;
        private System.Windows.Forms.Label salariuSpecL;
        private System.Windows.Forms.TextBox telSpec;
        private System.Windows.Forms.Label telSpecL;
        private System.Windows.Forms.TextBox emailSpec;
        private System.Windows.Forms.Label emailSpecL;
        private System.Windows.Forms.TextBox numeSpec;
        private System.Windows.Forms.Label numeSpecL;
        private System.Windows.Forms.TextBox idSpec;
        private System.Windows.Forms.Label idSpecL;
        private System.Windows.Forms.Button applyButton3;
        private System.Windows.Forms.Label idSpecL2;
        private System.Windows.Forms.Button applyButton4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label idSpecL3;
        private System.Windows.Forms.ComboBox columnChoice;
        private System.Windows.Forms.Label columnL;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.ComboBox idDept;
        private System.Windows.Forms.ComboBox idSpec2;
        private System.Windows.Forms.ComboBox idSpec3;
        private System.Windows.Forms.ComboBox numeDept;
        private System.Windows.Forms.Label numeDeptL;
        private System.Windows.Forms.ComboBox numeSpec2;
        private System.Windows.Forms.Label numeSpecL2;
        private System.Windows.Forms.ComboBox numeSpec3;
        private System.Windows.Forms.Label numeSpecL3;
    }
}