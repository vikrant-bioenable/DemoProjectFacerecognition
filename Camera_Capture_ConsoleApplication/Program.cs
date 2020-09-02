using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using FaceRecognitionDotNet;
using OpenCvSharp;
using System.Diagnostics;
using System.IO;

namespace Camera_Capture_ConsoleApplication
{
    [StructLayout(LayoutKind.Sequential)]


    internal class Program
    {
        private static FaceRecognition fr;
        public static string AppRootPath = AppDomain.CurrentDomain.BaseDirectory;


        static bool process = true;
        static void StartWithWhileLoop_only_Video_Show()
        {
            try
            {
                var videoCapture = new VideoCapture(0);
                while (true)
                {
                    try
                    {
                        var frame = videoCapture.RetrieveMat();
                        if (process)
                        {
                            Cv2.ImShow("Video Preview Window", frame);
                            Cv2.WaitKey(1);
                        }
                        process = !process;
                    }
                    catch (Exception ex)
                    {
                        loger.WriteLog("err", "Error inside While loop - " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                loger.WriteLog("err", "Error in StartWithWhileLoop - " + ex.Message);
            }
        }
        private static void Main(string[] args)
        {
            try
            {
                if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
                {                // Environment.Exit(0);
                    try
                    {
                        loger.WriteLog("sts", "In Main - close existing CaptureCameraConsole_P");
                        Process process1 = Process.GetProcessesByName("CaptureCameraConsole_P")[0];
                        loger.WriteLog("sts", process1.ToString());
                        process1.Kill();
                        loger.WriteLog("sts", "old porcess killed");
                    }
                    catch (Exception ex)
                    {
                        loger.WriteLog("err", "Error in closing existing instance of CaptureCameraConsole_P " + ex.Message);
                        System.Environment.Exit(0);
                    }
                }


                loger.WriteLog("sts", "CaptureCameraConsole_P Version - " + glob.ApplicationVersion);


                Console.WriteLine("Capture Camera Console Started..");
                loger.WriteLog("sts", "Capture Camera Console Started..");

                process = true;

                loger.WriteLog("sts", "Before Create models");
                fr = FaceRecognition.Create(AppRootPath + "\\models");
                loger.WriteLog("sts", "After Create models");

                StartWithWhileLoop_only_Video_Show(); //// this included head and shoulder count for reduce unauthorised person alert

               // _quitEvent.WaitOne();
            }
            catch (Exception ex)
            {
                loger.WriteLog("err", "Error in Main Method - " + ex.ToString());
                loger.WriteLog("err", "Error in Main Method - " + ex.Message);
            }
        }
    }
}
