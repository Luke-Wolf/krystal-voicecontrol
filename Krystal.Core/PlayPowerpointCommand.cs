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
using System.Linq;

namespace Krystal.Core
{
    /// <summary>
    /// Plays a powerpoint on the commands of "powerpoint" and "presentation".
    /// </summary>
    public class PlayPowerpointCommand: FileCommand,ICommand
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Krystal.Core.PlayPowerpointCommand"/> class.
        /// picks a random powerpoint to play from the user's My Documents Directory, recognizes
        /// "powerpoint" and "presentation"
        /// </summary>
        public PlayPowerpointCommand()
        {
            Commands= new List<String>(new [] {"powerpoint","presentation"});
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Krystal.Core.PlayPowerpointCommand"/> class.
        /// plays the powerpoint passed in by the path.  Recognizes "powerpoint" and "presentation"
        /// </summary>
        /// <param name="path">Path.</param>
        public PlayPowerpointCommand(String path):this()
        {
            CheckFileExists(path);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Krystal.Core.PlayPowerpointCommand"/> class.
        /// plays the powerpoint passed in by the path, and utilizes the commands passed in, it is
        /// recommended you use an anonymous type.
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="commands">Commands.</param>
        public PlayPowerpointCommand(String path, String[] commands)
        {
            CheckFileExists(path); 
            Commands.AddRange(commands);
        }
        #endregion

        #region Methods
        public override void Execute()
        {
            if(PlayPath == null)
            {
                var files = new List<String>(Directory.GetFiles(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)));

                //strain out the files that aren't powerpoints
                var temp = from file in files
                        where file.Contains(".pptx") || file.Contains(".ppt") || file.Contains(".odp")
                    select file;

                files = new List<String>(temp);
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

