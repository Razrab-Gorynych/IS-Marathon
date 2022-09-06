
namespace Marathon
{
    partial class FormSponsorRunners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSponsorRunners));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRunners = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonSponsRun = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTotalSum = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelRunners = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(257, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Спонсирование бегунов";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Honeydew;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(547, 19);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(130, 34);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Назад";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Выберите бегуна из списка:";
            // 
            // comboBoxRunners
            // 
            this.comboBoxRunners.FormattingEnabled = true;
            this.comboBoxRunners.Location = new System.Drawing.Point(43, 120);
            this.comboBoxRunners.Name = "comboBoxRunners";
            this.comboBoxRunners.Size = new System.Drawing.Size(241, 24);
            this.comboBoxRunners.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Сумма спонсирования ($):";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(115, 202);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(97, 23);
            this.textBoxSum.TabIndex = 16;
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.Honeydew;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Location = new System.Drawing.Point(224, 196);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(60, 34);
            this.buttonPlus.TabIndex = 17;
            this.buttonPlus.Text = "+100$";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.Honeydew;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Location = new System.Drawing.Point(43, 196);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(60, 34);
            this.buttonMinus.TabIndex = 18;
            this.buttonMinus.Text = "-100$";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonSponsRun
            // 
            this.buttonSponsRun.BackColor = System.Drawing.Color.Honeydew;
            this.buttonSponsRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSponsRun.Location = new System.Drawing.Point(43, 248);
            this.buttonSponsRun.Name = "buttonSponsRun";
            this.buttonSponsRun.Size = new System.Drawing.Size(240, 45);
            this.buttonSponsRun.TabIndex = 19;
            this.buttonSponsRun.Text = "Спонсировать бегуна";
            this.buttonSponsRun.UseVisualStyleBackColor = false;
            this.buttonSponsRun.Click += new System.EventHandler(this.buttonSponsRun_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ваши спонсированные бегуны:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Общая сумма спонсорских взносов:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Количество спонсируемых бегунов:";
            // 
            // textBoxTotalSum
            // 
            this.textBoxTotalSum.Location = new System.Drawing.Point(43, 365);
            this.textBoxTotalSum.Name = "textBoxTotalSum";
            this.textBoxTotalSum.Size = new System.Drawing.Size(240, 23);
            this.textBoxTotalSum.TabIndex = 23;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(43, 451);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(240, 23);
            this.textBoxCount.TabIndex = 24;
            // 
            // flowLayoutPanelRunners
            // 
            this.flowLayoutPanelRunners.BackColor = System.Drawing.Color.Honeydew;
            this.flowLayoutPanelRunners.Location = new System.Drawing.Point(325, 120);
            this.flowLayoutPanelRunners.Name = "flowLayoutPanelRunners";
            this.flowLayoutPanelRunners.Size = new System.Drawing.Size(352, 354);
            this.flowLayoutPanelRunners.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Marathon.Properties.Resources.Бегун;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // FormSponsorRunners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(709, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanelRunners);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxTotalSum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSponsRun);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRunners);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSponsorRunners";
            this.Text = "Спонсирование бегунов";
            this.Load += new System.EventHandler(this.FormSponsorRunners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRunners;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonSponsRun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTotalSum;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRunners;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}