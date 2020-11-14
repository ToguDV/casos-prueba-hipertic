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

namespace Casos_prueba_visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/Usuario/Documents/GitHub/casos-prueba-hipertic/registro/CP001 && robot CP001.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();
            /* Process proc = null;
            string targetDir = string.Format(@"D:\myd");   //this is where mybatch.bat lies
            proc = new Process();
            proc.StartInfo.WorkingDirectory = targetDir;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = string.Format("cd C:\Users\cesar\PycharmProjects\prueba2\TestCases\casos-prueba-hipertic\registro\CP001 && robot CP001.robot");  //this is argument
            proc.StartInfo.CreateNoWindow = false;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;  //this is for hiding the cmd window...so execution will happen in back ground.
            proc.Start();
            proc.WaitForExit(); 


           /* var processInfo = new ProcessStartInfo("cmd.exe", "cd" + "C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro/CP001");
       //     processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);

            processInfo.e  //     processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            process = Process.Start(processInfo);

            process.WaitForExit();

            Console.WriteLine("ExitCode: {0}", process.ExitCode);
            process.Close();
           */
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/Usuario/Documents/GitHub/casos-prueba-hipertic/registro/CP002 && robot CP002.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();
            /* Process proc = null;
            string targetDir = string.Format(@"D:\myd");   //this is where mybatch.bat lies
            proc = new Process();
            proc.StartInfo.WorkingDirectory = targetDir;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = string.Format("cd C:\Users\cesar\PycharmProjects\prueba2\TestCases\casos-prueba-hipertic\registro\CP001 && robot CP001.robot");  //this is argument
            proc.StartInfo.CreateNoWindow = false;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;  //this is for hiding the cmd window...so execution will happen in back ground.
            proc.Start();
            proc.WaitForExit(); 


           /* var processInfo = new ProcessStartInfo("cmd.exe", "cd" + "C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro/CP001");
       //     processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);

            processInfo.e  //     processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            process = Process.Start(processInfo);

            process.WaitForExit();

            Console.WriteLine("ExitCode: {0}", process.ExitCode);
            process.Close();
           */
        }
    }
}
