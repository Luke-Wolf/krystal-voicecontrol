using System;

namespace Krystal.Core
{
    public class PlayVideoCommand:ICommand
    {
        #region Constructors
        public PlayVideoCommand()
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

