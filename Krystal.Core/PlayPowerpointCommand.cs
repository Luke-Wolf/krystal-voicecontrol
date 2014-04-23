using System;
using System.Collections.Generic;

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

        }
        public void Execute(String command)
        {

        }
        #endregion
        #region Properties
        #endregion
    }
}

