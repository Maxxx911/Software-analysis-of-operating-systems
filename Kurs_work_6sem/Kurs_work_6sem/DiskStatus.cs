using Kurs_work_6sem.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Kurs_work_6sem
{
    public static class DiskStatus
    {
        public static List<DiskInfo> Show()
        {
            List<DiskInfo> diskInfos = new List<DiskInfo>();
            foreach (DriveInfo dI in DriveInfo.GetDrives())
            {
                diskInfos.Add(
                    new DiskInfo
                    {
                        DiskName = Convert.ToString(dI.Name),
                        DiskFormat = Convert.ToString(dI.DriveFormat),
                        DiskSize = Convert.ToDouble(dI.TotalSize / 1024 / 1024 / 1024),
                        DiskAvailableFreeSpace = Convert.ToDouble(dI.AvailableFreeSpace / 1024 / 1024 / 1024),
                    });
            }
            return diskInfos;
        }
    }
}
