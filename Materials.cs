using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Demo
{
    public partial class Material_list : Form
    {
        // Здесь представленны переменные, которые отвечают за проводимый поиск из БД, данные из которой представляются в таблице на форме
        string query_uni = "select material.ID as '№ п/п', material.Title as 'Наименование', materialtype.Title as 'Тип материала', material.Cost as 'Цена', material.CountInStock as 'Количество на складе', material.MinCount as 'Минимальное количество', material.CountInPack as 'Количество в упаковке', Unit as 'Единица измерения', material.Description as 'Описание' from material join materialtype on material.MaterialTypeID = materialtype.ID";
        string query_search = "";
        string query_sort = "";
        string query_filtr = "";
        public Material_list()
        {
            InitializeComponent();
            get_Info(query_uni + ";");
        }

        //Функция получения данных в таблицу под универсальный запрос
        public void get_Info(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter ada = new MySqlDataAdapter(query, conn);
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                ada.Fill(dt);
                table.DataSource = dt;
                table.ClearSelection();                
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("" + Environment.NewLine + ex.Message);
            }
        }

        //Очистка текстового поля при входе в него
        private void search_box_Enter(object sender, EventArgs e)
        {
            if (search_box.Text == "Введите для поиска")
            {
                search_box.Clear();
                search_box.ForeColor = Color.Black;
            }
        }
        //Появление надписи в случае, если при выходе из текстового поля оно пустое
        private void search_box_Leave(object sender, EventArgs e)
        {
            if(search_box.Text == "")
            {
                search_box.Text = "Введите для поиска";
                search_box.ForeColor = Color.Gray;
            }
        }
        //Поиск по наименованию и описанию материала
        private void search_box_TextChanged(object sender, EventArgs e)
        {            
            if (search_box.Text == "" || search_box.Text == "Введите для поиска")
                query_search = " where material.ID > 0 ";
            else
                query_search = " where concat(material.Title, material.Description) like '%" + search_box.Text + "%' ";
            get_Info(query_uni + query_search + query_filtr + query_sort);
        }
        //Сортировка по наименованию, количеству на складе и цене
        private void sort_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sort_box.SelectedIndex)
            {
                case 0:
                    query_sort = " order by material.Title;";
                    break;
                case 1:
                    query_sort = " order by material.Title desc;";
                    break;
                case 2:
                    query_sort = " order by material.CountInStock;";
                    break;
                case 3:
                    query_sort = " order by material.CountInStock desc;";
                    break;
                case 4:
                    query_sort = " order by material.Cost;";
                    break;
                case 5:
                    query_sort = " order by material.Cost desc;";
                    break;
            }
            get_Info(query_uni + query_search + query_filtr + query_sort);
        }
        //Фильтрация по материалам
        private void filter_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (filter_box.SelectedIndex)
            {
                case 0:
                    query_filtr = "";
                    break;
                case 1:
                    query_filtr = " and materialtype.ID = 1";
                    break;
                case 2:
                    query_filtr = " and materialtype.ID = 2";
                    break;
                case 3:
                    query_filtr = " and materialtype.ID = 3";
                    break;
            }
            get_Info(query_uni + query_search + query_filtr + query_sort);
        }
        //Переход в редактирование материала по клику на необходимую строку
        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table.RowCount > 0)
            {
                Material_addnchange Win = new Material_addnchange(Convert.ToInt32(table[0, table.CurrentRow.Index].Value), "chng");
                Win.Owner = this;
                Win.Show();
            }
            else
            {
                MessageBox.Show("Вы не выбрали строку!");
            }
        }
        //Кнопка перехода на форму добавления нового материала
        private void add_btn_Click(object sender, EventArgs e)
        {
            Material_addnchange Win = new Material_addnchange(0, "add");
            Win.Owner = this;
            Win.Show();
        }
        //Обновление списка при переходе из формы добавления/изменения обратно на форму со списком
        private void Material_list_Activated(object sender, EventArgs e)
        {
            get_Info(query_uni + query_search + query_filtr + query_sort);
        }
    }
}
