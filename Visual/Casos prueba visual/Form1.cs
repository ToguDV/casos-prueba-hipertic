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

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro/CP001 && robot CP001.robot");
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

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro/CP002 && robot CP002.robot");
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

        private void button3_Click(object sender, EventArgs e)
        {

            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro/CP003 && robot CP003.robot");
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

        private void button4_Click(object sender, EventArgs e)
        {

            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro/CP004 && robot CP004.robot");
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

        private void button5_Click(object sender, EventArgs e)
        {

            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro/CP005 && robot CP005.robot");
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

        private void button6_Click(object sender, EventArgs e)
        {

            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro/CP006 && robot CP006.robot");
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

        private void button9_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro/CP007 && robot CP007.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro/CP008 && robot CP008.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/Test Hipertensión/CP-009 && robot CP-009.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/Test Hipertensión/CP-010 && robot CP-010.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/Test Hipertensión/CP-011 && robot CP-011.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/Funciones Admin/CP012 && robot CP012.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/Funciones Admin/CP013 && robot CP013.robot"); 
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/Funciones Admin/CP-014 && robot CP014.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro/CP001 && robot CP001.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro/CP002 && robot CP002.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro/CP003 && robot CP003.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro/CP004 && robot CP004.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro/CP005 && robot CP005.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro/CP006 && robot CP006.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro/CP007 && robot CP007.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;



            process = Process.Start(processInfo);
            process.WaitForExit();

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro/CP008 && robot CP008.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;



            process = Process.Start(processInfo);
            process.WaitForExit();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/Funciones admin/CP012 && robot CP012.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/Funciones admin/CP013 && robot CP013.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/Funciones admin/CP-014 && robot CP014.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/Test Hipertensión/CP-009 && robot CP-009.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/Test Hipertensión/CP-010 && robot CP-010.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/Test Hipertensión/CP-011 && robot CP-011.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();
        }
    }
}
