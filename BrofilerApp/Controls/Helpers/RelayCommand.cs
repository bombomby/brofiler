﻿using System;
using System.Windows.Input; //ICommand


namespace Profiler.Controls.Helpers
{
    class RelayCommand : ICommand 
    {
        public Predicate<object> CanExecuteDelegate { get; set; }
        public Action<object> ExecuteDelegate { get; set; }

        public RelayCommand(Action<object> action, Predicate<Object> predicate)
        {
            ExecuteDelegate = action;
            CanExecuteDelegate = predicate;
        }
        public RelayCommand(Action<object> action) 
            : this(action, null)
        {
        }
        //Implement ICommand interface
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if(CanExecuteDelegate != null)
            {
              return  CanExecuteDelegate(parameter);
            }
            return true;
        }

        
        public void Execute(object parameter)
        {
            if (ExecuteDelegate != null)
                ExecuteDelegate(parameter); 
        }
    }
}
