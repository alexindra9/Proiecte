
namespace MDBStefanAlexandra1306B
{
    partial class SGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SGeneral));
            this.backButton = new System.Windows.Forms.Button();
            this.specialistsTab = new System.Windows.Forms.TabControl();
            this.viewPage = new System.Windows.Forms.TabPage();
            this.applyButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertPage = new System.Windows.Forms.TabPage();
            this.insertButton = new System.Windows.Forms.Button();
            this.sefSectie = new System.Windows.Forms.TextBox();
            this.numeDept = new System.Windows.Forms.TextBox();
            this.sefSectieL = new System.Windows.Forms.Label();
            this.numeDeptL = new System.Windows.Forms.Label();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.numeDept2 = new System.Windows.Forms.ComboBox();
            this.numeDeptL2 = new System.Windows.Forms.Label();
            this.idModificat = new System.Windows.Forms.ComboBox();
            this.idModificatL = new System.Windows.Forms.Label();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.columnChoice = new System.Windows.Forms.ComboBox();
            this.columnL = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.removePage = new System.Windows.Forms.TabPage();
            this.numeDept3 = new System.Windows.Forms.ComboBox();
            this.numeDeptL3 = new System.Windows.Forms.Label();
            this.idStersL2 = new System.Windows.Forms.Label();
            this.idSters = new System.Windows.Forms.ComboBox();
            this.idStersL = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.deptPage = new System.Windows.Forms.TabPage();
            this.viewButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.specialistsTab.SuspendLayout();
            this.viewPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.insertPage.SuspendLayout();
            this.updatePage.SuspendLayout();
            this.removePage.SuspendLayout();
            this.deptPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(176)))), ((int)(((byte)(246)))));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(0, 580);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(225, 60);
            this.backButton.TabIndex = 0;
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
            this.specialistsTab.Controls.Add(this.deptPage);
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
            this.applyButton.TabIndex = 1;
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
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // insertPage
            // 
            this.insertPage.Controls.Add(this.insertButton);
            this.insertPage.Controls.Add(this.sefSectie);
            this.insertPage.Controls.Add(this.numeDept);
            this.insertPage.Controls.Add(this.sefSectieL);
            this.insertPage.Controls.Add(this.numeDeptL);
            this.insertPage.Location = new System.Drawing.Point(4, 29);
            this.insertPage.Name = "insertPage";
            this.insertPage.Padding = new System.Windows.Forms.Padding(3);
            this.insertPage.Size = new System.Drawing.Size(950, 620);
            this.insertPage.TabIndex = 2;
            this.insertPage.Text = "Insert";
            this.insertPage.UseVisualStyleBackColor = true;
            this.insertPage.Click += new System.EventHandler(this.insertPage_Click);
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.insertButton.Location = new System.Drawing.Point(857, 5);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(94, 29);
            this.insertButton.TabIndex = 76;
            this.insertButton.Text = "Apply";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // sefSectie
            // 
            this.sefSectie.Location = new System.Drawing.Point(305, 208);
            this.sefSectie.Name = "sefSectie";
            this.sefSectie.Size = new System.Drawing.Size(170, 27);
            this.sefSectie.TabIndex = 75;
            this.sefSectie.TextChanged += new System.EventHandler(this.sefSectie_TextChanged);
            // 
            // numeDept
            // 
            this.numeDept.Location = new System.Drawing.Point(305, 104);
            this.numeDept.Name = "numeDept";
            this.numeDept.Size = new System.Drawing.Size(170, 27);
            this.numeDept.TabIndex = 74;
            this.numeDept.TextChanged += new System.EventHandler(this.numeDept_TextChanged);
            // 
            // sefSectieL
            // 
            this.sefSectieL.AutoSize = true;
            this.sefSectieL.Location = new System.Drawing.Point(111, 208);
            this.sefSectieL.Name = "sefSectieL";
            this.sefSectieL.Size = new System.Drawing.Size(43, 20);
            this.sefSectieL.TabIndex = 73;
            this.sefSectieL.Text = "Chief";
            this.sefSectieL.Click += new System.EventHandler(this.sefSectieL_Click);
            // 
            // numeDeptL
            // 
            this.numeDeptL.AutoSize = true;
            this.numeDeptL.Location = new System.Drawing.Point(111, 104);
            this.numeDeptL.Name = "numeDeptL";
            this.numeDeptL.Size = new System.Drawing.Size(49, 20);
            this.numeDeptL.TabIndex = 72;
            this.numeDeptL.Text = "Name";
            this.numeDeptL.Click += new System.EventHandler(this.numeDeptL_Click);
            // 
            // updatePage
            // 
            this.updatePage.Controls.Add(this.numeDept2);
            this.updatePage.Controls.Add(this.numeDeptL2);
            this.updatePage.Controls.Add(this.idModificat);
            this.updatePage.Controls.Add(this.idModificatL);
            this.updatePage.Controls.Add(this.valueBox);
            this.updatePage.Controls.Add(this.columnChoice);
            this.updatePage.Controls.Add(this.columnL);
            this.updatePage.Controls.Add(this.updateButton);
            this.updatePage.Location = new System.Drawing.Point(4, 29);
            this.updatePage.Name = "updatePage";
            this.updatePage.Padding = new System.Windows.Forms.Padding(3);
            this.updatePage.Size = new System.Drawing.Size(950, 620);
            this.updatePage.TabIndex = 3;
            this.updatePage.Text = "Update";
            this.updatePage.UseVisualStyleBackColor = true;
            this.updatePage.Click += new System.EventHandler(this.updatePage_Click);
            // 
            // numeDept2
            // 
            this.numeDept2.FormattingEnabled = true;
            this.numeDept2.Location = new System.Drawing.Point(305, 104);
            this.numeDept2.Name = "numeDept2";
            this.numeDept2.Size = new System.Drawing.Size(170, 28);
            this.numeDept2.TabIndex = 89;
            this.numeDept2.SelectedIndexChanged += new System.EventHandler(this.numeDept2_SelectedIndexChanged);
            // 
            // numeDeptL2
            // 
            this.numeDeptL2.AutoSize = true;
            this.numeDeptL2.Location = new System.Drawing.Point(111, 104);
            this.numeDeptL2.Name = "numeDeptL2";
            this.numeDeptL2.Size = new System.Drawing.Size(49, 20);
            this.numeDeptL2.TabIndex = 88;
            this.numeDeptL2.Text = "Name";
            this.numeDeptL2.Click += new System.EventHandler(this.numeDeptL2_Click);
            // 
            // idModificat
            // 
            this.idModificat.FormattingEnabled = true;
            this.idModificat.Location = new System.Drawing.Point(704, 104);
            this.idModificat.Name = "idModificat";
            this.idModificat.Size = new System.Drawing.Size(170, 28);
            this.idModificat.TabIndex = 87;
            this.idModificat.SelectedIndexChanged += new System.EventHandler(this.idModificat_SelectedIndexChanged);
            // 
            // idModificatL
            // 
            this.idModificatL.AutoSize = true;
            this.idModificatL.Location = new System.Drawing.Point(510, 104);
            this.idModificatL.Name = "idModificatL";
            this.idModificatL.Size = new System.Drawing.Size(22, 20);
            this.idModificatL.TabIndex = 86;
            this.idModificatL.Text = "Id";
            this.idModificatL.Click += new System.EventHandler(this.idModificatL_Click);
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(704, 208);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(170, 27);
            this.valueBox.TabIndex = 85;
            this.valueBox.TextChanged += new System.EventHandler(this.valueBox_TextChanged);
            // 
            // columnChoice
            // 
            this.columnChoice.FormattingEnabled = true;
            this.columnChoice.Items.AddRange(new object[] {
            "nume_dept",
            "sef_de_sectie"});
            this.columnChoice.Location = new System.Drawing.Point(305, 208);
            this.columnChoice.Name = "columnChoice";
            this.columnChoice.Size = new System.Drawing.Size(170, 28);
            this.columnChoice.TabIndex = 84;
            this.columnChoice.SelectedIndexChanged += new System.EventHandler(this.columnChoice_SelectedIndexChanged);
            // 
            // columnL
            // 
            this.columnL.AutoSize = true;
            this.columnL.Location = new System.Drawing.Point(111, 208);
            this.columnL.Name = "columnL";
            this.columnL.Size = new System.Drawing.Size(60, 20);
            this.columnL.TabIndex = 83;
            this.columnL.Text = "Column";
            this.columnL.Click += new System.EventHandler(this.columnL_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateButton.Location = new System.Drawing.Point(857, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(94, 29);
            this.updateButton.TabIndex = 82;
            this.updateButton.Text = "Apply";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // removePage
            // 
            this.removePage.Controls.Add(this.numeDept3);
            this.removePage.Controls.Add(this.numeDeptL3);
            this.removePage.Controls.Add(this.idStersL2);
            this.removePage.Controls.Add(this.idSters);
            this.removePage.Controls.Add(this.idStersL);
            this.removePage.Controls.Add(this.removeButton);
            this.removePage.Location = new System.Drawing.Point(4, 29);
            this.removePage.Name = "removePage";
            this.removePage.Padding = new System.Windows.Forms.Padding(3);
            this.removePage.Size = new System.Drawing.Size(950, 620);
            this.removePage.TabIndex = 4;
            this.removePage.Text = "Remove";
            this.removePage.UseVisualStyleBackColor = true;
            this.removePage.Click += new System.EventHandler(this.removePage_Click);
            // 
            // numeDept3
            // 
            this.numeDept3.FormattingEnabled = true;
            this.numeDept3.Location = new System.Drawing.Point(305, 104);
            this.numeDept3.Name = "numeDept3";
            this.numeDept3.Size = new System.Drawing.Size(170, 28);
            this.numeDept3.TabIndex = 92;
            this.numeDept3.SelectedIndexChanged += new System.EventHandler(this.numeDept3_SelectedIndexChanged);
            // 
            // numeDeptL3
            // 
            this.numeDeptL3.AutoSize = true;
            this.numeDeptL3.Location = new System.Drawing.Point(111, 104);
            this.numeDeptL3.Name = "numeDeptL3";
            this.numeDeptL3.Size = new System.Drawing.Size(49, 20);
            this.numeDeptL3.TabIndex = 91;
            this.numeDeptL3.Text = "Name";
            this.numeDeptL3.Click += new System.EventHandler(this.numeDeptL3_Click);
            // 
            // idStersL2
            // 
            this.idStersL2.AutoSize = true;
            this.idStersL2.Location = new System.Drawing.Point(510, 104);
            this.idStersL2.Name = "idStersL2";
            this.idStersL2.Size = new System.Drawing.Size(22, 20);
            this.idStersL2.TabIndex = 90;
            this.idStersL2.Text = "Id";
            this.idStersL2.Click += new System.EventHandler(this.idStersL2_Click);
            // 
            // idSters
            // 
            this.idSters.FormattingEnabled = true;
            this.idSters.Location = new System.Drawing.Point(702, 104);
            this.idSters.Name = "idSters";
            this.idSters.Size = new System.Drawing.Size(170, 28);
            this.idSters.TabIndex = 85;
            this.idSters.SelectedIndexChanged += new System.EventHandler(this.idSters_SelectedIndexChanged);
            // 
            // idStersL
            // 
            this.idStersL.AutoSize = true;
            this.idStersL.Location = new System.Drawing.Point(56, 296);
            this.idStersL.Name = "idStersL";
            this.idStersL.Size = new System.Drawing.Size(0, 20);
            this.idStersL.TabIndex = 84;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeButton.Location = new System.Drawing.Point(857, 5);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(94, 29);
            this.removeButton.TabIndex = 83;
            this.removeButton.Text = "Apply";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // deptPage
            // 
            this.deptPage.Controls.Add(this.viewButton);
            this.deptPage.Controls.Add(this.dataGridView2);
            this.deptPage.Location = new System.Drawing.Point(4, 29);
            this.deptPage.Name = "deptPage";
            this.deptPage.Padding = new System.Windows.Forms.Padding(3);
            this.deptPage.Size = new System.Drawing.Size(950, 620);
            this.deptPage.TabIndex = 5;
            this.deptPage.Text = "Departments";
            this.deptPage.UseVisualStyleBackColor = true;
            this.deptPage.Click += new System.EventHandler(this.deptPage_Click);
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewButton.Location = new System.Drawing.Point(857, 5);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(94, 29);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "Apply";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 38);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(947, 579);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // SGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.specialistsTab);
            this.Controls.Add(this.backButton);
            this.MaximizeBox = false;
            this.Name = "SGeneral";
            this.ShowIcon = false;
            this.Text = "General";
            this.Load += new System.EventHandler(this.sGeneral_Load);
            this.specialistsTab.ResumeLayout(false);
            this.viewPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.insertPage.ResumeLayout(false);
            this.insertPage.PerformLayout();
            this.updatePage.ResumeLayout(false);
            this.updatePage.PerformLayout();
            this.removePage.ResumeLayout(false);
            this.removePage.PerformLayout();
            this.deptPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TabControl specialistsTab;
        private System.Windows.Forms.TabPage viewPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TabPage insertPage;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox sefSectie;
        private System.Windows.Forms.TextBox numeDept;
        private System.Windows.Forms.Label sefSectieL;
        private System.Windows.Forms.Label numeDeptL;
        private System.Windows.Forms.TabPage updatePage;
        private System.Windows.Forms.ComboBox idModificat;
        private System.Windows.Forms.Label idModificatL;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.ComboBox columnChoice;
        private System.Windows.Forms.Label columnL;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TabPage removePage;
        private System.Windows.Forms.ComboBox idSters;
        private System.Windows.Forms.Label idStersL;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ComboBox numeDept2;
        private System.Windows.Forms.Label numeDeptL2;
        private System.Windows.Forms.ComboBox numeDept3;
        private System.Windows.Forms.Label numeDeptL3;
        private System.Windows.Forms.Label idStersL2;
        private System.Windows.Forms.TabPage deptPage;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}