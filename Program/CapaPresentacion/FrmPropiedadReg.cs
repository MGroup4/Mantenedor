using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormPropiedadesDispo : Form
    {
        public FormPropiedadesDispo()
        {
            InitializeComponent();
        }


        private void buttonComprarAlquilar_Click(object sender, EventArgs e)
        {
            
        }

        private void ActualizarDatos(object sender, FormClosedEventArgs e)
        {
            MostrarRegistro();
        }

        private void buttonMostrarInfo_Click(object sender, EventArgs e)
        {
            FrmPropiedadInfo formulariom = new FrmPropiedadInfo();
            formulariom.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            formulariom.ShowDialog();
        }
    }
}
