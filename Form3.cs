using Microsoft.Data.Sqlite;
using System;

namespace Fitnes
{
    public partial class Form3 : Form
    {
        private string path = "C:\\Users\\B-ZONE\\OneDrive\\Рабочий стол\\Fitnes\\Resource\\Viking.db";
        // Убрали коммент fsuajidghfoaisudfh
        // da
        public Form3()
        {
            InitializeComponent();
            buttonFirstName.Visible = false;
            buttonName.Visible = false;
            buttonPatronymic.Visible = false;
            buttonPhoneNumber.Visible = false;
            buttonBirthDate.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;

            try
            {
                using (var connection = new SqliteConnection($"Data Source={path};Cache=Default;Mode=ReadWrite;"))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        // Поиск клиента по фамилии и имени
                        command.CommandText = "SELECT * FROM clients WHERE FirstName = @firstName AND Name = @Name";
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@Name", lastName);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Найден клиент, отображаем кнопки для редактирования данных
                                buttonFirstName.Visible = true;
                                buttonName.Visible = true;
                                buttonPatronymic.Visible = true;
                                buttonPhoneNumber.Visible = true;
                                buttonBirthDate.Visible = true;

                                // Убираем текстовые поля для ввода фамилии и имени
                                textBox1.Visible = false;
                                textBox2.Visible = false;
                                button1.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Client not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowTextBoxAndUpdate(string columnName)
        {
            // Создаем TextBox
            TextBox textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(10, 10);
            textBox.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(textBox);

            // Добавляем событие для кнопки "OK"
            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.Location = new System.Drawing.Point(220, 10);
            okButton.Click += (s, e) =>
            {
                UpdateClientData(columnName, textBox.Text);
                // Удаляем TextBox и кнопку после обновления данных
                this.Controls.Remove(textBox);
                this.Controls.Remove(okButton);
            };
            this.Controls.Add(okButton);
        }

        private void UpdateClientData(string columnName, string newValue)
        {
            try
            {
                using (var connection = new SqliteConnection($"Data Source={path};Cache=Default;Mode=ReadWrite;"))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        // Предполагая, что у нас есть колонка Id для идентификации клиента
                        command.CommandText = $"UPDATE Clients SET {columnName} = @newValue WHERE Id = @id";
                        command.Parameters.AddWithValue("@newValue", newValue);
                        //command.Parameters.AddWithValue("@id", /*здесь нужно указать Id клиента*/);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
