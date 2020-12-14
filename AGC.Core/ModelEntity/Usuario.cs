using System;
using System.Collections.Generic;
using System.Text;

namespace AGC.Core.ModelEntity
{
    public class Usuario
    {
        public int IdUsuario { get; set; } 
        public string Nombre { get; set; } 
        public DateTime  FecRegistro { get; set; }
        public string Correo { get; set; } 
        public string Contraseña { get; set; }
    }
}
