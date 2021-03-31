
namespace MDBStefanAlexandra1306B
{
    partial class Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.homeButton = new System.Windows.Forms.Button();
            this.generalButton = new System.Windows.Forms.Button();
            this.admissionsButton = new System.Windows.Forms.Button();
            this.surgeriesButton = new System.Windows.Forms.Button();
            this.consultationsButton = new System.Windows.Forms.Button();
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
            // generalButton
            // 
            this.generalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(176)))), ((int)(((byte)(246)))));
            this.generalButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.generalButton.Location = new System.Drawing.Point(0, 202);
            this.generalButton.Name = "generalButton";
            this.generalButton.Size = new System.Drawing.Size(225, 60);
            this.generalButton.TabIndex = 20;
            this.generalButton.Text = "General";
            this.generalButton.UseVisualStyleBackColor = false;
            this.generalButton.Click += new System.EventHandler(this.generalButton_Click);
            // 
            // admissionsButton
            // 
            this.admissionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(176)))), ((int)(((byte)(246)))));
            this.admissionsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admissionsButton.Location = new System.Drawing.Point(0, 376);
            this.admissionsButton.Name = "admissionsButton";
            this.admissionsButton.Size = new System.Drawing.Size(225, 60);
            this.admissionsButton.TabIndex = 19;
            this.admissionsButton.Text = "Admissions";
            this.admissionsButton.UseVisualStyleBackColor = false;
            this.admissionsButton.Click += new System.EventHandler(this.admissionsButton_Click);
            // 
            // surgeriesButton
            // 
            this.surgeriesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(176)))), ((int)(((byte)(246)))));
            this.surgeriesButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.surgeriesButton.Location = new System.Drawing.Point(0, 318);
            this.surgeriesButton.Name = "surgeriesButton";
            this.surgeriesButton.Size = new System.Drawing.Size(225, 60);
            this.surgeriesButton.TabIndex = 18;
            this.surgeriesButton.Text = "Surgeries";
            this.surgeriesButton.UseVisualStyleBackColor = false;
            this.surgeriesButton.Click += new System.EventHandler(this.surgeriesButton_Click);
            // 
            // consultationsButton
            // 
            this.consultationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(176)))), ((int)(((byte)(246)))));
            this.consultationsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.consultationsButton.Location = new System.Drawing.Point(0, 260);
            this.consultationsButton.Name = "consultationsButton";
            this.consultationsButton.Size = new System.Drawing.Size(225, 60);
            this.consultationsButton.TabIndex = 17;
            this.consultationsButton.Text = "Consultations";
            this.consultationsButton.UseVisualStyleBackColor = false;
            this.consultationsButton.Click += new System.EventHandler(this.consultationsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(231, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(939, 628);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.generalButton);
            this.Controls.Add(this.admissionsButton);
            this.Controls.Add(this.surgeriesButton);
            this.Controls.Add(this.consultationsButton);
            this.Controls.Add(this.homeButton);
            this.MaximizeBox = false;
            this.Name = "Schedule";
            this.ShowIcon = false;
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button generalButton;
        private System.Windows.Forms.Button admissionsButton;
        private System.Windows.Forms.Button surgeriesButton;
        private System.Windows.Forms.Button consultationsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}