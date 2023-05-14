using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anti_afk_complex
{
    public partial class Select_Key : Form
    {
        Form1 MainForm = (Form1)Application.OpenForms["Form1"];
        public Select_Key()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(btnClickToDetect_KeyPress);
        }

        private void btnClickToDetect_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = char.ToLower(e.KeyChar);
            // Mostrar la tecla presionada en una ventana de mensaje
            DialogResult result = MessageBox.Show($"¿Está seguro de que desea asignar la tecla '{key}'?", "Confirmar tecla", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Se ha asignado la tecla '{key}'");
            }
        }
    }
}
