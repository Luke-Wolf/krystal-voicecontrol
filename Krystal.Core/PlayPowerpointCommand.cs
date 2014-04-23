using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Krystal.Core
{
    public class PlayPowerpointCommand: ICommand
    {
        #region Constructors
        public PlayPowerpointCommand()
        {
        }
        #endregion
        #region Methods
        public bool CanExecute(String command)
        {
            return true;
        }

        public void Execute()
        {
            Process.Start();
        }
        public void Execute(String command)
        {
            Execute();
        }
        #endregion
        #region Properties
        #endregion
    }
}

