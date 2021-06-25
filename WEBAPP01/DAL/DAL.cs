using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL
    {
        private static SqlConnection conn;
        private string conString;

        public DAL()
        {
            conString = $@"Data Source=; Initial Catalog=; Persist Security Info=True; User ID=; Password=";
            conString = $@"Data Source=; Initial Catalog=; Persist Security Info=True; User ID=; Password=";
            conn = new SqlConnection(conString);
        }

        // METODOS PUBLICOS CLOSE
        public void Close() { if (conn.State == ConnectionState.Open){ conn.Close(); } }

        // METODO PUBLICO OPEN
        public SqlConnection Open() { if (conn.State == ConnectionState.Closed){  conn.Open(); } return conn; }

        // METODO PRIVADO OPEN
        private static SqlConnection _Open()
        {
            if (conn.State == ConnectionState.Closed) { conn.Open(); }
            return conn;
        }

        // CMMD GET, RETORNA TABELA DE DADOS
        public static DataTable dtaGet(string cmd)
        {
            DataTable dt = new DataTable();
            SqlCommand cmmd = new SqlCommand(cmd,_Open());  
            SqlDataAdapter da = new SqlDataAdapter(cmmd);
            da.Fill(dt);
            return dt;
        }
        
        // CMMD SET, EXECUTA INSERT, UPDATE, DELETE
        public void Set(string cmd) 
        { 
            SqlCommand cmmd = new SqlCommand(cmd, _Open());
            cmmd.ExecuteNonQuery();
        }
    }                   
}
