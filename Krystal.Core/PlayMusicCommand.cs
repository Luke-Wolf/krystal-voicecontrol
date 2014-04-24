//
//  Copyright 2014  Luke
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

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

