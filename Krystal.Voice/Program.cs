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
