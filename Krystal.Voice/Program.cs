//
//  Copyright 2014  Terry
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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krystal.Core;

namespace Krystal.Voice
{
    class MyPipeline : UtilMPipeline
    {
        /*ProcessStartInfo startMusic = new ProcessStartInfo("..\\..\\Media\\Green Bird.mp3");
        ProcessStartInfo startMovie = new ProcessStartInfo("..\\..\\Media\\Frozen.mp4");
        ProcessStartInfo startPowerPoint = new ProcessStartInfo("..\\..\\Media\\Proposal.pptx");
        */
        readonly Controller controller = new Controller(new Core.ICommand[]
        {
            new PlayMusicCommand("..\\..\\Media\\Green Bird.mp3"),
            new PlayVideoCommand("..\\..\\Media\\Frozen.mp4"),
            new PlayPowerpointCommand("..\\..\\Media\\Proposal.pptx")
        });

        public MyPipeline() : base()
        {
            EnableVoiceRecognition();
        }

        public override void OnRecognized(ref PXCMVoiceRecognition.Recognition data)
        {
            controller.Execute(data.dictation);
            /*if (data.dictation.ToString().ToLower().Contains("music")) 
                Process.Start(startMusic);
            if (data.dictation.ToString().ToLower().Contains("movie")) 
                Process.Start(startMovie);
            if (data.dictation.ToString().ToLower().Contains("powerpoint"))
                Process.Start(startPowerPoint);
            */
            //Console.WriteLine("Recognized: " + data.dictation);
            //if (data.ToString() == "Play music") {}
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Kristal());
        }
    }
}
