using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.Models
{
    public class EmpleadoML
    {
        [DisplayName("Id empleado")]
        public int IdEmpleado { get; set; }

        [DisplayName("Nombre")]
        public string NombreEmpledo { get; set; }

        [DisplayName("Apellido paterno")]
        public string ApPaternoEmpleado { get; set; }

        [DisplayName("Apellido materno")]
        public string ApMAternoEmpleado { get; set; }

        [DisplayName("Fecha contrato")]
        public DateTime? FechaContratoEmpleado { get; set; }

        [DisplayName("Id tipo contrato")]
        public int IdTipoContrato { get; set; }

        [DisplayName("Tipo contrato")]
        public string TipoContratoNombre { get; set; }
    }
}
