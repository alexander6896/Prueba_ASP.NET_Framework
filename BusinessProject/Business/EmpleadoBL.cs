using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessProject.Models;
using BusinessProject.DataAccess;

namespace BusinessProject.Business
{
    public class EmpleadoBL
    {
        public List<EmpleadoML> EmpleadoLista()
        {
            List<EmpleadoML> oLista = new List<EmpleadoML>();

            EmpleadoDAL oEmpleadoDAL = new EmpleadoDAL();

            oLista = oEmpleadoDAL.GetEmpleado();

            return oLista;
        }
    }
}
