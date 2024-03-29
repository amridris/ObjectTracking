﻿namespace ObjectTrackingUI
{
    partial class ObjectTrackingDevForm
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
            this.components = new System.ComponentModel.Container();
            this.btnPixyLog = new System.Windows.Forms.Button();
            this.btnPixyRunBuild = new System.Windows.Forms.Button();
            this.btnPixyRun = new System.Windows.Forms.Button();
            this.btnTestWrapper = new System.Windows.Forms.Button();
            this.btnCNTK = new System.Windows.Forms.Button();
            this.BROKEN = new System.Windows.Forms.Label();
            this.lblArduino = new System.Windows.Forms.Label();
            this.Database = new System.Windows.Forms.Label();
            this.CNTK = new System.Windows.Forms.Label();
            this.textArduinoPixySerial = new System.Windows.Forms.TextBox();
            this.btnSendArduinoSerial = new System.Windows.Forms.Button();
            this.lblArduinoSerial = new System.Windows.Forms.Label();
            this.serArduinoPixy = new System.IO.Ports.SerialPort(this.components);
            this.tmrArduinoPixy = new System.Windows.Forms.Timer(this.components);
            this.btnStartArduinoSerial = new System.Windows.Forms.Button();
            this.lblDebugMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPixyLog
            // 
            this.btnPixyLog.Location = new System.Drawing.Point(22, 715);
            this.btnPixyLog.Name = "btnPixyLog";
            this.btnPixyLog.Size = new System.Drawing.Size(162, 35);
            this.btnPixyLog.TabIndex = 2;
            this.btnPixyLog.Text = "Build Pixy Logger";
            this.btnPixyLog.UseVisualStyleBackColor = true;
            this.btnPixyLog.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPixyRunBuild
            // 
            this.btnPixyRunBuild.Location = new System.Drawing.Point(22, 629);
            this.btnPixyRunBuild.Name = "btnPixyRunBuild";
            this.btnPixyRunBuild.Size = new System.Drawing.Size(162, 58);
            this.btnPixyRunBuild.TabIndex = 3;
            this.btnPixyRunBuild.Text = "Build and Run Pixy Logger";
            this.btnPixyRunBuild.UseVisualStyleBackColor = true;
            this.btnPixyRunBuild.Click += new System.EventHandler(this.btnPixyRun_Click);
            // 
            // btnPixyRun
            // 
            this.btnPixyRun.Location = new System.Drawing.Point(22, 768);
            this.btnPixyRun.Name = "btnPixyRun";
            this.btnPixyRun.Size = new System.Drawing.Size(162, 35);
            this.btnPixyRun.TabIndex = 4;
            this.btnPixyRun.Text = "Run Pixy Logger";
            this.btnPixyRun.UseVisualStyleBackColor = true;
            this.btnPixyRun.Click += new System.EventHandler(this.btnPixyRun_Click_1);
            // 
            // btnTestWrapper
            // 
            this.btnTestWrapper.Location = new System.Drawing.Point(330, 148);
            this.btnTestWrapper.Name = "btnTestWrapper";
            this.btnTestWrapper.Size = new System.Drawing.Size(199, 46);
            this.btnTestWrapper.TabIndex = 5;
            this.btnTestWrapper.Text = "Test Create Store Item";
            this.btnTestWrapper.UseVisualStyleBackColor = true;
            this.btnTestWrapper.Click += new System.EventHandler(this.btnTestGetWrapper_Click);
            // 
            // btnCNTK
            // 
            this.btnCNTK.Location = new System.Drawing.Point(686, 148);
            this.btnCNTK.Name = "btnCNTK";
            this.btnCNTK.Size = new System.Drawing.Size(162, 52);
            this.btnCNTK.TabIndex = 6;
            this.btnCNTK.Text = "Run CNTK";
            this.btnCNTK.UseVisualStyleBackColor = true;
            this.btnCNTK.Click += new System.EventHandler(this.btnPySerial_Click);
            // 
            // BROKEN
            // 
            this.BROKEN.AutoSize = true;
            this.BROKEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BROKEN.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BROKEN.Location = new System.Drawing.Point(22, 579);
            this.BROKEN.Name = "BROKEN";
            this.BROKEN.Size = new System.Drawing.Size(151, 37);
            this.BROKEN.TabIndex = 7;
            this.BROKEN.Text = "BROKEN";
            this.BROKEN.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblArduino
            // 
            this.lblArduino.AutoSize = true;
            this.lblArduino.Location = new System.Drawing.Point(29, 39);
            this.lblArduino.Name = "lblArduino";
            this.lblArduino.Size = new System.Drawing.Size(64, 20);
            this.lblArduino.TabIndex = 8;
            this.lblArduino.Text = "Arduino";
            // 
            // Database
            // 
            this.Database.AutoSize = true;
            this.Database.Location = new System.Drawing.Point(330, 39);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(79, 20);
            this.Database.TabIndex = 9;
            this.Database.Text = "Database";
            // 
            // CNTK
            // 
            this.CNTK.AutoSize = true;
            this.CNTK.Location = new System.Drawing.Point(682, 39);
            this.CNTK.Name = "CNTK";
            this.CNTK.Size = new System.Drawing.Size(50, 20);
            this.CNTK.TabIndex = 10;
            this.CNTK.Text = "CNKT";
            // 
            // textArduinoPixySerial
            // 
            this.textArduinoPixySerial.Location = new System.Drawing.Point(33, 148);
            this.textArduinoPixySerial.Name = "textArduinoPixySerial";
            this.textArduinoPixySerial.Size = new System.Drawing.Size(100, 26);
            this.textArduinoPixySerial.TabIndex = 11;
            // 
            // btnSendArduinoSerial
            // 
            this.btnSendArduinoSerial.Location = new System.Drawing.Point(33, 180);
            this.btnSendArduinoSerial.Name = "btnSendArduinoSerial";
            this.btnSendArduinoSerial.Size = new System.Drawing.Size(100, 28);
            this.btnSendArduinoSerial.TabIndex = 12;
            this.btnSendArduinoSerial.Text = "send";
            this.btnSendArduinoSerial.UseVisualStyleBackColor = true;
            this.btnSendArduinoSerial.Click += new System.EventHandler(this.btnSendArduinoSerial_Click);
            // 
            // lblArduinoSerial
            // 
            this.lblArduinoSerial.AutoSize = true;
            this.lblArduinoSerial.Location = new System.Drawing.Point(33, 242);
            this.lblArduinoSerial.Name = "lblArduinoSerial";
            this.lblArduinoSerial.Size = new System.Drawing.Size(103, 20);
            this.lblArduinoSerial.TabIndex = 13;
            this.lblArduinoSerial.Text = "ArduinoLabel";
            // 
            // serArduinoPixy
            // 
            this.serArduinoPixy.PortName = "COM5";
            this.serArduinoPixy.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serArduinoPixy_DataReceived);
            // 
            // tmrArduinoPixy
            // 
            this.tmrArduinoPixy.Tick += new System.EventHandler(this.tmrArduinoPixy_Tick);
            // 
            // btnStartArduinoSerial
            // 
            this.btnStartArduinoSerial.Location = new System.Drawing.Point(33, 62);
            this.btnStartArduinoSerial.Name = "btnStartArduinoSerial";
            this.btnStartArduinoSerial.Size = new System.Drawing.Size(151, 57);
            this.btnStartArduinoSerial.TabIndex = 14;
            this.btnStartArduinoSerial.Text = "Start Arduino Serial Connection";
            this.btnStartArduinoSerial.UseVisualStyleBackColor = true;
            this.btnStartArduinoSerial.Click += new System.EventHandler(this.btnStartArduinoSerial_Click);
            // 
            // lblDebugMessage
            // 
            this.lblDebugMessage.AutoSize = true;
            this.lblDebugMessage.Location = new System.Drawing.Point(262, 629);
            this.lblDebugMessage.Name = "lblDebugMessage";
            this.lblDebugMessage.Size = new System.Drawing.Size(126, 20);
            this.lblDebugMessage.TabIndex = 15;
            this.lblDebugMessage.Text = "Debug Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 579);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "DEBUG";
            // 
            // ObjectTrackingDevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 843);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDebugMessage);
            this.Controls.Add(this.btnStartArduinoSerial);
            this.Controls.Add(this.lblArduinoSerial);
            this.Controls.Add(this.btnSendArduinoSerial);
            this.Controls.Add(this.textArduinoPixySerial);
            this.Controls.Add(this.CNTK);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.lblArduino);
            this.Controls.Add(this.BROKEN);
            this.Controls.Add(this.btnCNTK);
            this.Controls.Add(this.btnTestWrapper);
            this.Controls.Add(this.btnPixyRun);
            this.Controls.Add(this.btnPixyRunBuild);
            this.Controls.Add(this.btnPixyLog);
            this.Name = "ObjectTrackingDevForm";
            this.Text = "Object Tracking Dev";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ObjectTrackingDevForm_FormClosing);
            this.Load += new System.EventHandler(this.ObjectTracking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPixyLog;
        private System.Windows.Forms.Button btnPixyRunBuild;
        private System.Windows.Forms.Button btnPixyRun;
        private System.Windows.Forms.Button btnTestWrapper;
        private System.Windows.Forms.Button btnCNTK;
        private System.Windows.Forms.Label BROKEN;
        private System.Windows.Forms.Label lblArduino;
        private System.Windows.Forms.Label Database;
        private System.Windows.Forms.Label CNTK;
        private System.Windows.Forms.TextBox textArduinoPixySerial;
        private System.Windows.Forms.Button btnSendArduinoSerial;
        private System.Windows.Forms.Label lblArduinoSerial;
        private System.IO.Ports.SerialPort serArduinoPixy;
        private System.Windows.Forms.Timer tmrArduinoPixy;
        private System.Windows.Forms.Button btnStartArduinoSerial;
        private System.Windows.Forms.Label lblDebugMessage;
        private System.Windows.Forms.Label label2;
    }
}

