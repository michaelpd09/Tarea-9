using System.Data.Entity;
using Entidades;
using System.Data.SqlClient;
namespace DAL
{

    public class RegistroDB
    {
        private SqlConnection MyConection;

        private string ConnectionString = ("Data Source=MICHAEL-PC\\SQLEXPRESS;Initial Catalog=RegistroDB;Integrated Security=True");

        public void Conectar()
        {
            MyConection = new SqlConnection(ConnectionString);
            MyConection.Open();
        }

        public void Desconectar()
        {
            MyConection.Close();
        }

        public void EjecutarSql(string Query)
        {
            SqlCommand Comandos = new SqlCommand(Query, MyConection);

        }

    }
}
