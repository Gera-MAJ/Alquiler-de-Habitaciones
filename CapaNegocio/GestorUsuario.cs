using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class GestorUsuario
    {
        private string usuario;
        private string contrasenia;
        public GestorUsuario() 
        {
            usuario = "";
            contrasenia = "";
        }

        public void setUsuario(string usuario)
        {
            this.usuario = usuario;
        }

        public string getUsuario()
        {
            return usuario;
        }

        public void setContrasenia(string contrasenia)
        {
            this.contrasenia = contrasenia;
        }
        public string getContrasenia()
        {
            return contrasenia;
        }

    }
}
