using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLI;

namespace ObjectTrackingUI
{
    public partial class ObjectTrackingDevForm : Form
    {
        public ObjectTrackingDevForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            System.Diagnostics.Process cmd = new System.Diagnostics.Process();
            cmd.StartInfo.FileName = "bash.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.Write("../../../hello_pixy_outside/build/hello_pixy_outside/hello_pixy_outside\n");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            */
        }

        private void btnPixyRun_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process cmd = new System.Diagnostics.Process();
            cmd.StartInfo.FileName = "bash.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.Write("../../../hello_pixy_outside/scripts/build_hello_pixy_outside.sh\n");
            cmd.StandardInput.Write("../../../hello_pixy_outside/build/hello_pixy_outside/hello_pixy_outside\n");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

        private void ObjectTracking_Load(object sender, EventArgs e)
        {

        }

        private void btnPixyRun_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process cmd = new System.Diagnostics.Process();
            cmd.StartInfo.FileName = "bash.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.Write("../../../hello_pixy_outside/build/hello_pixy_outside/hello_pixy_outside\n");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

        private void btnTestGetWrapper_Click(object sender, EventArgs e)
        {
            StoreItem item = new StoreItem(10);
            Console.WriteLine(item.itemNumber);
            item.itemNumber = 20;
            Console.WriteLine(item.itemNumber);
        }

        private void btnPySerial_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "Python.exe";
            startInfo.Arguments = "yourfile.py";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
