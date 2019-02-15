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
    class vkResponse
    {
       
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "photo_max")]
        public Uri Photo_max { get; set; }

        [JsonProperty(PropertyName = "mobile_phone")]
        public string mobile_phone { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string status { get; set; }

        [JsonProperty(PropertyName = "about")]
        public string about { get; set; }



    }
    

}
