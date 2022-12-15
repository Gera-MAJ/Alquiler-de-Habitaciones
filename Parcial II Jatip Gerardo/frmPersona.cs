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
    public partial class frmPersona : Form
    {
        public GestorConexion miGestorConexion;
        public GestorReserva miGestorReserva;

        public frmPersona()
        {
            InitializeComponent();
            miGestorConexion = new GestorConexion();
            miGestorReserva = new GestorReserva();
            
        }

       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Botón para preguntar si se quiere salir
            if (MessageBox.Show("Está Seguro?", "Cerrar Ooking", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmPersona_Load(object sender, EventArgs e)
        {
            dgvPersona.DataSource = miGestorReserva.llenarGridPersona();
            dgvPersona.ReadOnly = true;
            txtCodigo.ReadOnly = true;
            dgvPersona.ClearSelection();
        }

        private void dgvPersona_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice != -1)
            {
                txtCodigo.Text = dgvPersona.Rows[indice].Cells[0].Value.ToString();
                txtNombre.Text = dgvPersona.Rows[indice].Cells[1].Value.ToString();
                txtPrecio.Text = dgvPersona.Rows[indice].Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un campo válido");
            }
        }

        private void irAReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReservas frmReservas1 = new frmReservas();
            frmReservas1.Show();
        }

       
        public void borrarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCodigo.Clear();
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            int valor = 0;
            int indice = 0;
            int idReserva = 0;

            if (Convert.ToInt32(txtPrecio.Text) >= 0)
            {
                if (MessageBox.Show("Agregar Habitación?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    string consulta = "INSERT INTO cant_Personas (id_Personas, cant_Persona, precio) VALUES (@id_Personas, @cant_Persona, @precio)";
                    SqlCommand cmd = new SqlCommand(consulta, miGestorConexion.getConexion());
                    valor = dgvPersona.Rows.Count;
                    indice = valor - 2;
                    idReserva = Convert.ToInt32(dgvPersona.Rows[indice].Cells[0].Value) + 1;
                    cmd.Parameters.AddWithValue("@id_Personas", idReserva);
                    cmd.Parameters.AddWithValue("@cant_Persona", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@precio", Convert.ToInt32(txtPrecio.Text));
                    miGestorConexion.abrirConexion();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los datos fueron ingresados");
                    cmd.Parameters.Clear();
                    dgvPersona.DataSource = miGestorReserva.llenarGridPersona();
                    miGestorConexion.cerrarConexion();
                    borrarCampos();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un precio correcto");
            }

            
        }

        private void btnEditarPersona_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtPrecio.Text) >= 0)
            {
                if (MessageBox.Show("Editar Habitación?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    string consulta = "UPDATE cant_Personas SET cant_Persona=@cant_Persona, precio=@precio WHERE id_Personas=@id_Personas";
                    SqlCommand cmd = new SqlCommand(consulta, miGestorConexion.getConexion());
                    cmd.Parameters.AddWithValue("@id_Personas", Convert.ToInt32(txtCodigo.Text));
                    cmd.Parameters.AddWithValue("@cant_Persona", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@precio", Convert.ToInt32(txtPrecio.Text));
                    miGestorConexion.abrirConexion();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los datos se cambiaron correctamente");
                    dgvPersona.DataSource = miGestorReserva.llenarGridPersona();
                    miGestorConexion.cerrarConexion();
                    borrarCampos();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un precio correcto");
            }
            
        }

        private void btnBorrarPersona_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea borrar?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes) 
            {
                string consulta = "DELETE FROM cant_Personas WHERE id_Personas=@id_Personas";
                SqlCommand cmd = new SqlCommand(consulta, miGestorConexion.getConexion());
                cmd.Parameters.AddWithValue("@id_Personas", Convert.ToInt32(txtCodigo.Text));
                miGestorConexion.abrirConexion();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se borraron los datos correctamente");
                dgvPersona.DataSource = miGestorReserva.llenarGridPersona();
                miGestorConexion.cerrarConexion();
                borrarCampos();
            }
                
        }

        private void irAServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmServicio frmServicio1 = new frmServicio();
            frmServicio1.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está Seguro?", "Cerrar Ooking", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            miGestorReserva.SoloNumeros(e);
        }
    }
}
