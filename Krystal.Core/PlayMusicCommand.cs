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
    /// Plays Music on the command of "Music" or "Sound"
    /// </summary>
    public class PlayMusicCommand : ICommand
    {
        #region Variables
        Random randGen = new Random();
        string playPath;
        #endregion
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Krystal.Core.PlayMusicCommand"/> class.
        /// 
        /// </summary>
        public PlayMusicCommand()
        {
            Commands.AddRange(new [] {"music","sound"});
        }
        public PlayMusicCommand(String path):this()
        {
            playPath = path;
        }
        public PlayMusicCommand(String path, String[] commands)
        {
            playPath = path; 
            Commands.AddRange(commands);
        }


        #endregion
        #region Methods
        #region Public
        public void Execute()
        {
            if(playPath == null)
            {
                var files = new List<String>(Directory.GetFiles(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)));
                int rand = randGen.Next(files.Count);
                Execute(files[rand]);
            }
            else
            {
                Execute(playPath);
            }
        }
        #endregion
        #region Private
        static void Execute(String path)
        {
            var player = new SoundPlayer(path);
            player.Play();
        }
        #endregion
        #endregion
        #region Properties
        public List<String> Commands
        {
            get;
            private set;
        }
        #endregion
    }
}

