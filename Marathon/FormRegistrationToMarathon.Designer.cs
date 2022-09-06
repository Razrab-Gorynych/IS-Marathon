
namespace Marathon
{
    partial class FormRegistrationToMarathon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrationToMarathon));
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton42 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonTypeC = new System.Windows.Forms.RadioButton();
            this.radioButtonTypeB = new System.Windows.Forms.RadioButton();
            this.radioButtonTypeA = new System.Windows.Forms.RadioButton();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWallet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxType.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Honeydew;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(484, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(130, 34);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Назад";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(210, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Регистрация на марафон";
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.radioButton5);
            this.groupBoxType.Controls.Add(this.radioButton21);
            this.groupBoxType.Controls.Add(this.radioButton42);
            this.groupBoxType.Location = new System.Drawing.Point(12, 128);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(275, 197);
            this.groupBoxType.TabIndex = 9;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Вид марафона";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(25, 143);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(205, 21);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.Text = "5 км Малый марафон (20$)";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton21
            // 
            this.radioButton21.AutoSize = true;
            this.radioButton21.Location = new System.Drawing.Point(25, 95);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(197, 21);
            this.radioButton21.TabIndex = 1;
            this.radioButton21.Text = "21 км Полумарафон (75$)";
            this.radioButton21.UseVisualStyleBackColor = true;
            this.radioButton21.CheckedChanged += new System.EventHandler(this.radioButton21_CheckedChanged);
            // 
            // radioButton42
            // 
            this.radioButton42.AutoSize = true;
            this.radioButton42.Checked = true;
            this.radioButton42.Location = new System.Drawing.Point(25, 48);
            this.radioButton42.Name = "radioButton42";
            this.radioButton42.Size = new System.Drawing.Size(228, 21);
            this.radioButton42.TabIndex = 0;
            this.radioButton42.TabStop = true;
            this.radioButton42.Text = "42 км Полный марафон (145$)";
            this.radioButton42.UseVisualStyleBackColor = true;
            this.radioButton42.CheckedChanged += new System.EventHandler(this.radioButton42_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonTypeC);
            this.groupBox2.Controls.Add(this.radioButtonTypeB);
            this.groupBox2.Controls.Add(this.radioButtonTypeA);
            this.groupBox2.Location = new System.Drawing.Point(306, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 251);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Варианты комплектов";
            // 
            // radioButtonTypeC
            // 
            this.radioButtonTypeC.AutoSize = true;
            this.radioButtonTypeC.Location = new System.Drawing.Point(31, 179);
            this.radioButtonTypeC.Name = "radioButtonTypeC";
            this.radioButtonTypeC.Size = new System.Drawing.Size(234, 38);
            this.radioButtonTypeC.TabIndex = 2;
            this.radioButtonTypeC.Text = "Вариант С (45$): Вариант В + \r\nфутболка + сувенирный буклет";
            this.radioButtonTypeC.UseVisualStyleBackColor = true;
            this.radioButtonTypeC.CheckedChanged += new System.EventHandler(this.radioButtonTypeC_CheckedChanged);
            // 
            // radioButtonTypeB
            // 
            this.radioButtonTypeB.AutoSize = true;
            this.radioButtonTypeB.Location = new System.Drawing.Point(31, 111);
            this.radioButtonTypeB.Name = "radioButtonTypeB";
            this.radioButtonTypeB.Size = new System.Drawing.Size(226, 38);
            this.radioButtonTypeB.TabIndex = 1;
            this.radioButtonTypeB.Text = "Вариант В (20$): Вариант А + \r\nбейсболка + бутылка воды";
            this.radioButtonTypeB.UseVisualStyleBackColor = true;
            this.radioButtonTypeB.CheckedChanged += new System.EventHandler(this.radioButtonTypeB_CheckedChanged);
            // 
            // radioButtonTypeA
            // 
            this.radioButtonTypeA.AutoSize = true;
            this.radioButtonTypeA.Checked = true;
            this.radioButtonTypeA.Location = new System.Drawing.Point(31, 42);
            this.radioButtonTypeA.Name = "radioButtonTypeA";
            this.radioButtonTypeA.Size = new System.Drawing.Size(220, 38);
            this.radioButtonTypeA.TabIndex = 0;
            this.radioButtonTypeA.TabStop = true;
            this.radioButtonTypeA.Text = "Вариант А (0$): \r\nномер бегуна + RFID браслет";
            this.radioButtonTypeA.UseVisualStyleBackColor = true;
            this.radioButtonTypeA.CheckedChanged += new System.EventHandler(this.radioButtonTypeA_CheckedChanged);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.Color.Honeydew;
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistration.Location = new System.Drawing.Point(306, 340);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(308, 45);
            this.buttonRegistration.TabIndex = 11;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ваш кошелёк:";
            // 
            // labelWallet
            // 
            this.labelWallet.AutoSize = true;
            this.labelWallet.Location = new System.Drawing.Point(134, 85);
            this.labelWallet.Name = "labelWallet";
            this.labelWallet.Size = new System.Drawing.Size(16, 17);
            this.labelWallet.TabIndex = 13;
            this.labelWallet.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Регистрационный взнос:";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(206, 354);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(16, 17);
            this.labelSum.TabIndex = 15;
            this.labelSum.Text = "$";
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
            // FormRegistrationToMarathon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(628, 401);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelWallet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegistrationToMarathon";
            this.Text = "Регистрация на марафон";
            this.Load += new System.EventHandler(this.FormRegistrationToMarathon_Load);
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton21;
        private System.Windows.Forms.RadioButton radioButton42;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonTypeC;
        private System.Windows.Forms.RadioButton radioButtonTypeB;
        private System.Windows.Forms.RadioButton radioButtonTypeA;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelWallet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}