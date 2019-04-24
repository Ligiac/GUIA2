using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiaIIProgra
{
    public partial class Form2 : Form
    {
        private MessageBoxButtons tipoDeBoton = MessageBoxButtons.OK;
        private MessageBoxIcon tipoDeIcono = MessageBoxIcon.Error;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tipoDeBoton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == radioButton1)
                tipoDeBoton = MessageBoxButtons.OK;
            else if (sender == radioButton2)
                tipoDeBoton = MessageBoxButtons.OKCancel;
            else if (sender == radioButton3)
                tipoDeBoton = MessageBoxButtons.YesNo;
            else if (sender == radioButton4)
                tipoDeBoton = MessageBoxButtons.YesNoCancel;
            else if (sender == radioButton5)
                tipoDeBoton = MessageBoxButtons.RetryCancel;
            else
                tipoDeBoton = MessageBoxButtons.AbortRetryIgnore;
        }

        private void tipoDeIcono_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == radioButton7) //display error icon
                tipoDeIcono = MessageBoxIcon.Information;
            else if (sender == radioButton8)
                tipoDeIcono = MessageBoxIcon.Exclamation;
            else if (sender == radioButton9)
                tipoDeIcono = MessageBoxIcon.Question;
            else
                tipoDeIcono = MessageBoxIcon.Error;
        }

        private void btnVisualizar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Mensaje a desplegar", "Titulo de Ventana", tipoDeBoton, tipoDeIcono);

            switch (result)
            {
                case DialogResult.OK: label2.Text = "Selecciono OK."; break;
                case DialogResult.Cancel: label2.Text = "Selecciono Cancel."; break;
                case DialogResult.Yes: label2.Text = "Selecciono Yes."; break;
                case DialogResult.No: label2.Text = "Selecciono No."; break;
                case DialogResult.Ignore: label2.Text = "Selecciono Ignore."; break;
                case DialogResult.Abort: label2.Text = "Selecciono Abort."; break;
                case DialogResult.Retry: label2.Text = "Selecciono Retry."; break;
            }
        }
    }
}
