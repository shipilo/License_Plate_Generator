
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
            this.GenerateTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.NextTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.BackTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PlatePictureBox = new System.Windows.Forms.PictureBox();
            this.ColorButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.Symbol1 = new System.Windows.Forms.Label();
            this.Number1 = new System.Windows.Forms.Label();
            this.Number2 = new System.Windows.Forms.Label();
            this.Number3 = new System.Windows.Forms.Label();
            this.Symbol2 = new System.Windows.Forms.Label();
            this.Symbol3 = new System.Windows.Forms.Label();
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NextCMS = new System.Windows.Forms.ToolStripMenuItem();
            this.BackCMS = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomCMS = new System.Windows.Forms.ToolStripMenuItem();
            this.RegionComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.PlateLabel = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlatePictureBox)).BeginInit();
            this.ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateTSMI,
            this.RegionComboBox});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(782, 32);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "Меню";
            // 
            // GenerateTSMI
            // 
            this.GenerateTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NextTSMI,
            this.BackTSMI,
            this.RandomTSMI});
            this.GenerateTSMI.Name = "GenerateTSMI";
            this.GenerateTSMI.Size = new System.Drawing.Size(129, 28);
            this.GenerateTSMI.Text = "Сгенерировать";
            // 
            // NextTSMI
            // 
            this.NextTSMI.Name = "NextTSMI";
            this.NextTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NextTSMI.Size = new System.Drawing.Size(234, 26);
            this.NextTSMI.Text = "Следующий";
            this.NextTSMI.Click += new System.EventHandler(this.NextTSMI_Click);
            // 
            // BackTSMI
            // 
            this.BackTSMI.Name = "BackTSMI";
            this.BackTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.BackTSMI.Size = new System.Drawing.Size(234, 26);
            this.BackTSMI.Text = "Предыдущий";
            this.BackTSMI.Click += new System.EventHandler(this.BackTSMI_Click);
            // 
            // RandomTSMI
            // 
            this.RandomTSMI.Name = "RandomTSMI";
            this.RandomTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.RandomTSMI.Size = new System.Drawing.Size(234, 26);
            this.RandomTSMI.Text = "Рандомный";
            this.RandomTSMI.Click += new System.EventHandler(this.RandomTSMI_Click);
            // 
            // PlatePictureBox
            // 
            this.PlatePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlatePictureBox.Image = global::License_Plate_Generator.Properties.Resources.sample;
            this.PlatePictureBox.Location = new System.Drawing.Point(0, 32);
            this.PlatePictureBox.Name = "PlatePictureBox";
            this.PlatePictureBox.Size = new System.Drawing.Size(782, 519);
            this.PlatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlatePictureBox.TabIndex = 1;
            this.PlatePictureBox.TabStop = false;
            // 
            // ColorButton
            // 
            this.ColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorButton.BackgroundImage = global::License_Plate_Generator.Properties.Resources.button_icon;
            this.ColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ColorButton.FlatAppearance.BorderSize = 0;
            this.ColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorButton.Location = new System.Drawing.Point(706, 475);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(75, 75);
            this.ColorButton.TabIndex = 2;
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.AllowFullOpen = false;
            // 
            // Symbol1
            // 
            this.Symbol1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Symbol1.AutoSize = true;
            this.Symbol1.BackColor = System.Drawing.Color.Transparent;
            this.Symbol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 70.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Symbol1.Location = new System.Drawing.Point(12, 223);
            this.Symbol1.Name = "Symbol1";
            this.Symbol1.Size = new System.Drawing.Size(133, 132);
            this.Symbol1.TabIndex = 3;
            this.Symbol1.Text = "A";
            // 
            // Number1
            // 
            this.Number1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Number1.AutoSize = true;
            this.Number1.BackColor = System.Drawing.Color.Transparent;
            this.Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 70.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number1.Location = new System.Drawing.Point(114, 223);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(120, 132);
            this.Number1.TabIndex = 4;
            this.Number1.Text = "1";
            // 
            // Number2
            // 
            this.Number2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Number2.AutoSize = true;
            this.Number2.BackColor = System.Drawing.Color.Transparent;
            this.Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 70.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number2.Location = new System.Drawing.Point(203, 223);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(120, 132);
            this.Number2.TabIndex = 5;
            this.Number2.Text = "2";
            // 
            // Number3
            // 
            this.Number3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Number3.AutoSize = true;
            this.Number3.BackColor = System.Drawing.Color.Transparent;
            this.Number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 70.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number3.Location = new System.Drawing.Point(294, 223);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(120, 132);
            this.Number3.TabIndex = 6;
            this.Number3.Text = "3";
            // 
            // Symbol2
            // 
            this.Symbol2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Symbol2.AutoSize = true;
            this.Symbol2.BackColor = System.Drawing.Color.Transparent;
            this.Symbol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 70.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Symbol2.Location = new System.Drawing.Point(379, 223);
            this.Symbol2.Name = "Symbol2";
            this.Symbol2.Size = new System.Drawing.Size(133, 132);
            this.Symbol2.TabIndex = 7;
            this.Symbol2.Text = "B";
            // 
            // Symbol3
            // 
            this.Symbol3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Symbol3.AutoSize = true;
            this.Symbol3.BackColor = System.Drawing.Color.Transparent;
            this.Symbol3.Font = new System.Drawing.Font("Microsoft Sans Serif", 70.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Symbol3.ForeColor = System.Drawing.Color.Black;
            this.Symbol3.Location = new System.Drawing.Point(473, 223);
            this.Symbol3.Name = "Symbol3";
            this.Symbol3.Size = new System.Drawing.Size(139, 132);
            this.Symbol3.TabIndex = 8;
            this.Symbol3.Text = "C";
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NextCMS,
            this.BackCMS,
            this.RandomCMS});
            this.ContextMenuStrip.Name = "ContextMenuStrip";
            this.ContextMenuStrip.Size = new System.Drawing.Size(221, 76);
            this.ContextMenuStrip.Text = "Сгенерировать";
            // 
            // NextCMS
            // 
            this.NextCMS.Name = "NextCMS";
            this.NextCMS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NextCMS.Size = new System.Drawing.Size(220, 24);
            this.NextCMS.Text = "Следующий";
            // 
            // BackCMS
            // 
            this.BackCMS.Name = "BackCMS";
            this.BackCMS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.BackCMS.Size = new System.Drawing.Size(220, 24);
            this.BackCMS.Text = "Предыдущий";
            // 
            // RandomCMS
            // 
            this.RandomCMS.Name = "RandomCMS";
            this.RandomCMS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.RandomCMS.Size = new System.Drawing.Size(220, 24);
            this.RandomCMS.Text = "Рандомный";
            // 
            // RegionComboBox
            // 
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
            // 
            // PlateLabel
            // 
            this.PlateLabel.AutoSize = true;
            this.PlateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 70.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlateLabel.Location = new System.Drawing.Point(31, 77);
            this.PlateLabel.Name = "PlateLabel";
            this.PlateLabel.Size = new System.Drawing.Size(498, 134);
            this.PlateLabel.TabIndex = 9;
            this.PlateLabel.Text = "A123BC";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 551);
            this.Controls.Add(this.PlateLabel);
            this.Controls.Add(this.Symbol3);
            this.Controls.Add(this.Symbol2);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Symbol1);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.PlatePictureBox);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "Генератор Номерных Знаков - LPG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlatePictureBox)).EndInit();
            this.ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem GenerateTSMI;
        private System.Windows.Forms.ToolStripMenuItem NextTSMI;
        private System.Windows.Forms.ToolStripMenuItem BackTSMI;
        private System.Windows.Forms.ToolStripMenuItem RandomTSMI;
        private System.Windows.Forms.PictureBox PlatePictureBox;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label Symbol1;
        private System.Windows.Forms.Label Number1;
        private System.Windows.Forms.Label Number2;
        private System.Windows.Forms.Label Number3;
        private System.Windows.Forms.Label Symbol2;
        private System.Windows.Forms.Label Symbol3;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NextCMS;
        private System.Windows.Forms.ToolStripMenuItem BackCMS;
        private System.Windows.Forms.ToolStripMenuItem RandomCMS;
        private System.Windows.Forms.ToolStripComboBox RegionComboBox;
        private System.Windows.Forms.Label PlateLabel;
    }
}

