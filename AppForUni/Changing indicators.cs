using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForUni
{
    public partial class Changing_indicators : Form
    {
        private string userID;
        private SqlConnection sqlConnection;
        public Changing_indicators(string userID, SqlConnection connection)
        {
            InitializeComponent();
            this.userID = userID;
            this.sqlConnection = connection;
        }

        private void Changing_indicators_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримання введених користувачем даних з лічильників
            double gasUsage;
            double elecUsage;
            double waterUsage;

            if (!double.TryParse(txtGasUsage.Text, out gasUsage) ||
                !double.TryParse(txtElecUsage.Text, out elecUsage) ||
                !double.TryParse(txtWaterUsage.Text, out waterUsage))
            {
                MessageBox.Show("Невірний формат введених даних. Будь ласка, переконайтесь, що ви вводите числові значення.");
                return;
            }

            // Отримання даних користувача з бази даних
            string query = "SELECT * FROM userDB WHERE id_key = @UserID";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@UserID", userID);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                try
                {
                    double gasData = double.Parse(reader["gas"].ToString());
                    double elecData = double.Parse(reader["elec"].ToString());
                    double waterData = double.Parse(reader["water"].ToString());
                    double gasPrice = 7.99; // Ціна за одиницю газу
                    double elecPrice = 1.44; // Ціна за одиницю електрики
                    double waterPrice = 22.24; // Ціна за одиницю води

                    if (gasData > gasUsage)
                    {
                        MessageBox.Show("Невірне значення показника газу");
                    }
                    else if (elecData > elecUsage)
                    {
                        MessageBox.Show("Невірне значення показника електроенергії");
                    }
                    else if (waterData > waterUsage)
                    {
                        MessageBox.Show("Невірне значення показника води");
                    }
                    else
                    {
                        double gasPay = (gasUsage - gasData) * gasPrice;
                        double elecPay = (elecUsage - elecData) * elecPrice;
                        double waterPay = (waterUsage - waterData) * waterPrice;

                        reader.Close();
                        query = "UPDATE userDB SET gas = @GasData, elec = @ElecData, water = @WaterData, gas_pay = @GasPay, elec_pay = @ElecPay, water_pay = @WaterPay, Date = @LastCalculation WHERE id_key = @UserID";
                        command = new SqlCommand(query, sqlConnection);
                        command.Parameters.AddWithValue("@GasData", gasUsage);
                        command.Parameters.AddWithValue("@ElecData", elecUsage);
                        command.Parameters.AddWithValue("@WaterData", waterUsage);
                        command.Parameters.AddWithValue("@GasPay", gasPay);
                        command.Parameters.AddWithValue("@ElecPay", elecPay);
                        command.Parameters.AddWithValue("@WaterPay", waterPay);
                        command.Parameters.AddWithValue("@LastCalculation", DateTime.Now);
                        command.Parameters.AddWithValue("@UserID", userID);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Дані успішно збережено!");

                        // Оновлення форми особистого кабінету
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталася помилка при обробці даних: " + ex.Message);
                }
                finally
                {
                    reader.Close();
                }
            }
        }
    }
    
}
