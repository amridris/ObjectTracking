namespace ObjectTrackingUI
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
            this.btnPixyLog = new System.Windows.Forms.Button();
            this.btnPixyRunBuild = new System.Windows.Forms.Button();
            this.btnPixyRun = new System.Windows.Forms.Button();
            this.btnTestWrapper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPixyLog
            // 
            this.btnPixyLog.Location = new System.Drawing.Point(27, 159);
            this.btnPixyLog.Name = "btnPixyLog";
            this.btnPixyLog.Size = new System.Drawing.Size(162, 35);
            this.btnPixyLog.TabIndex = 2;
            this.btnPixyLog.Text = "Build Pixy Logger";
            this.btnPixyLog.UseVisualStyleBackColor = true;
            this.btnPixyLog.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPixyRunBuild
            // 
            this.btnPixyRunBuild.Location = new System.Drawing.Point(27, 73);
            this.btnPixyRunBuild.Name = "btnPixyRunBuild";
            this.btnPixyRunBuild.Size = new System.Drawing.Size(162, 58);
            this.btnPixyRunBuild.TabIndex = 3;
            this.btnPixyRunBuild.Text = "Build and Run Pixy Logger";
            this.btnPixyRunBuild.UseVisualStyleBackColor = true;
            this.btnPixyRunBuild.Click += new System.EventHandler(this.btnPixyRun_Click);
            // 
            // btnPixyRun
            // 
            this.btnPixyRun.Location = new System.Drawing.Point(27, 212);
            this.btnPixyRun.Name = "btnPixyRun";
            this.btnPixyRun.Size = new System.Drawing.Size(162, 35);
            this.btnPixyRun.TabIndex = 4;
            this.btnPixyRun.Text = "Run Pixy Logger";
            this.btnPixyRun.UseVisualStyleBackColor = true;
            this.btnPixyRun.Click += new System.EventHandler(this.btnPixyRun_Click_1);
            // 
            // btnTestWrapper
            // 
            this.btnTestWrapper.Location = new System.Drawing.Point(503, 108);
            this.btnTestWrapper.Name = "btnTestWrapper";
            this.btnTestWrapper.Size = new System.Drawing.Size(199, 46);
            this.btnTestWrapper.TabIndex = 5;
            this.btnTestWrapper.Text = "Test Create Store Item";
            this.btnTestWrapper.UseVisualStyleBackColor = true;
            this.btnTestWrapper.Click += new System.EventHandler(this.btnTestGetWrapper_Click);
            // 
            // ObjectTrackingDevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 843);
            this.Controls.Add(this.btnTestWrapper);
            this.Controls.Add(this.btnPixyRun);
            this.Controls.Add(this.btnPixyRunBuild);
            this.Controls.Add(this.btnPixyLog);
            this.Name = "ObjectTrackingDevForm";
            this.Text = "Object Tracking Dev";
            this.Load += new System.EventHandler(this.ObjectTracking_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPixyLog;
        private System.Windows.Forms.Button btnPixyRunBuild;
        private System.Windows.Forms.Button btnPixyRun;
        private System.Windows.Forms.Button btnTestWrapper;
    }
}

