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
    public partial class Material_addnchange : Form
    {
        //Переменная, хранящая в себе данные об ID материала
        int ID_mat;
        public Material_addnchange(int ID, string mode)
        {
            InitializeComponent();
            if(mode == "chng")//в случае, если форма открывается в режиме "Изменения", то делается запрос по ID для получения данных, которые будут редактироваться
            {
                string query = "select Title, MaterialTypeID, CountInStock, Unit, CountInPack, MinCount, Cost, Description from material where ID =" + ID.ToString() + ";";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    if(rd.HasRows)
                        while (rd.Read())
                        {
                            name_box.Text = rd.GetString(0);
                            material_type.SelectedIndex = Convert.ToInt32(rd.GetString(1)) - 1;
                            stock_box.Text = rd.GetString(2);
                            unit_box.Text = rd.GetString(3);
                            pack_box.Text = rd.GetString(4);
                            min_box.Text = rd.GetString(5);
                            cost_box.Text = rd.GetString(6);
                            description_box.Text = rd.GetString(7);
                        }
                    conn.Close();
                    ID_mat = ID;
                }catch(Exception ex)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                }
            }
            else if(mode == "add") //В случае, если форма открывается в режиме "Создания", то кнопка удаления скрывается, а кнопка изменения изменяется на кнопку создания
            {
                del_btn.Visible = false;
                add_chng_btn.Text = "Создать";
            }
        }
        //Функция, отвечающая за выполнение команды по нажатию кнопки "Создать/Изменить". В зависимости от названия кнопки, будут выполнятсья разные запросы в БД
        private void add_chng_btn_Click(object sender, EventArgs e)
        {
            string query = "";
            if (add_chng_btn.Text == "Изменить")
            {
                query = "update material set Title = '" + name_box.Text + "', MaterialTypeID = " + (material_type.SelectedIndex + 1).ToString() + ", CountInStock = " + stock_box.Text + ", Unit = '" + unit_box.Text + "', CountInPack = " + pack_box.Text + ", MinCount = " + min_box.Text + ", Cost = " + cost_box.Text + ", Description = '" + description_box.Text + "' where ID =" + ID_mat.ToString() + ";";
            }
            else if(add_chng_btn.Text == "Создать")
            {
                query = "insert into material(Title, MaterialTypeID, CountInStock, Unit, CountInPack, MinCount, Cost, Description) values('" + name_box.Text + "', " + (material_type.SelectedIndex + 1).ToString() + ", " + stock_box.Text + ", '" + unit_box.Text + "', " + pack_box.Text + ", " + min_box.Text + ", " + cost_box.Text + ", '" + description_box.Text + "');";
            }
            if (cost_box.Text.Contains(","))
            {
                MessageBox.Show("Исправьте значение стоимости! Используйте вместо запятой точку!");
            }
            else
                do_Action(query);

            this.Close();
        }
        //Кнопка удаления по ID, сохраненному при инициализации формы
        private void del_btn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены что хотите удалить данный материал?", "Вы уверены?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string query = "delete from material where ID =" + ID_mat + ";";
                do_Action(query);
                this.Close();
            }
        }
        //Функция, позволяющая отправить команду на сервер БД для оптимизации кода
        public void do_Action(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmDB.ExecuteReader();
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }
    }
}
