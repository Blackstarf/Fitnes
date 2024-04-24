using System.Data.SQLite;
using Microsoft.Data.Sqlite;
using Rndmgenerator;
using System.Globalization;
using Timer = System.Windows.Forms.Timer;
namespace Fitnes
{
    public partial class Form1 : Form
    {
        string? newValue;
        string? ID;
        private string path = "Viking.db";
        string? Data2;
        public Form1()
        {

            InitializeComponent();
            DataView.Columns.Add("FirstName", "Фамилия");
            DataView.Columns.Add("Name", "Имя");
            DataView.Columns.Add("Otchestvo", "Отчество");
            DataView.Columns.Add("Data", "Дата рождения");
            DataView.Columns.Add("Number", "Номер телефона");
            DataView.Columns.Add("Age", "Возраст");
            DataView.Columns.Add("Status", "Статус");
            DataView.Columns.Add("Subscription", "Подписка");
            DataView.Columns.Add("ID", "ID");
            DataView.Columns.Add("DateReg", "Дата регистрации");
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
            label20.Visible = false;
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
            // Разрешаем ввод только цифр и символа '/'
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '/')
            {
                e.Handled = true;
            }
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
            if (OtchestvoBox.Text != "" && phoneNumBox.Text != "" && nameBox.Text != "" && familiyaBox.Text != "")
            {
                if (phoneNumBox.Text.Length == 11 || phoneNumBox.Text.Length == 12)
                {
                    string[] Statuses = { "клиент", "бизнес-клиен", "вип-клиент" };

                    Random random = new Random();
                    int randomNumber = random.Next(0, 3);
                    int randomDay = random.Next(1, 365);
                    string FirstName1 = familiyaBox.Text;
                    string Name = nameBox.Text;
                    string OtName = OtchestvoBox.Text;
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

                        // Проверяем, существует ли номер телефона в базе данных
                        string checkPhoneNumberQuery = "SELECT COUNT(*) FROM clients WHERE Number = @Number";
                        using (SqliteCommand checkPhoneNumberCommand = new SqliteCommand(checkPhoneNumberQuery, connection))
                        {
                            checkPhoneNumberCommand.Parameters.AddWithValue("@Number", Number);
                            int count = Convert.ToInt32(checkPhoneNumberCommand.ExecuteScalar());

                            // Если номер телефона уже существует, отображаем сообщение об ошибке
                            if (count > 0)
                            {
                                MessageBox.Show("Номер телефона уже существует в базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // Прекращаем выполнение операции добавления
                            }
                        }
                        string sqlExpression = "INSERT INTO clients (FirstName, Name, Otchestvo, Data, Number, Age,Status,Subscription,ID,DateReg) VALUES (@FirstName, @Name, @OtName, @Data2, @Number, @age,@Statuses, @Days, @GuidID,@DateReg)";
                        using (SqliteCommand command = new SqliteCommand(sqlExpression, connection))
                        {
                            command.Parameters.AddWithValue("@FirstName", FirstName1);
                            command.Parameters.AddWithValue("@Name", Name);
                            command.Parameters.AddWithValue("@OtName", OtName);
                            command.Parameters.AddWithValue("@Data2", Data2);
                            command.Parameters.AddWithValue("@Number", Number);
                            command.Parameters.AddWithValue("@age", age);
                            command.Parameters.AddWithValue("@Statuses", Statuses[randomNumber]);
                            command.Parameters.AddWithValue("@Days", randomDay);
                            command.Parameters.AddWithValue("@GuidID", Guid.NewGuid());
                            command.Parameters.AddWithValue("@DateReg", Convert.ToString(DateTime.Now));
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Пользователь добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OtchestvoBox.Text = null;
                    nameBox.Text = null;
                    familiyaBox.Text = null;
                    phoneNumBox.Text = null;
                    dateTimePicker1.Text = null;
                }
                else
                {
                    MessageBox.Show("!Вы ввели меньше 11 чисел номера!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("!Вы добавили не все главные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                label13.Visible = false;
                                label14.Visible = false;
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
            if (columnName == "Data")
            {
                textBox3.KeyPress += textBox6_KeyPress;
                textBox3.KeyPress -= textBox_KeyPress;
                textBox3.KeyPress -= text_KeyPress;
            }
            else if (columnName == "Number")
            {
                textBox3.KeyPress += textBox_KeyPress;
                textBox3.KeyPress -= text_KeyPress;
                textBox3.KeyPress -= textBox6_KeyPress;
            }
            else
            {
                textBox3.KeyPress += text_KeyPress;
                textBox3.KeyPress -= textBox_KeyPress;
                textBox3.KeyPress -= textBox6_KeyPress;
            }
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
                            textBox3.KeyPress += textBox6_KeyPress;
                            command.CommandText = $"UPDATE Clients SET {columnName} = @newValue, Age = @newAge WHERE ID = @id";
                            //DateTime dateTime = DateTime.ParseExact(newValue, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                            DateTime dateTime = DateTime.ParseExact(newValue, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                            //DateTime numericDate = DateTime.Parse(dateTime.ToString("MM/dd/yyyy"));
                            string[] Data2 = Convert.ToString(dateTime).Split(" ");
                            command.Parameters.AddWithValue("@newValue", Data2[0]);
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
                        else if (columnName == "Number")
                        {
                            if (textBox3.Text.Length == 11 || textBox3.Text.Length == 12)
                            {
                                // Предполагая, что у нас есть колонка Id для идентификации клиента
                                command.CommandText = $"UPDATE Clients SET {columnName} = @newValue WHERE ID = @id";
                                command.Parameters.AddWithValue("@newValue", newValue);
                                command.Parameters.AddWithValue("@id", ID);
                            }
                            else
                            {
                                MessageBox.Show("Вы ввели мало цифр для номера", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        else
                        {
                            // Предполагая, что у нас есть колонка Id для идентификации клиента
                            command.CommandText = $"UPDATE Clients SET {columnName} = @newValue WHERE ID = @id";
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
            textBox3.KeyPress -= textBox6_KeyPress;
            textBox3.KeyPress -= textBox_KeyPress;
            label20.Visible = false;
        }
        private void buttonName_Click(object sender, EventArgs e)
        {
            ShowTextBoxAndUpdate("Name");
            textBox3.KeyPress -= textBox6_KeyPress;
            textBox3.KeyPress -= textBox_KeyPress;
            label20.Visible = false;
        }
        private void buttonOtName_Click(object sender, EventArgs e)
        {
            ShowTextBoxAndUpdate("Otchestvo");
            textBox3.KeyPress -= textBox6_KeyPress;
            textBox3.KeyPress -= textBox_KeyPress;
            label20.Visible = false;
        }
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            ShowTextBoxAndUpdate("Number");
            textBox3.KeyPress -= textBox6_KeyPress;
            textBox3.KeyPress -= text_KeyPress;
            label20.Visible = false;
        }
        private void buttonDateBirt_Click(object sender, EventArgs e)
        {
            label20.Visible = true;
            ShowTextBoxAndUpdate("Data");
            textBox3.KeyPress -= text_KeyPress;
            textBox3.KeyPress -= textBox_KeyPress;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateClientData(newValue, textBox3.Text);
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            buttonFirstName.Visible = false;
            buttonName.Visible = false;
            buttonPatronymic.Visible = false;
            buttonPhoneNumber.Visible = false;
            buttonBirthDate.Visible = false;
            label20.Visible = false;
            textBox3.Visible = false;
            button2.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button3.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            textBox3.KeyPress -= textBox6_KeyPress;
            textBox3.KeyPress -= text_KeyPress;
            textBox3.KeyPress -= textBox_KeyPress;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDateBirt_Click_1(object sender, EventArgs e)
        {
            UpdateClientDateBrt();
        }

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
            textBox7.Text = null;
            textBox6.Text = null;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred while deleting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string firstName = textBox5.Text;
            string Name = textBox4.Text;


            using (var connection = new SqliteConnection($"Data Source={path};Cache=Default;Mode=ReadWrite;"))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    // Поиск клиента по фамилии и имени
                    command.CommandText = "SELECT ID,DateReg,Subscription FROM clients WHERE FirstName = @firstName AND Name = @Name";
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@Name", Name);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Найден клиент, отображаем кнопки для редактирования данных
                            //ID = reader["ID"].ToString();
                            //string DataReg = reader["DateReg"].ToString();
                            string TimeAb = reader["Subscription"].ToString();
                            DateTime dateTime = DateTime.Parse(reader["DateReg"].ToString());
                            // Добавление указанного количества дней к дате регистрации
                            DateTime expirationDate = dateTime.AddDays(Convert.ToInt32(TimeAb));

                            // Вычисление времени, оставшегося до истечения срока действия
                            TimeSpan timeRemaining = expirationDate - DateTime.Now;
                            if (timeRemaining > TimeSpan.Zero)
                            {
                                string[] DataAb = timeRemaining.ToString().Split('.');
                                MessageBox.Show($"Осталось:\nДней: {DataAb[0]}\nВремени: {DataAb[1]}");
                                textBox5.Text = null;
                                textBox4.Text = null;
                            }
                            else
                            {
                                MessageBox.Show("Абонимент истёк");
                                textBox5.Text = null;
                                textBox4.Text = null;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Client not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = $"Data Source={path};Cache=Default;Mode=ReadWrite;";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = $"DELETE FROM Clients;"; // Запрос на удаление всех записей из указанной таблицы

                using (SqliteCommand command = new SqliteCommand(sqlQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            RndmDBGenerator.GenerateRandomData(path);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}