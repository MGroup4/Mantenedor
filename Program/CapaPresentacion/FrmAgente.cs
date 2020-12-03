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
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FrmAgente : Form
    {

        private bool Editar = false;
        readonly E_AgenteDeInmobiliaria ObjEntidad = new E_AgenteDeInmobiliaria();
        readonly N_AgenteInmobiliaria ObjNegocio = new N_AgenteInmobiliaria();

        public FrmAgente()
        {
            InitializeComponent();
        }

        public void MostrarRegistro()
        {
            DGV.DataSource = N_AgenteInmobiliaria.MostrarRegistro();
        }

        private void FormAgentes_Load(object sender, EventArgs e)
        {
            MostrarRegistro();
            label4.Focus();
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
            TxtID.Text = "";
            TxtNombre.Text = "";
            TxtUsuarioID.Text = "";
            TxtDNI.Text = "";
            TxtTelefono.Text = "";
            TxtID.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(Editar == false)
            {
                try
                {
                    ObjEntidad.AgenteDeInmobiliariaID = Convert.ToInt32(TxtID.Text);
                    ObjEntidad.Nombre = TxtNombre.Text.ToUpper();
                    ObjEntidad.UsuarioID = Convert.ToInt32(TxtUsuarioID.Text);
                    ObjEntidad.DNI = Convert.ToInt32(TxtDNI.Text);
                    ObjEntidad.Telefono = Convert.ToInt32(TxtTelefono.Text);

                    ObjNegocio.InsertarRegistro(ObjEntidad);

                    MensajeConfirmacion("Se insertó correctamente");
                    MostrarRegistro();
                    LimpiarCajas();
                }
                catch (Exception ex)
                {
                    MensajeError("No se pudo insertar el registro - "+ex.Message);
                }
            }
            if(Editar == true)
            {
                try
                {
                    ObjEntidad.AgenteDeInmobiliariaID = Convert.ToInt32(TxtID.Text);
                    ObjEntidad.Nombre = TxtNombre.Text;
                    ObjEntidad.UsuarioID = Convert.ToInt32(TxtUsuarioID.Text);
                    ObjEntidad.DNI = Convert.ToInt32(TxtDNI.Text);
                    ObjEntidad.Telefono = Convert.ToInt32(TxtTelefono.Text);

                    ObjNegocio.EditarRegistro(ObjEntidad);


                    MensajeConfirmacion("Se editó correctamente");
                    MostrarRegistro();
                    LimpiarCajas();
                }
                catch (Exception)
                {
                    MensajeError("No se pudo editar el registro.");
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(DGV.SelectedRows.Count > 0)
            {
                Editar = true;
                TxtID.Text = DGV.CurrentRow.Cells[0].Value.ToString();
                TxtNombre.Text = DGV.CurrentRow.Cells[1].Value.ToString();
                TxtUsuarioID.Text = DGV.CurrentRow.Cells[2].Value.ToString();
                TxtDNI.Text = DGV.CurrentRow.Cells[3].Value.ToString();
                TxtTelefono.Text = DGV.CurrentRow.Cells[4].Value.ToString();

                TxtID.Focus();
            }
            else
            {
                MensajeError("Seleccione una fila primero.");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Desea eliminar este registro?", "Comfy House", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(opcion == DialogResult.OK)
                {
                    ObjEntidad.AgenteDeInmobiliariaID = Convert.ToInt32(DGV.CurrentRow.Cells[0].Value);

                    ObjNegocio.EliminarRegistro(ObjEntidad);

                    MensajeConfirmacion("El registro ha sido eliminado");
                    MostrarRegistro();
                }
                else
                {
                    MensajeError("Seleccione primero una fila a eliminar.");
                }
            }
        }
    }
}
