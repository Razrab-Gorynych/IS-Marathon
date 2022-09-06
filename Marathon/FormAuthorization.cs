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
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        MarathonDataSet.UsersDataTable dataUsers;
        MarathonDataSetTableAdapters.UsersTableAdapter usersTableAdapter = new MarathonDataSetTableAdapters.UsersTableAdapter();
        MarathonDataSetTableAdapters.LoginHistoryTableAdapter loginHistoryTableAdapter = new MarathonDataSetTableAdapters.LoginHistoryTableAdapter();

        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            dataUsers = this.usersTableAdapter.GetData();                                    //Получение всех записей из таблицы Users
            int totalCount = dataUsers.Count;                                                //Количество записей
            this.dataGridViewUsers.DataSource = dataUsers;                                   //Отобразить полученные записи в компоненте
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;    //Настроить компонент по ширине
            dataGridViewUsers.AllowUserToAddRows = false;                                    //Разрешить добавлять новые строки
            this.dataGridViewUsers.Columns["ID"].Visible = false;                            //Настроить видимость нужных столбцов
            this.dataGridViewUsers.Columns["IDRole"].HeaderText = "Роль";                    //Изменить заголовки столбцов таблицы
            this.dataGridViewUsers.Columns["Email"].HeaderText = "Логин";
            this.dataGridViewUsers.Columns["Password"].HeaderText = "Пароль";
            this.textBoxPassword.PasswordChar = '*';	                                     //Символ для отображения пароля
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            string log, pas;
            pas = this.textBoxPassword.Text;
            log = this.textBoxLogin.Text;
            Auterization(log, pas);
        }

        public void Auterization (string log, string pas)
        {
            DateTime dt = DateTime.Now;			            //Дата для истории
            TimeSpan timeSpanNow = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
            dataUsers = this.usersTableAdapter.GetData();
            //Наложить на все записи фильтр на совпадение по логину и паролю
            var filter = dataUsers.Where(rec => rec.Email == log && rec.Password == pas);
            if (filter.Count() == 0)                        //Нет записей – совпадение логина+пароля не найдено
            {
                MessageBox.Show("Вы неверно ввели логин или пароль");
                try
                {
                    //Добавить в таблицу истории запись с неудачным входом
                    loginHistoryTableAdapter.Insert(log, timeSpanNow, false);
                }
                catch
                {
                    MessageBox.Show("Ошибка в истории входа");
                }

            }
            else //Данные в БД есть
            {
                try
                {
                    //Добавить в таблицу истории запись с удачным входом
                    loginHistoryTableAdapter.Insert(log, timeSpanNow, true);
                }
                catch
                {
                    MessageBox.Show("Ошибка в истории входа");
                }

                //Получение данных об этом пользователе и запись их в общий класс
                //Первая и единственная запись с 0 индексом
                ClassTotal.idUser = filter.ElementAt(0).ID;
                ClassTotal.idRole = filter.ElementAt(0).IDRole;
                ClassTotal.login = filter.ElementAt(0).Email;

                //Переход к формам в зависимости от роли
                switch (ClassTotal.idRole)
                {
                    case 1:
                        MessageBox.Show("Вы успешно авторизовались как бегун.");
                        FormRunner fr = new FormRunner();
                        this.Hide();
                        fr.ShowDialog();
                        this.Show();
                        break;
                    case 2:
                        MessageBox.Show("Вы успешно авторизовались как спонсор.");
                        FormSponsor fs = new FormSponsor();
                        this.Hide();
                        fs.ShowDialog();
                        this.Show();
                        break;
                    case 3:
                        MessageBox.Show("Вы успешно авторизовались как организатор.");
                        FormAdmin fa = new FormAdmin();
                        this.Hide();
                        fa.ShowDialog();
                        this.Show();
                        break;
                }
            }
        }
    }
}
