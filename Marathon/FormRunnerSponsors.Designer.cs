
namespace Marathon
{
    partial class FormRunnerSponsors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRunnerSponsors));
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelSponsors = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTotalSum = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Honeydew;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(306, 12);
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
            this.label1.Location = new System.Drawing.Point(167, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Мои спонсоры";
            // 
            // flowLayoutPanelSponsors
            // 
            this.flowLayoutPanelSponsors.Location = new System.Drawing.Point(13, 101);
            this.flowLayoutPanelSponsors.Name = "flowLayoutPanelSponsors";
            this.flowLayoutPanelSponsors.Size = new System.Drawing.Size(423, 394);
            this.flowLayoutPanelSponsors.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Общая сумма спонсирования:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 553);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Количество спонсоров:";
            // 
            // textBoxTotalSum
            // 
            this.textBoxTotalSum.Location = new System.Drawing.Point(258, 519);
            this.textBoxTotalSum.Name = "textBoxTotalSum";
            this.textBoxTotalSum.Size = new System.Drawing.Size(168, 23);
            this.textBoxTotalSum.TabIndex = 12;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(258, 553);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(168, 23);
            this.textBoxCount.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Marathon.Properties.Resources.Бегун;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FormRunnerSponsors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(448, 594);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxTotalSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanelSponsors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRunnerSponsors";
            this.Text = "Мои спонсоры";
            this.Load += new System.EventHandler(this.FormRunnerSponsors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSponsors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTotalSum;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}