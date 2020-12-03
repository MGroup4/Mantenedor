using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FrmPropiedad : Form
    {

        private bool Editar = false;
        readonly E_Propiedad ObjEntidad = new E_Propiedad();
        readonly N_Propiedad ObjNegocio = new N_Propiedad();

        public FrmPropiedad()
        {
            InitializeComponent();
        }

        public void MostrarRegistro()
        {
            DGV.DataSource = N_Propiedad.MostrarRegistro();
        }

        private void FrmPropiedad_Load(object sender, EventArgs e)
        {
            MostrarRegistro();
            TxtPropiedadID.Focus();
        }

        private void MensajeConfirmacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Comfy House", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Comfy House", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LimpiarCajas()
        {
            Editar = false;
            TxtPropiedadID.Text = "";
            TxtAgente.Text = "";
            TxtValorDeVenta.Text = "";
            TxtUbicacion.Text = "";
            TxtDormitorios.Text = "";
            TxtBaños.Text = "";
            TxtEstacionamiento.Text = "";
            TxtTamaño.Text = "";
            TxtPropiedadID.Focus();
        }

        private void BtnGuardarr_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {

                    ObjEntidad.PropiedadID = Convert.ToInt32(TxtPropiedadID.Text.ToUpper());
                    ObjEntidad.AgenteDeInmobiliariaID =  Convert.ToInt32(TxtAgente.Text.ToUpper());
                    ObjEntidad.ValorDeVenta = Convert.ToInt32(TxtValorDeVenta.Text.ToUpper());
                    ObjEntidad.Ubicacion = TxtUbicacion.Text.ToUpper();
                    ObjEntidad.Dormitorios = Convert.ToInt32(TxtDormitorios.Text.ToUpper());
                    ObjEntidad.Baños = Convert.ToInt32(TxtBaños.Text.ToUpper());
                    ObjEntidad.Estacionamiento = Convert.ToInt32(TxtEstacionamiento.Text.ToUpper());
                    ObjEntidad.Tamaño = Convert.ToInt32(TxtTamaño.Text.ToUpper());

                    ObjNegocio.InsertarRegistro(ObjEntidad);

                    MensajeConfirmacion("Se insertó correctamente");
                    MostrarRegistro();
                    LimpiarCajas();
                }
                catch (Exception)
                {
                    MensajeError("No se pudo insertar el registro");
                }
            }
            if (Editar == true)
            {
                try
                {
                    ObjEntidad.PropiedadID = Convert.ToInt32(TxtPropiedadID.Text.ToUpper());
                    ObjEntidad.AgenteDeInmobiliariaID = Convert.ToInt32(TxtAgente.Text.ToUpper());
                    ObjEntidad.ValorDeVenta = Convert.ToInt32(TxtValorDeVenta.Text.ToUpper());
                    ObjEntidad.Ubicacion = TxtUbicacion.Text.ToUpper();
                    ObjEntidad.Dormitorios = Convert.ToInt32(TxtDormitorios.Text.ToUpper());
                    ObjEntidad.Baños = Convert.ToInt32(TxtBaños.Text.ToUpper());
                    ObjEntidad.Estacionamiento = Convert.ToInt32(TxtEstacionamiento.Text.ToUpper());
                    ObjEntidad.Tamaño = Convert.ToInt32(TxtTamaño.Text.ToUpper());

                    ObjNegocio.EditarRegistro(ObjEntidad);

                    MensajeConfirmacion("Se modificó correctamente");
                    MostrarRegistro();
                    LimpiarCajas();
                }
                catch (Exception)
                {
                    MensajeError("No se pudo modificar el registro");
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                Editar = true;
                TxtPropiedadID.Text = DGV.CurrentRow.Cells[0].Value.ToString();
                TxtAgente.Text = DGV.CurrentRow.Cells[1].Value.ToString();
                TxtValorDeVenta.Text = DGV.CurrentRow.Cells[2].Value.ToString();
                TxtUbicacion.Text = DGV.CurrentRow.Cells[3].Value.ToString();
                TxtDormitorios.Text = DGV.CurrentRow.Cells[4].Value.ToString();
                TxtBaños.Text = DGV.CurrentRow.Cells[5].Value.ToString();
                TxtEstacionamiento.Text = DGV.CurrentRow.Cells[6].Value.ToString();
                TxtTamaño.Text = DGV.CurrentRow.Cells[7].Value.ToString();
                TxtPropiedadID.Focus();
            }
            else
            {
                MensajeError("Seleccione una fila primero");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Desea eliminar este registro?", "Comfy House", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    ObjEntidad.PropiedadID = Convert.ToInt32(DGV.CurrentRow.Cells[0].Value);
                    ObjNegocio.EliminarRegistro(ObjEntidad);

                    MensajeConfirmacion("Se eliminó correctamente el registro.");

                    MostrarRegistro();
                }
            }
            else
            {
                MensajeError("Seleccione primero una fila a eliminar");
            }
        }
    }
}
