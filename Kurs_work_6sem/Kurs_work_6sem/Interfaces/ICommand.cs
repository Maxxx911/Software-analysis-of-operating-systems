using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_work_6sem.Interfaces
{
    interface ICommand
    {
       void RelayCommand(Action<object> execute, Func<object, bool> canExecute = null);
    }
}
