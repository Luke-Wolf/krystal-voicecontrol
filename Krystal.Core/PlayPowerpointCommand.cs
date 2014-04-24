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
using System.Diagnostics;

namespace Krystal.Core
{
    public class PlayPowerpointCommand: ICommand
    {
        #region local variables
        private readonly String location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +@"/Krystal Powerpoint.pptx";
        #endregion
        #region Constructors
        public PlayPowerpointCommand()
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
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                Process.Start(location);
            else if (Environment.OSVersion.Platform == PlatformID.Unix)
                Process.Start("xdg-open", location);
        }
        public void Execute(String command)
        {
            Execute();
        }
        #endregion
        #region Properties
        #endregion
    }
}

