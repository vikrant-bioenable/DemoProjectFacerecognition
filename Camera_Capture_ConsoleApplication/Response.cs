using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Capture_ConsoleApplication
{
    class Response
    {
        [JsonProperty("monitoring")]
        public string monitoring { get; set; }

        [JsonProperty("post_screenshot_enabled")]
        public string post_screenshot_enabled { get; set; }

        [JsonProperty("take_local_screenshot_backup")]
        public string take_local_screenshot_backup { get; set; }

        [JsonProperty("capture_interval")]
        public string capture_interval { get; set; }

        [JsonProperty("snapshot_post_interval")]
        public string snapshot_post_interval { get; set; }

        [JsonProperty("url_to_upload_snap")]
        public string url_to_upload_snap { get; set; }

        [JsonProperty("url_to_post_logs")]
        public string url_to_post_logs { get; set; }

        [JsonProperty("snap_matching_threshhold")]
        public string snap_matching_threshhold { get; set; }

        [JsonProperty("url_to_upload_webcam_img")]
        public string url_to_upload_webcam_img { get; set; }

        //[JsonProperty("url_to_post_alerts")]
        //public string url_to_post_alerts { get; set; }

        [JsonProperty("photo_matching_threshold")]
        public string photo_matching_threshold { get; set; }


        [JsonProperty("webcam_capture")]
        public string webcam_capture { get; set; }

        [JsonProperty("screen_capture")]
        public string screen_capture { get; set; }

        [JsonProperty("url_to_upload_photo")]
        public string url_to_upload_photo { get; set; }
    }

}
