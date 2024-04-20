using Microsoft.Data.Sqlite;

namespace Fitnes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.TextChanged += TextBox1_TextChanged;
            textBox2.TextChanged += TextBox2_TextChanged;
            textBox3.TextChanged += TextBox3_TextChanged;
            textBox4.TextChanged += TextBox4_TextChanged;
            textBox6.TextChanged += TextBox6_TextChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, пустое ли текстовое поле
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                // Если текстовое поле пустое, делаем метку видимой
                label6.Visible = true;
            }
            else
            {
                // Если в текстовом поле что-то есть, скрываем метку
                label6.Visible = false;
            }
        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, пустое ли текстовое поле
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                // Если текстовое поле пустое, делаем метку видимой
                label7.Visible = true;
            }
            else
            {
                // Если в текстовом поле что-то есть, скрываем метку
                label7.Visible = false;
            }
        }
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, пустое ли текстовое поле
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                // Если текстовое поле пустое, делаем метку видимой
                label9.Visible = true;
            }
            else
            {
                // Если в текстовом поле что-то есть, скрываем метку
                label9.Visible = false;
            }
        }
        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, пустое ли текстовое поле
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                // Если текстовое поле пустое, делаем метку видимой
                label8.Visible = true;
            }
            else
            {
                // Если в текстовом поле что-то есть, скрываем метку
                label8.Visible = false;
            }
        }
        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, пустое ли текстовое поле
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                // Если текстовое поле пустое, делаем метку видимой
                label10.Visible = true;
            }
            else
            {
                // Если в текстовом поле что-то есть, скрываем метку
                label10.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox6.Text != "")
            {
                string[] Statuses = { "клиент", "бизнес-клиен", "вип-клиент" };
                Random random = new Random();
                int randomNumber = random.Next(0, 3);
                int randomDay = random.Next(1, 365);
                string FirstName1 = textBox1.Text;
                string Name = textBox2.Text;
                string OtName = textBox4.Text;
                string[] Data = textBox3.Text.Split(".");
                string Data2 = textBox3.Text;
                string Number = textBox6.Text;
                // Предположим, что у вас есть переменная birthDate, содержащая дату рождения
                DateTime birthDate = new DateTime(Int32.Parse(Data[2]), Int32.Parse(Data[1]), Int32.Parse(Data[0]));

                // Получаем текущую дату
                DateTime currentDate = DateTime.Today;

                // Рассчитываем разницу между текущей датой и датой рождения в годах
                int age = currentDate.Year - birthDate.Year;

                // Проверяем, нужно ли скорректировать возраст на основе месяца и дня рождения
                if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
                {
                    age--;
                }
                string path = "C:\\Users\\B-ZONE\\OneDrive\\Рабочий стол\\Fitnes\\Resource\\Viking.db";

                using (var connection = new SqliteConnection($"Data Source={path};Cache=Default;Mode=ReadWrite;"))
                {
                    connection.Open();
                    string sqlExpression = "INSERT INTO clients (FirstName, Name, Otchestvo, Data, Number, Age,Status,Subscription,ID) VALUES (@FirstName, @Name, @OtName, @Data2, @Number, @age,@Statuses, @Days, @GuidID)";
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

                Close();
            }
            else
            {
                MessageBox.Show("Надо ввести во все поля", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

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

    }
}
