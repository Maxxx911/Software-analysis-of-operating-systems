using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Kurs_work_6sem.Models
{
    public class SystemInfo:  INotifyPropertyChanged
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

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
