using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK__V2_
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public static Image Background;
        public static Uri BackgroundUrl;
        public static Color ColorFont;



        private void button3_Click(object sender, EventArgs e)
        {
            Authorization Authorization = new Authorization();
            {

                this.Hide();
                Authorization.ShowDialog();
                this.Show();
                Close();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog BackFile = new OpenFileDialog();
            BackgroundSample.SizeMode = PictureBoxSizeMode.StretchImage;
            if (BackFile.ShowDialog(this) == DialogResult.OK)
                BackgroundSample.Image = Image.FromFile(BackFile.FileName);

        }

        private void Settings_Load(object sender, EventArgs e)
        {
        }

        private void Complete_izmeneniuja_Click(object sender, EventArgs e)
        {
            Background = BackgroundSample.Image;
            Main Main = new Main();
            {

                this.Hide();
                Main.ShowDialog();
                Close();



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Background = null;
            ColorFont = Color.Black;
            Main Main = new Main();
            {

                this.Hide();
                Main.ShowDialog();
                this.Show();
                Close();


            }

        }

        private void UrlBackground_TextChanged(object sender, EventArgs e)
        {

        }

        private void ColorBackground_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = comboBox1.SelectedItem;
            string test = Convert.ToString(selectedItem);


            switch (test)
            {
                case "Black":
                    ColorFont = Color.Black; 
                    break;
                case "Red":
                    ColorFont = Color.Red; 
                    break;
                case "Blue":
                    ColorFont = Color.Blue;
                    break;
                case "Green":
                    ColorFont = Color.Green;
                    break;
                case "Gold":
                    ColorFont = Color.Gold; 
                    break;
                case "Indigo":
                    ColorFont = Color.Indigo;
                    break;
                case "Orchid":
                    ColorFont = Color.Orchid;
                    break;





                    
            }
        }
    }
}
