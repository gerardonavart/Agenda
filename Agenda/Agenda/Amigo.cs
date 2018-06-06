using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
    public class Amigo
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Apodo { get; set; }
        public override string ToString()
        {
            return String.Format("{0} ({1}): [{2}]", Nombre, Apodo, Telefono);
        }
    }
}
