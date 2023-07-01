using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AppForUni
{
    public partial class PersonalCabinet : Form
    {
        private string userID;
        private SqlConnection sqlConnection;
        public PersonalCabinet(string userID, SqlConnection connection)
        {
            InitializeComponent();
            this.userID = userID;
            this.sqlConnection = connection;
        }

        private void PersonalCabinet_Load(object sender, EventArgs e)
        {
            // Отримати дані користувача з бази даних
            string query = "SELECT * FROM userDB WHERE id_key = @UserID";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@UserID", userID);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                // Отримати дані зчитані з бази даних
                string imagePath = reader["picture"].ToString();  // Припустимо, що зображення зберігається як шлях до файлу
                string userName = reader["Name"].ToString();
                string gasData = reader["gas"].ToString();
                string elecData = reader["elec"].ToString();
                string waterData = reader["water"].ToString();
                string gasCost = reader["gas_pay"].ToString();
                string elecCost = reader["elec_pay"].ToString();
                string waterCost = reader["water_pay"].ToString();
                string lastCalculation = reader["Date"].ToString();

                // Відображення отриманих даних у відповідних елементах на формі
                pictureBoxim.Image = Image.FromFile(imagePath);
                nametag.Text = userName;
                usegas.Text = "Показники лічильника газу: " + gasData;
                useelec.Text = "Показники лічильника електроенергії: " + elecData;
                usewater.Text = "Показники лічильника води: " + waterData;
                gascost.Text = "Оплата за газ: " + gasCost + " грн.";
                eleccost.Text = "Оплата за електрику: " + elecCost + " грн.";
                watercost.Text = "Оплата за воду: " + waterCost + " грн.";
                date.Text = "Останній розрахунок: " + lastCalculation;
            

        }

            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Створення та відображення форми "Changing_indicators"
            Changing_indicators changingIndicatorsForm = new Changing_indicators(userID, sqlConnection);
            changingIndicatorsForm.ShowDialog();

            // Оновлення форми особистого кабінету після закриття форми "Changing_indicators"
            PersonalCabinet_Load(sender, e);

        }

        private void changeimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png, *.jpg, *.jpeg, *.gif)|*.png;*.jpg;*.jpeg;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                try
                {
                    // Завантаження зображення з файлу
                    Image image = Image.FromFile(imagePath);

                    // Встановлення зображення в PictureBox
                    pictureBoxim.Image = image;

                    // Оновлення розташування зображення в базі даних
                    string query = "UPDATE userDB SET picture = @ImagePath WHERE id_key = @UserID";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@ImagePath", imagePath);
                    command.Parameters.AddWithValue("@UserID", userID);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Зображення успішно змінено і збережено в базі даних!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталася помилка при зміні зображення: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SingIn loginForm = new SingIn();
            loginForm.Show();
            this.Close();
        }

        private void useelec_Click(object sender, EventArgs e)
        {

        }

        private void PersonalCabinet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
