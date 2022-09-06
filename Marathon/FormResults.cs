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
    public partial class FormResults : Form
    {
        MarathonDataSetTableAdapters.OrdersMarathonTableAdapter ordersMarathonTableAdapter = new MarathonDataSetTableAdapters.OrdersMarathonTableAdapter();
        MarathonDataSetTableAdapters.ResultMarathonTableAdapter resultMarathonTableAdapter = new MarathonDataSetTableAdapters.ResultMarathonTableAdapter();
        MarathonDataSetTableAdapters.TypeDistanceTableAdapter typeDistanceTableAdapter = new MarathonDataSetTableAdapters.TypeDistanceTableAdapter();

        MarathonDataSet.ResultMarathonDataTable dataResult;	//Данные из сводного адаптера
        MarathonDataSet.TypeDistanceDataTable dataTypeDist; //таблица результатов
        MarathonDataSet.OrdersMarathonDataTable dataSortTimeRun;

        int countTab;			//Количество закладок=числу типов марафона
        DataGridView[] dgv;		//Динамические сетки, по одной на каждой закладке
        string[] typeDist;			                        //Название типов дистанций

        public FormResults()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormResults_Load(object sender, EventArgs e)
        {
            tabControlResult.Controls.Clear();

            TabPage tabPage;			                        //Динамические закладки

            //Получить количество типов дистанций марафона
            dataTypeDist = this.typeDistanceTableAdapter.GetData();
            countTab = dataTypeDist.Count();		            //Число закладок=числу типов марафона
            typeDist = new string[countTab];		            //Названия типов марафона
            dgv = new DataGridView[countTab];	                //Динамические сетки

            for (int i = 0; i < countTab; i++)		            //По количеству типов марафона
            {
                typeDist[i] = dataTypeDist.ElementAt(i).Title;	//Взять название типа марафона
                tabPage = new TabPage(typeDist[i]);		        //Создать закладку с таким названием
                dgv[i] = new DataGridView();			        //Динамическая сетка
                tabPage.Controls.Add(dgv[i]);			        //Добавить на закладку
                tabControlResult.TabPages.Add(tabPage);         //Добавить закладку в компонент Блокнот
            }

            //Внесение в таблицу Orders значений в поле Место в зависимости от времени пробега
            MarathonDataSet.OrdersMarathonRow ordersRow;	//Строки таблицы

            for (int i = 0; i < countTab; i++)	//Для каждого типа марафона свои результаты
            {
                //Выполнить сортировку результатов по полю времени для каждого типа дистанции
                dataSortTimeRun = this.ordersMarathonTableAdapter.GetDataSortByTimeRun(i + 1);

                //Для отсортированных данных установить значения мест по порядку следования
                for (int j = 0; j < dataSortTimeRun.Count(); j++)
                {
                    ordersRow = dataSortTimeRun.ElementAt(j);
                    ordersRow.Place = j + 1;		//Место
                    this.ordersMarathonTableAdapter.Update(ordersRow);	//Редактировать таблицу
                }
            }

            //Для каждой сетки на своей закладке:
            for (int i = 0; i < countTab; i++)
            {
                //Отобразить в сетке только данные по конкретному типу марафона
                ShowTableByTypeDist(dgv[i], typeDist[i]);               
            }

            //Список для роли Бегун: Все результаты/Мои результаты
            this.comboBoxResult.Text = this.comboBoxResult.Items[0].ToString();

            if (ClassTotal.idRole == 1)
            {
                this.comboBoxResult.Visible = true;
            }
            else
            {
                this.comboBoxResult.Visible = false;
            }
        }

        private void ShowTableByTypeDist(DataGridView dgv, string titleDist)
        {
            this.comboBoxResult.Visible = false;                      //Только для роли Бегун     
            
            dataResult = this.resultMarathonTableAdapter.GetData();   //Все данные из сводного адаптера

            //Отбор данных из сводного адаптера по конкретной дистанции
            var filter = dataResult.Where(x => x.Distance == titleDist);

            if (filter.Count() == 0)					     //Пока данные не заполнены
            {
                dgv.DataSource = null;				         //Таблица пустая
            }
            else                                             //Результаты данного бегуна заполнены
            {
                dgv.DataSource = filter.CopyToDataTable();   //Вывод данных этого бегуна  
            }


            if (ClassTotal.idRole == 1)				                  //Для роли Бегун
            {
                this.comboBoxResult.Visible = true; 	              //Выбор: Все результаты/Мои результаты
                if (comboBoxResult.Text == comboBoxResult.Items[1].ToString())	//Мои результаты
                {
                    //Дополнительный фильтр по бегуну
                    filter = dataResult.Where(x => x.Distance == titleDist && x.IDRunner == ClassTotal.idUser);
                }
            }

            if (filter.Count() == 0)					     //Пока данные не заполнены
            {
                dgv.DataSource = null;				         //Таблица пустая
            }
            else                                             //Результаты данного бегуна заполнены
            {
                dgv.DataSource = filter.CopyToDataTable(); 	 //Вывод данных этого бегуна  
            }

            //Настройка таблицы
            dgv.Width = this.tabControlResult.Width - 10;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ScrollBars = ScrollBars.Both;
            dgv.AllowUserToAddRows = false; 	        //Нет дополнительных строк
            dgv.AutoGenerateColumns = false;		    //Нет автогенерации столбцов

            //Сначала сделать все столбы невидимыми
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Visible = false;
            }

            //Изменить заголовки видимых столбцов таблицы
            dgv.Columns["FIO"].Visible = true;
            dgv.Columns["FIO"].HeaderText = "ФИО";
            dgv.Columns["FIO"].ReadOnly = true; ;
            dgv.Columns["TimeRun"].Visible = true;
            dgv.Columns["TimeRun"].HeaderText = "Время пробега";
            dgv.Columns["TimeRun"].ReadOnly = false;	//Доступность колонки для изменения
            dgv.Columns["Country"].Visible = true;
            dgv.Columns["Country"].HeaderText = "Страна";
            dgv.Columns["Country"].ReadOnly = true;

            if (ClassTotal.idRole == 3)			//Роль организатора
            {
                buttonFix.Visible = true;		//Можно вносить изменения в БД
                dgv.Columns["TimeRun"].ReadOnly = false;	//Доступность изменения времени

                //Цветовое выделение незаполненных строк в поле время пробега
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    if ((decimal)dgv.Rows[i].Cells["TimeRun"].Value == 0)
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }

            if (ClassTotal.idRole == 1 || ClassTotal.idRole == 2)	//Роли бегуна или спонсора
            {
                buttonFix.Visible = false;		//Невозможность вносить изменения в БД
                dgv.Columns["TimeRun"].ReadOnly = true; 		//Недоступность для изменения

                //Дополнительно выводятся значения поля Место
                dgv.Columns["Place"].HeaderText = "Место";
                dgv.Columns["Place"].Visible = true;
                dgv.Columns["Place"].ReadOnly = true;

                //Цветовое выделение золото, серебро, бронза
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    switch ((int)dgv.Rows[i].Cells["Place"].Value)
                    {
                        case 1:
                            dgv.Rows[i].DefaultCellStyle.BackColor = Color.Gold;	//Первое место
                            break;
                        case 2:
                            dgv.Rows[i].DefaultCellStyle.BackColor = Color.Silver;	//Второе место
                            break;
                        case 3:
                            dgv.Rows[i].DefaultCellStyle.BackColor = Color.RosyBrown;	//Третье место
                            break;
                        default:
                            dgv.Rows[i].DefaultCellStyle.BackColor = Color.White;  //Остальные
                            break;
                    }
                }
            }
        }

        private void buttonFix_Click(object sender, EventArgs e)
        {
            try
            {
                //По всем сеткам на каждой закладке
                for (int i = 0; i < countTab; i++)
                {
                    //По всем строкам сетки
                    for (int row = 0; row < dgv[i].RowCount; row++)
                    {
                        //Вызов созданного метода к существующему адаптеру
                        //Вносит изменения в поле время дистанции (TimeRun) таблицы Orders
                        //для заданного бегуна на выбранную дистанцию
                        this.ordersMarathonTableAdapter.UpdateQueryTimeRun((decimal)dgv[i].Rows[row].Cells["TimeRun"].Value, (int)dgv[i].Rows[row].Cells["IDRunner"].Value, i + 1);
                    }
                }

                MessageBox.Show("Все результаты занесены");
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при сохранении результатов");
            }

            FormResults_Load(null, null);
        }

        private void comboBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Для каждой сетки на своей закладке:
            for (int i = 0; i < countTab; i++)
            {
                //Отобразить в сетке только данные по конкретному типу марафона
                ShowTableByTypeDist(dgv[i], typeDist[i]);
            }
        }
    }
}
