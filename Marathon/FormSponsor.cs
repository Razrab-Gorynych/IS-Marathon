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
    public partial class FormSponsor : Form
    {
        MarathonDataSet.SponsorsDataTable dataSponsors;
        MarathonDataSet.SponsorsRow rowSponsor;

        MarathonDataSetTableAdapters.SponsorsTableAdapter sponsorsTableAdapter = new MarathonDataSetTableAdapters.SponsorsTableAdapter();

        public FormSponsor()
        {
            InitializeComponent();
        }

        private void FormSponsor_Load(object sender, EventArgs e)
        {
            //Получили все данные
            dataSponsors = this.sponsorsTableAdapter.GetData();

            //Ищем профиль того аккаунта, который вошел в систему
            rowSponsor = dataSponsors.FindByID(ClassTotal.idUser);

            if (rowSponsor == null)
            {
                MessageBox.Show("У Вас не заполнен профиль." + Environment.NewLine + "Надо его заполнить для дальнейшей работы");

                //Конструктору передается команда о добавлении
                FormSponsorProfile fsp = new FormSponsorProfile("Addition");
                this.Hide();
                fsp.ShowDialog();
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
            FormSponsorProfile fsp = new FormSponsorProfile("ViewEdit");
            this.Hide();
            fsp.ShowDialog();
            this.Show();
        }

        private void buttonSponsRun_Click(object sender, EventArgs e)
        {
            FormSponsorRunners fsr = new FormSponsorRunners();
            this.Hide();
            fsr.ShowDialog();
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
