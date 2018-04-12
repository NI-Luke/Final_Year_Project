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
        private void BtnStart_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(StoreData));
            BtnStart.Enabled = false;
            BtnStop.Enabled = true;
            BtnShowChart.Enabled = false;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Visible = false;
            txtSPO2.Visible = true;
            txtPRBPM.Visible = true;
            stop = false;

            t.Start();
            
        }
        Boolean stop = false;
        private void StoreData()
        {
            string line;
            StreamWriter data; //= null;
            Char delim = ',';
            

            try
            {

                if (stop == false)
                {
                    data = new StreamWriter("something.csv");
                    stream.Open();
                    line = string.Format("{0},{1}", "PRBPM", "SPO2");

                    data.WriteLine(line);
                    data.Flush();

                    ThreadHelperClass.SetText(this, txtPRBPM, "Please wait while data is collected");
                    ThreadHelperClass.SetText(this, txtSPO2, "Please wait while data is collected");



                    while (stop == false)
                    {
                        String[] dataStream;
                        dataStream = stream.ReadLine().Split(delim);


                        ThreadHelperClass.SetText(this, txtPRBPM, "Your PRBPM: " + dataStream[0]);
                        ThreadHelperClass.SetText(this, txtSPO2, "Your SPO2: " + dataStream[1]);

                        line = string.Format("{0},{1}", dataStream[0], dataStream[1]);
                        data.WriteLine(line);
                        data.Flush();
                    }

                    data.Close();
                    stream.Close();
                }
            }
            catch (IOException e)
            {
                //this.txtError.Visible = true;
                ThreadHelperClass.SetText(this, txtSPO2, "Please attach the device");
                ThreadHelperClass.SetText(this, txtPRBPM, "Please attach the device");
                
                
                StoreData();

            }
            catch (InvalidOperationException e)
            {
                //this.txtError.Visible = true;
                ThreadHelperClass.SetText(this, txtSPO2, "Please attach the device");
                ThreadHelperClass.SetText(this, txtPRBPM, "Please attach the device");

                StoreData();

            }
            catch (NullReferenceException e)
            {
                //this.txtError.Visible = true;
                ThreadHelperClass.SetText(this, txtSPO2, "Please attach the device");
                ThreadHelperClass.SetText(this, txtPRBPM, "Please attach the device");

                StoreData();

            }
            catch (IndexOutOfRangeException)
            {
                
                stream.Close();
                StoreData();
            }
        }


        private void BtnStop_Click(object sender, EventArgs e)
        {
            stop = true;
            BtnStart.Enabled = true;
            BtnStop.Enabled = false;
            BtnShowChart.Enabled = true;
            
        }

        private void BtnShowChart_Click(object sender, EventArgs e)
        {
            try
            {
                txtSPO2.Visible = false;
                txtPRBPM.Visible = false;
                chart1.Visible = true;
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
                        
                        chart1.Series["PRBPM"].Points.AddXY(count, sensors[0]);
                        chart1.Series["SPO2"].Points.AddXY(count, sensors[1]);
                    }

                }
                BtnShowChart.Enabled = false;
                database.Close();
            }
            catch (IOException ex)
            {
                
            }
            catch (InvalidOperationException ex)
            {
               
            }
            catch (NullReferenceException ex)
            {

               
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
