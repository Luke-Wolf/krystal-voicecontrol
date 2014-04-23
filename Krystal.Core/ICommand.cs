using System;

namespace Krystal.Core
{
    public interface ICommand
    {
        void Execute(String command);
        bool CanExecute(String command);
    }
}

