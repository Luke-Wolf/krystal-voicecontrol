using System;
using System.Collections.Generic;
using System.IO;
using System.Media;



namespace Krystal.Core
{
    /// <summary>
    /// Play music command.
    /// </summary>
    public class PlayMusicCommand : ICommand
    {
        #region Constructors
        public PlayMusicCommand()
        {
        }
        public bool CanExecute (String command)
        {
            //implement a check to see if a command will work
            return true;
        }

        public void Execute()
        {

        }
        /// <summary>
        /// Execute the specified command.
        /// </summary>
        /// <param name="command">Music File must be in .wav Format</param>
        public void Execute(String command)
        {
            List<String> files = new List<String>(Directory.GetFiles("Music/"));
            if (command == "")
            {
                int rand = System.Random % files.Count;
                SoundPlayer player = new SoundPlayer(files[rand]);
                player.Play();
            }
            else
            {

            }
        }
        #endregion
        #region Methods
        #endregion
        #region Properties
        public List<String> CommandPrefaces
        {
            get;
            set;
        }
        #endregion
    }
}

