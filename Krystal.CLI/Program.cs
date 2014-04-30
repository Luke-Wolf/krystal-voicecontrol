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
using Krystal.Core;

namespace Krystal.CLI
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Controller controller = new Controller(new ICommand[]
            {
                new PlayMusicCommand(),
                new PlayVideoCommand(@"/home/luke/Music/ICanWalkOnWater.mp4"),
                new PlayPowerpointCommand()
            });
            /*
            Console.WriteLine("Executing Music Command");
            controller.Execute("music");
            */
            Console.WriteLine("Executing Video Command");
            controller.Execute("video");
            Console.WriteLine("Executing Powerpoint Command");
            controller.Execute("powerpoint");
        }
    }
}
