using Kurs_work_6sem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_work_6sem
{
    static class NetworkStatus
    {
        // Получение имени компьютера.
        static String host = System.Net.Dns.GetHostName();

        // Получение ip-адреса.
       
        // Показ адреса в label'е.
        static public NetworkInfo Show()
        {
            NetworkInfo networkInfo = new NetworkInfo();
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress[] addr = ipEntry.AddressList;
                if (addr.Length == 2)
                {
                    networkInfo.IPv6Adress = addr[0].ToString();
                    networkInfo.IPv4Adress = addr[1].ToString();
                }
                else
                {
                    networkInfo.IPv4Adress = addr[0].ToString();
                }
                
            }
            return networkInfo;
        }

    }
}
