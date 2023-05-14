using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anti_afk_complex
{
    public partial class Process_List : Form
    {
        Form1 MainForm = (Form1)Application.OpenForms["Form1"];
        public Form1 Form1MainForm1;
        private DialogResult yesNoResult = DialogResult.No;

        public Process_List(Form1 form)
        {
            Form1MainForm1 = form;
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listOfProcesses.Items.Clear();
            MainForm.rtrnListOfProcesses();

        }

        public void Process_List_Load(object sender, EventArgs e)
        {

        }
        private void listOfProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void listOfProcesses_DoubleClick(object sender, EventArgs e)
        {
            Form1MainForm1.stateWaitingInjection(); //setea el estado de injection
            string itemSelected = listOfProcesses.SelectedItems[0].ToString(); //toma el item de la lista
            yesNoResult = MessageBox.Show("Are you sure you want to select process?\n" + "'" + itemSelected + "'" + "", "Title", MessageBoxButtons.YesNo); //muestra

            if (yesNoResult == DialogResult.Yes)
            {
                Form1MainForm1.stateInjected();
                //accion
                this.Close();
                Form1MainForm1.btnSelectProcess.Enabled = false;
                Form1MainForm1.btnStopInjection.Enabled = true;
            }
            else { Form1MainForm1.stateNotInjected(); }


        }

        private void btnSelectKey_Click(object sender, EventArgs e)
        {

        }
    }
}