using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using xNet;
using System.Net;
using System.IO;
using System.Drawing.Printing;

namespace VK__V2_
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            //CaptureScreen();
            //printDocument2.Print();
            
        }
        //Bitmap memoryImage;

/*
private void CaptureScreen()
{
    var source = this.Location;
    var destination = this.Location;
    Graphics myGraphics = this.CreateGraphics();
    Size size = this.Size;
    memoryImage = new Bitmap(size.Width, size.Height, myGraphics);
    Graphics memoryGraphics = Graphics.FromImage(memoryImage);
    memoryGraphics.CopyFromScreen(source, destination, size);
}
*/

private void panel1_Paint(object sender, PaintEventArgs e)
{
    panel1.ForeColor = Settings.ColorFont;
    panel1.BackgroundImage = Settings.Background;
    name.Text = Authorization.name;
    status.Text = Authorization.status;
    About.Text = Authorization.about;
    Phone.Text = Authorization.Phone;
    pictureBox1.ImageLocation = Convert.ToString(Authorization.photo);
    Email.Text = Authorization.email;

}

private void Main_Load(object sender, EventArgs e)
{
            panel1.BackgroundImage = null;
            name.Text = null;
            status.Text = null;
            About.Text = null;
            Phone.Text = null;
            pictureBox1.ImageLocation = null;
            Email.Text = null;

  }

private void token_TextChanged(object sender, EventArgs e)
{

}

private void richTextBox1_TextChanged(object sender, EventArgs e)
{

}

private void pictureBox1_Click(object sender, EventArgs e)
{

}

private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
{

      // e.Graphics.DrawImage(memoryImage, 0, 0);

}

private void printPreviewDialog1_Load(object sender, EventArgs e)
{

}

        private void button1_Click_1(object sender, EventArgs e)
        {

            Settings Settings = new Settings();
            {

                this.Hide();
                Settings.ShowDialog();
                Close();


            }
        }
    }
}
