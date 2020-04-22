using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ArjMVVM.Framework
{
    public class RelayCommand : ICommand
    {
        private Action<object> _action;
        private Predicate<object> _predicate;
        private bool _canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> action) : this(action,null) // Note the default params in constructor!
        {
            _canExecute = true;
            _action = action;
        }
        /// <summary>
        /// Constructor taking 2 arguments
        /// </summary>
        /// <param name="action"></param>
        /// <param name="predicate"></param>
        public RelayCommand(Action<object> action, Predicate<object> predicate)
        {
            // Need to add sensible checks - is predicate valid??
            _canExecute = true;
            _action = action;
            _predicate = predicate;
        }
        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();
            return true; // Always returns TRUE - elementary code!
        }

        public void Execute(object parameter)
        {
            //throw new NotImplementedException();
            _action(parameter);
        }
    }
}
