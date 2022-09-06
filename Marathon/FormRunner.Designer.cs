
namespace Marathon
{
    partial class FormRunner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRunner));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonSponsors = new System.Windows.Forms.Button();
            this.buttonRegistrationToMarathon = new System.Windows.Forms.Button();
            this.buttonResults = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бегун";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Honeydew;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(402, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(130, 34);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Назад";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.Honeydew;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Location = new System.Drawing.Point(12, 74);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(520, 45);
            this.buttonProfile.TabIndex = 9;
            this.buttonProfile.Text = "Мой профиль";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonSponsors
            // 
            this.buttonSponsors.BackColor = System.Drawing.Color.Honeydew;
            this.buttonSponsors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSponsors.Location = new System.Drawing.Point(12, 125);
            this.buttonSponsors.Name = "buttonSponsors";
            this.buttonSponsors.Size = new System.Drawing.Size(520, 45);
            this.buttonSponsors.TabIndex = 10;
            this.buttonSponsors.Text = "Мои спонсоры";
            this.buttonSponsors.UseVisualStyleBackColor = false;
            this.buttonSponsors.Click += new System.EventHandler(this.buttonSponsors_Click);
            // 
            // buttonRegistrationToMarathon
            // 
            this.buttonRegistrationToMarathon.BackColor = System.Drawing.Color.Honeydew;
            this.buttonRegistrationToMarathon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrationToMarathon.Location = new System.Drawing.Point(12, 176);
            this.buttonRegistrationToMarathon.Name = "buttonRegistrationToMarathon";
            this.buttonRegistrationToMarathon.Size = new System.Drawing.Size(520, 45);
            this.buttonRegistrationToMarathon.TabIndex = 11;
            this.buttonRegistrationToMarathon.Text = "Запись на марафон";
            this.buttonRegistrationToMarathon.UseVisualStyleBackColor = false;
            this.buttonRegistrationToMarathon.Click += new System.EventHandler(this.buttonRegistrationToMarathon_Click);
            // 
            // buttonResults
            // 
            this.buttonResults.BackColor = System.Drawing.Color.Honeydew;
            this.buttonResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResults.Location = new System.Drawing.Point(12, 227);
            this.buttonResults.Name = "buttonResults";
            this.buttonResults.Size = new System.Drawing.Size(520, 45);
            this.buttonResults.TabIndex = 15;
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
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FormRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(544, 285);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonResults);
            this.Controls.Add(this.buttonRegistrationToMarathon);
            this.Controls.Add(this.buttonSponsors);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRunner";
            this.Text = "Бегун";
            this.Load += new System.EventHandler(this.FormRunner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonSponsors;
        private System.Windows.Forms.Button buttonRegistrationToMarathon;
        private System.Windows.Forms.Button buttonResults;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}