using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Capture_ConsoleApplication
{
    class EmpDetails
    {
        [JsonProperty("companyname")]
        public string companyname { get; set; }

        [JsonProperty("empid")]
        public string empid { get; set; }

        [JsonProperty("macid")]
        public string macid { get; set; }

        [JsonProperty("filename")]
        public string filename { get; set; }

        [JsonProperty("datetime")]
        public string datetime { get; set; }

        [JsonProperty("alert1")]
        public string alert1 { get; set; }

        [JsonProperty("alert2")]
        public string alert2 { get; set; }

        [JsonProperty("alert3")]
        public string alert3 { get; set; }

        [JsonProperty("alert4")]
        public string alert4 { get; set; }

        [JsonProperty("alert5")]
        public string alert5 { get; set; }

        [JsonProperty("alert6")]
        public string alert6 { get; set; }


        [JsonProperty("alert7")]
        public string alert7 { get; set; }

        [JsonProperty("blurness")]
        public string blurness { get; set; }
    }
}
