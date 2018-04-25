namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtSPO2 = new System.Windows.Forms.TextBox();
            this.txtPRBPM = new System.Windows.Forms.TextBox();
            this.txtNormHR = new System.Windows.Forms.TextBox();
            this.txtNormSPO2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.DisplayChart = new System.Windows.Forms.PictureBox();
            this.ShowFiles = new System.Windows.Forms.PictureBox();
            this.StopButton = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.PictureBox();
            this.PnlRadioButtons = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartButton)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(349, 77);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series7.BorderWidth = 10;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "PRBPM";
            series8.BorderWidth = 10;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "SPO2";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(428, 303);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // txtSPO2
            // 
            this.txtSPO2.BackColor = System.Drawing.SystemColors.Control;
            this.txtSPO2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSPO2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSPO2.Enabled = false;
            this.txtSPO2.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F);
            this.txtSPO2.Location = new System.Drawing.Point(349, 137);
            this.txtSPO2.Multiline = true;
            this.txtSPO2.Name = "txtSPO2";
            this.txtSPO2.Size = new System.Drawing.Size(425, 61);
            this.txtSPO2.TabIndex = 5;
            this.txtSPO2.WordWrap = false;
            // 
            // txtPRBPM
            // 
            this.txtPRBPM.BackColor = System.Drawing.SystemColors.Control;
            this.txtPRBPM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPRBPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPRBPM.Enabled = false;
            this.txtPRBPM.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRBPM.Location = new System.Drawing.Point(349, 271);
            this.txtPRBPM.Multiline = true;
            this.txtPRBPM.Name = "txtPRBPM";
            this.txtPRBPM.Size = new System.Drawing.Size(425, 61);
            this.txtPRBPM.TabIndex = 6;
            this.txtPRBPM.WordWrap = false;
            // 
            // txtNormHR
            // 
            this.txtNormHR.BackColor = System.Drawing.SystemColors.Control;
            this.txtNormHR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNormHR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNormHR.Enabled = false;
            this.txtNormHR.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F);
            this.txtNormHR.Location = new System.Drawing.Point(349, 70);
            this.txtNormHR.Multiline = true;
            this.txtNormHR.Name = "txtNormHR";
            this.txtNormHR.Size = new System.Drawing.Size(425, 61);
            this.txtNormHR.TabIndex = 7;
            this.txtNormHR.Text = "Normal resting heart rate: 60-100";
            this.txtNormHR.WordWrap = false;
            // 
            // txtNormSPO2
            // 
            this.txtNormSPO2.BackColor = System.Drawing.SystemColors.Control;
            this.txtNormSPO2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNormSPO2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNormSPO2.Enabled = false;
            this.txtNormSPO2.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F);
            this.txtNormSPO2.Location = new System.Drawing.Point(349, 204);
            this.txtNormSPO2.Multiline = true;
            this.txtNormSPO2.Name = "txtNormSPO2";
            this.txtNormSPO2.Size = new System.Drawing.Size(425, 61);
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.65894F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.34106F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPRBPM, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.DisplayChart, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtNormSPO2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ShowFiles, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSPO2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.StopButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNormHR, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.StartButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 356);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitle, 2);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Sitka Small", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(771, 54);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "e-Health Management";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayChart
            // 
            this.DisplayChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayChart.Enabled = false;
            this.DisplayChart.Image = global::WindowsFormsApp1.Properties.Resources.chart_png_image_inactive_71182;
            this.DisplayChart.Location = new System.Drawing.Point(3, 271);
            this.DisplayChart.Name = "DisplayChart";
            this.DisplayChart.Size = new System.Drawing.Size(340, 61);
            this.DisplayChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DisplayChart.TabIndex = 14;
            this.DisplayChart.TabStop = false;
            this.DisplayChart.Click += new System.EventHandler(this.DisplayChart_Click);
            // 
            // ShowFiles
            // 
            this.ShowFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowFiles.Image = global::WindowsFormsApp1.Properties.Resources.desk_drawer_png_image_12850;
            this.ShowFiles.Location = new System.Drawing.Point(3, 204);
            this.ShowFiles.Name = "ShowFiles";
            this.ShowFiles.Size = new System.Drawing.Size(340, 61);
            this.ShowFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowFiles.TabIndex = 15;
            this.ShowFiles.TabStop = false;
            this.ShowFiles.Click += new System.EventHandler(this.ShowFiles_Click);
            // 
            // StopButton
            // 
            this.StopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopButton.Enabled = false;
            this.StopButton.Image = global::WindowsFormsApp1.Properties.Resources.red_stop_button_png_inactive_image_100688;
            this.StopButton.Location = new System.Drawing.Point(3, 137);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(340, 61);
            this.StopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StopButton.TabIndex = 13;
            this.StopButton.TabStop = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartButton.Image = global::WindowsFormsApp1.Properties.Resources.start_button_png_image_14963;
            this.StartButton.Location = new System.Drawing.Point(3, 70);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(340, 61);
            this.StartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartButton.TabIndex = 12;
            this.StartButton.TabStop = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PnlRadioButtons
            // 
            this.PnlRadioButtons.AutoScroll = true;
            this.PnlRadioButtons.Location = new System.Drawing.Point(349, 94);
            this.PnlRadioButtons.Name = "PnlRadioButtons";
            this.PnlRadioButtons.Size = new System.Drawing.Size(425, 303);
            this.PnlRadioButtons.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(777, 380);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.PnlRadioButtons);
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
            ((System.ComponentModel.ISupportInitialize)(this.DisplayChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtSPO2;
        private System.Windows.Forms.TextBox txtPRBPM;
        private System.Windows.Forms.TextBox txtNormHR;
        private System.Windows.Forms.TextBox txtNormSPO2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PnlRadioButtons;
        private System.Windows.Forms.PictureBox StartButton;
        private System.Windows.Forms.PictureBox StopButton;
        private System.Windows.Forms.PictureBox DisplayChart;
        private System.Windows.Forms.PictureBox ShowFiles;
        private System.Windows.Forms.Label lblTitle;
    }
}

