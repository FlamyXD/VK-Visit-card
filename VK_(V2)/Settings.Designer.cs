namespace VK__V2_
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Complete_izmeneniuja = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Account_smenit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.BackgroundSample = new System.Windows.Forms.PictureBox();
            this.TakeImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundSample)).BeginInit();
            this.SuspendLayout();
            // 
            // Complete_izmeneniuja
            // 
            this.Complete_izmeneniuja.Location = new System.Drawing.Point(41, 321);
            this.Complete_izmeneniuja.Name = "Complete_izmeneniuja";
            this.Complete_izmeneniuja.Size = new System.Drawing.Size(132, 31);
            this.Complete_izmeneniuja.TabIndex = 1;
            this.Complete_izmeneniuja.Text = "Применить изменения";
            this.Complete_izmeneniuja.UseVisualStyleBackColor = true;
            this.Complete_izmeneniuja.Click += new System.EventHandler(this.Complete_izmeneniuja_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Account_smenit
            // 
            this.Account_smenit.Location = new System.Drawing.Point(113, 368);
            this.Account_smenit.Name = "Account_smenit";
            this.Account_smenit.Size = new System.Drawing.Size(171, 31);
            this.Account_smenit.TabIndex = 6;
            this.Account_smenit.Text = "Сменить акаунт";
            this.Account_smenit.UseVisualStyleBackColor = true;
            this.Account_smenit.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.BackgroundSample);
            this.panel1.Controls.Add(this.TakeImage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 291);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Цвет текста";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "Green",
            "Gold",
            "Indigo",
            "Orchid"});
            this.comboBox1.Location = new System.Drawing.Point(164, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(408, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(8, 8);
            this.button4.TabIndex = 11;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BackgroundSample
            // 
            this.BackgroundSample.Location = new System.Drawing.Point(48, 61);
            this.BackgroundSample.Name = "BackgroundSample";
            this.BackgroundSample.Size = new System.Drawing.Size(280, 161);
            this.BackgroundSample.TabIndex = 8;
            this.BackgroundSample.TabStop = false;
            // 
            // TakeImage
            // 
            this.TakeImage.Location = new System.Drawing.Point(164, 22);
            this.TakeImage.Name = "TakeImage";
            this.TakeImage.Size = new System.Drawing.Size(164, 23);
            this.TakeImage.TabIndex = 7;
            this.TakeImage.Text = "Выбрать фон";
            this.TakeImage.UseVisualStyleBackColor = true;
            this.TakeImage.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фон визитки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сбросить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Account_smenit);
            this.Controls.Add(this.Complete_izmeneniuja);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundSample)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Complete_izmeneniuja;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Account_smenit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BackgroundSample;
        private System.Windows.Forms.Button TakeImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}