
namespace Marathon
{
    partial class FormWorkAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorkAccounts));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dataGridViewAccounts = new System.Windows.Forms.DataGridView();
            this.groupBoxAccount = new System.Windows.Forms.GroupBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).BeginInit();
            this.groupBoxAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Работа с аккаунтами";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Honeydew;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(523, 17);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(130, 34);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Назад";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dataGridViewAccounts
            // 
            this.dataGridViewAccounts.AllowUserToAddRows = false;
            this.dataGridViewAccounts.AllowUserToDeleteRows = false;
            this.dataGridViewAccounts.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccounts.Location = new System.Drawing.Point(12, 81);
            this.dataGridViewAccounts.MultiSelect = false;
            this.dataGridViewAccounts.Name = "dataGridViewAccounts";
            this.dataGridViewAccounts.RowHeadersVisible = false;
            this.dataGridViewAccounts.ShowEditingIcon = false;
            this.dataGridViewAccounts.Size = new System.Drawing.Size(311, 259);
            this.dataGridViewAccounts.TabIndex = 5;
            this.dataGridViewAccounts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccounts_RowEnter);
            // 
            // groupBoxAccount
            // 
            this.groupBoxAccount.Controls.Add(this.comboBoxRole);
            this.groupBoxAccount.Controls.Add(this.textBoxPas);
            this.groupBoxAccount.Controls.Add(this.textBoxLog);
            this.groupBoxAccount.Controls.Add(this.label4);
            this.groupBoxAccount.Controls.Add(this.label3);
            this.groupBoxAccount.Controls.Add(this.label2);
            this.groupBoxAccount.Location = new System.Drawing.Point(342, 81);
            this.groupBoxAccount.Name = "groupBoxAccount";
            this.groupBoxAccount.Size = new System.Drawing.Size(311, 259);
            this.groupBoxAccount.TabIndex = 6;
            this.groupBoxAccount.TabStop = false;
            this.groupBoxAccount.Text = "Данные";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(84, 189);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(209, 24);
            this.comboBoxRole.TabIndex = 6;
            // 
            // textBoxPas
            // 
            this.textBoxPas.Location = new System.Drawing.Point(84, 125);
            this.textBoxPas.Name = "textBoxPas";
            this.textBoxPas.Size = new System.Drawing.Size(209, 23);
            this.textBoxPas.TabIndex = 4;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(84, 55);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(209, 23);
            this.textBoxLog.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Роль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.Honeydew;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.Location = new System.Drawing.Point(12, 359);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(311, 45);
            this.buttonReg.TabIndex = 7;
            this.buttonReg.Text = "Регистрация пользователя";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.Honeydew;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Location = new System.Drawing.Point(342, 359);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(311, 45);
            this.buttonEnter.TabIndex = 8;
            this.buttonEnter.Text = "Внести пользователя";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Marathon.Properties.Resources.Бегун;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormWorkAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(667, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.groupBoxAccount);
            this.Controls.Add(this.dataGridViewAccounts);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormWorkAccounts";
            this.Text = "Работа с аккаунтами";
            this.Load += new System.EventHandler(this.FormWorkAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).EndInit();
            this.groupBoxAccount.ResumeLayout(false);
            this.groupBoxAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dataGridViewAccounts;
        private System.Windows.Forms.GroupBox groupBoxAccount;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.TextBox textBoxPas;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}