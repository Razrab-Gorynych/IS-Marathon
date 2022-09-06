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
    public partial class FormSponsorProfile : Form
    {
        string command;						               //С какой целью открывается форма

        MarathonDataSet.UsersDataTable dataUsers;		  //все данные
        MarathonDataSet.UsersRow rowUser;			      //Отдельная строка таблицы
        MarathonDataSet.SponsorsDataTable dataSponsors;	  //все данные
        MarathonDataSet.SponsorsRow rowSponsor;		      //Отдельная строка таблицы

        MarathonDataSetTableAdapters.UsersTableAdapter usersTableAdapter = new MarathonDataSetTableAdapters.UsersTableAdapter();
        MarathonDataSetTableAdapters.SponsorsTableAdapter sponsorsTableAdapter = new MarathonDataSetTableAdapters.SponsorsTableAdapter();

        public FormSponsorProfile(string command)
        {
            InitializeComponent();
            this.command = command;			//Получение цели, с какой создается форма
        }

        private void FormSponsorProfile_Load(object sender, EventArgs e)
        {
            //Начальные настройки интерфейса
            buttonAdd.Visible = false;
            buttonUpdate.Visible = false;
            buttonExit.Enabled = true;
            textBoxSum.Enabled = false;
            textBoxPathPhoto.Enabled = false;
            openFileDialog1.Filter = "jpg|*.jpg|jpeg|*.jpeg|png|*.png";
            openFileDialog1.InitialDirectory = Application.StartupPath + @"\PhotoSponsors";
            openFileDialog1.Title = "Выбрать фото для спонсора";

            //Данные из таблицы Users, которые нельзя менять
            dataUsers = this.usersTableAdapter.GetData();
            rowUser = dataUsers.FindByID(ClassTotal.idUser);
            labelID.Text = "Ваш номер: " + rowUser.ID.ToString();
            labelLog.Text = "Ваш логин: " + rowUser.Email;
            labelPas.Text = "Ваш пароль: " + rowUser.Password;

            //Настройка списков
            comboBoxMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                comboBoxMonth.Items.Add(i.ToString());
            }
            comboBoxMonth.Text = comboBoxMonth.Items[0].ToString();
            comboBoxYear.Items.Clear();
            for (int i = DateTime.Now.Year - 5; i <= DateTime.Now.Year + 5; i++)
            {
                comboBoxYear.Items.Add(i.ToString());
            }
            comboBoxYear.Text = comboBoxYear.Items[0].ToString();
            switch (command)
            {
                case "Addition":
                    buttonAdd.Visible = true;
                    buttonExit.Enabled = false;
                    textBoxSum.Text = "0,00";
                    break;
                case "ViewEdit":
                    buttonUpdate.Visible = true;
                    dataSponsors = this.sponsorsTableAdapter.GetData();	//Все данные из Sponsors

                    //Поиск среди них запись с нужным ID
                    rowSponsor = dataSponsors.FindByID(ClassTotal.idUser);

                    //Перенос данных из записи в элементы интерфейса
                    textBoxSum.Text = rowSponsor.TotalSum.ToString();
                    textBoxName.Text = rowSponsor.Name;
                    maskedTextBoxCard.Text = rowSponsor.NumberCard;
                    comboBoxMonth.Text = rowSponsor.MonthCard.ToString();
                    comboBoxYear.Text = rowSponsor.YearCard.ToString();

                    //Обработка фото
                    if (rowSponsor.IsLogoNull())
                    {
                        pictureBoxPhoto.Image = Properties.Resources.NotPicture;
                    }
                    else
                    {
                        byte[] photo = rowSponsor.Logo;
                        MemoryStream stream = new MemoryStream(photo);
                        Image bit = Image.FromStream(stream);
                        pictureBoxPhoto.Image = bit;
                    }
                    break;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            byte[] photo = null;
            string sponsorName = textBoxName.Text;

            if (sponsorName == "")
            {
                MessageBox.Show("Не заполнили имя");
                return;
            }

            string numberCard = maskedTextBoxCard.Text;
            int monthCard = int.Parse(comboBoxMonth.Text);
            int yearCard = int.Parse(comboBoxYear.Text);
            decimal summa = decimal.Parse(textBoxSum.Text);

            if (pictureBoxPhoto.Image != null)
            {
                photo = File.ReadAllBytes(openFileDialog1.FileName);	//в массив
            }

            try
            {
                this.sponsorsTableAdapter.Insert(ClassTotal.idUser, sponsorName, numberCard, monthCard, yearCard, summa, photo);
                MessageBox.Show("Ваш профиль добавлен в систему");
                buttonAdd.Visible = false;
                buttonSelectPhoto.Enabled = false;
                buttonExit.Enabled = true;		//доступ к функционалу спонсора
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении профиля");
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Заполнить строку-шаблон данными из элементов формы
            string sponsorName = textBoxName.Text;

            if (sponsorName == "")
            {
                MessageBox.Show("Не заполнили имя или фамилию");
                return;
            }

            rowSponsor.Name = sponsorName;
            rowSponsor.NumberCard = maskedTextBoxCard.Text;
            rowSponsor.MonthCard = int.Parse(comboBoxMonth.Text);
            rowSponsor.YearCard = int.Parse(comboBoxYear.Text);
            rowSponsor.TotalSum = decimal.Parse(textBoxSum.Text);

            if (pictureBoxPhoto.Image != null)
            {
                MemoryStream stream = new MemoryStream();	//Промежуточный поток 
                pictureBoxPhoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                rowSponsor.Logo = stream.ToArray();
            }
            else
            {
                rowSponsor.Logo = null;
            }

            try
            {
                this.sponsorsTableAdapter.Update(rowSponsor);
                MessageBox.Show("Ваш профиль обновлен в системе");
                buttonSelectPhoto.Enabled = false;
                buttonExit.Enabled = true;		//доступ к функционалу спонсора
            }
            catch
            {
                MessageBox.Show("Ошибка при обновлении профиля");
            }
        }
    }
}
