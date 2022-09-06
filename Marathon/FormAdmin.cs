using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLoginHistory_Click(object sender, EventArgs e)
        {
            FormLoginHistory formLoginHistory = new FormLoginHistory();
            this.Hide();
            formLoginHistory.ShowDialog();
            this.Show();
        }

        private void buttonWorkAccounts_Click(object sender, EventArgs e)
        {
            FormWorkAccounts formWorkAccounts = new FormWorkAccounts();
            this.Hide();
            formWorkAccounts.ShowDialog();
            this.Show();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            FormResults formResults = new FormResults();
            this.Hide();
            formResults.ShowDialog();
            this.Show();
        }
    }
}
