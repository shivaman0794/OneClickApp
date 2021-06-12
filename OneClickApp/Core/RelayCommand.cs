using System;
using System.Windows.Input;

namespace OneClickApp.ViewModel
{
    public class RelayCommand : ICommand
    {
        Action<object> _execute;
        Func<object, bool> _canExecute;

        public RelayCommand(Action<object> execute, Func<object,bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged {

            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}