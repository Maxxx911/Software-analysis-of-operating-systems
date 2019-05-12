using System.Collections.Generic;

namespace Kurs_work_6sem.Models
{
    public class SystemInfo
    {
        public string OSVersion { get; set; }
        public string ProcessorArchitecture { get; set; }
        public string ProcessorModel { get; set; }
        public string SystemDirectory { get; set; }
        public int ProcessorCount { get; set; }
        public string UserName { get; set; }
        public List<DiskInfo> DisksInfo = new List<DiskInfo>();
        public List<VideoCardInfo> VideoCard = new List<VideoCardInfo>();
        public NetworkInfo NetworkInfo = new NetworkInfo();
    }
}
