using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioWF01_2
{
    public partial class MiniEncuesta : Form
    {
        public MiniEncuesta()
        {
            InitializeComponent();
        }

        private void MiniEncuesta_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string mensaje = "Tu sistema operativo preferivo es ";

            //Comprobamos el sistema operativo y se lo añadimos al mensaje

            mensaje += ComprobarRadio(rbLinux);
            mensaje += ComprobarRadio(rbWindows);
            mensaje += ComprobarRadio(rbMac);

            // Comprobamos la especialidad y se lo añadimos al mensaje
            mensaje += ", tus especialidades son: ";
            mensaje += ComprobarCheck(chkbAdministracion);
            mensaje += ComprobarCheck(chkbGrafico);
            mensaje += ComprobarCheck(chkbProgramacion);

            //Comprobamos el número de horas
            mensaje += " y el número de horas dedicadas al ordenador son: ";
            mensaje += nudHoras.Value;


            //Imprimimos el mensaje

            MessageBox.Show(mensaje);

        }

        private string ComprobarRadio (RadioButton elemento)
        {
            if (elemento.Checked) return elemento.Text;
            return "";
        }

        private string ComprobarCheck(CheckBox elemento)
        {
            if (elemento.Checked) return (elemento.Text + ", ");
            return "";
        }
    }
}
