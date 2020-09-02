﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Capture_ConsoleApplication
{
    class loger
    {
        public static string PathSeparator = "\\";
        public static void WriteLog(string logtype, string log)
        {
            try
            {
                if (logtype == "sts")
                {
                    //string text0 = Application.StartupPath + "\\Logs";
                    string text0 = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\Camera_Capture_ConsoleApplication";

                    string str0 = PathSeparator + DateTime.Now.ToString("yyyyMMddHH") + ".txt";
                    if (!Directory.Exists(text0))
                    {
                        Directory.CreateDirectory(text0);
                    }
                    File.AppendAllText(text0 + str0, Environment.NewLine + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\t" + "Status" + "\t" + log);
                    return;
                }

                if (logtype == "err")
                {
                    //string text = Path.GetTempPath() + "NitgenClientService_Log";
                    //string text1 = Application.StartupPath + "\\Logs";
                    string text1 = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\Face_Form";

                    string str1 = PathSeparator + DateTime.Now.ToString("yyyyMMddHH") + ".txt";
                    if (!Directory.Exists(text1))
                    {
                        Directory.CreateDirectory(text1);
                    }
                    File.AppendAllText(text1 + str1, Environment.NewLine + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\t" + "Error" + "\t" + log);
                    return;
                }
            }
            catch
            {
            }
        }
    }
}
