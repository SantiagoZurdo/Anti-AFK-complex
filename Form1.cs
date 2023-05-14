using System.Diagnostics;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace anti_afk_complex
{
    public partial class Form1 : Form
    {
        Process_List frmProcessList;
        Select_Key frmSelectkey = new Select_Key();
        public Form1()
        {
            InitializeComponent();
            frmProcessList = new Process_List(this);
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnStopInjection.Enabled = false;
           
        }
        public void btnSelectProcess_Click(object sender, EventArgs e)
        {
            rtrnListOfProcesses();
            frmProcessList.ShowDialog();
        }
        //metodos propios
        public void stateInjected()
        {
            lblStatus.Text = "Injected";
            lblStatus.ForeColor = Color.Green;
        }  //estado injectd
        public void stateWaitingInjection()
        {
            lblStatus.Text = "Waiting";
            lblStatus.ForeColor = Color.DarkGoldenrod;
        } //wait

        public void stateNotInjected()
        {
            lblStatus.Text = "Not Injected";
            lblStatus.ForeColor = Color.Red;
        } //not

        public void rtrnListOfProcesses()
        {
            frmProcessList.listOfProcesses.Items.Clear();
            Process[] procesos = Process.GetProcesses(); //obtengo
            foreach (Process process in procesos) { frmProcessList.listOfProcesses.Items.Add(process.ProcessName); }
            //frmProcessList.listOfProcesses.SelectionMode = SelectionMode.One;
        } //retorna lista de procesos

        public Select_Key GetFrmSelectkey()
        {
            return frmSelectkey;
        }
        //metodos propios

        private async void btnStopInjection_Click(object sender, EventArgs e)
        {
            //parar el inject
            stateWaitingInjection();
            btnStopInjection.Enabled = false;
            await Task.Delay(1000); //esta funcion miente como ella
            btnSelectProcess.Enabled = true;
            stateNotInjected();


        }

        private void btnSelectKey_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectKey_Click_1(object sender, EventArgs e)
        {
            frmSelectkey.Show();
        }

        //metodos propios








    }
}