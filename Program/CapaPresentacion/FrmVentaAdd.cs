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
    public partial class FrmVentaAdd : Form
    {

        readonly E_Venta ObjEntidad = new E_Venta();
        readonly N_Venta ObjNegocio = new N_Venta();
        readonly E_Alquiler ObjEntidadA = new E_Alquiler();
        readonly N_Alquiler ObjNegocioA = new N_Alquiler();

        public FrmVentaAdd()
        {
            InitializeComponent();
        }

        private void MensajeConfirmacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Comfy House", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Comfy House", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void LimpiarCajas()
        {
            TxtPrecioA.Text = "";
            TxtDNIA.Text = "";
            //TxtNombreA.Text = "";
            //TxtTelefonoA.Text = "";
            TxtPrecioV.Text = "";
            TxtDNIV.Text = "";
            //TxtNombreV.Text = "";
            //TxtTelefonoV.Text = "";
            TxtCuotas.Text = "";
            TxtPrecioCuotas.Text = "";
        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
            try
            {
                ObjEntidad.Fecha = DTPFechaV.Value.Date;
                ObjEntidad.Precio = Convert.ToInt32(TxtPrecioV.Text);
                ObjEntidad.DNICliente = Convert.ToInt32(TxtDNIV.Text);


                ObjNegocio.InsertarRegistro(ObjEntidad);

                MensajeConfirmacion("Se insertó correctamente");
                LimpiarCajas();
            }
            catch (Exception ex)
            {
                MensajeError("No se pudo insertar el registro " + ex.Message);
            }
        }

        private void BtnAlquiler_Click(object sender, EventArgs e)
        {
            try
            {
                ObjEntidadA.FechaInicio = DtpFechaAI.Value.Date;
                ObjEntidadA.FechaFin = DtpFechaAF.Value.Date;
                ObjEntidadA.Precio = Convert.ToInt32(TxtPrecioA.Text);
                ObjEntidadA.DNICliente = Convert.ToInt32(TxtDNIA.Text);
                ObjEntidadA.Cuotas = Convert.ToInt32(TxtCuotas.Text);
                ObjEntidadA.PrecioPorCuotas = Convert.ToDouble(TxtPrecioA.Text) / Convert.ToDouble(TxtCuotas.Text);

                ObjNegocioA.InsertarRegistro(ObjEntidadA);

                MensajeConfirmacion("Se insertó correctamente");
                LimpiarCajas();
            }
            catch (Exception ex)
            {
                MensajeError("No se pudo insertar el registro " + ex.Message);
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(TxtPrecioA.Text) / Convert.ToDouble(TxtCuotas.Text);
            TxtPrecioCuotas.Text = result.ToString();
        }

        private void TxtNombreA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTelefonoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombreV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtTelefonoV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
