using Microsoft.Data.SqlClient;

namespace Part_A.Functions.FConnection
{
    public class IConecction
    {
        public interface IConnect
        {
            void conection(string conectionString);
        }
    }
}