
namespace Marathon
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoginHistory = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonWorkAccounts = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Организатор";
            // 
            // buttonLoginHistory
            // 
            this.buttonLoginHistory.BackColor = System.Drawing.Color.Honeydew;
            this.buttonLoginHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginHistory.Location = new System.Drawing.Point(12, 74);
            this.buttonLoginHistory.Name = "buttonLoginHistory";
            this.buttonLoginHistory.Size = new System.Drawing.Size(520, 45);
            this.buttonLoginHistory.TabIndex = 2;
            this.buttonLoginHistory.Text = "Просмотр истории входов";
            this.buttonLoginHistory.UseVisualStyleBackColor = false;
            this.buttonLoginHistory.Click += new System.EventHandler(this.buttonLoginHistory_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Honeydew;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(402, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(130, 34);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Назад";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonWorkAccounts
            // 
            this.buttonWorkAccounts.BackColor = System.Drawing.Color.Honeydew;
            this.buttonWorkAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkAccounts.Location = new System.Drawing.Point(12, 125);
            this.buttonWorkAccounts.Name = "buttonWorkAccounts";
            this.buttonWorkAccounts.Size = new System.Drawing.Size(520, 45);
            this.buttonWorkAccounts.TabIndex = 4;
            this.buttonWorkAccounts.Text = "Работа с аккаунтами";
            this.buttonWorkAccounts.UseVisualStyleBackColor = false;
            this.buttonWorkAccounts.Click += new System.EventHandler(this.buttonWorkAccounts_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.Honeydew;
            this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUp.Location = new System.Drawing.Point(12, 176);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(520, 45);
            this.buttonSignUp.TabIndex = 5;
            this.buttonSignUp.Text = "Результаты марафона";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Marathon.Properties.Resources.Бегун;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(544, 234);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonWorkAccounts);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLoginHistory);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdmin";
            this.Text = "Организатор";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoginHistory;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonWorkAccounts;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}