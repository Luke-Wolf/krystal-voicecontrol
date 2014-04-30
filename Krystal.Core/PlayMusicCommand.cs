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
using System.Linq;



namespace Krystal.Core
{
    /// <summary>
    /// Play music command.
    /// </summary>
    public class PlayMusicCommand : ICommand
    {
        #region Variables
        Random randGen = new Random();
        #endregion
        #region Constructors
        public PlayMusicCommand()
        {
            Commands.AddRange(new [] {"music","sound"});
        }
        public bool CanExecute (String command)
        {
            //implement a check to see if a command will work
            return true;
        }

        public void Execute()
        {
            Execute("");
        }
        /// <summary>
        /// Execute the specified command.
        /// </summary>
        /// <param name="command">Music File must be in .wav Format</param>
        public void Execute(String command)
        {
            var files = new List<String>(Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)));
            if (command == "")
            {

                int rand = randGen.Next(files.Count);
                var player = new SoundPlayer(files[rand]);
                player.Play();
            }
            else
            {
                var items = from item in files where item.Contains(command) select item;
                foreach(string item in items)
                {
                    var player = new SoundPlayer(item);
                    player.Play();
                }

            }
        }
        #endregion
        #region Methods
        #endregion
        #region Properties
        public List<String> Commands
        {
            get;
            set;
        }
        #endregion
    }
}

