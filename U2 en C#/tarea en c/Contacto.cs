using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_en_c
{
    internal class Contacto: Persona
    {
        private string telefono;
        private string correo;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value.Replace(" ", "").Replace(".", "").Substring(0, 10); }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public Contacto() : base()
        {
            correo = string.Empty;
            telefono = string.Empty;
        }
        public override string ToString()
        {
            return base.ToString() + " " + telefono + " " + correo;
           
        }
    }
}
