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
    public partial class FrmUsuario : Form
    {
        private bool Editar = false;
        readonly E_Usuario ObjEntidad = new E_Usuario();
        readonly N_Usuario ObjNegocio = new N_Usuario();

        public FrmUsuario()
        {
            InitializeComponent();
        }

        public void MostrarRegistro()
        {
            DGV.DataSource = N_Usuario.MostrarRegistro();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            MostrarRegistro();
            TxtUsuarioID.Focus();
        }

        private void MensajeConfirmacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "INMOBILIRIA X", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "INMOBILIRIA X", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void LimpiarCajas()
        {
            Editar = false;
            TxtUsuarioID.Text = "";
            TxtTelefono.Text = "";
            TxtRango.Text = "";
            TxtNombre.Text = "";
            TxtDNI.Text = "";
            TxtContraseña.Text = "";
            TxtUsuarioID.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    ObjEntidad.UsuarioID = Convert.ToInt32(TxtUsuarioID.Text);
                    ObjEntidad.Nombre = TxtNombre.Text;
                    ObjEntidad.Contraseña = TxtContraseña.Text;
                    ObjEntidad.Rango = Convert.ToInt32(TxtRango.Text);
                    ObjEntidad.DNI = Convert.ToInt32(TxtDNI.Text);
                    ObjEntidad.Telefono = Convert.ToInt32(TxtTelefono.Text);

                    ObjNegocio.InsertarRegistro(ObjEntidad);

                    MensajeConfirmacion("Se insertó correctamente");
                    MostrarRegistro();
                    LimpiarCajas();
                }
                catch (Exception ex)
                {
                    MensajeError("No se pudo insertar el registro " + ex.Message);
                }
            }
            if (Editar == true)
            {
                try
                {
                    ObjEntidad.UsuarioID = Convert.ToInt32(TxtUsuarioID.Text);
                    ObjEntidad.Nombre = TxtNombre.Text;
                    ObjEntidad.Contraseña = TxtContraseña.Text;
                    ObjEntidad.Rango = Convert.ToInt32(TxtRango.Text);
                    ObjEntidad.DNI = Convert.ToInt32(TxtDNI.Text);
                    ObjEntidad.Telefono = Convert.ToInt32(TxtTelefono.Text);

                    ObjNegocio.EditarRegistro(ObjEntidad);

                    MensajeConfirmacion("Se modificó correctamente");
                    MostrarRegistro();
                    LimpiarCajas();
                }
                catch (Exception ex)
                {
                    MensajeError("No se pudo modificar el registro " + ex.Message);
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                Editar = true;

                TxtUsuarioID.Text = DGV.CurrentRow.Cells[0].Value.ToString();
                TxtContraseña.Text  = DGV.CurrentRow.Cells[1].Value.ToString();
                TxtRango.Text = DGV.CurrentRow.Cells[2].Value.ToString();
                TxtNombre.Text = DGV.CurrentRow.Cells[3].Value.ToString();
                TxtDNI.Text = DGV.CurrentRow.Cells[4].Value.ToString();
                TxtTelefono.Text = DGV.CurrentRow.Cells[5].Value.ToString();

                TxtUsuarioID.Focus();
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
                opcion = MessageBox.Show("¿Desea eliminar este registro?", "Valentina Market", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    ObjEntidad.UsuarioID = Convert.ToInt32(DGV.CurrentRow.Cells[0].Value.ToString());
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
