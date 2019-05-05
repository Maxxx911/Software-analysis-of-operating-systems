using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_work_6sem
{
    static class PCStatus
    {
        public static void ShowSystemInfo()
        {
            Console.WriteLine("Операционная система (номер версии):  {0}", Environment.OSVersion);
            Console.WriteLine("Разрядность процессора:  {0}", Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE"));
            Console.WriteLine("Модель процессора:  {0}", Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER"));
            Console.WriteLine("Путь к системному каталогу:  {0}", Environment.SystemDirectory);
            Console.WriteLine("Число процессоров:  {0}", Environment.ProcessorCount);
            Console.WriteLine("Имя пользователя: {0}", Environment.UserName);
            // Локальные диски
            Console.WriteLine("Локальные диски: ");
            foreach (DriveInfo dI in DriveInfo.GetDrives())
            {
                Console.Write(
                      "\t Диск: {0}\n\t" +
                      " Формат диска: {1}\n\t " +
                      "Размер диска (ГБ): {2}\n\t Доступное свободное место (ГБ): {3}\n",
                      dI.Name, dI.DriveFormat, (double)dI.TotalSize / 1024 / 1024 / 1024, (double)dI.AvailableFreeSpace / 1024 / 1024 / 1024);
                Console.WriteLine();
            }
        }
    }
}
