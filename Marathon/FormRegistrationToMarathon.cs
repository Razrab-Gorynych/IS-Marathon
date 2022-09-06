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
    public partial class FormRegistrationToMarathon : Form
    {

        double sumTotal = 145, sumType = 145, sumSet = 0;	//Сумма
        int idTypeDistance = 1, idSet = 1;		//ID типа и набора
        MarathonDataSet.RunnersRow runnersRow;	//Строка с информацией о бегуне

        MarathonDataSetTableAdapters.OrdersMarathonTableAdapter ordersMarathonTableAdapter = new MarathonDataSetTableAdapters.OrdersMarathonTableAdapter();
        MarathonDataSetTableAdapters.RunnersTableAdapter runnersTableAdapter = new MarathonDataSetTableAdapters.RunnersTableAdapter();

        public FormRegistrationToMarathon()
        {
            InitializeComponent();
        }

        private void FormRegistrationToMarathon_Load(object sender, EventArgs e)
        {
            this.labelSum.Text = "$ " + sumTotal.ToString();              //Сумма по умолчанию

            //Доступ к информации активного бегуна
            runnersRow = this.runnersTableAdapter.GetData().FindByID(ClassTotal.idUser);
            this.labelWallet.Text = "$ " + runnersRow.Wallet.ToString();	//Его сумма кошелька
        }

        private void radioButtonTypeA_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonTypeA.Checked)
            {
                sumSet = 0;
                idSet = 1;
            }
            sumTotal = sumType + sumSet;
            this.labelSum.Text = "$ " + sumTotal.ToString();
        }

        private void radioButtonTypeB_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonTypeB.Checked)
            {
                sumSet = 20;
                idSet = 2;
            }
            sumTotal = sumType + sumSet;
            this.labelSum.Text = "$ " + sumTotal.ToString();
        }

        private void radioButtonTypeC_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonTypeC.Checked)
            {
                sumSet = 45;
                idSet = 3;
            }
            sumTotal = sumType + sumSet;
            this.labelSum.Text = "$ " + sumTotal.ToString();
        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton42.Checked)
            {
                sumType = 145;
                idTypeDistance = 1;
            }
            sumTotal = sumType + sumSet;
            this.labelSum.Text = "$ " + sumTotal.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton21.Checked)
            {
                sumType = 75;
                idTypeDistance = 2;
            }
            sumTotal = sumType + sumSet;
            this.labelSum.Text = "$ " + sumTotal.ToString();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton5.Checked)
            {
                sumType = 20;
                idTypeDistance = 3;
            }
            sumTotal = sumType + sumSet;
            this.labelSum.Text = "$ " + sumTotal.ToString();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if ((double)runnersRow.Wallet >= sumTotal)
            {
                try
                {
                    //Добавить запись о бегуне и выбранных условиях, статус = 3, время и место пока 0
                    ordersMarathonTableAdapter.Insert(ClassTotal.idUser, idTypeDistance, idSet, 3, 0, 0);
                    runnersRow.Wallet -= (decimal)sumTotal;
                    this.runnersTableAdapter.Update(runnersRow);
                    this.labelWallet.Text = "$ " + runnersRow.Wallet.ToString();
                    MessageBox.Show("Вы успешно записаны на марафон");
                }
                catch
                {
                    MessageBox.Show("При записи на марафон возникли проблемы");
                }
            }
            else
            {
                MessageBox.Show("У Вас недостаточно средств для записи на марафон");
            }
        }
    }
}