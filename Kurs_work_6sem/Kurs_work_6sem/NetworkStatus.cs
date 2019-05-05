using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_work_6sem
{
    class NetworkStatus
    {
        // Получение имени компьютера.
        static String host = System.Net.Dns.GetHostName();

        // Получение ip-адреса.
        readonly System.Net.IPAddress ip = System.Net.Dns.GetHostByName(host).AddressList[0];
        // Показ адреса в label'е.
       
    }
}
