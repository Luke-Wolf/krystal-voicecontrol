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
    /// <summary>
    /// Abstract Class to contain all functionality that is generic to commands that operate on files
    /// </summary>
    public abstract class FileCommand
    {
        #region Methods
        #region Protected
        /// <summary>
        /// Generic cross platform method to execute the default program on a file in a given location
        /// </summary>
        /// <param name="path">Path.</param>
        protected void Execute(String path)
        {
            //Windows can just start a program using a file other platforms
            //need a program passed in, so in order for the core to be cross platform
            //we check if it's a recognized platform before we try to launch
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                Process.Start(path);
            else if (Environment.OSVersion.Platform == PlatformID.Unix)
                Process.Start("xdg-open", path);
        }

        protected void CheckFileExists(String path)
        {
            if (File.Exists(path))
                PlayPath = path;
            else
                throw new FileNotFoundException();
        }

        /// <summary>
        /// Executes the default action on a random file given a list of files.
        /// if the list is empty then it throws an InvalidDataException
        /// </summary>
        /// <param name="files">List of Files.</param>
        protected void ExecuteRandomFile(List<String> files)
        {
            //if files is empty we can't do anything
            if (files.Count == 0)
                throw new InvalidDataException("No Valid Files in this directory");
            int rand = randGen.Next(files.Count);
            Execute(files[rand]);
        }
        #endregion

        #region Abstract
        public abstract void Execute();
        #endregion
        #endregion

        #region Variables
        protected String PlayPath;
        readonly Random randGen = new Random();
        #endregion
    }
}

