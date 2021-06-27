using Microsoft.Data.SqlClient;

namespace Part_A.Functions.FConnection
{
    public class COpen: IConecction
    {
        public void conection(string conectionString)
        {
            SqlConnection conect = new SqlConnection(conectionString);
            conect.Open();
        }
    }
}