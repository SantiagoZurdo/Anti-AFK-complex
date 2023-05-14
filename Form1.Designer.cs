namespace anti_afk_complex
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectProcess = new Button();
            lblStatus = new Label();
            btnStopInjection = new Button();
            btnSelectKey = new Button();
            SuspendLayout();
            // 
            // btnSelectProcess
            // 
            btnSelectProcess.Location = new Point(12, 88);
            btnSelectProcess.Name = "btnSelectProcess";
            btnSelectProcess.Size = new Size(287, 61);
            btnSelectProcess.TabIndex = 0;
            btnSelectProcess.Text = "Select Process";
            btnSelectProcess.UseVisualStyleBackColor = true;
            btnSelectProcess.Click += btnSelectProcess_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(669, 88);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(91, 20);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Not injected";
            // 
            // btnStopInjection
            // 
            btnStopInjection.Location = new Point(12, 155);
            btnStopInjection.Name = "btnStopInjection";
            btnStopInjection.Size = new Size(287, 61);
            btnStopInjection.TabIndex = 4;
            btnStopInjection.Text = "Stop Injection";
            btnStopInjection.UseVisualStyleBackColor = true;
            btnStopInjection.Click += btnStopInjection_Click;
            // 
            // btnSelectKey
            // 
            btnSelectKey.Location = new Point(12, 21);
            btnSelectKey.Name = "btnSelectKey";
            btnSelectKey.Size = new Size(287, 61);
            btnSelectKey.TabIndex = 5;
            btnSelectKey.Text = "Select Key";
            btnSelectKey.UseVisualStyleBackColor = true;
            btnSelectKey.Click += btnSelectKey_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 495);
            Controls.Add(btnSelectKey);
            Controls.Add(btnStopInjection);
            Controls.Add(lblStatus);
            Controls.Add(btnSelectProcess);
            Name = "Form1";
            Text = "AFK complex";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lblStatus;
        public Button btnSelectProcess;
        public Button btnStopInjection;
        public Button btnSelectKey;
    }
}