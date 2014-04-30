using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Kristal : Form
    {

        MyPipeline pp = new MyPipeline();


        public Kristal()
        {
            InitializeComponent();
        }

        private void Kristal_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(voiceloop);
            thread.Start();
            
        }

        private void voiceloop()
        {
            pp.LoopFrames();
            pp.Dispose();
        }



    }
}
