using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.Models
{
    public class TableExampleML
    {
        //Elementos que llevara la Table example
        [DisplayName("Id usuario")]
        public int IIDUsuario { get; set; }

        [DisplayName("Nombre usuario")]
        public string NombreUsuerio { get; set; }

        [DisplayName("Id tipo usuario")]
        public string TipoUsuario { get; set; }

        [DisplayName("Id rol")]
        public int IIDRol { get; set; }

        [DisplayName("Rol nombre")]
        public string Rol_Nombre { get; set; }
    }
}
