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
using System.Web;
using System.Xml;
using Newtonsoft.Json;

namespace VK__V2_
{
    public partial class Authorization : Form
    {

        public Authorization()
        {
            InitializeComponent();
            
        }
        public static string acces_token;//получено
        public static string Token_url;//получено
        public static string email;//получено
        public static string name;
        public static string Phone;
        public static string work;
        public static string status;
        public static Uri photo;
        public static string about;
        public static string id_user;//получено
        public static string Info;




        private void button1_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            String values;
            String[] urlArray = new string[20];
            String value = Token_url;
            Char[] razdelitel = { ' ', ',', '=', '/', '\t', '#', '&', ':' };
            String[] parse = value.Split(razdelitel);
            foreach (var substring in parse)
            {
                i++;
                values = substring;// здесь мы получаем первую часть
                urlArray[i] = values; //присваиваем ту часть которую мы парсили элементу массива по индексу
                Console.WriteLine(values + " " + i); // выводим данную строку
            }

            acces_token = urlArray[7];
            email = urlArray[13];
            id_user = urlArray[11];


            var req = new HttpRequest();
            string resp = req.Get("https://api.vk.com/method/users.get?user_ids=" + id_user + "&fields=first_name,last_name,career,about,status,photo_max,contacts&access_token=" + acces_token + "&v=5.74").ToString();
            JObject o = JObject.Parse(resp);
            JArray array = (JArray)o["response"];
            vkResponse v = JsonConvert.DeserializeObject<vkResponse>(array.First().ToString());
            name =  v.FirstName+ "  " + v.LastName;
            photo = v.Photo_max;
            status = v.status;
            about = v.about;
            Phone = v.mobile_phone;


            Main Main = new Main();
            {
               
                this.Hide();
                Main.ShowDialog();
                this.Show();
                Close();


            }



        }

        



        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
            {
            Token_url = webBrowser1.Url.ToString();
            
        }
        private void test_Load(object sender, EventArgs e)
        {
            
            
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            webBrowser1.Navigate("http://oauth.vk.com/authorize?client_id=6473960&redirect_uri=https://oauth.vk.com/blank.html&display=page&scope=photos,pages,messages,status,wall,stats,email,offline&response_type=token&v=5.76");
            ProxyForWeb.WinInetHelper.SupressCookiePersist();

        }
    }
}