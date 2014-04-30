using System;
using System.Collections.Generic;

namespace Krystal.Core
{
    public class Controller
    {

        #region Constructors
        public Controller()
        {
            Commands.AddRange(new ICommand[] {new PlayMusicCommand(),
                new PlayPowerpointCommand(),new PlayVideoCommand()});        
        }
        public Controller(ICommand[] commands)
        {
            Commands.AddRange(commands);
        }
        #endregion
        #region Methods
        public void Execute(String command)
        {
            command = command.ToLower();
            foreach(ICommand item in Commands)
            {
                foreach(string commandString in item.Commands)
                {
                    if(commandString.Contains(command))
                    {
                        item.Execute();
                        return;
                    }
                }
            }
        }
        #endregion
        #region Properties
        List<ICommand> Commands{ get; set;}
        #endregion
    }
}

