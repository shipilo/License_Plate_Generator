
namespace License_Plate_Generator
{
    partial class Form1
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.GenerateTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.NextTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.BackTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PlatePictureBox = new System.Windows.Forms.PictureBox();
            this.ColorButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlatePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateTSMI});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(782, 30);
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
            this.GenerateTSMI.Size = new System.Drawing.Size(129, 26);
            this.GenerateTSMI.Text = "Сгенерировать";
            // 
            // NextTSMI
            // 
            this.NextTSMI.Name = "NextTSMI";
            this.NextTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NextTSMI.Size = new System.Drawing.Size(234, 26);
            this.NextTSMI.Text = "Следующий";
            // 
            // BackTSMI
            // 
            this.BackTSMI.Name = "BackTSMI";
            this.BackTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.BackTSMI.Size = new System.Drawing.Size(234, 26);
            this.BackTSMI.Text = "Предыдущий";
            // 
            // RandomTSMI
            // 
            this.RandomTSMI.Name = "RandomTSMI";
            this.RandomTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.RandomTSMI.Size = new System.Drawing.Size(234, 26);
            this.RandomTSMI.Text = "Рандомный";
            // 
            // PlatePictureBox
            // 
            this.PlatePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlatePictureBox.Image = global::License_Plate_Generator.Properties.Resources.sample;
            this.PlatePictureBox.Location = new System.Drawing.Point(0, 30);
            this.PlatePictureBox.Name = "PlatePictureBox";
            this.PlatePictureBox.Size = new System.Drawing.Size(782, 521);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 551);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.PlatePictureBox);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "Генератор Номерных Знаков - LPG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlatePictureBox)).EndInit();
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
    }
}

