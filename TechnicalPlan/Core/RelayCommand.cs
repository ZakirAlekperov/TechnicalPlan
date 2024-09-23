using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TechnicalPlan.Core
{
    /// <summary>
    /// Реализация ICommand для связывания действий с методами в ViewModel.
    /// </summary>
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        /// <summary>
        /// Создает новый экземпляр RelayCommand.
        /// </summary>
        /// <param name="execute">Метод, который будет выполняться при вызове команды.</param>
        /// <param name="canExecute">Метод, который определяет доступность команды.</param>
        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        /// <summary>
        /// Указывает, может ли команда быть выполнена.
        /// </summary>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute();
        }

        /// <summary>
        /// Выполняет команду.
        /// </summary>
        public void Execute(object parameter)
        {
            _execute();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Вызывает событие CanExecuteChanged для обновления состояния UI.
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }
    }
}
