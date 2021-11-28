namespace ThermalImageStreamerDemo
{
    partial class RecorderForm
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonPause = new System.Windows.Forms.Button();
            this.labelOutputPath = new System.Windows.Forms.Label();
            this.buttonRec = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxNumFramesPreRec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxPreRecording = new System.Windows.Forms.CheckBox();
            this.groupBoxPreRecording = new System.Windows.Forms.GroupBox();
            this.textBoxTimeSpan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonRecSpeed = new System.Windows.Forms.RadioButton();
            this.radioButtonRecSpeedInterval = new System.Windows.Forms.RadioButton();
            this.listViewRecordings = new System.Windows.Forms.ListView();
            this.groupBoxRecSpeed = new System.Windows.Forms.GroupBox();
            this.labelElapsedTime = new System.Windows.Forms.Label();
            this.labelLostImages = new System.Windows.Forms.Label();
            this.labelFrameCounter = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBoxPreRecording.SuspendLayout();
            this.groupBoxRecSpeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Recordings";
            this.columnHeader1.Width = 71;
            // 
            // buttonPause
            // 
            this.buttonPause.Enabled = false;
            this.buttonPause.Location = new System.Drawing.Point(700, 970);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(10);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(168, 74);
            this.buttonPause.TabIndex = 36;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // labelOutputPath
            // 
            this.labelOutputPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOutputPath.Location = new System.Drawing.Point(66, 1504);
            this.labelOutputPath.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelOutputPath.Name = "labelOutputPath";
            this.labelOutputPath.Size = new System.Drawing.Size(796, 58);
            this.labelOutputPath.TabIndex = 23;
            this.labelOutputPath.Text = "Path";
            this.labelOutputPath.Click += new System.EventHandler(this.labelOutputPath_Click);
            // 
            // buttonRec
            // 
            this.buttonRec.Enabled = false;
            this.buttonRec.Location = new System.Drawing.Point(511, 970);
            this.buttonRec.Margin = new System.Windows.Forms.Padding(10);
            this.buttonRec.Name = "buttonRec";
            this.buttonRec.Size = new System.Drawing.Size(168, 74);
            this.buttonRec.TabIndex = 35;
            this.buttonRec.Text = "Rec";
            this.buttonRec.UseVisualStyleBackColor = true;
            this.buttonRec.Click += new System.EventHandler(this.buttonRec_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(66, 970);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(10);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(210, 74);
            this.buttonBrowse.TabIndex = 34;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxNumFramesPreRec
            // 
            this.textBoxNumFramesPreRec.Location = new System.Drawing.Point(234, 144);
            this.textBoxNumFramesPreRec.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxNumFramesPreRec.Name = "textBoxNumFramesPreRec";
            this.textBoxNumFramesPreRec.Size = new System.Drawing.Size(182, 55);
            this.textBoxNumFramesPreRec.TabIndex = 2;
            this.textBoxNumFramesPreRec.Text = "30";
            this.textBoxNumFramesPreRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frames:";
            // 
            // checkBoxPreRecording
            // 
            this.checkBoxPreRecording.AutoSize = true;
            this.checkBoxPreRecording.Location = new System.Drawing.Point(60, 77);
            this.checkBoxPreRecording.Margin = new System.Windows.Forms.Padding(10);
            this.checkBoxPreRecording.Name = "checkBoxPreRecording";
            this.checkBoxPreRecording.Size = new System.Drawing.Size(190, 46);
            this.checkBoxPreRecording.TabIndex = 0;
            this.checkBoxPreRecording.Text = "Enable";
            this.checkBoxPreRecording.UseVisualStyleBackColor = true;
            this.checkBoxPreRecording.CheckStateChanged += new System.EventHandler(this.checkBoxPreRecording_CheckStateChanged);
            // 
            // groupBoxPreRecording
            // 
            this.groupBoxPreRecording.Controls.Add(this.textBoxNumFramesPreRec);
            this.groupBoxPreRecording.Controls.Add(this.label2);
            this.groupBoxPreRecording.Controls.Add(this.checkBoxPreRecording);
            this.groupBoxPreRecording.Enabled = false;
            this.groupBoxPreRecording.Location = new System.Drawing.Point(66, 718);
            this.groupBoxPreRecording.Margin = new System.Windows.Forms.Padding(10);
            this.groupBoxPreRecording.Name = "groupBoxPreRecording";
            this.groupBoxPreRecording.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxPreRecording.Size = new System.Drawing.Size(802, 231);
            this.groupBoxPreRecording.TabIndex = 33;
            this.groupBoxPreRecording.TabStop = false;
            this.groupBoxPreRecording.Text = "Pre-recording";
            // 
            // textBoxTimeSpan
            // 
            this.textBoxTimeSpan.Location = new System.Drawing.Point(150, 210);
            this.textBoxTimeSpan.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxTimeSpan.Name = "textBoxTimeSpan";
            this.textBoxTimeSpan.Size = new System.Drawing.Size(207, 55);
            this.textBoxTimeSpan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time span in seconds.";
            // 
            // radioButtonRecSpeed
            // 
            this.radioButtonRecSpeed.AutoSize = true;
            this.radioButtonRecSpeed.Location = new System.Drawing.Point(42, 63);
            this.radioButtonRecSpeed.Margin = new System.Windows.Forms.Padding(10);
            this.radioButtonRecSpeed.Name = "radioButtonRecSpeed";
            this.radioButtonRecSpeed.Size = new System.Drawing.Size(209, 46);
            this.radioButtonRecSpeed.TabIndex = 2;
            this.radioButtonRecSpeed.TabStop = true;
            this.radioButtonRecSpeed.Text = "Highest";
            this.radioButtonRecSpeed.UseVisualStyleBackColor = true;
            this.radioButtonRecSpeed.CheckedChanged += new System.EventHandler(this.radioButtonRecSpeed_CheckedChanged);
            // 
            // radioButtonRecSpeedInterval
            // 
            this.radioButtonRecSpeedInterval.AutoSize = true;
            this.radioButtonRecSpeedInterval.Location = new System.Drawing.Point(42, 136);
            this.radioButtonRecSpeedInterval.Margin = new System.Windows.Forms.Padding(10);
            this.radioButtonRecSpeedInterval.Name = "radioButtonRecSpeedInterval";
            this.radioButtonRecSpeedInterval.Size = new System.Drawing.Size(230, 46);
            this.radioButtonRecSpeedInterval.TabIndex = 2;
            this.radioButtonRecSpeedInterval.TabStop = true;
            this.radioButtonRecSpeedInterval.Text = "Interval";
            this.radioButtonRecSpeedInterval.UseVisualStyleBackColor = true;
            // 
            // listViewRecordings
            // 
            this.listViewRecordings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewRecordings.HideSelection = false;
            this.listViewRecordings.Location = new System.Drawing.Point(606, 32);
            this.listViewRecordings.Margin = new System.Windows.Forms.Padding(10);
            this.listViewRecordings.Name = "listViewRecordings";
            this.listViewRecordings.Size = new System.Drawing.Size(252, 340);
            this.listViewRecordings.TabIndex = 37;
            this.listViewRecordings.UseCompatibleStateImageBehavior = false;
            this.listViewRecordings.View = System.Windows.Forms.View.Details;
            this.listViewRecordings.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewRecordings_MouseDoubleClick);
            // 
            // groupBoxRecSpeed
            // 
            this.groupBoxRecSpeed.Controls.Add(this.textBoxTimeSpan);
            this.groupBoxRecSpeed.Controls.Add(this.label1);
            this.groupBoxRecSpeed.Controls.Add(this.radioButtonRecSpeed);
            this.groupBoxRecSpeed.Controls.Add(this.radioButtonRecSpeedInterval);
            this.groupBoxRecSpeed.Enabled = false;
            this.groupBoxRecSpeed.Location = new System.Drawing.Point(66, 399);
            this.groupBoxRecSpeed.Margin = new System.Windows.Forms.Padding(10);
            this.groupBoxRecSpeed.Name = "groupBoxRecSpeed";
            this.groupBoxRecSpeed.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxRecSpeed.Size = new System.Drawing.Size(802, 298);
            this.groupBoxRecSpeed.TabIndex = 32;
            this.groupBoxRecSpeed.TabStop = false;
            this.groupBoxRecSpeed.Text = "Recording speed";
            // 
            // labelElapsedTime
            // 
            this.labelElapsedTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelElapsedTime.Location = new System.Drawing.Point(294, 294);
            this.labelElapsedTime.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelElapsedTime.Name = "labelElapsedTime";
            this.labelElapsedTime.Size = new System.Drawing.Size(286, 68);
            this.labelElapsedTime.TabIndex = 24;
            this.labelElapsedTime.Text = "0";
            this.labelElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLostImages
            // 
            this.labelLostImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLostImages.Location = new System.Drawing.Point(294, 206);
            this.labelLostImages.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelLostImages.Name = "labelLostImages";
            this.labelLostImages.Size = new System.Drawing.Size(286, 68);
            this.labelLostImages.TabIndex = 25;
            this.labelLostImages.Text = "0";
            this.labelLostImages.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFrameCounter
            // 
            this.labelFrameCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFrameCounter.Location = new System.Drawing.Point(294, 119);
            this.labelFrameCounter.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelFrameCounter.Name = "labelFrameCounter";
            this.labelFrameCounter.Size = new System.Drawing.Size(286, 68);
            this.labelFrameCounter.TabIndex = 26;
            this.labelFrameCounter.Text = "0";
            this.labelFrameCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 312);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 42);
            this.label9.TabIndex = 27;
            this.label9.Text = "Elapsed time:";
            // 
            // labelStatus
            // 
            this.labelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStatus.Location = new System.Drawing.Point(294, 32);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(286, 68);
            this.labelStatus.TabIndex = 28;
            this.labelStatus.Text = "Stopped";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 42);
            this.label6.TabIndex = 29;
            this.label6.Text = "Lost images:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 42);
            this.label5.TabIndex = 30;
            this.label5.Text = "Images:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 42);
            this.label3.TabIndex = 31;
            this.label3.Text = "Status:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 1102);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 74);
            this.button1.TabIndex = 39;
            this.button1.Text = "VideoStop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 1102);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 74);
            this.button2.TabIndex = 38;
            this.button2.Text = "VideoRec";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(133, 1420);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(588, 58);
            this.label4.TabIndex = 24;
            this.label4.Text = "Focus(m): ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 1249);
            this.button3.Margin = new System.Windows.Forms.Padding(10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(287, 74);
            this.button3.TabIndex = 36;
            this.button3.Text = "f near\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(451, 1249);
            this.button4.Margin = new System.Windows.Forms.Padding(10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(279, 74);
            this.button4.TabIndex = 37;
            this.button4.Text = "f far";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(117, 1336);
            this.button5.Margin = new System.Windows.Forms.Padding(10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(287, 74);
            this.button5.TabIndex = 40;
            this.button5.Text = "f stop";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(451, 1336);
            this.button6.Margin = new System.Windows.Forms.Padding(10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(287, 74);
            this.button6.TabIndex = 41;
            this.button6.Text = "f auto\r\n";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(758, 1336);
            this.button7.Margin = new System.Windows.Forms.Padding(10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 67);
            this.button7.TabIndex = 42;
            this.button7.Text = "f auto\r\n";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // RecorderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 1591);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelOutputPath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonRec);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.groupBoxPreRecording);
            this.Controls.Add(this.listViewRecordings);
            this.Controls.Add(this.groupBoxRecSpeed);
            this.Controls.Add(this.labelElapsedTime);
            this.Controls.Add(this.labelLostImages);
            this.Controls.Add(this.labelFrameCounter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "RecorderForm";
            this.Text = "Recorder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecorderForm_FormClosing);
            this.Load += new System.EventHandler(this.RecorderForm_Load);
            this.groupBoxPreRecording.ResumeLayout(false);
            this.groupBoxPreRecording.PerformLayout();
            this.groupBoxRecSpeed.ResumeLayout(false);
            this.groupBoxRecSpeed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Label labelOutputPath;
        private System.Windows.Forms.Button buttonRec;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxNumFramesPreRec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxPreRecording;
        private System.Windows.Forms.GroupBox groupBoxPreRecording;
        private System.Windows.Forms.TextBox textBoxTimeSpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonRecSpeed;
        private System.Windows.Forms.RadioButton radioButtonRecSpeedInterval;
        private System.Windows.Forms.ListView listViewRecordings;
        private System.Windows.Forms.GroupBox groupBoxRecSpeed;
        private System.Windows.Forms.Label labelElapsedTime;
        private System.Windows.Forms.Label labelLostImages;
        private System.Windows.Forms.Label labelFrameCounter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}