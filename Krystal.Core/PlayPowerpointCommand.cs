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
using System.Diagnostics;

namespace Krystal.Core
{
    public class PlayPowerpointCommand: ICommand
    {
        #region local variables
        Random randGen = Random();
        String playPath;
        #endregion
        #region Constructors
        public PlayPowerpointCommand()
        {
            Commands.AddRange(new [] {"powerpoint","presentation"});
        }
        public PlayPowerpointCommand(String path):this()
        {
            playPath = path;
        }
        public PlayPowerpointCommand(String path, String[] commands)
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
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)));
                files = from file in files
                        where file.Contains(".pptx") || file.Contains(".ppt")
                                    select file;
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
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                Process.Start(path);
            else if (Environment.OSVersion.Platform == PlatformID.Unix)
                Process.Start("xdg-open", path);
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

