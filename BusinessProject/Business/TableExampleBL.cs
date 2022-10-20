using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessProject.DataAccess;
using BusinessProject.Models;

namespace BusinessProject.Business
{
    public class TableExampleBL
    {
        public List<TableExampleML> ListaTableExample()
        {
            //Instancia de Objeto del DAL
            TableExampleDAL oTableExampleDAL = new TableExampleDAL();

            //Lista de elementos a retornar
            List<TableExampleML> Lista = new List<TableExampleML>();

            //Agregar a la Lista los elementos que traemos de la BD
            Lista = oTableExampleDAL.GetListaTableExample();

            return Lista;
        }
    }
}
