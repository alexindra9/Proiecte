
namespace MDBStefanAlexandra1306B
{
    partial class Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data));
            this.homeButton = new System.Windows.Forms.Button();
            this.medicationsButton = new System.Windows.Forms.Button();
            this.assistantsButton = new System.Windows.Forms.Button();
            this.pacientsButton = new System.Windows.Forms.Button();
            this.specialistsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(176)))), ((int)(((byte)(246)))));
            this.homeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.homeButton.Location = new System.Drawing.Point(0, 580);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(225, 60);
            this.homeButton.TabIndex = 10;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // medicationsButton
            // 
            this.medicationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(176)))), ((int)(((byte)(246)))));
            this.medicationsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.medicationsButton.Location = new System.Drawing.Point(0, 376);
            this.medicationsButton.Name = "medicationsButton";
            this.medicationsButton.Size = new System.Drawing.Size(225, 60);
            this.medicationsButton.TabIndex = 16;
            this.medicationsButton.Text = "Medications";
            this.medicationsButton.UseVisualStyleBackColor = false;
            this.medicationsButton.Click += new System.EventHandler(this.medicationsButton_Click);
            // 
            // assistantsButton
            // 
            this.assistantsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(176)))), ((int)(((byte)(246)))));
            this.assistantsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.assistantsButton.Location = new System.Drawing.Point(0, 318);
            this.assistantsButton.Name = "assistantsButton";
            this.assistantsButton.Size = new System.Drawing.Size(225, 60);
            this.assistantsButton.TabIndex = 15;
            this.assistantsButton.Text = "Assistants";
            this.assistantsButton.UseVisualStyleBackColor = false;
            this.assistantsButton.Click += new System.EventHandler(this.assistantsButton_Click);
            // 
            // pacientsButton
            // 
            this.pacientsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(176)))), ((int)(((byte)(246)))));
            this.pacientsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pacientsButton.Location = new System.Drawing.Point(0, 260);
            this.pacientsButton.Name = "pacientsButton";
            this.pacientsButton.Size = new System.Drawing.Size(225, 60);
            this.pacientsButton.TabIndex = 14;
            this.pacientsButton.Text = "Pacients";
            this.pacientsButton.UseVisualStyleBackColor = false;
            this.pacientsButton.Click += new System.EventHandler(this.pacientsButton_Click);
            // 
            // specialistsButton
            // 
            this.specialistsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(176)))), ((int)(((byte)(246)))));
            this.specialistsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.specialistsButton.Location = new System.Drawing.Point(0, 202);
            this.specialistsButton.Name = "specialistsButton";
            this.specialistsButton.Size = new System.Drawing.Size(225, 60);
            this.specialistsButton.TabIndex = 13;
            this.specialistsButton.Text = "Specialists";
            this.specialistsButton.UseVisualStyleBackColor = false;
            this.specialistsButton.Click += new System.EventHandler(this.specialistsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(231, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(939, 628);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.medicationsButton);
            this.Controls.Add(this.assistantsButton);
            this.Controls.Add(this.pacientsButton);
            this.Controls.Add(this.specialistsButton);
            this.Controls.Add(this.homeButton);
            this.MaximizeBox = false;
            this.Name = "Data";
            this.ShowIcon = false;
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button medicationsButton;
        private System.Windows.Forms.Button assistantsButton;
        private System.Windows.Forms.Button pacientsButton;
        private System.Windows.Forms.Button specialistsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}