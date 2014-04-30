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
            List<String> files = new List<String>(Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)));

            int rand = System.Random % files.Count;


            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                Process.Start(files[rand]);
            else if (Environment.OSVersion.Platform == PlatformID.Unix)
                Process.Start("xdg-open", files[rand]);

        }
        public void Execute(String command)
        {

        }
        #endregion
        #region Properties
        #endregion
    }
}
