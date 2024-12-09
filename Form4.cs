using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fitnes
{
    public partial class Form4 : Form
    {
        string path = "C:\\Users\\B-ZONE\\OneDrive\\Рабочий стол\\Fitnes\\Resource\\Viking.db";
        private Client itemToEdit;
        public Form4(Client item)
        {
            InitializeComponent();
            this.itemToEdit = item;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void EditForm_Load(object sender, EventArgs e)
        {
            // Отображаем данные выбранного элемента в элементах управления формы
            LoadClientData();
            // и так далее
        }
        private void LoadClientData()
        {
            try
            {
                // Создаем подключение к базе данных
                using (var connection = new SqliteConnection($"Data Source={path}"))
                {
                    connection.Open();

                    // Создаем команду для выполнения запроса
                    using (var command = connection.CreateCommand())
                    {
                        // Задаем текст SQL-запроса для выборки данных клиента по его Id
                        command.CommandText = "SELECT * FROM clients WHERE Name = @Name";
                        command.Parameters.AddWithValue("@Name", itemToEdit.Name);

                        // Выполняем запрос и считываем результат
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Заполняем поля формы данными из базы данных
                                textBox1.Text = reader["FirstName"].ToString();
                                textBox2.Text = reader["Name"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void SaveButton_Click(object sender, EventArgs e)
        //{
        //    // Сохраняем изменения в элементе базы данных
        //    itemToEdit.Property1 = textBox1.Text;
        //    itemToEdit.Property2 = textBox2.Text;
        //    // и так далее

        //    // Закрываем форму
        //    this.Close();
        //}
    }
}
