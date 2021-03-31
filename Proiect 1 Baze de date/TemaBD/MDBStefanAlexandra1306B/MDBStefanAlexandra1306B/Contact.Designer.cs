
namespace MDBStefanAlexandra1306B
{
    partial class Contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact));
            this.homeButton = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(176)))), ((int)(((byte)(246)))));
            this.homeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.homeButton.Location = new System.Drawing.Point(0, 580);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(225, 60);
            this.homeButton.TabIndex = 9;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.text.Location = new System.Drawing.Point(431, 175);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(502, 300);
            this.text.TabIndex = 14;
            this.text.Text = resources.GetString("text.Text");
            this.text.Click += new System.EventHandler(this.text_Click);
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.text);
            this.Controls.Add(this.homeButton);
            this.MaximizeBox = false;
            this.Name = "Contact";
            this.ShowIcon = false;
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.Contact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label text;
    }
}