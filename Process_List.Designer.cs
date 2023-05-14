namespace anti_afk_complex
{
    public partial class Process_List
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
            listOfProcesses = new ListBox();
            btnRefresh = new Button();
            SuspendLayout();
            // 
            // listOfProcesses
            // 
            listOfProcesses.FormattingEnabled = true;
            listOfProcesses.ItemHeight = 20;
            listOfProcesses.Location = new Point(12, 12);
            listOfProcesses.Name = "listOfProcesses";
            listOfProcesses.Size = new Size(522, 464);
            listOfProcesses.TabIndex = 0;
            listOfProcesses.SelectedIndexChanged += listOfProcesses_SelectedIndexChanged;
            listOfProcesses.DoubleClick += listOfProcesses_DoubleClick;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(12, 482);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(522, 51);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Process_List
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 545);
            Controls.Add(btnRefresh);
            Controls.Add(listOfProcesses);
            Name = "Process_List";
            Text = "Key Selected: ";
            Load += Process_List_Load;
            ResumeLayout(false);
        }

        #endregion

        public ListBox listOfProcesses;
        private Button btnRefresh;
    }
}