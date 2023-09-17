using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CocoaLib.ViewModel
{
    class ViewModelCommand : ICommand
    {
        #region Fields
        public Action<object>? ActionCommand { get; set; }
        public Predicate<object>? CanExecuteCommand { get; set; } = null;
        #endregion

        #region ctors
        /// <summary>
        /// 均有输入的情况
        /// </summary>
        /// <param name="_actionCommand"></param>
        /// <param name="_canExecuteCommand"></param>
        public ViewModelCommand(Action<object> _actionCommand, Predicate<object> _canExecuteCommand)
        {
            ActionCommand = _actionCommand;
            CanExecuteCommand = _canExecuteCommand;
        }

        /// <summary>
        /// 妹有判断是否可执行的情况
        /// </summary>
        /// <param name="_actionCommand"></param>
        public ViewModelCommand(Action<object> _actionCommand)
        {
            ActionCommand = _actionCommand;
            CanExecuteCommand = (object obj) => { return true; };
        }
        #endregion

        #region CanExecuteChanged
        /// <summary>
        /// 在有改变时通知所有命令源重新查询(re-query)CanExecute
        /// </summary>
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        #endregion

        #region Methods
        public bool CanExecute(object? parameter) => CanExecuteCommand(parameter);

        public void Execute(object? parameter) => ActionCommand(parameter);
        #endregion
    }
}
