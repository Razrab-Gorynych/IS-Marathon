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
    public partial class FormSponsorRunners : Form
    {
        decimal sum;  //Спонсорская сумма

        MarathonDataSetTableAdapters.RunnersCountriesTableAdapter runnersCountriesTableAdapter = new MarathonDataSetTableAdapters.RunnersCountriesTableAdapter();
        MarathonDataSetTableAdapters.RunnerSponsorTableAdapter runnerSponsorTableAdapter = new MarathonDataSetTableAdapters.RunnerSponsorTableAdapter();
        MarathonDataSetTableAdapters.SponsorsTableAdapter sponsorsTableAdapter = new MarathonDataSetTableAdapters.SponsorsTableAdapter();
        MarathonDataSetTableAdapters.RunnersTableAdapter runnersTableAdapter = new MarathonDataSetTableAdapters.RunnersTableAdapter();
        MarathonDataSetTableAdapters.ListRunnersSponsorsTableAdapter listRunnersSponsorsTableAdapter = new MarathonDataSetTableAdapters.ListRunnersSponsorsTableAdapter();

        MarathonDataSet.ListRunnersSponsorsDataTable dataListRunnersSponsors;

        public FormSponsorRunners()
        {
            InitializeComponent();
        }

        private void FormSponsorRunners_Load(object sender, EventArgs e)
        {
            sum = 0;
            textBoxSum.Text = sum.ToString();
            textBoxSum.Enabled = false;

            //Данные из сводного адаптера
            this.comboBoxRunners.DataSource = this.runnersCountriesTableAdapter.GetData();

            //Данные из объединенного поля
            this.comboBoxRunners.DisplayMember = "FIOCountry";
            this.comboBoxRunners.ValueMember = "ID";

            ShowList();
        }

        private void buttonSponsRun_Click(object sender, EventArgs e)
        {
            int idRunner;                            //ID спонсируемого бегуна
            sum = decimal.Parse(textBoxSum.Text);    //Спонсируемая сумма

            //Изменение общей суммы в таблице спонсоров
            var dataSponsors = this.sponsorsTableAdapter.GetData();
            var rowSponsor = dataSponsors.FindByID(ClassTotal.idUser);
            rowSponsor.TotalSum += sum;			//Увеличить

            try
            {
                this.sponsorsTableAdapter.Update(rowSponsor);
            }
            catch
            {
                MessageBox.Show("Не удалось обновить общую сумму в таблице спонсоров");
                return;
            }

            //Изменения суммы в кошельке у спонсируемого бегуна
            idRunner = (int)this.comboBoxRunners.SelectedValue;		//Номер бегуна

            //Сначала получить текущее значение кошелька
            var rowRunner = this.runnersTableAdapter.GetData().FindByID(idRunner);

            //Увеличить его сумму
            rowRunner.Wallet += sum;

            try
            {
                this.runnersTableAdapter.Update(rowRunner);
            }
            catch
            {
                MessageBox.Show("Не удалось обновить сумму в таблице бегуна");
                return;
            }

            //Поиск в таблице-связке записи с заданными бегун+спонсор
            //Получить строку из таблицы бегун+спонсор
            var dataRunnerSponsor = this.runnerSponsorTableAdapter.GetData().
                        Where(rec => rec.IDRunner == idRunner && rec.IDSponsor == ClassTotal.idUser);

            if (dataRunnerSponsor.Count() == 0)		//Спонсор не спонсировал этого бегуна
            {
                try
                {
                    //Добавление в таблицу-связку
                    this.runnerSponsorTableAdapter.Insert(idRunner, ClassTotal.idUser, sum);
                }
                catch
                {
                    MessageBox.Show("Добавился новый бегун в таблице-связке");
                    return;
                }
            }
            else //Этот спонсор спонсировал этого бегуна
            {
                var rowRunnerSponsor = dataRunnerSponsor.First(); //Единственная запись в таблице
                rowRunnerSponsor.SumSponsor += sum;	//Увеличить на сумму спонсорства
                try
                {
                    this.runnerSponsorTableAdapter.Update(rowRunnerSponsor); 	//Обновить
                }
                catch
                {
                    MessageBox.Show("Не удалось обновить сумму в таблице-связке");
                    return;
                }
            }

            //Все удачно
            ShowList();
            MessageBox.Show("Все суммы обновлены");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (sum >= 100)
            {
                sum -= 100;
                textBoxSum.Text = sum.ToString();
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            sum += 100;
            textBoxSum.Text = sum.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void ShowList()
        {
            Panel panel;
            Label labelName, labelLastname, labelSum;
            PictureBox pictureBoxRunner;
            byte[] photo;
            System.IO.MemoryStream stream;
            Bitmap bit, bitNot;
            bitNot = new Bitmap(Properties.Resources.NotPicture);	//Для пустой картинки

            //Получить все данные из смешанной таблицы для конкретного спонсора
            //вызывается свой метод для созданного адаптера из четырех таблиц
            dataListRunnersSponsors = listRunnersSponsorsTableAdapter.GetDataByIDSponsor(ClassTotal.idUser);

            if (dataListRunnersSponsors.Count == 0)		//Пустой список
            {
                MessageBox.Show("У Вас нет спонсируемых бегунов");
                textBoxTotalSum.Text = "0";
                textBoxCount.Text = "0";
            }
            else
            {
                //Настройка панели FlowLayoutPanel: все записи последовательно спускаются вниз
                this.flowLayoutPanelRunners.FlowDirection = FlowDirection.TopDown;	//свеpху
                this.flowLayoutPanelRunners.AutoScroll = true;		//Полосы прокрутки
                this.flowLayoutPanelRunners.WrapContents = false;	//В одной строке
                this.flowLayoutPanelRunners.Font = new Font(FontFamily.GenericMonospace, 12);
                this.flowLayoutPanelRunners.Controls.Clear();

                //Все записи по очереди переносятся в FlowLayoutPanel
                for (int i = 0; i < dataListRunnersSponsors.Count; i++)
                {
                    panel = new Panel();		//Контейнер для элементов одной записи
                    panel.Size = new Size(this.flowLayoutPanelRunners.Width, 100);	//Размер

                    //Настройка фото бегуна
                    pictureBoxRunner = new PictureBox();
                    pictureBoxRunner.Size = new Size(panel.Width / 3, panel.Height - 10);
                    pictureBoxRunner.Location = new Point(5, 5);
                    pictureBoxRunner.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxRunner.SizeMode = PictureBoxSizeMode.Zoom;

                    //Работа с фото
                    if (dataListRunnersSponsors.ElementAt(i).IsPhotoNull())
                    {
                        pictureBoxRunner.Image = bitNot;    //Изображение без фото
                    }
                    else
                    {
                        photo = dataListRunnersSponsors.ElementAt(i).Photo;	//Значение поля фото
                        stream = new System.IO.MemoryStream(photo);
                        bit = (Bitmap)Image.FromStream(stream);
                        pictureBoxRunner.Image = bit;				//Для отображения
                    }

                    panel.Controls.Add(pictureBoxRunner);	//Добавить картинку в панель

                    //Добавить надпись с именем бегуна
                    labelName = new Label();
                    labelName.Location = new Point(pictureBoxRunner.Size.Width + 5, 20);
                    labelName.Size = new Size(2 * this.flowLayoutPanelRunners.Width / 3, 20);
                    labelName.AutoSize = false;
                    labelName.Text = "Имя: " + dataListRunnersSponsors.ElementAt(i).NameRunner;
                    panel.Controls.Add(labelName);		//Добавить надпись в панель

                    //Добавить надпись с фамилией бегуна
                    labelLastname = new Label();
                    labelLastname.Location = new Point(pictureBoxRunner.Size.Width + 5, 45);
                    labelLastname.Size = new Size(2 * this.flowLayoutPanelRunners.Width / 3, 20);
                    labelLastname.AutoSize = false;
                    labelLastname.Text = "Фамилия: " + dataListRunnersSponsors.ElementAt(i).Surname;
                    panel.Controls.Add(labelLastname);		//Добавить надпись в панель

                    //Добавить надпись с суммой спонсирования бегуна
                    labelSum = new Label();
                    labelSum.Location = new Point(pictureBoxRunner.Size.Width + 5, 70);
                    labelSum.Size = new Size(2 * this.flowLayoutPanelRunners.Width / 3, 20);
                    labelSum.AutoSize = false;
                    labelSum.Text = "Сумма: " + dataListRunnersSponsors.ElementAt(i).SumSponsor.ToString();
                    panel.Controls.Add(labelSum);			//Добавить надпись в панель

                    //Добавить сформированную панель добавить в FlowLayoutPanel
                    this.flowLayoutPanelRunners.Controls.Add(panel);
                }

                //Вызвать дополнительные метода адаптера таблицы-связки
                textBoxTotalSum.Text = this.runnerSponsorTableAdapter.SumOfSponsor(ClassTotal.idUser).ToString();
                textBoxCount.Text = this.runnerSponsorTableAdapter.CountOfSponsor(ClassTotal.idUser).ToString();
            }
        }

    }
}
