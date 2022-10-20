using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessProject.Models;
using BusinessProject.Persistenece;

namespace BusinessProject.DataAccess
{
    public class EmpleadoDAL
    {
        public List<EmpleadoML> GetEmpleado()
        {
            List<EmpleadoML> oLista = new List<EmpleadoML>();

            using (BDPasajeEntities ceoContext = new BDPasajeEntities())
            {
                oLista = (from E in ceoContext.Empleadoes
                          join TC in ceoContext.TipoContratoes
                          on E.IIDTIPOCONTRATO equals TC.IIDTIPOCONTRATO
                          select new EmpleadoML
                          {
                              IdEmpleado = E.IIDEMPLEADO,
                              NombreEmpledo = E.NOMBRE,
                              ApPaternoEmpleado = E.APPATERNO,
                              ApMAternoEmpleado = E.APMATERNO,
                              FechaContratoEmpleado = E.FECHACONTRATO,
                              IdTipoContrato = TC.IIDTIPOCONTRATO,
                              TipoContratoNombre = TC.NOMBRE
                          }
                        ).ToList();
            }

            return oLista;
        }
    }
}
