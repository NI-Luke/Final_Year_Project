﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnShowChart = new System.Windows.Forms.Button();
            this.txtSPO2 = new System.Windows.Forms.TextBox();
            this.txtPRBPM = new System.Windows.Forms.TextBox();
            this.txtNormHR = new System.Windows.Forms.TextBox();
            this.txtNormSPO2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShowFiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(3, 3);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(699, 3);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 56);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 10;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "PRBPM";
            series2.BorderWidth = 10;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "SPO2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(693, 324);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // BtnShowChart
            // 
            this.BtnShowChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnShowChart.Enabled = false;
            this.BtnShowChart.Location = new System.Drawing.Point(699, 330);
            this.BtnShowChart.Name = "BtnShowChart";
            this.BtnShowChart.Size = new System.Drawing.Size(75, 23);
            this.BtnShowChart.TabIndex = 4;
            this.BtnShowChart.Text = "Show Chart";
            this.BtnShowChart.UseVisualStyleBackColor = true;
            this.BtnShowChart.Click += new System.EventHandler(this.BtnShowChart_Click);
            // 
            // txtSPO2
            // 
            this.txtSPO2.Enabled = false;
            this.txtSPO2.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F);
            this.txtSPO2.Location = new System.Drawing.Point(3, 145);
            this.txtSPO2.Multiline = true;
            this.txtSPO2.Name = "txtSPO2";
            this.txtSPO2.Size = new System.Drawing.Size(416, 53);
            this.txtSPO2.TabIndex = 5;
            this.txtSPO2.WordWrap = false;
            // 
            // txtPRBPM
            // 
            this.txtPRBPM.Enabled = false;
            this.txtPRBPM.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRBPM.Location = new System.Drawing.Point(3, 287);
            this.txtPRBPM.Multiline = true;
            this.txtPRBPM.Name = "txtPRBPM";
            this.txtPRBPM.Size = new System.Drawing.Size(416, 53);
            this.txtPRBPM.TabIndex = 6;
            this.txtPRBPM.WordWrap = false;
            // 
            // txtNormHR
            // 
            this.txtNormHR.Enabled = false;
            this.txtNormHR.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F);
            this.txtNormHR.Location = new System.Drawing.Point(3, 74);
            this.txtNormHR.Multiline = true;
            this.txtNormHR.Name = "txtNormHR";
            this.txtNormHR.Size = new System.Drawing.Size(416, 53);
            this.txtNormHR.TabIndex = 7;
            this.txtNormHR.Text = "Normal resting heart rate: 60-100";
            this.txtNormHR.WordWrap = false;
            // 
            // txtNormSPO2
            // 
            this.txtNormSPO2.Enabled = false;
            this.txtNormSPO2.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F);
            this.txtNormSPO2.Location = new System.Drawing.Point(3, 216);
            this.txtNormSPO2.Multiline = true;
            this.txtNormSPO2.Name = "txtNormSPO2";
            this.txtNormSPO2.Size = new System.Drawing.Size(416, 53);
            this.txtNormSPO2.TabIndex = 8;
            this.txtNormSPO2.Text = "Normal SPO2: 90 and above";
            this.txtNormSPO2.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.72186F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.18111F));
            this.tableLayoutPanel1.Controls.Add(this.btnShowFiles, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNormHR, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSPO2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNormSPO2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPRBPM, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnStart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnStop, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnShowChart, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 356);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // btnShowFiles
            // 
            this.btnShowFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowFiles.Location = new System.Drawing.Point(699, 216);
            this.btnShowFiles.Name = "btnShowFiles";
            this.btnShowFiles.Size = new System.Drawing.Size(75, 23);
            this.btnShowFiles.TabIndex = 11;
            this.btnShowFiles.Text = "Show Files";
            this.btnShowFiles.UseVisualStyleBackColor = true;
            this.btnShowFiles.Click += new System.EventHandler(this.btnShowFiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(777, 380);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Health Check";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BtnShowChart;
        private System.Windows.Forms.TextBox txtSPO2;
        private System.Windows.Forms.TextBox txtPRBPM;
        private System.Windows.Forms.TextBox txtNormHR;
        private System.Windows.Forms.TextBox txtNormSPO2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnShowFiles;
    }
}

