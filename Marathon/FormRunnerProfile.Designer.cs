
namespace Marathon
{
    partial class FormRunnerProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRunnerProfile));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCountries = new System.Windows.Forms.ComboBox();
            this.comboBoxGenders = new System.Windows.Forms.ComboBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxWallet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelPas = new System.Windows.Forms.Label();
            this.labelLog = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonSelectPhoto = new System.Windows.Forms.Button();
            this.textBoxPathPhoto = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(306, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мой профиль";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Honeydew;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(564, 26);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(169, 34);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Назад";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(343, 338);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(390, 45);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить профиль";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maskedTextBoxPhone);
            this.panel1.Controls.Add(this.dateTimePickerBirthday);
            this.panel1.Controls.Add(this.comboBoxCountries);
            this.panel1.Controls.Add(this.comboBoxGenders);
            this.panel1.Controls.Add(this.textBoxSurname);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 318);
            this.panel1.TabIndex = 9;
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(105, 274);
            this.maskedTextBoxPhone.Mask = "8(999)000-00-00";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(186, 23);
            this.maskedTextBoxPhone.TabIndex = 14;
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(145, 168);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(146, 23);
            this.dateTimePickerBirthday.TabIndex = 13;
            // 
            // comboBoxCountries
            // 
            this.comboBoxCountries.FormattingEnabled = true;
            this.comboBoxCountries.Location = new System.Drawing.Point(105, 222);
            this.comboBoxCountries.Name = "comboBoxCountries";
            this.comboBoxCountries.Size = new System.Drawing.Size(186, 24);
            this.comboBoxCountries.TabIndex = 12;
            // 
            // comboBoxGenders
            // 
            this.comboBoxGenders.FormattingEnabled = true;
            this.comboBoxGenders.Location = new System.Drawing.Point(105, 116);
            this.comboBoxGenders.Name = "comboBoxGenders";
            this.comboBoxGenders.Size = new System.Drawing.Size(186, 24);
            this.comboBoxGenders.TabIndex = 11;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(105, 65);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(186, 23);
            this.textBoxSurname.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(105, 16);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(186, 23);
            this.textBoxName.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Страна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Пол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Имя";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBoxWallet);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.labelPas);
            this.panel2.Controls.Add(this.labelLog);
            this.panel2.Controls.Add(this.labelID);
            this.panel2.Location = new System.Drawing.Point(343, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 249);
            this.panel2.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(168, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "$";
            // 
            // textBoxWallet
            // 
            this.textBoxWallet.Location = new System.Drawing.Point(91, 205);
            this.textBoxWallet.Name = "textBoxWallet";
            this.textBoxWallet.Size = new System.Drawing.Size(74, 23);
            this.textBoxWallet.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Кошелёк";
            // 
            // labelPas
            // 
            this.labelPas.AutoSize = true;
            this.labelPas.Location = new System.Drawing.Point(18, 148);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(69, 17);
            this.labelPas.TabIndex = 2;
            this.labelPas.Text = "Password";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(18, 84);
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
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Image = global::Marathon.Properties.Resources.NotPicture;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(579, 81);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(140, 140);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 11;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // buttonSelectPhoto
            // 
            this.buttonSelectPhoto.BackColor = System.Drawing.Color.Honeydew;
            this.buttonSelectPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectPhoto.Location = new System.Drawing.Point(564, 240);
            this.buttonSelectPhoto.Name = "buttonSelectPhoto";
            this.buttonSelectPhoto.Size = new System.Drawing.Size(169, 34);
            this.buttonSelectPhoto.TabIndex = 12;
            this.buttonSelectPhoto.Text = "Выбрать фото";
            this.buttonSelectPhoto.UseVisualStyleBackColor = false;
            this.buttonSelectPhoto.Click += new System.EventHandler(this.buttonSelectPhoto_Click);
            // 
            // textBoxPathPhoto
            // 
            this.textBoxPathPhoto.Location = new System.Drawing.Point(564, 291);
            this.textBoxPathPhoto.Name = "textBoxPathPhoto";
            this.textBoxPathPhoto.Size = new System.Drawing.Size(169, 23);
            this.textBoxPathPhoto.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Honeydew;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(343, 338);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(390, 45);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Обновить профиль";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
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
            // FormRunnerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(755, 400);
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
            this.Name = "FormRunnerProfile";
            this.Text = "Мой профиль";
            this.Load += new System.EventHandler(this.FormRunnerProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCountries;
        private System.Windows.Forms.ComboBox comboBoxGenders;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxWallet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonSelectPhoto;
        private System.Windows.Forms.TextBox textBoxPathPhoto;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}