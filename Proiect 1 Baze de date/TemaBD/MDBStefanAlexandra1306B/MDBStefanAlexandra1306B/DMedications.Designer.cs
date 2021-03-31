
namespace MDBStefanAlexandra1306B
{
    partial class DMedications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMedications));
            this.backButton = new System.Windows.Forms.Button();
            this.specialistsTab = new System.Windows.Forms.TabControl();
            this.viewPage = new System.Windows.Forms.TabPage();
            this.applyButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertPage = new System.Windows.Forms.TabPage();
            this.idIntern = new System.Windows.Forms.ComboBox();
            this.idInternL = new System.Windows.Forms.Label();
            this.applyButton2 = new System.Windows.Forms.Button();
            this.perioadaAdm = new System.Windows.Forms.TextBox();
            this.perioadaAdmL = new System.Windows.Forms.Label();
            this.doza = new System.Windows.Forms.TextBox();
            this.dozaL = new System.Windows.Forms.Label();
            this.oraAdm = new System.Windows.Forms.TextBox();
            this.oraAdmL = new System.Windows.Forms.Label();
            this.descrTrat = new System.Windows.Forms.TextBox();
            this.descrTratL = new System.Windows.Forms.Label();
            this.marcaTrat = new System.Windows.Forms.TextBox();
            this.marcaTratL = new System.Windows.Forms.Label();
            this.numeTrat = new System.Windows.Forms.TextBox();
            this.numeTratL = new System.Windows.Forms.Label();
            this.idTrat = new System.Windows.Forms.TextBox();
            this.idTratL = new System.Windows.Forms.Label();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.numeTrat2 = new System.Windows.Forms.ComboBox();
            this.numeTratL2 = new System.Windows.Forms.Label();
            this.idTrat2 = new System.Windows.Forms.ComboBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.columnChoice = new System.Windows.Forms.ComboBox();
            this.columnL = new System.Windows.Forms.Label();
            this.applyButton3 = new System.Windows.Forms.Button();
            this.idTratL2 = new System.Windows.Forms.Label();
            this.removePage = new System.Windows.Forms.TabPage();
            this.numeTrat3 = new System.Windows.Forms.ComboBox();
            this.numeTratL3 = new System.Windows.Forms.Label();
            this.idTrat3 = new System.Windows.Forms.ComboBox();
            this.applyButton4 = new System.Windows.Forms.Button();
            this.idTratL3 = new System.Windows.Forms.Label();
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
            this.insertPage.Controls.Add(this.idIntern);
            this.insertPage.Controls.Add(this.idInternL);
            this.insertPage.Controls.Add(this.applyButton2);
            this.insertPage.Controls.Add(this.perioadaAdm);
            this.insertPage.Controls.Add(this.perioadaAdmL);
            this.insertPage.Controls.Add(this.doza);
            this.insertPage.Controls.Add(this.dozaL);
            this.insertPage.Controls.Add(this.oraAdm);
            this.insertPage.Controls.Add(this.oraAdmL);
            this.insertPage.Controls.Add(this.descrTrat);
            this.insertPage.Controls.Add(this.descrTratL);
            this.insertPage.Controls.Add(this.marcaTrat);
            this.insertPage.Controls.Add(this.marcaTratL);
            this.insertPage.Controls.Add(this.numeTrat);
            this.insertPage.Controls.Add(this.numeTratL);
            this.insertPage.Controls.Add(this.idTrat);
            this.insertPage.Controls.Add(this.idTratL);
            this.insertPage.Location = new System.Drawing.Point(4, 29);
            this.insertPage.Name = "insertPage";
            this.insertPage.Padding = new System.Windows.Forms.Padding(3);
            this.insertPage.Size = new System.Drawing.Size(950, 620);
            this.insertPage.TabIndex = 1;
            this.insertPage.Text = "Insert";
            this.insertPage.UseVisualStyleBackColor = true;
            this.insertPage.Click += new System.EventHandler(this.insertPage_Click);
            // 
            // idIntern
            // 
            this.idIntern.FormattingEnabled = true;
            this.idIntern.Location = new System.Drawing.Point(305, 320);
            this.idIntern.Name = "idIntern";
            this.idIntern.Size = new System.Drawing.Size(170, 28);
            this.idIntern.TabIndex = 37;
            this.idIntern.SelectedIndexChanged += new System.EventHandler(this.idIntern_SelectedIndexChanged);
            // 
            // idInternL
            // 
            this.idInternL.AutoSize = true;
            this.idInternL.Location = new System.Drawing.Point(111, 320);
            this.idInternL.Name = "idInternL";
            this.idInternL.Size = new System.Drawing.Size(95, 20);
            this.idInternL.TabIndex = 23;
            this.idInternL.Text = "Admission Id";
            this.idInternL.Click += new System.EventHandler(this.idInternL_Click);
            // 
            // applyButton2
            // 
            this.applyButton2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton2.Location = new System.Drawing.Point(857, 5);
            this.applyButton2.Name = "applyButton2";
            this.applyButton2.Size = new System.Drawing.Size(94, 29);
            this.applyButton2.TabIndex = 27;
            this.applyButton2.Text = "Apply";
            this.applyButton2.UseVisualStyleBackColor = false;
            this.applyButton2.Click += new System.EventHandler(this.applyButton2_Click);
            // 
            // perioadaAdm
            // 
            this.perioadaAdm.Location = new System.Drawing.Point(305, 512);
            this.perioadaAdm.Name = "perioadaAdm";
            this.perioadaAdm.Size = new System.Drawing.Size(170, 27);
            this.perioadaAdm.TabIndex = 26;
            this.perioadaAdm.TextChanged += new System.EventHandler(this.perioadaAdm_TextChanged);
            // 
            // perioadaAdmL
            // 
            this.perioadaAdmL.AutoSize = true;
            this.perioadaAdmL.Location = new System.Drawing.Point(111, 512);
            this.perioadaAdmL.Name = "perioadaAdmL";
            this.perioadaAdmL.Size = new System.Drawing.Size(51, 20);
            this.perioadaAdmL.TabIndex = 25;
            this.perioadaAdmL.Text = "Period";
            this.perioadaAdmL.Click += new System.EventHandler(this.perioadaAdmL_Click);
            // 
            // doza
            // 
            this.doza.Location = new System.Drawing.Point(305, 448);
            this.doza.Name = "doza";
            this.doza.Size = new System.Drawing.Size(170, 27);
            this.doza.TabIndex = 24;
            this.doza.TextChanged += new System.EventHandler(this.doza_TextChanged);
            // 
            // dozaL
            // 
            this.dozaL.AutoSize = true;
            this.dozaL.Location = new System.Drawing.Point(111, 448);
            this.dozaL.Name = "dozaL";
            this.dozaL.Size = new System.Drawing.Size(60, 20);
            this.dozaL.TabIndex = 23;
            this.dozaL.Text = "Dosage";
            this.dozaL.Click += new System.EventHandler(this.dozaL_Click);
            // 
            // oraAdm
            // 
            this.oraAdm.Location = new System.Drawing.Point(305, 384);
            this.oraAdm.Name = "oraAdm";
            this.oraAdm.Size = new System.Drawing.Size(170, 27);
            this.oraAdm.TabIndex = 22;
            this.oraAdm.TextChanged += new System.EventHandler(this.oraAdm_TextChanged);
            // 
            // oraAdmL
            // 
            this.oraAdmL.AutoSize = true;
            this.oraAdmL.Location = new System.Drawing.Point(111, 384);
            this.oraAdmL.Name = "oraAdmL";
            this.oraAdmL.Size = new System.Drawing.Size(42, 20);
            this.oraAdmL.TabIndex = 21;
            this.oraAdmL.Text = "Hour";
            this.oraAdmL.Click += new System.EventHandler(this.oraAdmL_Click);
            // 
            // descrTrat
            // 
            this.descrTrat.Location = new System.Drawing.Point(305, 256);
            this.descrTrat.Name = "descrTrat";
            this.descrTrat.Size = new System.Drawing.Size(170, 27);
            this.descrTrat.TabIndex = 18;
            this.descrTrat.TextChanged += new System.EventHandler(this.descrTrat_TextChanged);
            // 
            // descrTratL
            // 
            this.descrTratL.AutoSize = true;
            this.descrTratL.Location = new System.Drawing.Point(111, 256);
            this.descrTratL.Name = "descrTratL";
            this.descrTratL.Size = new System.Drawing.Size(85, 20);
            this.descrTratL.TabIndex = 17;
            this.descrTratL.Text = "Description";
            this.descrTratL.Click += new System.EventHandler(this.descrTratL_Click);
            // 
            // marcaTrat
            // 
            this.marcaTrat.Location = new System.Drawing.Point(305, 192);
            this.marcaTrat.Name = "marcaTrat";
            this.marcaTrat.Size = new System.Drawing.Size(170, 27);
            this.marcaTrat.TabIndex = 16;
            this.marcaTrat.TextChanged += new System.EventHandler(this.marcaTrat_TextChanged);
            // 
            // marcaTratL
            // 
            this.marcaTratL.AutoSize = true;
            this.marcaTratL.Location = new System.Drawing.Point(111, 192);
            this.marcaTratL.Name = "marcaTratL";
            this.marcaTratL.Size = new System.Drawing.Size(48, 20);
            this.marcaTratL.TabIndex = 15;
            this.marcaTratL.Text = "Brand";
            this.marcaTratL.Click += new System.EventHandler(this.marcaTratL_Click);
            // 
            // numeTrat
            // 
            this.numeTrat.Location = new System.Drawing.Point(305, 128);
            this.numeTrat.Name = "numeTrat";
            this.numeTrat.Size = new System.Drawing.Size(170, 27);
            this.numeTrat.TabIndex = 14;
            this.numeTrat.TextChanged += new System.EventHandler(this.numeTrat_TextChanged);
            // 
            // numeTratL
            // 
            this.numeTratL.AutoSize = true;
            this.numeTratL.Location = new System.Drawing.Point(111, 128);
            this.numeTratL.Name = "numeTratL";
            this.numeTratL.Size = new System.Drawing.Size(49, 20);
            this.numeTratL.TabIndex = 13;
            this.numeTratL.Text = "Name";
            this.numeTratL.Click += new System.EventHandler(this.numeTratL_Click);
            // 
            // idTrat
            // 
            this.idTrat.Enabled = false;
            this.idTrat.Location = new System.Drawing.Point(305, 64);
            this.idTrat.Name = "idTrat";
            this.idTrat.Size = new System.Drawing.Size(170, 27);
            this.idTrat.TabIndex = 12;
            this.idTrat.TextChanged += new System.EventHandler(this.idTrat_TextChanged);
            // 
            // idTratL
            // 
            this.idTratL.AutoSize = true;
            this.idTratL.Enabled = false;
            this.idTratL.Location = new System.Drawing.Point(111, 64);
            this.idTratL.Name = "idTratL";
            this.idTratL.Size = new System.Drawing.Size(22, 20);
            this.idTratL.TabIndex = 11;
            this.idTratL.Text = "Id";
            this.idTratL.Click += new System.EventHandler(this.idTratL_Click);
            // 
            // updatePage
            // 
            this.updatePage.Controls.Add(this.numeTrat2);
            this.updatePage.Controls.Add(this.numeTratL2);
            this.updatePage.Controls.Add(this.idTrat2);
            this.updatePage.Controls.Add(this.valueBox);
            this.updatePage.Controls.Add(this.columnChoice);
            this.updatePage.Controls.Add(this.columnL);
            this.updatePage.Controls.Add(this.applyButton3);
            this.updatePage.Controls.Add(this.idTratL2);
            this.updatePage.Location = new System.Drawing.Point(4, 29);
            this.updatePage.Name = "updatePage";
            this.updatePage.Size = new System.Drawing.Size(950, 620);
            this.updatePage.TabIndex = 2;
            this.updatePage.Text = "Update";
            this.updatePage.UseVisualStyleBackColor = true;
            this.updatePage.Click += new System.EventHandler(this.updatePage_Click);
            // 
            // numeTrat2
            // 
            this.numeTrat2.FormattingEnabled = true;
            this.numeTrat2.Items.AddRange(new object[] {
            "nume_trat",
            "marca_trat",
            "descriere_trat",
            "id_intern",
            "ora_admin",
            "dozaj_zilnic",
            "per_admin"});
            this.numeTrat2.Location = new System.Drawing.Point(305, 64);
            this.numeTrat2.Name = "numeTrat2";
            this.numeTrat2.Size = new System.Drawing.Size(170, 28);
            this.numeTrat2.TabIndex = 50;
            this.numeTrat2.SelectedIndexChanged += new System.EventHandler(this.numeTrat2_SelectedIndexChanged);
            // 
            // numeTratL2
            // 
            this.numeTratL2.AutoSize = true;
            this.numeTratL2.Location = new System.Drawing.Point(111, 64);
            this.numeTratL2.Name = "numeTratL2";
            this.numeTratL2.Size = new System.Drawing.Size(49, 20);
            this.numeTratL2.TabIndex = 49;
            this.numeTratL2.Text = "Name";
            this.numeTratL2.Click += new System.EventHandler(this.numeTratL2_Click);
            // 
            // idTrat2
            // 
            this.idTrat2.FormattingEnabled = true;
            this.idTrat2.Location = new System.Drawing.Point(704, 64);
            this.idTrat2.Name = "idTrat2";
            this.idTrat2.Size = new System.Drawing.Size(170, 28);
            this.idTrat2.TabIndex = 48;
            this.idTrat2.SelectedIndexChanged += new System.EventHandler(this.idTrat2_SelectedIndexChanged);
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(704, 128);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(170, 27);
            this.valueBox.TabIndex = 47;
            this.valueBox.TextChanged += new System.EventHandler(this.valueBox_TextChanged);
            // 
            // columnChoice
            // 
            this.columnChoice.FormattingEnabled = true;
            this.columnChoice.Items.AddRange(new object[] {
            "nume_trat",
            "marca_trat",
            "descriere_trat",
            "id_intern",
            "ora_admin",
            "dozaj_zilnic",
            "per_admin"});
            this.columnChoice.Location = new System.Drawing.Point(305, 128);
            this.columnChoice.Name = "columnChoice";
            this.columnChoice.Size = new System.Drawing.Size(170, 28);
            this.columnChoice.TabIndex = 46;
            this.columnChoice.SelectedIndexChanged += new System.EventHandler(this.columnChoice_SelectedIndexChanged);
            // 
            // columnL
            // 
            this.columnL.AutoSize = true;
            this.columnL.Location = new System.Drawing.Point(111, 128);
            this.columnL.Name = "columnL";
            this.columnL.Size = new System.Drawing.Size(60, 20);
            this.columnL.TabIndex = 45;
            this.columnL.Text = "Column";
            this.columnL.Click += new System.EventHandler(this.columnL_Click);
            // 
            // applyButton3
            // 
            this.applyButton3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton3.Location = new System.Drawing.Point(857, 5);
            this.applyButton3.Name = "applyButton3";
            this.applyButton3.Size = new System.Drawing.Size(94, 29);
            this.applyButton3.TabIndex = 44;
            this.applyButton3.Text = "Apply";
            this.applyButton3.UseVisualStyleBackColor = false;
            this.applyButton3.Click += new System.EventHandler(this.applyButton3_Click);
            // 
            // idTratL2
            // 
            this.idTratL2.AutoSize = true;
            this.idTratL2.Location = new System.Drawing.Point(510, 64);
            this.idTratL2.Name = "idTratL2";
            this.idTratL2.Size = new System.Drawing.Size(22, 20);
            this.idTratL2.TabIndex = 28;
            this.idTratL2.Text = "Id";
            this.idTratL2.Click += new System.EventHandler(this.idTratL2_Click);
            // 
            // removePage
            // 
            this.removePage.Controls.Add(this.numeTrat3);
            this.removePage.Controls.Add(this.numeTratL3);
            this.removePage.Controls.Add(this.idTrat3);
            this.removePage.Controls.Add(this.applyButton4);
            this.removePage.Controls.Add(this.idTratL3);
            this.removePage.Location = new System.Drawing.Point(4, 29);
            this.removePage.Name = "removePage";
            this.removePage.Size = new System.Drawing.Size(950, 620);
            this.removePage.TabIndex = 3;
            this.removePage.Text = "Remove";
            this.removePage.UseVisualStyleBackColor = true;
            this.removePage.Click += new System.EventHandler(this.removePage_Click);
            // 
            // numeTrat3
            // 
            this.numeTrat3.FormattingEnabled = true;
            this.numeTrat3.Items.AddRange(new object[] {
            "nume_trat",
            "marca_trat",
            "descriere_trat",
            "id_intern",
            "ora_admin",
            "dozaj_zilnic",
            "per_admin"});
            this.numeTrat3.Location = new System.Drawing.Point(305, 64);
            this.numeTrat3.Name = "numeTrat3";
            this.numeTrat3.Size = new System.Drawing.Size(170, 28);
            this.numeTrat3.TabIndex = 52;
            this.numeTrat3.SelectedIndexChanged += new System.EventHandler(this.numeTrat3_SelectedIndexChanged);
            // 
            // numeTratL3
            // 
            this.numeTratL3.AutoSize = true;
            this.numeTratL3.Location = new System.Drawing.Point(111, 64);
            this.numeTratL3.Name = "numeTratL3";
            this.numeTratL3.Size = new System.Drawing.Size(49, 20);
            this.numeTratL3.TabIndex = 51;
            this.numeTratL3.Text = "Name";
            this.numeTratL3.Click += new System.EventHandler(this.numeTratL3_Click);
            // 
            // idTrat3
            // 
            this.idTrat3.FormattingEnabled = true;
            this.idTrat3.Location = new System.Drawing.Point(704, 64);
            this.idTrat3.Name = "idTrat3";
            this.idTrat3.Size = new System.Drawing.Size(170, 28);
            this.idTrat3.TabIndex = 49;
            this.idTrat3.SelectedIndexChanged += new System.EventHandler(this.idTrat3_SelectedIndexChanged);
            // 
            // applyButton4
            // 
            this.applyButton4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyButton4.Location = new System.Drawing.Point(857, 5);
            this.applyButton4.Name = "applyButton4";
            this.applyButton4.Size = new System.Drawing.Size(94, 29);
            this.applyButton4.TabIndex = 44;
            this.applyButton4.Text = "Apply";
            this.applyButton4.UseVisualStyleBackColor = false;
            this.applyButton4.Click += new System.EventHandler(this.applyButton4_Click);
            // 
            // idTratL3
            // 
            this.idTratL3.AutoSize = true;
            this.idTratL3.Location = new System.Drawing.Point(510, 64);
            this.idTratL3.Name = "idTratL3";
            this.idTratL3.Size = new System.Drawing.Size(22, 20);
            this.idTratL3.TabIndex = 28;
            this.idTratL3.Text = "Id";
            this.idTratL3.Click += new System.EventHandler(this.idTratL3_Click);
            // 
            // DMedications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.specialistsTab);
            this.Controls.Add(this.backButton);
            this.MaximizeBox = false;
            this.Name = "DMedications";
            this.ShowIcon = false;
            this.Text = "Medications";
            this.Load += new System.EventHandler(this.DMedications_Load);
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
        private System.Windows.Forms.Label idTratL;
        private System.Windows.Forms.TextBox perioadaAdm;
        private System.Windows.Forms.Label perioadaAdmL;
        private System.Windows.Forms.TextBox doza;
        private System.Windows.Forms.Label dozaL;
        private System.Windows.Forms.TextBox oraAdm;
        private System.Windows.Forms.Label oraAdmL;
        private System.Windows.Forms.TextBox descrTrat;
        private System.Windows.Forms.Label descrTratL;
        private System.Windows.Forms.TextBox marcaTrat;
        private System.Windows.Forms.Label marcaTratL;
        private System.Windows.Forms.TextBox numeTrat;
        private System.Windows.Forms.Label numeTratL;
        private System.Windows.Forms.TextBox idTrat;
        private System.Windows.Forms.Button applyButton2;
        private System.Windows.Forms.Label idTratL2;
        private System.Windows.Forms.Button applyButton4;
        private System.Windows.Forms.Label idTratL3;
        private System.Windows.Forms.Button applyButton3;
        private System.Windows.Forms.ComboBox columnChoice;
        private System.Windows.Forms.Label columnL;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label idInternL;
        private System.Windows.Forms.ComboBox idIntern;
        private System.Windows.Forms.ComboBox idTrat2;
        private System.Windows.Forms.ComboBox idTrat3;
        private System.Windows.Forms.ComboBox numeTrat2;
        private System.Windows.Forms.Label numeTratL2;
        private System.Windows.Forms.ComboBox numeTrat3;
        private System.Windows.Forms.Label numeTratL3;
    }
}