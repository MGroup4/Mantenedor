using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FrmPropiedadInfo : Form
    {

        readonly E_Propiedad ObjEntidad = new E_Propiedad();
        readonly N_Propiedad ObjNegocio = new N_Propiedad();

        public FrmPropiedadInfo()
        {
            InitializeComponent();
        }

        public void MostrarRegistro()
        {
            DGV.DataSource = N_Propiedad.MostrarRegistro();
        }

        private void FrmPropiedadInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
