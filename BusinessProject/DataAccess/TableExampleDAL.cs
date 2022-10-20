using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessProject.Models;
using BusinessProject.Persistenece;

namespace BusinessProject.DataAccess
{
    public class TableExampleDAL
    {
        //Metodo parra obtener el listado
        public List<TableExampleML> GetListaTableExample()
        {
            List<TableExampleML> Lista = new List<TableExampleML>();

            using (BDPasajeEntities ceoContext = new BDPasajeEntities())
            {
                Lista = (from con in ceoContext.Usuarios
                         join JoinRol in ceoContext.Rols
                         on con.IIDROL equals JoinRol.IIDROL
                         select new TableExampleML
                         {
                             IIDUsuario = con.IIDUSUARIO,
                             NombreUsuerio = con.NOMBREUSUARIO,
                             TipoUsuario = con.TIPOUSUARIO,
                             IIDRol = (int)con.IIDROL,
                             Rol_Nombre = JoinRol.NOMBRE
                         }).ToList();
            }

            return (Lista);
        }
    }
}
