using System;
using System.Collections.Generic;
using System.IO;
using Kurs_work_6sem.Models;
using System.Management;

namespace Kurs_work_6sem
{
    internal static class PCStatus
    {
        private static List<string> GetHardwareInfo(string WIN32_Class, string ClassItemField)
        {
            List<string> result = new List<string>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);
            foreach (ManagementObject obj in searcher.Get())
            {
                result.Add(obj[ClassItemField].ToString().Trim());
            }
            return result;
        }

        private static void AddFieldToVideoCard(List<string> res, VideoCardInfo card1, VideoCardInfo card2, string field )
        {
            switch (field)
            {
                case "VideoName":
                    card1.VideoName = res[0];
                    if (res.Count == 2)
                        card2.VideoName = res[1];
                    break;
                case "VideoType":
                    card1.VideoType = res[0];
                    if (res.Count == 2)
                        card2.VideoType = res[1];
                    break;
                case "VideoVersion":
                    card1.VideoVersion = res[0];
                    if (res.Count == 2)
                        card2.VideoVersion = res[1];
                    break;
                case "VideoSize":
                    card1.VideoSize = Convert.ToDouble( res[0]) / 1024 / 1024;
                    if (res.Count == 2)
                        card2.VideoSize = Convert.ToDouble(res[1]) / 1024 / 1024;
                    break;
            }
           
        }

        private static void AddProcessorInfo()
        {
            MainWindow.SystemInfo.OSVersion = Convert.ToString(Environment.OSVersion);
            MainWindow.SystemInfo.ProcessorArchitecture = Convert.ToString(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE"));
            string PROCESSOR = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");
            string[] fieldProcessor = PROCESSOR.Split(',');
            MainWindow.SystemInfo.ProcessorModel = fieldProcessor[0];
            MainWindow.SystemInfo.SystemDirectory = Convert.ToString(Environment.SystemDirectory);
            MainWindow.SystemInfo.ProcessorCount = Convert.ToInt32(Environment.ProcessorCount);
            MainWindow.SystemInfo.UserName = Convert.ToString(Environment.UserName);
        }

        public static void ShowSystemInfo()
        {
            AddProcessorInfo();
            VideoCardInfo card1 = new VideoCardInfo();
            VideoCardInfo card2 = new VideoCardInfo();
      
            List<string> res = GetHardwareInfo("Win32_VideoController", "Name");
            AddFieldToVideoCard(res, card1, card2, "VideoName");
            res = GetHardwareInfo("Win32_VideoController", "VideoProcessor");
            AddFieldToVideoCard(res, card1, card2, "VideoType");
            res = GetHardwareInfo("Win32_VideoController", "DriverVersion");
            AddFieldToVideoCard(res, card1, card2, "VideoVersion");
            res = GetHardwareInfo("Win32_VideoController", "AdapterRAM");
            AddFieldToVideoCard(res, card1, card2, "VideoSize");
            MainWindow.SystemInfo.VideoCard.Add(card1);
            MainWindow.SystemInfo.VideoCard.Add(card2);
        }
    }
}
