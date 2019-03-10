using System;
using System.Windows.Input;

// This is a basic implementation of the ICommand interface.
namespace Unbound.ViewModels
{
    public class MapCommand : ICommand
    {
        private readonly Action _task;
        public event EventHandler CanExecuteChanged;

        public MapCommand(Action task)
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
