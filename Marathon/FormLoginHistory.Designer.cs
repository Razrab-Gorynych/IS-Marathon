
namespace Marathon
{
    partial class FormLoginHistory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginHistory));
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLoginHistory = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultLoginDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.loginHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marathonDataSet = new Marathon.MarathonDataSet();
            this.loginHistoryTableAdapter1 = new Marathon.MarathonDataSetTableAdapters.LoginHistoryTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Honeydew;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(483, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 38);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "История входов";
            // 
            // dataGridViewLoginHistory
            // 
            this.dataGridViewLoginHistory.AllowUserToAddRows = false;
            this.dataGridViewLoginHistory.AllowUserToDeleteRows = false;
            this.dataGridViewLoginHistory.AutoGenerateColumns = false;
            this.dataGridViewLoginHistory.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridViewLoginHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoginHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.timeLoginDataGridViewTextBoxColumn,
            this.resultLoginDataGridViewCheckBoxColumn});
            this.dataGridViewLoginHistory.DataSource = this.loginHistoryBindingSource;
            this.dataGridViewLoginHistory.Location = new System.Drawing.Point(12, 70);
            this.dataGridViewLoginHistory.Name = "dataGridViewLoginHistory";
            this.dataGridViewLoginHistory.RowHeadersVisible = false;
            this.dataGridViewLoginHistory.Size = new System.Drawing.Size(601, 280);
            this.dataGridViewLoginHistory.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 80;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // timeLoginDataGridViewTextBoxColumn
            // 
            this.timeLoginDataGridViewTextBoxColumn.DataPropertyName = "TimeLogin";
            this.timeLoginDataGridViewTextBoxColumn.HeaderText = "Время входа";
            this.timeLoginDataGridViewTextBoxColumn.Name = "timeLoginDataGridViewTextBoxColumn";
            this.timeLoginDataGridViewTextBoxColumn.Width = 200;
            // 
            // resultLoginDataGridViewCheckBoxColumn
            // 
            this.resultLoginDataGridViewCheckBoxColumn.DataPropertyName = "ResultLogin";
            this.resultLoginDataGridViewCheckBoxColumn.HeaderText = "Результат входа";
            this.resultLoginDataGridViewCheckBoxColumn.Name = "resultLoginDataGridViewCheckBoxColumn";
            this.resultLoginDataGridViewCheckBoxColumn.Width = 200;
            // 
            // loginHistoryBindingSource
            // 
            this.loginHistoryBindingSource.DataMember = "LoginHistory";
            this.loginHistoryBindingSource.DataSource = this.marathonDataSet;
            // 
            // marathonDataSet
            // 
            this.marathonDataSet.DataSetName = "MarathonDataSet";
            this.marathonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginHistoryTableAdapter1
            // 
            this.loginHistoryTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Marathon.Properties.Resources.Бегун;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormLoginHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(625, 362);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewLoginHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLoginHistory";
            this.Text = "История входов";
            this.Load += new System.EventHandler(this.FormLoginHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLoginHistory;
        private MarathonDataSet marathonDataSet;
        private System.Windows.Forms.BindingSource loginHistoryBindingSource;
        private MarathonDataSetTableAdapters.LoginHistoryTableAdapter loginHistoryTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeLoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn resultLoginDataGridViewCheckBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}