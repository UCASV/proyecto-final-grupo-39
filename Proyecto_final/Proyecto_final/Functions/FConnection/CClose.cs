using Microsoft.Data.SqlClient;

namespace Proyecto_final.Functions.FConnection
{
    public class CClose : IConecction
    {
        public void conection(string conectionString)
        {
            SqlConnection conect = new SqlConnection(conectionString);
            conect.Close();
        }
    }
}