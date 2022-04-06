
namespace License_Plate_Generator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.сгенерироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.NextTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PreviousTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.RegionComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NextCMS = new System.Windows.Forms.ToolStripMenuItem();
            this.BackCMS = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomCMS = new System.Windows.Forms.ToolStripMenuItem();
            this.PlateLabel = new System.Windows.Forms.Label();
            this.RegionLabel = new System.Windows.Forms.Label();
            this.ColorButton = new System.Windows.Forms.Button();
            this.PlatePictureBox = new System.Windows.Forms.PictureBox();
            this.MenuStrip.SuspendLayout();
            this.ContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlatePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сгенерироватьToolStripMenuItem,
            this.RegionComboBox});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 32);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "Меню";
            // 
            // сгенерироватьToolStripMenuItem
            // 
            this.сгенерироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RandomTSMI,
            this.NextTSMI,
            this.PreviousTSMI});
            this.сгенерироватьToolStripMenuItem.Name = "сгенерироватьToolStripMenuItem";
            this.сгенерироватьToolStripMenuItem.Size = new System.Drawing.Size(129, 28);
            this.сгенерироватьToolStripMenuItem.Text = "Сгенерировать";
            // 
            // RandomTSMI
            // 
            this.RandomTSMI.Name = "RandomTSMI";
            this.RandomTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.RandomTSMI.Size = new System.Drawing.Size(234, 26);
            this.RandomTSMI.Text = "Случайный";
            this.RandomTSMI.Click += new System.EventHandler(this.RandomTSMI_Click);
            // 
            // NextTSMI
            // 
            this.NextTSMI.Name = "NextTSMI";
            this.NextTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NextTSMI.Size = new System.Drawing.Size(234, 26);
            this.NextTSMI.Text = "Следующий";
            this.NextTSMI.Click += new System.EventHandler(this.NextTSMI_Click);
            // 
            // PreviousTSMI
            // 
            this.PreviousTSMI.Name = "PreviousTSMI";
            this.PreviousTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PreviousTSMI.Size = new System.Drawing.Size(234, 26);
            this.PreviousTSMI.Text = "Предыдущий";
            this.PreviousTSMI.Click += new System.EventHandler(this.PreviousTSMI_Click);
            // 
            // RegionComboBox
            // 
            this.RegionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegionComboBox.Items.AddRange(new object[] {
            "01 (Республика Адыгея)",
            "02 (Республика Башкортостан)",
            "03 (Республика Бурятия)",
            "04 (Республика Алтай)",
            "05 (Республика Дагестан)",
            "06 (Республика Ингушетия)",
            "07 (Кабардино-Балкарская Республика)",
            "08 (Республика Калмыкия)",
            "09 (Карачаево-Черкесская Республика)",
            "10 (Республика Карелия)",
            "11 (Республика Коми)",
            "12 (Республика Марий Эл)",
            "13 (Республика Мордовия)",
            "14 (Республика Саха-Якутия)",
            "15 (Республика Северная Осетия-Алания)",
            "16 (Республика Татарстан)",
            "17 (Республика Тыва)",
            "18 (Удмуртская Республика)",
            "19 (Республика Хакасия)",
            "20 (Республика Чечня)",
            "21 (Чувашская Республика — Чувашия)",
            "22 (Алтайский край)",
            "23 (Краснодарский край)",
            "24 (Красноярский край)",
            "25 (Приморский край)",
            "26 (Ставропольский край)",
            "27 (Хабаровский край)",
            "28 (Амурская область)",
            "29 (Архангельская область)",
            "30 (Астраханская область)",
            "31 (Белгородская область)",
            "32 (Брянская область)",
            "33 (Владимирская область)",
            "34 (Волгоградская область)",
            "35 (Вологодская область)",
            "36 (Воронежская область)",
            "37 (Ивановская область)",
            "38 (Иркутская область)",
            "39 (Калининградская область)",
            "40 (Калужская область)",
            "41 (Камчатская область)",
            "42 (Кемеровская область)",
            "43 (Кировская область)",
            "44 (Костромская область)",
            "45 (Курганская область)",
            "46 (Курская область)",
            "47 (Ленинградская область)",
            "48 (Липецкая область)",
            "49 (Магаданская область)",
            "50 (Московская область)",
            "51 (Мурманская область)",
            "52 (Нижегородская область)",
            "53 (Новгородская область)",
            "54 (Новосибирская область)",
            "55 (Омская область)",
            "56 (Оренбургская область)",
            "57 (Орловская область)",
            "58 (Пензенская область)",
            "59 (Пермский край)",
            "60 (Псковская область)",
            "61 (Ростовская область)",
            "62 (Рязанская область)",
            "63 (Самарская область)",
            "64 (Саратовская область)",
            "65 (Сахалинская область)",
            "66 (Свердловская область)",
            "67 (Смоленская область)",
            "68 (Тамбовская область)",
            "69 (Тверская область)",
            "70 (Томская область)",
            "71 (Тульская область)",
            "72 (Тюменская область)",
            "73 (Ульяновская область)",
            "74 (Челябинская область)",
            "75 (Читинская область)",
            "76 (Ярославская область)",
            "77 (Москва)",
            "78 (Санкт-Петербург)",
            "79 (Еврейская авт. область)",
            "80 (Агинский Бурятский авт. округ)",
            "81 (Коми-Пермяцкий авт. округ)",
            "82 (Корякский авт. округ)",
            "83 (Ненецкий авт. округ)",
            "84 (Таймырский авт. округ)",
            "85 (Усть-Ордынский Бурятский авт. округ)",
            "86 (Ханты-Мансийский авт. округ - Югра)",
            "87 (Чукотский авт. округ)",
            "88 (Эвенкийский авт. округ)",
            "89 (Ямало-Ненецкий авт. округ)",
            "90 (Московская область)",
            "95 (Чеченская республика)",
            "98 (Санкт-Петербург)",
            "99 (Москва)"});
            this.RegionComboBox.Name = "RegionComboBox";
            this.RegionComboBox.Size = new System.Drawing.Size(250, 28);
            this.RegionComboBox.SelectedIndexChanged += new System.EventHandler(this.RegionComboBox_SelectedIndexChanged);
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NextCMS,
            this.BackCMS,
            this.RandomCMS});
            this.ContextMenuStrip.Name = "ContextMenuStrip";
            this.ContextMenuStrip.Size = new System.Drawing.Size(171, 76);
            this.ContextMenuStrip.Text = "Сгенерировать";
            // 
            // NextCMS
            // 
            this.NextCMS.Name = "NextCMS";
            this.NextCMS.Size = new System.Drawing.Size(170, 24);
            this.NextCMS.Text = "Следующий";
            this.NextCMS.Click += new System.EventHandler(this.NextCMS_Click);
            // 
            // BackCMS
            // 
            this.BackCMS.Name = "BackCMS";
            this.BackCMS.Size = new System.Drawing.Size(170, 24);
            this.BackCMS.Text = "Предыдущий";
            this.BackCMS.Click += new System.EventHandler(this.BackCMS_Click);
            // 
            // RandomCMS
            // 
            this.RandomCMS.Name = "RandomCMS";
            this.RandomCMS.Size = new System.Drawing.Size(170, 24);
            this.RandomCMS.Text = "Рандомный";
            this.RandomCMS.Click += new System.EventHandler(this.RandomCMS_Click);
            // 
            // PlateLabel
            // 
            this.PlateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlateLabel.AutoSize = true;
            this.PlateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 70.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlateLabel.Location = new System.Drawing.Point(25, 225);
            this.PlateLabel.Name = "PlateLabel";
            this.PlateLabel.Size = new System.Drawing.Size(490, 132);
            this.PlateLabel.TabIndex = 9;
            this.PlateLabel.Text = "A123BC";
            // 
            // RegionLabel
            // 
            this.RegionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RegionLabel.AutoSize = true;
            this.RegionLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionLabel.Location = new System.Drawing.Point(627, 225);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(121, 85);
            this.RegionLabel.TabIndex = 10;
            this.RegionLabel.Text = "11";
            // 
            // ColorButton
            // 
            this.ColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorButton.BackgroundImage = global::License_Plate_Generator.Properties.Resources.button_icon;
            this.ColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ColorButton.FlatAppearance.BorderSize = 0;
            this.ColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorButton.Location = new System.Drawing.Point(725, 526);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(75, 75);
            this.ColorButton.TabIndex = 2;
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // PlatePictureBox
            // 
            this.PlatePictureBox.Image = global::License_Plate_Generator.Properties.Resources.sample;
            this.PlatePictureBox.Location = new System.Drawing.Point(0, 212);
            this.PlatePictureBox.Name = "PlatePictureBox";
            this.PlatePictureBox.Size = new System.Drawing.Size(782, 161);
            this.PlatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlatePictureBox.TabIndex = 1;
            this.PlatePictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::License_Plate_Generator.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.RegionLabel);
            this.Controls.Add(this.PlateLabel);
            this.Controls.Add(this.PlatePictureBox);
            this.Controls.Add(this.MenuStrip);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::License_Plate_Generator.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::License_Plate_Generator.Properties.Settings.Default, "WindowLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::License_Plate_Generator.Properties.Settings.Default.WindowLocation;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Генератор Номерных Знаков - LPG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ClientSizeChanged += new System.EventHandler(this.DrawLabel);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlatePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.PictureBox PlatePictureBox;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private new System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NextCMS;
        private System.Windows.Forms.ToolStripMenuItem BackCMS;
        private System.Windows.Forms.ToolStripMenuItem RandomCMS;
        private System.Windows.Forms.ToolStripComboBox RegionComboBox;
        private System.Windows.Forms.Label PlateLabel;
        private System.Windows.Forms.Label RegionLabel;
        private System.Windows.Forms.ToolStripMenuItem сгенерироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RandomTSMI;
        private System.Windows.Forms.ToolStripMenuItem NextTSMI;
        private System.Windows.Forms.ToolStripMenuItem PreviousTSMI;
    }
}

