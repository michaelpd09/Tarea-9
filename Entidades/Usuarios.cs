using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int IDusuario { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }

    }
}
