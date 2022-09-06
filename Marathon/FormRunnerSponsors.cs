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
    public partial class FormRunnerSponsors : Form
    {
        MarathonDataSetTableAdapters.ListRunnersSponsorsTableAdapter listRunnersSponsorsTableAdapter = new MarathonDataSetTableAdapters.ListRunnersSponsorsTableAdapter();
        MarathonDataSetTableAdapters.RunnerSponsorTableAdapter runnerSponsorTableAdapter = new MarathonDataSetTableAdapters.RunnerSponsorTableAdapter();

        MarathonDataSet.ListRunnersSponsorsDataTable dataSponsorsOfRunner;


        public FormRunnerSponsors()
        {
            InitializeComponent();
        }

        private void FormRunnerSponsors_Load(object sender, EventArgs e)
        {
            Panel panel;
            Label labelName, labelSum;
            PictureBox pictureBoxSponsor;
            byte[] photo;
            System.IO.MemoryStream stream;
            Bitmap bit, bitNot;
            bitNot = new Bitmap(Properties.Resources.NotPicture);	//Для пустой картинки

            //Получить все данные из смешанной таблицы для конкретного бегуна
            //вызывается свой метод для созданного адаптера из четырех таблиц
            dataSponsorsOfRunner = this.listRunnersSponsorsTableAdapter.GetDataByIDRunner(ClassTotal.idUser);

            if (dataSponsorsOfRunner.Count == 0)			//Пустой список
            {
                MessageBox.Show("У Вас нет спонсоров");
                textBoxTotalSum.Text = "0";
                textBoxCount.Text = "0";
            }
            else
            {
                //Настройка панели FlowLayoutPanel: все элементы последовательно спускаются вниз
                this.flowLayoutPanelSponsors.FlowDirection = FlowDirection.TopDown;	//свеху
                this.flowLayoutPanelSponsors.AutoScroll = true;  //Полосы прокрутки
                this.flowLayoutPanelSponsors.WrapContents = false;//Нет перехода на новую строку
                this.flowLayoutPanelSponsors.Font = new Font(FontFamily.GenericMonospace, 12);
                this.flowLayoutPanelSponsors.Controls.Clear();

                //Все записи по очереди переносятся в FlowLayoutPanel
                for (int i = 0; i < dataSponsorsOfRunner.Count; i++)
                {
                    panel = new Panel();			//Контейнер для элементов одной записи
                    panel.Size = new Size(this.flowLayoutPanelSponsors.Width, 100);	//Размер

                    //Настройка фото спонсора
                    pictureBoxSponsor = new PictureBox();
                    pictureBoxSponsor.Size = new Size(panel.Width / 3, panel.Height - 10);
                    pictureBoxSponsor.Location = new Point(5, 5);
                    pictureBoxSponsor.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxSponsor.SizeMode = PictureBoxSizeMode.Zoom;

                    //Работа с фото
                    if (dataSponsorsOfRunner.ElementAt(i).IsLogoNull())
                    {
                        pictureBoxSponsor.Image = bitNot; 			//Изображение без фото
                    }
                    else
                    {
                        photo = dataSponsorsOfRunner.ElementAt(i).Logo;//Значение поля логотипа
                        stream = new System.IO.MemoryStream(photo);
                        bit = (Bitmap)Image.FromStream(stream);
                        pictureBoxSponsor.Image = bit;			//Для отображения
                    }
                    panel.Controls.Add(pictureBoxSponsor);		//Добавить картинку в панель

                    //Добавить надпись с именем спонсора
                    labelName = new Label();
                    labelName.Location = new Point(pictureBoxSponsor.Size.Width + 5, 20);
                    labelName.Size = new Size(2 * this.flowLayoutPanelSponsors.Width / 3, 20);
                    labelName.AutoSize = false;
                    labelName.Text = "Имя: " + dataSponsorsOfRunner.ElementAt(i).NameSponsor;
                    panel.Controls.Add(labelName);		//Добавить надпись в панель

                    //Добавить надпись с суммой спонсирования этим спонсором
                    labelSum = new Label();
                    labelSum.Location = new Point(pictureBoxSponsor.Size.Width + 5, 45);
                    labelSum.Size = new Size(2 * this.flowLayoutPanelSponsors.Width / 3, 20);
                    labelSum.AutoSize = false;
                    labelSum.Text = "Сумма: " + dataSponsorsOfRunner.ElementAt(i).SumSponsor.ToString();
                    panel.Controls.Add(labelSum);			//Добавить надпись в панель

                    //Добавить сформированную панель добавить в FlowLayoutPanel
                    this.flowLayoutPanelSponsors.Controls.Add(panel);
                }

                //Вызвать дополнительные метода адаптера таблицы-связки
                textBoxTotalSum.Enabled = false;
                textBoxCount.Enabled = false;
                textBoxTotalSum.Text = this.runnerSponsorTableAdapter.SumOfRunner(ClassTotal.idUser).ToString();
                textBoxCount.Text = this.runnerSponsorTableAdapter.CountOfRunner(ClassTotal.idUser).ToString();
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
