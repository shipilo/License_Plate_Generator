using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace License_Plate_Generator
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection;
        private List<string> plates;

        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");
            plates = new List<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool tableIsExist = false;
            SqlDataReader reader = null;

            sqlConnection.Open();

            // проверка существования таблицы LPG_history
            SqlCommand sqlCommand1 = new SqlCommand("SELECT CONVERT(BIT, COUNT(*)) FROM sys.tables WHERE name = N'LPG_history'", sqlConnection);
            try
            {
                reader = sqlCommand1.ExecuteReader();
                reader.Read();
                tableIsExist = Convert.ToBoolean(reader[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (reader != null) reader.Close();

            // если таблица не существует, то создаем ее
            if (!tableIsExist)
            {
                SqlCommand sqlCommand2 = new SqlCommand(
                    "CREATE TABLE LPG_history" +
                    "(id INT PRIMARY KEY IDENTITY (1,1) NOT NULL," +
                    "Plate NVARCHAR(30))", sqlConnection);
                try
                {
                    sqlCommand2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // если существует, то загружаем оттуда данные
            else
            {
                SqlCommand sqlCommand3 = new SqlCommand("SELECT * FROM LPG_history", sqlConnection);
                try
                {
                    reader = sqlCommand3.ExecuteReader();
                    while (reader.Read())
                    {
                        plates.Add(reader["Plate"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (reader != null) reader.Close();
            sqlConnection.Close();
        }
    }
}
