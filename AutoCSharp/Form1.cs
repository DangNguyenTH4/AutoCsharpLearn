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

namespace AutoCSharp
{
    public partial class frmAutoCsharp : Form
    {
        public frmAutoCsharp()
        {
            InitializeComponent();
        }

        //Open any File/Program/...
        private void btnOpenNotepad_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Anh ky yeu mai\anh Mai\DSC03892.JPG");
            Process.Start("notepad");
            Process.Start("cmd");   
            //Process.Start(AppDomain.CurrentDomain.BaseDirectory + "");
        }

        private void btnRunCmdCommand_Click(object sender, EventArgs e)
        {
            #region Cach 1
            //string strCmdCm;
            //strCmdCm = "/C ping -t google.com";
            //Process.Start("cmd", strCmdCm);
            #endregion
            #region Cach 2_ cach chuan
            string strCmdCm;
            strCmdCm = "/C ping -t google.com";
            Process p = new Process();
            p.StartInfo.FileName = "cmd";
            p.StartInfo.Arguments = strCmdCm;
            p.Start();
            p.Kill();
            #endregion
        }

        private void btnRunCmdBack_Click(object sender, EventArgs e)
        {
            string cm = @"/C ""Ha ha ha.jpg""";
            Process p = new Process();
            p.StartInfo.FileName = "cmd";
            p.StartInfo.Arguments = cm;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();

            //....
            //p.Kill();
        }

        private void btnRunBG_WithResult_Click(object sender, EventArgs e)
        {
            string cmdCommand = "/C ping google.com";
            string fileName = "cmd";

            // Create instance Process
            Process p = new Process();

            //Create instace StartInfo, setting it!
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = fileName;
            startInfo.Arguments = cmdCommand;
            //startInfo.CreateNoWindow = true; //Set hidden cmd Window
            startInfo.UseShellExecute = false;
           startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;

            //Start Process
            p.StartInfo = startInfo;
            p.Start();

            //Take output
            
            p.StandardInput.WriteLine(cmdCommand);
            p.StandardInput.Flush();
            p.StandardInput.Close();
            p.WaitForExit();
            
            string result = p.StandardOutput.ReadToEnd();
            MessageBox.Show(result);
        }
    }
}
