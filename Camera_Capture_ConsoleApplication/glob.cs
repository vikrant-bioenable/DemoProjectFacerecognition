using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Capture_ConsoleApplication
{
    class glob
    {
        public static string ApplicationVersion = "1.0.4";


        public static string Save_webcamImg_On_Success_Alert_Interval_In_Sec = "60";
        public static string New_Alerts_URL = "https://apps.bioenabletech.com/api/upload_service.php";

        public static string Show_Video = "false";

        public static Response StartResponse;
        public static string CaptureInterval = "10";//sec
        public static string ImageUploadInterval = "10";//sec

        public static string monitoring = "";
        public static string post_screenshot_enabled = "";
        public static string take_local_screenshot_backup = "";
        public static string capture_interval = "";
        public static string camera_capture_interval = "10";

        public static string snapshot_post_interval = "";

        public static string url_to_upload_snap = "";
        public static string url_to_post_logs = "";
        public static string snap_matching_threshhold = "";
        public static string url_to_upload_webcam_img = "";
        //   public static string url_to_post_alerts = "";
        public static string photo_matching_threshold = "0.50";

        public static string webcam_capture = "";
        public static string screen_capture = "";
        public static string url_to_upload_photo = "";





        public static string Screenlock_on_multi_faces_Enable = "1";
        public static string Screenlock_on_no_one_infront_of_screen_Enable = "0";
        public static string Screenlock_on_Unauthorised_access_Enable = "0";
        public static string Screenlock_on_Camera_feed_not_available = "0";
        public static string Screenlock_on_FakeFace_detected = "0";






        //public static string Screenlock_sound_play= "false";
        //public static string Respond_to_alerts_from_server= "false";
        //public static string Respond_to_alerts_from_server_Screenlock_on= "false";
        //public static string Respond_to_alerts_from_server_sound_play= "false";
        public static string Web_Camera_Alrets_URL = "https://apps.bioenabletech.com/alert_service.php";

        //// Vikrant made changes
        public static string Threshold_in_sec_to_restric_repeated_alerts_success = "60";        ///
        public static string Threshold_in_sec_to_restric_repeated_alerts_Unauthorised_access = "60";
        public static string Threshold_in_sec_to_restric_repeated_alerts_no_one_infront_of_screen = "600";
        public static string Threshold_in_sec_to_restric_repeated_alerts_for_multi_faces = "60";
        public static string Threshold_in_sec_to_restric_repeated_alerts_Camera_Feed_not_available = "60";
        public static string Threshold_in_sec_to_restric_repeated_alerts_Fake_Face = "60";







        public static string Multifaces_check_enabled = "1";
        public static string NoOneInfrontofScreen_check_enabled = "1";
        public static string Unauthorise_check_enabled = "1";
        public static string CameraFeedNotAvailable_Check_enable = "1";
        public static string FakeFace_check_enabled = "0";

        public static string single_image_check = "1";








        //// setting values not from WebApi

        public static string Company = "";
        public static string Department = "";
        public static string Emp_ID = "";
        public static string Email_ID = "";
        public static string Dev_ID = "NEW_WFH";
        public static string Timer_For_Posting_Logs = "";
        public static string MacAddress = "";
        public static string Camera_Name = "HP TrueVision HD";
        public static string Video_Size = "Default";
        public static string VideoClipEnable = "false";


    }
}
