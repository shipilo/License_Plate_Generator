using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace License_Plate_Generator
{
    public partial class MainForm : Form
    {
        private SqlConnection sqlConnection;
        private List<string> plates;

        public MainForm()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(@"Server=.\SQLEXPRESS;Integrated security=SSPI;database=master");
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


            //Прозрачный фон у label'ов для PictureBox'a
            PlateLabel.Parent = PlatePictureBox;
            RegionLabel.Parent = PlatePictureBox;
            RegionComboBox.SelectedIndex = Properties.Settings.Default.SelectedRegion;
            RegionLabel.Text = $"{RegionComboBox.SelectedIndex + 1}";
            Size = Properties.Settings.Default.WindowSize;

            PlatePictureBox.ContextMenuStrip = ContextMenuStrip;

            MainForm_SizeChanged(this, EventArgs.Empty);
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                PlatePictureBox.BackColor = colorDialog.Color;
                ColorButton.BackColor = colorDialog.Color;
                TableButtons.BackColor = colorDialog.Color;
                BackColor = colorDialog.Color;
            }
        }

        private void NextTSMI_Click(object sender, EventArgs e)
        {

        }

        private void BackTSMI_Click(object sender, EventArgs e)
        {

        }

        private void RandomTSMI_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            PlatePictureBox.Width = Width - 18;
            PlatePictureBox.Height = PlatePictureBox.Width / 5;
            PlatePictureBox.Location = new Point(0, (Height - PlatePictureBox.Height)/2);

            PlateLabel.Height = PlatePictureBox.Height;
            PlateLabel.Font = new Font(FontFamily.GenericSansSerif, PlatePictureBox.Height * 3/4, GraphicsUnit.Pixel);
            PlateLabel.Location = new Point((PlatePictureBox.Width * 3 / 4 - PlateLabel.Width) / 2, (PlatePictureBox.Height - PlateLabel.Height)/2);

            RegionLabel.Height = PlatePictureBox.Height * 3 / 4;
            RegionLabel.Font = new Font(FontFamily.GenericSansSerif, PlatePictureBox.Height * 1 / 2, GraphicsUnit.Pixel);
            RegionLabel.Location = new Point(PlatePictureBox.Width * 7 / 8 - RegionLabel.Width/2, (PlatePictureBox.Height * 2 / 3 - RegionLabel.Height)/2);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SelectedRegion = RegionComboBox.SelectedIndex;
            if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.WindowSize = Size;
            }
            else
            {
                Properties.Settings.Default.WindowLocation = RestoreBounds.Location;
                Properties.Settings.Default.WindowSize = RestoreBounds.Size;
            }
            Properties.Settings.Default.Save();
        }

        private void RegionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegionLabel.Text = $"{RegionComboBox.SelectedIndex + 1}";
        }
    }
}
