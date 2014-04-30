using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{


    class MyPipeline : UtilMPipeline
    {
        ProcessStartInfo startMusic = new ProcessStartInfo("Green Bird.mp3");
        ProcessStartInfo startMovie = new ProcessStartInfo("Frozen.mp4");
        ProcessStartInfo startPowerPoint = new ProcessStartInfo("Proposal.pptx");


        public MyPipeline() : base()
        {
            EnableVoiceRecognition();
        }

        public override void OnRecognized(ref PXCMVoiceRecognition.Recognition data)
        {
            Console.WriteLine("Recognized: " + data.dictation);

            if (data.ToString() == "Play music") {

                Process.Start(startMusic);
            }
        }

        static void PlayMusic()
        {
            

        }

        static void PlayMovie()
        {


        }

        static void PlayPowerPoint()
        {


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

            //MyPipeline pp = new MyPipeline();
            //pp.LoopFrames();
            //pp.Dispose();

        }


    }
}
