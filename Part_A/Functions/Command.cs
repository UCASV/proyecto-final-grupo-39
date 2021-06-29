using System;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Part_A.Functions
{
    public class Command
    {
        public string cnn = "Server=LAPTOP-HF5FGEQ6;Database=BancoDatos;Trusted_Connection=True;";
        public SqlConnection connection;
        private object id = 0;
        public Command()
        {
            this.connection = new SqlConnection(cnn);
        }
        public bool CStringComparer(string comparingObject, int column, string query)
        {
            id = 0;
            connection.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            bool output = false;
            command = new SqlCommand(query, connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if ((string)dataReader.GetValue(column) == comparingObject)
                {
                    output = true;
                    id = dataReader.GetValue(0);
                }
            }
            
            dataReader.Close();
            command.Dispose();
            connection.Close();
            return output;
        }

        public DataSet CShowTable(string query, string tableName)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            
            connection.Open();
            dataAdapter.Fill(ds, tableName);
            connection.Close();
            
            return ds;
        }


        public void CInserRegister(string cabin)
        {
            DateTime registerTime = DateTime.Now;
            string query = "INSERT INTO REGISTRO (id_gestor,cabina,fecha_hora) VALUES (@Id,@Cabin,@RegisterTime);";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@Id", SqlDbType.Int);
            cmd.Parameters["@Id"].Value = (int) id;
            cmd.Parameters.Add("@Cabin", SqlDbType.VarChar);
            cmd.Parameters["@Cabin"].Value = cabin;
            cmd.Parameters.Add("@RegisterTime", SqlDbType.DateTime);
            cmd.Parameters["@RegisterTime"].Value = registerTime;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

    }
}