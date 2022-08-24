using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App02.Clases
{
    public class cPersona
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public cPersona()
        {
            Identificacion = "";
            Nombre = "";
            Apellidos = "";
            FechaNacimiento = DateTime.Now;

        } 

    }
}
