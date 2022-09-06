using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Marathon
{
    public partial class FormRunnerProfile : Form
    {
        string command;						            //С какой целью открывается форма
        MarathonDataSet.UsersDataTable dataUsers;		//все данные
        MarathonDataSet.UsersRow rowUser;               //Отдельная строка таблицы
        MarathonDataSet.RunnersDataTable dataRunners;   //все данные из таблицы Runners
        MarathonDataSet.RunnersRow rowRunner;           //Отдельная строка таблицы

        MarathonDataSetTableAdapters.UsersTableAdapter usersTableAdapter = new MarathonDataSetTableAdapters.UsersTableAdapter();
        MarathonDataSetTableAdapters.RunnersTableAdapter runnersTableAdapter = new MarathonDataSetTableAdapters.RunnersTableAdapter();
        MarathonDataSetTableAdapters.GendersTableAdapter gendersTableAdapter = new MarathonDataSetTableAdapters.GendersTableAdapter();
        MarathonDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter = new MarathonDataSetTableAdapters.CountriesTableAdapter();

        //Конструктор с параметром – цель открытия формы
        public FormRunnerProfile(string command)
        {
            InitializeComponent();
            this.command = command;
        }

        private void FormRunnerProfile_Load(object sender, EventArgs e)
        {
            //Начальные настройки интерфейса
            buttonAdd.Visible = false;
            buttonExit.Enabled = true;
            textBoxWallet.Enabled = false;
            textBoxPathPhoto.Enabled = false;
            openFileDialog1.Filter = "jpg|*.jpg|png|*.png";

            //Данные из таблицы Users, которые нельзя менять
            dataUsers = this.usersTableAdapter.GetData();
            rowUser = dataUsers.FindByID(ClassTotal.idUser);
            labelID.Text = "Ваш номер: " + rowUser.ID.ToString();
            labelLog.Text = "Ваш логин: " + rowUser.Email;
            labelPas.Text = "Ваш пароль: " + rowUser.Password;

            //Настройка списков
            comboBoxCountries.DataSource = countriesTableAdapter.GetData();
            comboBoxCountries.DisplayMember = "Title";
            comboBoxCountries.ValueMember = "ID";
            comboBoxGenders.DataSource = gendersTableAdapter.GetData();
            comboBoxGenders.DisplayMember = "Title";
            comboBoxGenders.ValueMember = "ID";

            switch (command)	//С какой целью будет открываться форма
            {
                case "Addition":	//Цель - добавление
                    buttonAdd.Visible = true;
                    buttonExit.Enabled = false;
                    textBoxWallet.Text = "0,00";
                    buttonUpdate.Visible = false;
                    break;
                case "ViewEdit":
                    dataRunners = runnersTableAdapter.GetData(); 	//Все данные из таблице Runners

                    //Поиск среди них запись с нужным ID
                    rowRunner = dataRunners.FindByID(ClassTotal.idUser);

                    //Перенос данных из записи в элементы интерфейса
                    textBoxWallet.Text = rowRunner.Wallet.ToString();
                    textBoxName.Text = rowRunner.Name;
                    textBoxSurname.Text = rowRunner.Surname;
                    comboBoxGenders.SelectedValue = rowRunner.IDGender;
                    dateTimePickerBirthday.Value = rowRunner.Birthday;
                    comboBoxCountries.SelectedValue = rowRunner.IDCountry;
                    maskedTextBoxPhone.Text = rowRunner.Phone;

                    //Получить фото из БД и отобразить его в компоненте
                    if (rowRunner.IsPhotoNull())		//проверка пустого значения в поле фото
                    {
                        pictureBoxPhoto.Image = Properties.Resources.NotPicture;
                    }
                    else
                    {
                        byte[] photo = rowRunner.Photo;
                        MemoryStream stream = new MemoryStream(photo);
                        Image bit = Image.FromStream(stream);
                        pictureBoxPhoto.Image = bit;
                        buttonSelectPhoto.Text = "Удалить фото";
                    }
                    break;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            byte[] photo = null;

            //Получить данные из элементов интерфейса
            string runnerName = textBoxName.Text;
            string runnerLastname = textBoxSurname.Text;
            if (runnerName == "" || runnerLastname == "")
            {
                MessageBox.Show("Не заполнили имя или фамилию");
                return;
            }

            //Данные из списков ComboBox
            int idGender = (int)comboBoxGenders.SelectedValue;
            DateTime birthday = dateTimePickerBirthday.Value;
            int idCountry = (int)comboBoxCountries.SelectedValue;
            string phone = maskedTextBoxPhone.Text;
            decimal wallet = decimal.Parse(textBoxWallet.Text);

            //Работа с фото
            if (pictureBoxPhoto.Image != null)
            {
                photo = File.ReadAllBytes(openFileDialog1.FileName); //в массив
            }
            try
            {
                //Метод Insert адаптера 
                runnersTableAdapter.Insert(ClassTotal.idUser, runnerName, runnerLastname, idGender, birthday, idCountry, phone, wallet, photo);
                MessageBox.Show("Ваш профиль добавлен в систему");
                buttonAdd.Visible = false;
                buttonSelectPhoto.Enabled = false;
                buttonExit.Enabled = true;		//доступ к функционалу бегуна
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении профиля" + Environment.NewLine + ex.Message);
            }
        }

        private void buttonSelectPhoto_Click(object sender, EventArgs e)
        {
            if (buttonSelectPhoto.Text == "Выбрать фото")
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBoxPathPhoto.Text = openFileDialog1.FileName;
                    pictureBoxPhoto.Load(openFileDialog1.FileName);
                    buttonSelectPhoto.Text = "Удалить фото";
                }
            }
            else
            {
                textBoxPathPhoto.Text = "";
                pictureBoxPhoto.Image = Properties.Resources.NotPicture;
                buttonSelectPhoto.Text = "Выбрать фото";
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Заполнить строку-шаблон данными из элементов формы
            string runnerName = textBoxName.Text;
            string runnerLastname = textBoxSurname.Text;

            if (runnerName == "" || runnerLastname == "")
            {
                MessageBox.Show("Не заполнили имя или фамилию");
                return;
            }

            rowRunner.Name = runnerName;
            rowRunner.Surname = runnerLastname;
            rowRunner.IDGender = (int)comboBoxGenders.SelectedValue;
            rowRunner.Birthday = dateTimePickerBirthday.Value;
            rowRunner.IDCountry = (int)comboBoxCountries.SelectedValue;
            rowRunner.Phone = maskedTextBoxPhone.Text;
            rowRunner.Wallet = decimal.Parse(textBoxWallet.Text);

            //Подготовка к сохранению фото в БД
            if (pictureBoxPhoto.Image != null)
            {
                MemoryStream stream = new MemoryStream();	//Промежуточный поток
                pictureBoxPhoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                rowRunner.Photo = stream.ToArray();
            }
            else
            {
                rowRunner.Photo = null;
            }

            try
            {
                //Перенести измененные данные в БД
                runnersTableAdapter.Update(rowRunner);
                MessageBox.Show("Ваш профиль обновлен в системе");
                buttonSelectPhoto.Enabled = false;
                buttonExit.Enabled = true;		//Открыт доступ к функционалу бегуна
            }
            catch
            {
                MessageBox.Show("Ошибка при обновлении профиля");
            }
        }
    }
}
