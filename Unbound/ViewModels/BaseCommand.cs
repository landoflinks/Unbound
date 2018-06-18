using System;
using System.Windows.Input;

namespace Unbound.ViewModels
{
    class BaseCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action _task;

        public BaseCommand(Action task)
        {
            _task = task;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _task();
        }
    }
}
