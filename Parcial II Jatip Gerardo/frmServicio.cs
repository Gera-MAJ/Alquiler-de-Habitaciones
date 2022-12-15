using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace Parcial_II_Jatip_Gerardo
{
    public partial class frmServicio : Form
    {
        public GestorConexion miGestorConexion;
        public GestorReserva miGestorReserva;

        public frmServicio()
        {
            InitializeComponent();
            miGestorConexion = new GestorConexion();
            miGestorReserva = new GestorReserva();
            
        }

        private void frmServicio_Load(object sender, EventArgs e)
        {
            dgvServicio.DataSource = miGestorReserva.llenarGridServicio();
            dgvServicio.ReadOnly = true;
            txtCodigoServicio.ReadOnly = true;
            dgvServicio.ClearSelection();
        }

        private void dgvServicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice != -1)
            {
                txtCodigoServicio.Text = dgvServicio.Rows[indice].Cells[0].Value.ToString();
                txtNombreServicio.Text = dgvServicio.Rows[indice].Cells[1].Value.ToString();
                txtPrecioServicio.Text = dgvServicio.Rows[indice].Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un campo válido");
            }
        }

        private void irAMenúReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReservas frmReservas1 = new frmReservas();
            frmReservas1.Show();
        }

        private void irAMenúPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPersona frmPersona1 = new frmPersona();
            frmPersona1.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está Seguro?", "Cerrar Ooking", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void borrarCampos()
        {
            txtCodigoServicio.Clear();
            txtNombreServicio.Clear();
            txtPrecioServicio.Clear();
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            int valor = 0;
            int indice = 0;
            int idReserva = 0;

            if (Convert.ToInt32(txtPrecioServicio.Text) >= 0 && txtNombreServicio != null)
            {
                if (MessageBox.Show("Agregar Servicio?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    string consulta = "insert into Servicio (id_Servicio, tipo_Servicio, Adicional) values (@id_Servicio, @tipo_Servicio, @Adicional)";
                    SqlCommand cmd = new SqlCommand(consulta, miGestorConexion.getConexion());
                    valor = dgvServicio.Rows.Count;
                    indice = valor - 2;
                    idReserva = Convert.ToInt32(dgvServicio.Rows[indice].Cells[0].Value) + 1;
                    cmd.Parameters.AddWithValue("@id_Servicio", idReserva);
                    cmd.Parameters.AddWithValue("@tipo_Servicio", txtNombreServicio.Text);
                    cmd.Parameters.AddWithValue("@Adicional", Convert.ToInt32(txtPrecioServicio.Text));
                    miGestorConexion.abrirConexion();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los datos fueron ingresados");
                    cmd.Parameters.Clear();
                    dgvServicio.DataSource = miGestorReserva.llenarGridServicio();
                    miGestorConexion.cerrarConexion();
                    borrarCampos();
                }
            }
            else
            {
                MessageBox.Show("Colocar un precio correcto");
            }

            
        }

        private void btnEditarServicio_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtPrecioServicio.Text) >= 0)
            {
                if (MessageBox.Show("Editar Servicio?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    string consulta = "update Servicio set tipo_Servicio = @tipo_Servicio, Adicional= @Adicional where id_Servicio = @id_Servicio";
                    SqlCommand cmd = new SqlCommand(consulta, miGestorConexion.getConexion());
                    cmd.Parameters.AddWithValue("@id_Servicio", Convert.ToInt32(txtCodigoServicio.Text));
                    cmd.Parameters.AddWithValue("@tipo_Servicio", txtNombreServicio.Text);
                    cmd.Parameters.AddWithValue("@Adicional", Convert.ToInt32(txtPrecioServicio.Text));
                    miGestorConexion.abrirConexion();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los datos se cambiaron correctamente");
                    dgvServicio.DataSource = miGestorReserva.llenarGridServicio();
                    miGestorConexion.cerrarConexion();
                    borrarCampos();
                }
            }
            else
            {
                MessageBox.Show("Colocar un precio correcto");
            }
            
        }

        private void btnBorrarServicio_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea borrar el servicio?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                string consulta = "delete from Servicio where id_Servicio = @id_Servicio";
                SqlCommand cmd = new SqlCommand(consulta, miGestorConexion.getConexion());
                cmd.Parameters.AddWithValue("@id_Servicio", Convert.ToInt32(txtCodigoServicio.Text));
                miGestorConexion.abrirConexion();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se borraron los datos correctamente");
                dgvServicio.DataSource = miGestorReserva.llenarGridServicio();
                miGestorConexion.cerrarConexion();
                borrarCampos();
            }
        }

        private void txtPrecioServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            miGestorReserva.SoloNumeros(e);
        }
    }
}
