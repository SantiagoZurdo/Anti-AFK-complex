﻿namespace anti_afk_complex
{
    partial class Select_Key
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
            label2 = new Label();
            label1 = new Label();
            btnClickToDetect = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(161, 134);
            label2.Name = "label2";
            label2.Size = new Size(17, 23);
            label2.TabIndex = 7;
            label2.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 134);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 6;
            label1.Text = "Key Selected:";
            // 
            // btnClickToDetect
            // 
            btnClickToDetect.Location = new Point(12, 12);
            btnClickToDetect.Name = "btnClickToDetect";
            btnClickToDetect.Size = new Size(377, 79);
            btnClickToDetect.TabIndex = 5;
            btnClickToDetect.Text = "Click here to detect key";
            btnClickToDetect.UseVisualStyleBackColor = true;
            btnClickToDetect.KeyPress += btnClickToDetect_KeyPress;
            // 
            // Select_Key
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 469);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClickToDetect);
            Name = "Select_Key";
            Text = "Select_Key";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        public Button btnClickToDetect;
    }
}