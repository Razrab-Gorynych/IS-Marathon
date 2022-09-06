
namespace Marathon
{
    partial class FormSponsor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSponsor));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSponsRun = new System.Windows.Forms.Button();
            this.buttonResults = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Спонсор";
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.Honeydew;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Location = new System.Drawing.Point(12, 74);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(520, 45);
            this.buttonProfile.TabIndex = 12;
            this.buttonProfile.Text = "Мой профиль";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Honeydew;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(402, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(130, 34);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Назад";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSponsRun
            // 
            this.buttonSponsRun.BackColor = System.Drawing.Color.Honeydew;
            this.buttonSponsRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSponsRun.Location = new System.Drawing.Point(12, 125);
            this.buttonSponsRun.Name = "buttonSponsRun";
            this.buttonSponsRun.Size = new System.Drawing.Size(520, 45);
            this.buttonSponsRun.TabIndex = 13;
            this.buttonSponsRun.Text = "Спонсировать бегуна";
            this.buttonSponsRun.UseVisualStyleBackColor = false;
            this.buttonSponsRun.Click += new System.EventHandler(this.buttonSponsRun_Click);
            // 
            // buttonResults
            // 
            this.buttonResults.BackColor = System.Drawing.Color.Honeydew;
            this.buttonResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResults.Location = new System.Drawing.Point(12, 176);
            this.buttonResults.Name = "buttonResults";
            this.buttonResults.Size = new System.Drawing.Size(520, 45);
            this.buttonResults.TabIndex = 14;
            this.buttonResults.Text = "Результаты марафона";
            this.buttonResults.UseVisualStyleBackColor = false;
            this.buttonResults.Click += new System.EventHandler(this.buttonResults_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Marathon.Properties.Resources.Бегун;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FormSponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(544, 234);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonResults);
            this.Controls.Add(this.buttonSponsRun);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSponsor";
            this.Text = "Спонсор";
            this.Load += new System.EventHandler(this.FormSponsor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSponsRun;
        private System.Windows.Forms.Button buttonResults;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}