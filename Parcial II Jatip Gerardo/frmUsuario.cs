using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Parcial_II_Jatip_Gerardo
{
    public partial class frmInicio : Form
    {
        public GestorUsuario miGestorUsuario;
        
        public frmInicio()
        {
            InitializeComponent();
            miGestorUsuario = new GestorUsuario();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            miGestorUsuario.setUsuario(txtUsuario.Text);
            miGestorUsuario.setContrasenia(txtContrasenia.Text);

            if (miGestorUsuario.getUsuario() == "geramaj" && miGestorUsuario.getContrasenia() == "cardio87")
            {
                this.Hide();
                frmReservas frmReservas1 = new frmReservas();
                frmReservas1.Show();

                MessageBox.Show("Bienvenid@ "+ miGestorUsuario.getUsuario() + " a Ooking!");
            }
            else
            {
                MessageBox.Show("Debe ingresar un usuario y contraseña correctos");
            }


        }

    }
}
