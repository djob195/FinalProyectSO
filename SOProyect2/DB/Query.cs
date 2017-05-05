using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOProyect2.DB
{
    class Query
    {
        public static string insertListaTransaccion(string origen, string destino)
        {
            return @"INSERT INTO lista_transaccion
                    VALUES('" + origen + "','" + destino + "')";
        }

        public static string deleteListaTransaccion(string origen, string destino)
        {
            return @"DELETE FROM lista_transaccion
                    WHERE Id = (SELECT MAX(Id)
                                FROM lista_transaccion
                                WHERE Origen = '" + origen + "' " +
                                "AND Destino = '" + destino + "')";
        }
    }
}
