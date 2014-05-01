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
using System.IO;
using System.Collections.Generic;

namespace Krystal.Core
{
    /// <summary>
    /// Plays a video on the command phrase of "video", "movie", and "action clip".
    /// </summary>
    public class PlayVideoCommand:FileCommand,ICommand
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Krystal.Core.PlayVideoCommand"/> class.
        /// picks a random powerpoint to play from the user's My Videos Directory, recognizes
        /// "video", "movie", and "action clip"
        /// </summary>
        public PlayVideoCommand()
        {
            Commands = new List<String>( new [] {"video","movie","action clip"});
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Krystal.Core.PlayVideoCommand"/> class.
        /// plays the video passed in by the path.  Recognizes "video", "movie", and "action clip"
        /// </summary>
        /// <param name="path">Path.</param>
        public PlayVideoCommand(String path) : this()
        {
            CheckFileExists(path);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Krystal.Core.PlayPowerpointCommand"/> class.
        /// plays the video passed in by the path, and utilizes the commands passed in, it is
        /// recommended you use an anonymous type.
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="commands">Commands.</param>
        public PlayVideoCommand(String path, String[] commands)
        {
            CheckFileExists(path);
            Commands.AddRange(commands);
        }
        #endregion
        #region Methods
        public override void Execute()
        {
            if (PlayPath == null)
            {
                List<String> files = new List<String>(Directory.GetFiles(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)));
                ExecuteRandomFile(files);
            }
            else
            {
                Execute(PlayPath);
            }
        }
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

