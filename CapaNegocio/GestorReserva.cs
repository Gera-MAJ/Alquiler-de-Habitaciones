
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class GestorReserva
    {
        private GestorConexion miGestorConexion;
        private DataTable miDT;
        private string consulta;
        private int idPersona;
        private int idServicio;
        
        private string txtNombreReserva;

        public GestorReserva() 
        {
            miDT = new DataTable();
            consulta = "";
            miGestorConexion = new GestorConexion();
            idPersona = 0;
            idServicio = 0;

            txtNombreReserva = "";
        }

        public void setIdServicio(int idServicio)
        {
            this.idServicio = idServicio;
        }

        public int getIdServicio()
        {
            return idServicio;
        }

        public void setIdPersona(int idPersona) 
        {
            this.idPersona = idPersona;
        }

        public int getIdPersona() 
        {
            return idPersona;
        }

        public DataTable llenarGridReserva()
        {    
            consulta = "SELECT dbo.Reserva.id_Reserva, dbo.Reserva.nombre, dbo.Reserva.dni, dbo.Reserva.Ingreso, dbo.Reserva.Salida, dbo.cant_Personas.cant_Persona, dbo.cant_Personas.precio, dbo.Servicio.tipo_Servicio, dbo.Servicio.Adicional FROM dbo.Reserva INNER JOIN dbo.cant_Personas ON dbo.Reserva.id_Personas = dbo.cant_Personas.id_Personas INNER JOIN dbo.Servicio ON dbo.Reserva.id_Servicio = dbo.Servicio.id_Servicio";
            SqlCommand cmd = new SqlCommand(consulta, miGestorConexion.getConexion());
            SqlDataAdapter miDA = new SqlDataAdapter(cmd);
            miDT.Clear();
            miDA.Fill(miDT);
            return miDT;
        }
        public DataTable llenarGridPersona()
        {
            //DataTable miDT = new DataTable();
            string consulta = "SELECT id_Personas, cant_Persona, precio FROM dbo.cant_Personas";
            SqlCommand cmd = new SqlCommand(consulta, miGestorConexion.getConexion());
            SqlDataAdapter miDA = new SqlDataAdapter(cmd);
            miDT.Clear();
            miDA.Fill(miDT);
            return miDT;
        }

        public DataTable llenarGridServicio()
        {
            //DataTable miDT = new DataTable();
            string consulta = "SELECT dbo.Servicio.* FROM dbo.Servicio";
            SqlCommand cmd = new SqlCommand(consulta, miGestorConexion.getConexion());
            SqlDataAdapter miDA = new SqlDataAdapter(cmd);
            miDT.Clear();
            miDA.Fill(miDT);
            return miDT;
        }



        //Función para admitir solo números
        public void SoloNumeros(KeyPressEventArgs v) 
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else 
            {
                v.Handled = true;
            }
        }

        //Función para admitir solo letras
        public void SoloLetras(KeyPressEventArgs v) 
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else 
            {
                v.Handled = true;
            }
        }
    }
}
