using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private SerialPort stream = new SerialPort("COM3", 115200);
        private string fileName;
        private string date;
        private StreamWriter data;

        private Boolean stop = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(StoreData));
            StartButton.Enabled = false;
            StopButton.Enabled = true;
            DisplayChart.Enabled = false;
            ShowFiles.Enabled = false;

            StartButton.Image = WindowsFormsApp1.Properties.Resources.start_button_inactive_png_image_14963;
            StopButton.Image = WindowsFormsApp1.Properties.Resources.red_stop_button_png_image_100688;
            DisplayChart.Image = WindowsFormsApp1.Properties.Resources.chart_png_image_inactive_71182;
            ShowFiles.Image = WindowsFormsApp1.Properties.Resources.desk_drawer_png_image_inactive_12850;

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            chart1.Visible = false;
            txtSPO2.Visible = true;
            txtPRBPM.Visible = true;
            txtNormHR.Visible = true;
            txtNormSPO2.Visible = true;
            PnlRadioButtons.Visible = false;
            

            date = DateTime.Now.ToString("yyyy-M-dd-hh-mm-ss");
            fileName = date + "-Sensordata.csv";
            stop = false;

            t.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            stop = true;
            StartButton.Enabled = true;
            StopButton.Enabled = false;
            DisplayChart.Enabled = true;
            ShowFiles.Enabled = true;
            StartButton.Image = WindowsFormsApp1.Properties.Resources.start_button_png_image_14963;
            StopButton.Image = WindowsFormsApp1.Properties.Resources.red_stop_button_png_inactive_image_100688;
            DisplayChart.Image = WindowsFormsApp1.Properties.Resources.chart_png_image_71182;
            ShowFiles.Image = WindowsFormsApp1.Properties.Resources.desk_drawer_png_image_12850;
        }


        private void DisplayChart_Click(object sender, EventArgs e)
        {

            try
            {
                this.data.Close();
                stream.Close();
                txtSPO2.Visible = false;
                txtPRBPM.Visible = false;
                txtNormHR.Visible = false;
                txtNormSPO2.Visible = false;
                chart1.Visible = true;
                StreamReader database = new StreamReader(fileName);
                string data;
                Char delim = ',';
                String[] sensors;
                PnlRadioButtons.Visible = false;
                chart1.BringToFront();

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
                DisplayChart.Enabled = false;
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

        private void ShowFiles_Click(object sender, EventArgs e)
        {
            string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName); // @"\Debug\"
            string filter = "*.csv";
            string[] files = Directory.GetFiles(folder, filter);
            chart1.Visible = false;
            txtPRBPM.Visible = false;
            txtSPO2.Visible = false;
            txtNormSPO2.Visible = false;
            txtNormHR.Visible = false;
            DisplayChart.Enabled = true;
            int place = 0;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            for (int count = 0; count < files.Length; count++)
            {
                place = AddRadioButton(Path.GetFileName(files[count]), place);
            }

        }

        private void StoreData()
        {
            string line;
            
            Char delim = ',';

            try
            {
                if (stop == false)
                {
                    data = new StreamWriter(fileName);
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

                }
                
            }
            catch (IOException e)
            {
                //this.txtError.Visible = true;
                ThreadHelperClass.SetText(this, txtSPO2, "Please attach the device");
                ThreadHelperClass.SetText(this, txtPRBPM, "Please attach the device");
                data.Close();
                stream.Close();
                this.Invoke(new Action(() => { StopButton_Click(this.StopButton, null); }));



                StoreData();

            }
            catch (InvalidOperationException e)
            {
                //this.txtError.Visible = true;
                ThreadHelperClass.SetText(this, txtSPO2, "Please attach the device");
                ThreadHelperClass.SetText(this, txtPRBPM, "Please attach the device");

                data.Close();
                stream.Close();

                StoreData();

            }
            catch(UnauthorizedAccessException)
            {
                data.Close();
                stream.Close();
                StoreData();
            }
            catch (NullReferenceException e)
            {
                //this.txtError.Visible = true;
                ThreadHelperClass.SetText(this, txtSPO2, "Please attach the device");
                ThreadHelperClass.SetText(this, txtPRBPM, "Please attach the device");

                data.Close();
                stream.Close();

                StoreData();

            }
            catch (IndexOutOfRangeException)
            {
                data.Close();
                stream.Close();
                StoreData();
            }
        }




       
        private int AddRadioButton(string file, int place)
        {
            System.Windows.Forms.RadioButton rb = new System.Windows.Forms.RadioButton();
            PnlRadioButtons.Controls.Add(rb);
            PnlRadioButtons.Visible = true;
            PnlRadioButtons.BringToFront();
            
            rb.Top = place;
            rb.Left = 0;
            rb.Width = 200;
            rb.Text = file;
            place = place + 20;
            rb.Checked = true;
            fileName = file;
           
            return place;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
