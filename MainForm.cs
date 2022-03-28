using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace License_Plate_Generator
{
    public partial class MainForm : Form
    {
        private SQLiteConnection sqlConnection;
        private SQLiteCommand sqlCommand;
        private List<Plate> plates;
        private int regionSelected;

        public MainForm()
        {
            InitializeComponent();
            sqlConnection = new SQLiteConnection("Data Source=../../data.db");
            sqlCommand = new SQLiteCommand(sqlConnection);
            plates = new List<Plate>();
        }

        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sqlCommand.CommandText = "SELECT * FROM LPG_history";
            try
            {
                using (SQLiteDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        plates.Add(new Plate(reader["numbers"].ToString(), reader["symbols"].ToString(), (int)reader["region"]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            sqlConnection.Close();


            //Прозрачный фон у label'ов для PictureBox'a
            PlateLabel.Parent = PlatePictureBox;
            RegionLabel.Parent = PlatePictureBox;

            PlateLabel.Text = plates.Count != 0 ? plates[plates.Count - 1].ToString() : "";
            RegionComboBox.SelectedIndex = Properties.Settings.Default.SelectedRegion;
            RegionComboBox_SelectedIndexChanged(this, EventArgs.Empty);
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
                BackColor = colorDialog.Color;
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            PlatePictureBox.Width = (Width - 18) * 11/12;
            PlatePictureBox.Height = PlatePictureBox.Width / 5;
            PlatePictureBox.Location = new Point(PlatePictureBox.Width/22, ((Height - 18) - PlatePictureBox.Height)/2);

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

            sqlConnection.Open();
            sqlCommand.CommandText = "begin";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "SELECT COUNT(Id) FROM LPG_history";
            for(int i=(int)(long)sqlCommand.ExecuteScalar(); i < plates.Count; i++)
            {
                sqlCommand.CommandText = $"INSERT INTO LPG_history (numbers, symbols, region) " +
                                         $"VALUES ('{new string(plates[i].Numbers)}', '{new string(plates[i].Symbols)}', {plates[i].Region})";
                sqlCommand.ExecuteNonQuery();
            }
            sqlCommand.CommandText = "end";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void RegionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RegionComboBox.SelectedIndex)
            {
                case 90:
                    regionSelected = 95;
                    break;
                case 91:
                    regionSelected = 98;
                    break;
                case 92:
                    regionSelected = 99;
                    break;
                default:
                    regionSelected = RegionComboBox.SelectedIndex + 1;
                    break;
            }

            RegionLabel.Text = $"{regionSelected}";
        }

        private void RandomTSMI_Click(object sender, EventArgs e)
        {
            Plate plate = new Plate();
            do
            {
                for (int i = 0; i <= 2; i++)
                {
                    plate.Symbols[i] = Plate.symbolSet[rnd.Next(1, 11)];
                    plate.Numbers[i] = Convert.ToChar(rnd.Next(1, 9).ToString());
                }
                plate.Region = regionSelected; 
            } while (plates.Contains(plate));

            plates.Add(plate);

            PlateLabel.Text = plate.ToString();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
