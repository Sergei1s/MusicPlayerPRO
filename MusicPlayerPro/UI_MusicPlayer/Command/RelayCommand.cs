using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace UI_MusicPlayer.Command
{
    public class RelayCommand : ICommand
    {
        readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        public RelayCommand(Predicate<object> canExecute, Action<object> execute)
        {
            if (execute == null)
            {
                throw new NullReferenceException();
            }
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
