using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private int count = 0;
        private SerialPort stream = new SerialPort("COM3", 115200);
        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(storeData));
            button1.Enabled = false;
            button2.Enabled = true;
           
            t.Start();

            
        }
        Boolean stop = false;
        private void storeData()
        {
            string line;
            StreamWriter data = null;

            if (stop == false)
            {
                data = new StreamWriter("something.csv");
                stream.Open();
            }

            while (stop == false)
            {
                string PRBPM = stream.ReadLine();
                string SPO2 = stream.ReadLine();

                line = string.Format("{0},{1},", PRBPM, SPO2);
                data.WriteLine(line);
                data.Flush();
                displayData(line);
                
            }
            data.Close();
            stream.Close();
            stop = false;
        }

        private void displayData(string line)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stop = true;
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
