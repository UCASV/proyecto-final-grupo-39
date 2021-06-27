using System.Data;
using Microsoft.Data.SqlClient;
using Part_A.Functions.FConnection;

namespace Part_A.Functions
{
    public class Command
    {
        public string cnn = "Server=LAPTOP-HF5FGEQ6;Database=BancoDatos;Trusted_Connection=True;";
        public SqlConnection connection = new SqlConnection("Server=LAPTOP-HF5FGEQ6;Database=BancoDatos;Trusted_Connection=True;");
        public COpen open = new COpen();
        public CClose close = new CClose();
        
        public string CStringComparer(string comparingObject, int column, string query)
        {
            open.conection(cnn);
            SqlCommand command;
            SqlDataReader dataReader;
            string output = "";
            command = new SqlCommand(query, connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if (dataReader.GetValue(column) == comparingObject)
                {
                    output += dataReader.GetValue(column);
                }
            }
            return output;
            dataReader.Close();
            command.Dispose();
            close.conection(cnn);
        }

        public DataSet CShowTable(string query, string tableName)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            
            open.conection(cnn);
            dataAdapter.Fill(ds, tableName);
            close.conection(cnn);
            
            return ds;
        }

        public void CInserRegister()
        {
            
        }

        public void CInsertCitizenI()
        {
            
        }

        public void CInsertVaccineDate()
        {
            
        }
    }
}