using System;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Part_A.Functions
{
    public class Command
    {
        public string cnn = "Server=SQLEXPRESS;Database=BancoDatos;Trusted_Connection=True;";
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
        
        public void CInsertCitizenI(string Dui, string direccion,string nombre,string correo,string telefono,string cronica, string prioridad)
        {
            string query = 
                "INSERT INTO CIUDADANO (dui_ciudadano, domicilio, nombre, correo_electronico, telefono, enfermedades_cronicas, prioridad) VALUES (@Dui,@Direccion,@Nombre,@Correo,@Telefono,@Cronica,@Prioridad)";
            
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            
            cmd.Parameters.Add("@Dui", SqlDbType.VarChar);
            cmd.Parameters["@Dui"].Value = Dui;
            cmd.Parameters.Add("@Direccion", SqlDbType.VarChar);
            cmd.Parameters["@Direccion"].Value = direccion;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            cmd.Parameters["@Nombre"].Value = nombre;
            cmd.Parameters.Add("@Correo", SqlDbType.VarChar);
            cmd.Parameters["@Correo"].Value = correo;
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar);
            cmd.Parameters["@Telefono"].Value = telefono;
            cmd.Parameters.Add("@Cronica", SqlDbType.VarChar);
            cmd.Parameters["@Cronica"].Value = cronica;
            cmd.Parameters.Add("@Prioridad", SqlDbType.VarChar);
            cmd.Parameters["@Prioridad"].Value = prioridad;
            
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void CInsertApointment1(DateTime fecha, int id_lugar_vacunacion,string dui)
        {
            string query = "INSERT INTO PRIMERA_CITA(fecha_hora, id_lugar_vacunacion) VALUES (@Fecha,@IdLugar)";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            
            cmd.Parameters.Add("@Fecha", SqlDbType.DateTime);
            cmd.Parameters["@Fecha"].Value = fecha;
            cmd.Parameters.Add("@IdLugar", SqlDbType.Int);
            cmd.Parameters["@IdLugar"].Value = id_lugar_vacunacion;
            
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("SELECT @@IDENTITY FROM PRIMERA_CITA", connection);
            int id = Convert.ToInt32(cmd2.ExecuteScalar());
            SqlCommand cmd3 = new SqlCommand("UPDATE CIUDADANO SET id_primera_cita = @PCita WHERE dui_ciudadano = @Dui", connection);

            cmd3.Parameters.Add("@PCita", SqlDbType.Int);
            cmd3.Parameters["@PCita"].Value = id;
            cmd3.Parameters.Add("@Dui", SqlDbType.VarChar);
            cmd3.Parameters["@Dui"].Value = dui;

            cmd3.ExecuteNonQuery();
            connection.Close();
        }
        
        public void CInsertApointment2(DateTime fecha, int id_lugar_vacunacion_2,string dui)
        {
            int Id_primera_cita = CGetAppointmentFromDui(dui);
            string query = "INSERT INTO SEGUNDA_CITA(fecha_hora, id_lugar_vacunacion_2, id_primera_cita) VALUES (@Fecha,@IdLugar,@PCita)";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            
            cmd.Parameters.Add("@Fecha", SqlDbType.DateTime);
            cmd.Parameters["@Fecha"].Value = fecha;
            cmd.Parameters.Add("@IdLugar", SqlDbType.Int);
            cmd.Parameters["@IdLugar"].Value = id_lugar_vacunacion_2;
            cmd.Parameters.Add("@PCita", SqlDbType.Int);
            cmd.Parameters["@PCita"].Value = Id_primera_cita;
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("SELECT @@IDENTITY FROM SEGUNDA_CITA", connection);
            int id = Convert.ToInt32(cmd2.ExecuteScalar());
            SqlCommand cmd3 = new SqlCommand("UPDATE PRIMERA_CITA SET id_segunda_cita = @PCita WHERE id_primera_cita = @Id", connection);

            cmd3.Parameters.Add("@PCita", SqlDbType.Int);
            cmd3.Parameters["@PCita"].Value = id;
            cmd3.Parameters.Add("@Id", SqlDbType.Int);
            
           
            
            cmd3.Parameters["@Id"].Value = Id_primera_cita;

            cmd3.ExecuteNonQuery();
            connection.Close();
        }

        
        public void CInsertSecondaryEffect(int tiempo, string efecto, string dui)
        {
            
            string query = "INSERT INTO EFECTO_SECUNDARIO(id_primera_cita, tiempo, efecto_secundario) VALUES (@Idcita,@Tiempo,@Efecto)";
            int Id_primera_cita=CGetAppointmentFromDui(dui);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@Tiempo", SqlDbType.Int);
            cmd.Parameters["@Tiempo"].Value = tiempo;
            cmd.Parameters.Add("@Efecto", SqlDbType.VarChar);
            cmd.Parameters["@Efecto"].Value = efecto;
            cmd.Parameters.Add("@Idcita", SqlDbType.Int);
            cmd.Parameters["@Idcita"].Value = Id_primera_cita;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public int CGetAppointmentFromDui(string dui)
        {
            string query = "SELECT id_primera_cita FROM CIUDADANO WHERE dui_ciudadano = @Dui";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            
            cmd.Parameters.Add("@Dui", SqlDbType.VarChar);
            cmd.Parameters["@Dui"].Value = dui;
            
            int id_primera_cita = (int)cmd.ExecuteScalar();
            connection.Close();
            return id_primera_cita;
        }
        public void CUpdateWaitArea(string dui, DateTime fecha)
        {
            string query = "UPDATE CIUDADANO SET fecha_hora_area_espera = @Fecha WHERE dui_ciudadano = @Dui";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            
            cmd.Parameters.Add("@Dui", SqlDbType.VarChar);
            cmd.Parameters["@Dui"].Value = dui;
            cmd.Parameters.Add("@Fecha", SqlDbType.DateTime);
            cmd.Parameters["@Fecha"].Value = fecha;
            
            cmd.ExecuteNonQuery();
            connection.Close();
        }

    }
}
