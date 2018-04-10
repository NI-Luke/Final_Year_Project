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

        private SerialPort stream = new SerialPort("COM3", 115200);
        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(storeData));
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
            

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

                line = string.Format("{0},{1}", PRBPM, SPO2);
                data.WriteLine(line);
                data.Flush();
                
                
            }
            data.Close();
            stream.Close();
            stop = false;
        }
        int count=0;

        private void button2_Click(object sender, EventArgs e)
        {
            stop = true;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            chart1.Series[0].Points.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            StreamReader database = new StreamReader("something.csv");
            string data;
            Char delim = ',';
            String[] sensors;

            for (int count = 0; count < database.BaseStream.Length; count++)
            {
                data = database.ReadLine();
                
                if (data != null)
                {
                    sensors = data.Split(delim);
                    chart1.Series["Series1"].Points.AddXY(count, sensors[0]);
                    chart1.Series["Series2"].Points.AddXY(count, sensors[1]);
                    textBox1.Text =sensors[0];
                    chart1.Update();
                }
              
            }
            button3.Enabled=false;
            database.Close();
            
        }
    }
}
