using System;
using System.Collections.Generic;

namespace Krystal.Core
{
    /// <summary>
    /// Handles the business logic of calling various commands in a generic manner using the ICommand interface
    /// </summary>
    public class Controller
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Krystal.Core.Controller"/> class.
        /// provides sane default commands of Playing random: Music, Powerpoints, or Video files
        /// if you want different behavior utilize the ICommand[] variant
        /// </summary>
        public Controller()
        {
            Commands.AddRange(new ICommand[] {new PlayMusicCommand(),
                new PlayPowerpointCommand(),new PlayVideoCommand()});        
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Krystal.Core.Controller"/> class.
        /// allows user to pass in their own set of commands to plug into the controller.
        /// </summary>
        /// <param name="commands">
        /// a list of commands the suggested way to use this paramter
        /// is to use an anonymous type
        /// </param>
        public Controller(ICommand[] commands)
        {
            Commands = new List<ICommand>(commands);
        }
        #endregion
        #region Methods
        /// <summary>
        /// Execute the specified command.
        /// </summary>
        /// <param name="command">
        /// A string that is checked against the phrases the commands
        /// are listening to
        /// </param>
        public void Execute(String command)
        {
            //ensure that commands are in a form to be recognized
            command = command.ToLower();

            //check to see if any of the commands recognize the command string
            //if so execute that command and then return
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
        /// <summary>
        /// A List of Commands, allows user to add or remove commands that are listening
        /// for a command word after instantiation
        /// </summary>
        /// <value>The commands.</value>
        List<ICommand> Commands{ get; set;}
        #endregion
    }
}

