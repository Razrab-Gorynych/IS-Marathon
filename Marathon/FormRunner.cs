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
    public partial class FormRunner : Form
    {
        MarathonDataSet.RunnersGendersCountriesDataTable dataRunners;
        MarathonDataSet.RunnersGendersCountriesRow rowRunner;
        MarathonDataSetTableAdapters.RunnersGendersCountriesTableAdapter runnersGendersCountriesTableAdapter = new MarathonDataSetTableAdapters.RunnersGendersCountriesTableAdapter();

        public FormRunner()
        {
            InitializeComponent();
        }

        private void FormRunner_Load(object sender, EventArgs e)
        {
            //Получили все данные
            dataRunners = this.runnersGendersCountriesTableAdapter.GetData();

            //Ищем профиль того аккаунта, который вошел в систему
            rowRunner = dataRunners.FindByID(ClassTotal.idUser);

            if (rowRunner == null)
            {
                MessageBox.Show("У Вас не заполнен профиль." + Environment.NewLine + "Надо его заполнить для дальнейшей работы");
                //Переходим на форму профиля
                FormRunnerProfile frp = new FormRunnerProfile("Addition");
                this.Hide(); 
                frp.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("У Вас заполнен профиль." + Environment.NewLine + "Можете работат в системе");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            FormRunnerProfile frp = new FormRunnerProfile("ViewEdit");
            this.Hide();
            frp.ShowDialog();
            this.Show();
        }

        private void buttonSponsors_Click(object sender, EventArgs e)
        {
            FormRunnerSponsors frs = new FormRunnerSponsors();
            this.Hide();
            frs.ShowDialog();
            this.Show();
        }

        private void buttonRegistrationToMarathon_Click(object sender, EventArgs e)
        {
            FormRegistrationToMarathon frm = new FormRegistrationToMarathon();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            FormResults formResults = new FormResults();
            this.Hide();
            formResults.ShowDialog();
            this.Show();
        }
    }
}
