
namespace Marathon
{
    partial class FormSponsorProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSponsorProfile));
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxPathPhoto = new System.Windows.Forms.TextBox();
            this.buttonSelectPhoto = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelPas = new System.Windows.Forms.Label();
            this.labelLog = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBoxCard = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Honeydew;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(384, 335);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(355, 45);
            this.buttonUpdate.TabIndex = 23;
            this.buttonUpdate.Text = "Обновить профиль";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxPathPhoto
            // 
            this.textBoxPathPhoto.Location = new System.Drawing.Point(570, 288);
            this.textBoxPathPhoto.Name = "textBoxPathPhoto";
            this.textBoxPathPhoto.Size = new System.Drawing.Size(169, 23);
            this.textBoxPathPhoto.TabIndex = 22;
            // 
            // buttonSelectPhoto
            // 
            this.buttonSelectPhoto.BackColor = System.Drawing.Color.Honeydew;
            this.buttonSelectPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectPhoto.Location = new System.Drawing.Point(570, 237);
            this.buttonSelectPhoto.Name = "buttonSelectPhoto";
            this.buttonSelectPhoto.Size = new System.Drawing.Size(169, 34);
            this.buttonSelectPhoto.TabIndex = 21;
            this.buttonSelectPhoto.Text = "Выбрать фото";
            this.buttonSelectPhoto.UseVisualStyleBackColor = false;
            this.buttonSelectPhoto.Click += new System.EventHandler(this.buttonSelectPhoto_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(218, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "$";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(127, 116);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(91, 23);
            this.textBoxSum.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Сумма взноса";
            // 
            // labelPas
            // 
            this.labelPas.AutoSize = true;
            this.labelPas.Location = new System.Drawing.Point(16, 86);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(69, 17);
            this.labelPas.TabIndex = 2;
            this.labelPas.Text = "Password";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(18, 53);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(43, 17);
            this.labelLog.TabIndex = 1;
            this.labelLog.Text = "Login";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(18, 22);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 17);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBoxSum);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.labelPas);
            this.panel2.Controls.Add(this.labelLog);
            this.panel2.Controls.Add(this.labelID);
            this.panel2.Location = new System.Drawing.Point(306, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 249);
            this.panel2.TabIndex = 19;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(78, 16);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(173, 23);
            this.textBoxName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Месяц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Карта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Имя";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maskedTextBoxCard);
            this.panel1.Controls.Add(this.comboBoxYear);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBoxMonth);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 249);
            this.panel1.TabIndex = 18;
            // 
            // maskedTextBoxCard
            // 
            this.maskedTextBoxCard.Location = new System.Drawing.Point(78, 65);
            this.maskedTextBoxCard.Mask = "0000-0000-0000-0000";
            this.maskedTextBoxCard.Name = "maskedTextBoxCard";
            this.maskedTextBoxCard.Size = new System.Drawing.Size(173, 23);
            this.maskedTextBoxCard.TabIndex = 14;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(197, 116);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(54, 24);
            this.comboBoxYear.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Год";
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(78, 116);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(54, 24);
            this.comboBoxMonth.TabIndex = 11;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Honeydew;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(18, 335);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(355, 45);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Добавить профиль";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Honeydew;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(570, 23);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(169, 34);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.Text = "Назад";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(312, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Мой профиль";
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Image = global::Marathon.Properties.Resources.NotPicture;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(585, 78);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(140, 140);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 20;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Marathon.Properties.Resources.Бегун;
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // FormSponsorProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(762, 398);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxPathPhoto);
            this.Controls.Add(this.buttonSelectPhoto);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSponsorProfile";
            this.Text = "Мой профиль";
            this.Load += new System.EventHandler(this.FormSponsorProfile_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxPathPhoto;
        private System.Windows.Forms.Button buttonSelectPhoto;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCard;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}