using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace ProcessNote
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cPU_usage.Hide();
            memory_usage.Hide();
            running_time.Hide();
            start_time.Hide();
            threads.Hide();

            string processor = System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
            Console.WriteLine("CPU:" + processor);

            // Array to store the processes
            Process[] processList = Process.GetProcesses();

            // Show in console all information of processes
            foreach (Process p in processList)
            {
                dataGridView1.Rows.Add(p.ProcessName, p.Id);
                Console.WriteLine("Process Name: {0} --- ID: {1} --- Status: {2} --- Memory: {3}",
                    p.ProcessName, p.Id, p.Responding, p.PrivateMemorySize64);

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedProcessId = (Int32)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            Process currentProcess = Process.GetProcessById(selectedProcessId);

            long memoryUsed = currentProcess.PrivateMemorySize64;
            memory_usage.Text = memoryUsed.ToString();
            memory_usage.Show();

            DateTime startTime = currentProcess.StartTime;
            start_time.Text = startTime.ToString();
            start_time.Show();

            int number = currentProcess.Threads.Count;
            threads.Text = number.ToString();
            threads.Show();

            DateTime now = DateTime.Now;
            TimeSpan runningTime = now - startTime;
            running_time.Text = runningTime.ToString();
            running_time.Show();

            float cpu = GetCpuUsage(currentProcess);
            cPU_usage.Text = cpu.ToString();
            cPU_usage.Show();

        }
        private float GetCpuUsage(Process currentProcess)
        {
            var performanceCounter = new PerformanceCounter("Process", "% Processor Time", currentProcess.ToString());

            // Initialize to start capturing
            performanceCounter.NextValue();
                        
            Thread.Sleep(1000);

            float cpu = performanceCounter.NextValue() / Environment.ProcessorCount;

            Console.WriteLine("cpu: " + cpu);
            return cpu;
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("You didn't save your comment yet.");
        }
    }
}
