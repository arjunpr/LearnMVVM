using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Worlds_Simplest.VM
{
    public class DelegateCommand : ICommand
    {
        private readonly Action _action;
#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67

        public DelegateCommand(Action action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action();
        }
    }
}
