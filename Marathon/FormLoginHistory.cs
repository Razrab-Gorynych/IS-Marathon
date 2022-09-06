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
    public partial class FormLoginHistory : Form
    {
        public FormLoginHistory()
        {
            InitializeComponent();
        }

        //Объекты типов таблиц БД
        //MarathonDataSet.UsersDataTable dataUsers;
        //Данные всей таблицы истории
        MarathonDataSet.LoginHistoryDataTable dataLoginHistory;
        MarathonDataSetTableAdapters.LoginHistoryTableAdapter loginHistoryTableAdapter = new MarathonDataSetTableAdapters.LoginHistoryTableAdapter();


        private void FormLoginHistory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonDataSet.LoginHistory". При необходимости она может быть перемещена или удалена.
            this.loginHistoryTableAdapter1.Fill(this.marathonDataSet.LoginHistory);
            //В начале каждого запуска приложения удалять все предыдущие данные в истории
            //Получить все данные из таблицы История входа
            dataLoginHistory = this.loginHistoryTableAdapter.GetData();
            MarathonDataSet.LoginHistoryRow loginHR;	//Тип отдельной строки таблицы
            try
            {
                for (int i = 0; i < dataLoginHistory.Count; i++)	//Количество записей
                {
                    loginHR = dataLoginHistory.ElementAt(i);	//Отдельная запись
                    //Удалить текущую запись
                    this.loginHistoryTableAdapter.Delete(loginHR.ID, loginHR.Login, loginHR.TimeLogin, loginHR.ResultLogin);
                }
            }
            catch
            {
                MessageBox.Show("Не удалось удались из истории входов");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
