using System;
using System.Windows.Input;

namespace EntityManager
{
    public class RelayCommand : ICommand
    {
        private readonly Action mAction;

        public event EventHandler? CanExecuteChanged = (sender, e) => { };

        public RelayCommand(Action action)
        {
            mAction = action;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            mAction();
        }
    }
}
