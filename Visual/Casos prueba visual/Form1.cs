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

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/milam/source/repos/casos-prueba-hipertic2/registro/CP001 && robot CP001.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/milam/source/repos/casos-prueba-hipertic2/registro/CP002 && robot CP002.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/milam/source/repos/casos-prueba-hipertic2/registro/CP003 && robot CP003.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/milam/source/repos/casos-prueba-hipertic2/registro/CP004 && robot CP004.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/milam/source/repos/casos-prueba-hipertic2/registro/CP005 && robot CP005.robot");
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

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/milam/source/repos/casos-prueba-hipertic2/registro/CP006 && robot CP006.robot");
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

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/milam/source/repos/casos-prueba-hipertic2/registro/CP007 && robot CP007.robot");
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = false;
            processInfo.RedirectStandardOutput = false;

            process = Process.Start(processInfo);
            process.WaitForExit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/milam/source/repos/casos-prueba-hipertic2/registro/CP008 && robot CP008.robot");
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

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/milam/source/repos/casos-prueba-hipertic2/registro/CP009 && robot CP009.robot");
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

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/milam/source/repos/casos-prueba-hipertic2/Test Hipertensión/CP-009 && robot CP-009.robot");
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

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/milam/source/repos/casos-prueba-hipertic2/Test Hipertensión/CP-010 && robot CP-010.robot");
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

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/milam/source/repos/casos-prueba-hipertic2/Test Hipertensión/CP-011 && robot CP-011.robot");
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

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/milam/source/repos/casos-prueba-hipertic2/Funciones Admin/CP012 && robot CP012.robot");
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

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/milam/source/repos/casos-prueba-hipertic2/Funciones Admin/CP013 && robot CP013.robot");
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

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "cd C:/Users/milam/source/repos/casos-prueba-hipertic2/Funciones Admin/CP-014 && robot CP014.robot");
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
