
using Accessibility;
using Microsoft.Data.Sqlite;
using System.Globalization;
using System.IO;
<<<<<<< HEAD
using System.Text.RegularExpressions;
=======
using System.Runtime.Serialization.Formatters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
>>>>>>> ffa477e0d237ae1c1408ef1122b919ab30db91e6
using Timer = System.Windows.Forms.Timer;
namespace Fitnes
{

    public partial class Form1 : Form
    {
        string ID;
        string newValue;
        private string path = "C:\\Users\\lalka\\source\\repos\\Fit\\bin\\Debug\\net6.0-windows\\Resource\\Viking.db";
        string Data2;
        public Form1()
        {
            InitializeComponent();
            OtchestvoBox.TextChanged += OtchestvoBox_TextChanged;
            familiyaBox.TextChanged += familiyaBox_TextChanged_1;
            phoneNumBox.TextChanged += phoneNumBox_TextChanged_1;
            nameBox.TextChanged += nameBox_TextChanged_1;
            buttonFirstName.Visible = false;
            buttonName.Visible = false;
            buttonPatronymic.Visible = false;
            buttonPhoneNumber.Visible = false;
            buttonBirthDate.Visible = false;
            textBox3.Visible = false;
            button2.Visible = false;
            {
                Timer timer = new Timer();
                timer.Interval = 1000;
                timer.Enabled = true;
                timer.Tick += new EventHandler(timer1_Tick);
            }
        }
        private void nameBox_TextChanged_1(object sender, EventArgs e)
        {
            // Проверяем, пустое ли текстовое поле
            if (string.IsNullOrEmpty(nameBox.Text))
            {
                // Если текстовое поле пустое, делаем метку видимой
                nameRedStar.Visible = true;
            }
            else
            {
                // Если в текстовом поле что-то есть, скрываем метку
                nameRedStar.Visible = false;
            }
        }

        private void OtchestvoBox_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, пустое ли текстовое поле
            if (string.IsNullOrEmpty(OtchestvoBox.Text))
            {
                // Если текстовое поле пустое, делаем метку видимой
                otchestvoRedStar.Visible = true;
            }
            else
            {
                // Если в текстовом поле что-то есть, скрываем метку
                otchestvoRedStar.Visible = false;
            }
        }


        private void phoneNumBox_TextChanged_1(object sender, EventArgs e)
        {
            // Проверяем, пустое ли текстовое поле
            if (string.IsNullOrEmpty(phoneNumBox.Text))
            {
                // Если текстовое поле пустое, делаем метку видимой
                phoneRedStar.Visible = true;
            }
            else
            {
                // Если в текстовом поле что-то есть, скрываем метку
                phoneRedStar.Visible = false;
            }
        }
        private void Otchestvo_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, пустое ли текстовое поле
            if (string.IsNullOrEmpty(familiyaBox.Text))
            {
                // Если текстовое поле пустое, делаем метку видимой
                famRedStar.Visible = true;
            }
            else
            {
                // Если в текстовом поле что-то есть, скрываем метку
                famRedStar.Visible = false;
            }
        }


        private void PhoneNumBox_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, пустое ли текстовое поле
            if (string.IsNullOrEmpty(OtchestvoBox.Text))
            {
                // Если текстовое поле пустое, делаем метку видимой
                otchestvoRedStar.Visible = true;
            }
            else
            {
                // Если в текстовом поле что-то есть, скрываем метку
                otchestvoRedStar.Visible = false;
            }
        }
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, пустое ли текстовое поле
            if (string.IsNullOrEmpty(phoneNumBox.Text))
            {
                // Если текстовое поле пустое, делаем метку видимой
                phoneRedStar.Visible = true;
            }
            else
            {
                // Если в текстовом поле что-то есть, скрываем метку
                phoneRedStar.Visible = false;
            }
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToString($"      Дата и время:\nyyyy.MM.dd, HH:mm:ss");
        }
        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем ввод только букв и управляющих символов
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем ввод только цифр и символа '+'
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем ввод только цифр и символа '.'
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        Point lastpoint;
        private void panelMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void panel1MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
        private void CloseWindows(object sender, EventArgs e)
        {
            Close();
        }
        private void MinimizeWindows(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void PanelRegClient(object sender, EventArgs e)
        {
            panelshowclient.Visible = false;
            panelregclient.Visible = true;
            paneldeleteclient.Visible = false;
            panelchangeclient.Visible = false;
        }

        private void PanelShowClient(object sender, EventArgs e)
        {
            panelshowclient.Visible = true;
            panelregclient.Visible = false;
            paneldeleteclient.Visible = false;
            panelchangeclient.Visible = false;
        }

        private void PanelChangeClient(object sender, EventArgs e)
        {
            panelshowclient.Visible = false;
            panelregclient.Visible = false;
            paneldeleteclient.Visible = false;
            panelchangeclient.Visible = true;
        }

        private void PanelDeleteclient(object sender, EventArgs e)
        {
            panelshowclient.Visible = false;
            panelregclient.Visible = false;
            paneldeleteclient.Visible = true;
            panelchangeclient.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            //dataRoszhdBox.Text = theDate;
        }

        private void familiyaBox_TextChanged_1(object sender, EventArgs e)
        {
            {
                // Проверяем, пустое ли текстовое поле
                if (string.IsNullOrEmpty(familiyaBox.Text))
                {
                    // Если текстовое поле пустое, делаем метку видимой
                    famRedStar.Visible = true;
                }
                else
                {
                    // Если в текстовом поле что-то есть, скрываем метку
                    famRedStar.Visible = false;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] Data1 = DateTime.Today.ToString().Split(" ");
            if (OtchestvoBox.Text != "" && phoneNumBox.Text != "" && nameBox.Text != "" && familiyaBox.Text != "")
            {
                string[] Statuses = { "клиент", "бизнес-клиен", "вип-клиент" };

                Random random = new Random();
                int randomNumber = random.Next(0, 3);
                int randomDay = random.Next(1, 365);
                string FirstName1 = familiyaBox.Text;
                string Name = nameBox.Text;
                string OtName = OtchestvoBox.Text;
                string[] Data = dateTimePicker1.Text.Split("/");
                string Data2 = dateTimePicker1.Text;
                string Number = phoneNumBox.Text;
                DateTime birthDate = DateTime.Parse(dateTimePicker1.Text);

                // Получаем текущую дату
                DateTime currentDate = DateTime.Today;

                // Рассчитываем разницу между текущей датой и датой рождения в годах
                int age = currentDate.Year - birthDate.Year;

                // Проверяем, нужно ли скорректировать возраст на основе месяца и дня рождения
                if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
                {
                    age--;
                }

                using (var connection = new SqliteConnection($"Data Source={path};Cache=Default;Mode=ReadWrite;"))
                {
                    connection.Open();
                    string sqlExpression = "INSERT INTO clients (FirstName, Name, Otchestvo, Data, Number, Age,Status,Subscription,ID,DateReg) VALUES (@FirstName, @Name, @OtName, @Data2, @Number, @age,@Statuses, @Days, @GuidID,@DateReg)";
                    using (SqliteCommand command = new SqliteCommand(sqlExpression, connection))
                    {
                        // Добавьте параметры
                        command.Parameters.AddWithValue("@FirstName", FirstName1);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@OtName", OtName);
                        command.Parameters.AddWithValue("@Data2", Data2);
                        command.Parameters.AddWithValue("@Number", Number);
                        command.Parameters.AddWithValue("@age", age);
                        command.Parameters.AddWithValue("@Statuses", Statuses[randomNumber]);
                        command.Parameters.AddWithValue("@Days", randomDay);
                        command.Parameters.AddWithValue("@GuidID", Guid.NewGuid());
                        command.Parameters.AddWithValue("@DateReg", DateTime.Now);

                        // Выполните запрос
                        command.ExecuteNonQuery();
                    }
                    //string sqlExpression = "SELECT * FROM clients";
                    //SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                    //using (SqliteDataReader reader = command.ExecuteReader())
                    //{
                    //    if (reader.HasRows) // если есть данные
                    //    {
                    //        while (reader.Read())   // построчно считываем данные
                    //        {
                    //        }
                    //    }
                    //}
                }
                MessageBox.Show("Пользователь добавлен", "Успешно", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                OtchestvoBox.Text = null;
                nameBox.Text = null;
                familiyaBox.Text = null;
                phoneNumBox.Text = null;
                dateTimePicker1.Text = null;
            }
            else
            {
                MessageBox.Show("!Вы добавили не все главные поля!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void panelchangeclient_Paint(object sender, PaintEventArgs e)
        {

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
                        command.CommandText = "SELECT ID FROM clients WHERE FirstName = @firstName AND Name = @Name";
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@Name", lastName);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Найден клиент, отображаем кнопки для редактирования данных
                                ID = reader["ID"].ToString();
                                buttonFirstName.Visible = true;
                                buttonName.Visible = true;
                                buttonPatronymic.Visible = true;
                                buttonPhoneNumber.Visible = true;
                                buttonBirthDate.Visible = true;

                                // Убираем текстовые поля для ввода фамилии и имени
                                textBox1.Visible = false;
                                textBox2.Visible = false;
                                button3.Visible = false;
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
            textBox3.Visible = true;
            button2.Visible = true;
            newValue = columnName;
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
                        if (columnName == "Data")
                        {

                            command.CommandText = $"UPDATE Clients SET {columnName} = @newValue, Age = @newAge WHERE ID = @id";
                            //DateTime dateTime = DateTime.ParseExact(newValue, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                            DateTime dateTime = DateTime.ParseExact(newValue, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                            DateTime numericDate = DateTime.Parse(dateTime.ToString("MM/dd/yyyy"));
                            command.Parameters.AddWithValue("@newValue", numericDate);
                            //string formattedDate = dateTime.ToString("MM/dd/yyyy");
                            DateTime birthDate = DateTime.Parse(newValue);
                            // Получаем текущую дату
                            DateTime currentDate = DateTime.Today;
                            // Рассчитываем разницу между текущей датой и датой рождения в годах
                            int age = currentDate.Year - birthDate.Year;
                            // Проверяем, нужно ли скорректировать возраст на основе месяца и дня рождения
                            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
                            {
                                age--;
                            }
                            //command.CommandText = $"UPDATE Clients SET  = @newValue WHERE ID = @id";

                            command.Parameters.AddWithValue("@newAge", age);
                            command.Parameters.AddWithValue("@id", ID);
                        }
                        else
                        {
                            // Предполагая, что у нас есть колонка Id для идентификации клиента
                            command.CommandText = $"UPDATE Clients SET {columnName} = @newValue WHERE ID = @id";
<<<<<<< HEAD
=======
                            string[] s = newValue.Split(".");
                            //DateTime dateTime = new DateTime(Int32.Parse(s[0]);
>>>>>>> ffa477e0d237ae1c1408ef1122b919ab30db91e6
                            command.Parameters.AddWithValue("@newValue", newValue);
                            command.Parameters.AddWithValue("@id", ID);
                        }


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
        private void UpdateClientDateBrt()
        {
            try
            {

                using (var connection = new SqliteConnection($"Data Source={path};Cache=Default;Mode=ReadWrite;"))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        // Предполагая, что у нас есть колонка Id для идентификации клиента
                        command.CommandText = $"UPDATE Clients SET Data = @newValue WHERE ID = @id";
                        command.Parameters.AddWithValue("@newValue", Data2);
                        command.Parameters.AddWithValue("@id", ID);

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

        private void buttonFirstName_Click(object sender, EventArgs e)
        {
            ShowTextBoxAndUpdate("FirstName");
        }
        private void buttonName_Click(object sender, EventArgs e)
        {
            ShowTextBoxAndUpdate("Name");
        }
        private void buttonOtName_Click(object sender, EventArgs e)
        {
            ShowTextBoxAndUpdate("Otchestvo");
        }
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            ShowTextBoxAndUpdate("Number");
        }
        private void buttonDateBirt_Click(object sender, EventArgs e)
        {
            ShowTextBoxAndUpdate("Data");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateClientData(newValue, textBox3.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDateBirt_Click_1(object sender, EventArgs e)
        {
            UpdateClientDateBrt();
        }

<<<<<<< HEAD
        private void button5_Click(object sender, EventArgs e)
        {
            string firstName = textBox7.Text;
            string lastName = textBox6.Text;
            //try
            //{
            using (var connection = new SqliteConnection($"Data Source={path};Cache=Default;Mode=ReadWrite;"))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    // Поиск пользователя по фамилии и имени
                    command.CommandText = "SELECT Id FROM Clients WHERE FirstName = @firstName AND Name = @lastName";
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);

                    // Получение Id пользователя
                    string clientId;
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            clientId = reader["Id"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Client not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Удаление пользователя из базы данных
                    command.CommandText = "DELETE FROM Clients WHERE Id = @id";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@id", clientId);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Client deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred while deleting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
=======
        private void GenerateClientButton(object sender, EventArgs e)
        {
            using (var connection = new SqliteConnection($"Data Source={path};Cache=Default;Mode=ReadWrite;"))
            {
                connection.Open();
                string sqlExpression = "DELETE FROM clients";

                using (SqliteCommand command = new SqliteCommand(sqlExpression, connection))
                {
                    // Выполните запрос
                    command.ExecuteNonQuery();
                }



            }
            for (int i = 0; i < 200; i++)
                {
                    DataGenerator dataGenerator = new DataGenerator();
                    dataGenerator.GenerateRandomData();
                }
>>>>>>> ffa477e0d237ae1c1408ef1122b919ab30db91e6

        }
    }
}