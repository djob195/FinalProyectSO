using SOProyect2.DB;
using SOProyect2.Enum;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOProyect2.Class
{
    class ExecutorQuery
    {
        string Destine;
        string Origen;
        public int Register;
        SQLExecutor SQLExecutor;

        public ExecutorQuery(string origen, string destine,int register, SQLExecutor SQLexecutor)
        {
            if (register<1)
            {
                throw new Exception("Error 5: No se ha asignado la cantidad  de registros");
            }
            this.Register = register;
            if (string.IsNullOrWhiteSpace(origen))
            {
                throw new Exception("Error 1: No se ha definido el Origen");
            }
            if (origen.Length > 5)
            {
                throw new Exception("Error 2: El tamaño del origen, debe ser de 5 caracteres");
            }
            this.Origen = origen;
            if (string.IsNullOrWhiteSpace(destine))
            {
                throw new Exception("Error 3: No se ha definido el Destino");
            }
            if (destine.Length > 5)
            {
                throw new Exception("Error 4: El tamaño del destino, debe ser de 5 caracteres");
            }
            this.Destine = destine;
            this.SQLExecutor = SQLexecutor;
        }

        public void executeQuery()
        {
            SqlConnection con = new SqlConnection(Connection.ConnectionString);
            con.Open();
            string query = (this.SQLExecutor == SQLExecutor.insert) ? Query.insertListaTransaccion(this.Origen, this.Destine) :
                Query.deleteListaTransaccion(this.Origen, this.Destine);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string getData()
        {
            return "(" + this.Origen + "-" + this.Destine + ")";
        }

        public static string getSQLExecutorString(SQLExecutor SQLexecutor)
        {
            switch (SQLexecutor)
            {
                case SQLExecutor.insert:
                    return "Insert";
                case SQLExecutor.delete:
                    return "Delete";
                default:
                    return "";
            }
        }
    }
}
