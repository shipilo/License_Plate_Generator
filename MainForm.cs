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
        private List<Plate> regionPlates;
        private int regionSelected;

        public MainForm()
        {
            InitializeComponent();
            sqlConnection = new SQLiteConnection("Data Source=../../data.db");
            sqlCommand = new SQLiteCommand(sqlConnection);
            plates = new List<Plate>();
            regionPlates = new List<Plate>();
        }

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

            RegionComboBox.SelectedIndex = Properties.Settings.Default.SelectedRegion;
            Size = Properties.Settings.Default.WindowSize;

            PlatePictureBox.ContextMenuStrip = ContextMenuStrip;

            DrawLabel(this, EventArgs.Empty);
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

        private void DrawLabel(object sender, EventArgs e)
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

            plates.AddRange(regionPlates.FindAll(x => !plates.Contains(x)));

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

            plates.AddRange(regionPlates.FindAll(x => !plates.Contains(x)));
            regionPlates = plates.FindAll(x => x.Region == regionSelected);
            RegionLabel.Text = $"{regionSelected}";
            PlateLabel.Text = regionPlates.Count == 0 ? "" : regionPlates[regionPlates.Count - 1].ToString();
        }

        private void RandomTSMI_Click(object sender, EventArgs e)
        {
            regionPlates.Add(Plate.GenerateRandom(regionPlates, regionSelected));

            PlateLabel.Text = regionPlates[regionPlates.Count - 1].ToString();
            DrawLabel(sender, EventArgs.Empty);
        }

        private void PreviousTSMI_Click(object sender, EventArgs e)
        {
            if (regionPlates.Count == 0)
            {
                MessageBox.Show("Сначала сгенерируйте случайный номер", "Внимание", MessageBoxButtons.OK);
                return;
            }
            Plate generated = Plate.GeneratePrevious(regionPlates);
            if (generated != null)
            {
                regionPlates.Add(generated);
            }

            PlateLabel.Text = regionPlates[regionPlates.Count - 1].ToString();
        }

        private void NextTSMI_Click(object sender, EventArgs e )
        {
            if (regionPlates.Count == 0)
            {
                MessageBox.Show("Сначала сгенерируйте случайный номер", "Внимание", MessageBoxButtons.OK);
                return;
            }
            Plate generated = Plate.GenerateNext(regionPlates);
            if (generated != null)
            {
                regionPlates.Add(generated);
            }

            PlateLabel.Text = regionPlates[regionPlates.Count - 1].ToString();
        }
    }
}
