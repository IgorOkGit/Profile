using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppForUni
{
    public partial class SingIn : Form
    {
        public SqlConnection sqlConnection = null;
        public SingIn()
        {
            InitializeComponent();
        }

        private void SingIn_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ProgDB"].ConnectionString);
            sqlConnection.Open();
        }
        public SqlConnection GetSqlConnection()
        {
            return sqlConnection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримуємо інформацію з бази даних про користувача з введеним іменем
            string userName = userID.Text;
            string pass = password.Text;

            string query = "SELECT * FROM userDB WHERE id_key = @UserID AND Password = @Password";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@UserID", userName);
            command.Parameters.AddWithValue("@Password", pass);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                // Вхід успішний, закриваємо поточну форму та відкриваємо форму особистого кабінету
                reader.Close();
                this.Hide();

                PersonalCabinet personalCabinetForm = new PersonalCabinet(userName, sqlConnection);
                personalCabinetForm.Show();
            }
            else
            {
                MessageBox.Show("Неправильне ім'я користувача або пароль");
            }
        }

        private void userID_TextChanged(object sender, EventArgs e)
        {

        }

        private void userID_Enter_1(object sender, EventArgs e)
        {
            // Перевірка, чи текст у TextBox є текстом-підказкою
            if (userID.Text == "Введіть унікальний код...")
            {
                // Очистити текст у TextBox та змінити кольори тексту на чорний
                userID.Text = "";
                userID.ForeColor = Color.Black;
            }
        }

        private void userID_Leave_1(object sender, EventArgs e)
        {
            // Перевірка, чи TextBox порожній
            if (string.IsNullOrWhiteSpace(userID.Text))
            {
                // Встановлення тексту-підказки та зміна кольору тексту на сірий
                userID.Text = "Введіть унікальний код...";
                userID.ForeColor = Color.Gray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Уведіть пароль...")
            {
                // Очистити текст у TextBox та змінити кольори тексту на чорний
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            // Перевірка, чи TextBox порожній
            if (string.IsNullOrWhiteSpace(password.Text))
            {
                // Встановлення тексту-підказки та зміна кольору тексту на сірий
                password.Text = "Уведіть пароль...";
                password.ForeColor = Color.Gray;
            }
        }
    }
}
