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
    public partial class frmReservas : Form
    {
        public GestorConexion miGestorConexion;
        public GestorReserva miGestorReserva;

        public frmReservas()
        {
            InitializeComponent();
            miGestorConexion = new GestorConexion();
            miGestorReserva = new GestorReserva();
            
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            //miGestorConexion.abrirConexion();
            //dgvReserva.DataSource = miGestorReserva.llenarGridReserva();
            dgvReserva.DataSource = miGestorReserva.llenarGridReserva();
            dgvReserva.ReadOnly = true;
            txtCodigo.ReadOnly = true;
            txtTotal.ReadOnly = true;
            llenarComboPersonas();
            llenarComboServicios();
            dgvReserva.ClearSelection();
        }   

        public void llenarComboPersonas()
        {
            //llenar un comboBox con datos de la tabla
            string consulta = "SELECT cant_Persona FROM cant_Personas";
            SqlCommand cmd = new SqlCommand(consulta, miGestorConexion.getConexion());
            miGestorConexion.abrirConexion();
            SqlDataReader miReader = cmd.ExecuteReader();
            while (miReader.Read())
            {
                cboPersona.Items.Add(miReader["cant_Persona"].ToString());
            }
            miGestorConexion.cerrarConexion();
        }

        public void llenarComboServicios()
        {
            //llenar un comboBox con datos de la tabla
            string consulta = "SELECT tipo_Servicio FROM Servicio";
            SqlCommand cmd = new SqlCommand(consulta, miGestorConexion.getConexion());
            miGestorConexion.abrirConexion();
            SqlDataReader miReader = cmd.ExecuteReader();
            while (miReader.Read())
            {
                cboServicio.Items.Add(miReader["tipo_Servicio"].ToString());
            }
            miGestorConexion.cerrarConexion();
        }

        private void dgvReserva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice != -1)
            {
                txtCodigo.Text = dgvReserva.Rows[indice].Cells[0].Value.ToString();
                txtNombre.Text = dgvReserva.Rows[indice].Cells[1].Value.ToString();
                txtDNI.Text = dgvReserva.Rows[indice].Cells[2].Value.ToString();
                dtpIngreso.Value = Convert.ToDateTime(dgvReserva.Rows[indice].Cells[3].Value);
                dtpSalida.Value = Convert.ToDateTime(dgvReserva.Rows[indice].Cells[4].Value);
                cboPersona.SelectedItem = dgvReserva.Rows[indice].Cells[5].Value;
                cboServicio.SelectedItem = dgvReserva.Rows[indice].Cells[7].Value;
                //Contar días entre DateTimePicker
                TimeSpan ts = dtpSalida.Value - dtpIngreso.Value;
                int dias = (int)ts.TotalDays;
                txtTotal.Text = "$ "+ Convert.ToString((Convert.ToInt32(dgvReserva.Rows[indice].Cells[6].Value) + Convert.ToInt32(dgvReserva.Rows[indice].Cells[8].Value)) * dias);
                  
            }
            else
            {
                MessageBox.Show("Seleccione un campo válido");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar un valor a la tabla
            if (txtDNI.Text != "")
            {
                if (Convert.ToInt32(txtDNI.Text) > 0)
                {
                    if (MessageBox.Show("Agregar nueva reservar?", "Insertar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int valor = 0;
                        int indice = 0;
                        int idReserva = 0;

                        string consulta = "INSERT INTO Reserva (id_Reserva, nombre, dni, Ingreso, Salida, id_Personas, id_Servicio) VALUES (@id_Reserva, @nombre, @dni, @Ingreso, @Salida, @id_Personas, @id_Servicio)";
                        SqlCommand cmd = new SqlCommand(consulta, miGestorConexion.getConexion());
                        valor = dgvReserva.Rows.Count;
                        indice = valor - 2;
                        idReserva = Convert.ToInt32(dgvReserva.Rows[indice].Cells[0].Value) + 1;
                        cmd.Parameters.AddWithValue("@id_Reserva", idReserva);
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@dni", txtDNI.Text);
                        cmd.Parameters.AddWithValue("@Ingreso", dtpIngreso.Value.Date);
                        cmd.Parameters.AddWithValue("@Salida", dtpSalida.Value.Date);
                        cmd.Parameters.AddWithValue("@id_Personas", miGestorReserva.getIdPersona());
                        cmd.Parameters.AddWithValue("@id_Servicio", miGestorReserva.getIdServicio());
                        miGestorConexion.abrirConexion();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Los datos fueron ingresados");
                        cmd.Parameters.Clear();
                        dgvReserva.DataSource = miGestorReserva.llenarGridReserva();
                        miGestorConexion.cerrarConexion();
                        borrarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un DNI válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos para agregar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Editar la fila
            if (Convert.ToInt32(txtDNI.Text) > 0)
            {
                if (MessageBox.Show("Modificar reserva?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    string consulta = "UPDATE Reserva SET id_Reserva=@id_Reserva, nombre=@nombre, dni=@dni, Ingreso=@Ingreso, Salida=@Salida, id_Personas=@id_Personas, id_Servicio=@id_Servicio WHERE id_Reserva=@id_Reserva";
                    SqlCommand cmd = new SqlCommand(consulta, miGestorConexion.getConexion());
                    cmd.Parameters.AddWithValue("@id_Reserva", txtCodigo.Text);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@dni", txtDNI.Text);
                    cmd.Parameters.AddWithValue("@Ingreso", dtpIngreso.Value.Date);
                    cmd.Parameters.AddWithValue("@Salida", dtpSalida.Value.Date);
                    cmd.Parameters.AddWithValue("@id_Personas", miGestorReserva.getIdPersona());
                    cmd.Parameters.AddWithValue("@id_Servicio", miGestorReserva.getIdServicio());
                    miGestorConexion.abrirConexion();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los datos se cambiaron correctamente");
                    dgvReserva.DataSource = miGestorReserva.llenarGridReserva();
                    miGestorConexion.cerrarConexion();
                    borrarCampos();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor permitido");
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Borrar una fila

            if (MessageBox.Show("Está seguro que desea borrar los datos?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                string consulta = "DELETE FROM Reserva WHERE id_Reserva=@id_Reserva";
                SqlCommand cmd = new SqlCommand(consulta, miGestorConexion.getConexion());
                cmd.Parameters.AddWithValue("@id_Reserva", txtCodigo.Text);
                miGestorConexion.abrirConexion();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se borraron los datos correctamente");
                dgvReserva.DataSource = miGestorReserva.llenarGridReserva();
                miGestorConexion.cerrarConexion();
                borrarCampos();
            }
            
        }

        public void borrarCampos()
        {
            txtNombre.Clear();
            txtDNI.Clear();
            txtCodigo.Clear();
            dtpIngreso.Value = DateTime.Now;
            dtpSalida.Value = DateTime.Now;
            cboPersona.SelectedIndex = -1;
            cboServicio.SelectedIndex = -1;
            txtTotal.Clear();
        }

        private void cboPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            index = cboPersona.SelectedIndex;
            miGestorReserva.setIdPersona(index + 1);
        }
        private void cboServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            index = cboServicio.SelectedIndex;
            miGestorReserva.setIdServicio(index + 1);
        }


        private void cargarTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPersona frmPersona1 = new frmPersona();
            frmPersona1.Show();
        }

        private void irAlMenúServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmServicio frmServicio1 = new frmServicio();
            frmServicio1.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está Seguro?", "Cerrar Ooking", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void integrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmIntegrante frmIntegrante1 = new frmIntegrante();
            frmIntegrante1.Show();
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            miGestorReserva.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            miGestorReserva.SoloLetras(e);
        }
    }
    
}
