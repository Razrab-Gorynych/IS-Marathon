
namespace Marathon
{
    partial class FormResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResults));
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlResult = new System.Windows.Forms.TabControl();
            this.buttonFix = new System.Windows.Forms.Button();
            this.comboBoxResult = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Honeydew;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(625, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(130, 34);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Назад";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Результаты марафона";
            // 
            // tabControlResult
            // 
            this.tabControlResult.Location = new System.Drawing.Point(12, 93);
            this.tabControlResult.Name = "tabControlResult";
            this.tabControlResult.SelectedIndex = 0;
            this.tabControlResult.Size = new System.Drawing.Size(743, 292);
            this.tabControlResult.TabIndex = 6;
            // 
            // buttonFix
            // 
            this.buttonFix.BackColor = System.Drawing.Color.Honeydew;
            this.buttonFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFix.Location = new System.Drawing.Point(12, 391);
            this.buttonFix.Name = "buttonFix";
            this.buttonFix.Size = new System.Drawing.Size(743, 45);
            this.buttonFix.TabIndex = 7;
            this.buttonFix.Text = "Зафиксировать результаты";
            this.buttonFix.UseVisualStyleBackColor = false;
            this.buttonFix.Click += new System.EventHandler(this.buttonFix_Click);
            // 
            // comboBoxResult
            // 
            this.comboBoxResult.FormattingEnabled = true;
            this.comboBoxResult.Items.AddRange(new object[] {
            "Все результаты",
            "Мои результаты"});
            this.comboBoxResult.Location = new System.Drawing.Point(12, 63);
            this.comboBoxResult.Name = "comboBoxResult";
            this.comboBoxResult.Size = new System.Drawing.Size(246, 24);
            this.comboBoxResult.TabIndex = 8;
            this.comboBoxResult.SelectedIndexChanged += new System.EventHandler(this.comboBoxResult_SelectedIndexChanged);
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
            // FormResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxResult);
            this.Controls.Add(this.buttonFix);
            this.Controls.Add(this.tabControlResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormResults";
            this.Text = "Результаты марафона";
            this.Load += new System.EventHandler(this.FormResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlResult;
        private System.Windows.Forms.Button buttonFix;
        private System.Windows.Forms.ComboBox comboBoxResult;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}