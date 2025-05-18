using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP3.Estrutura.Model;

namespace CP3.Estrutura.Repository
{
    public class ClienteRepository
    {
        private readonly string _connectionString = "User Id=RM551716;Password=200398;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));";

        public List<Cliente> ListarClientes()
        {
            var lista = new List<Cliente>();

            using (var connection = new OracleConnection(_connectionString))
            {
                string query = "SELECT Nome, Tipo_Perfil FROM Cliente";

                var command = new OracleCommand(query, connection);
                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var cliente = new Cliente
                    {
                        nome = reader["Nome"].ToString(),
                        tipo_perfil = reader["Tipo_perfil"].ToString()
                    };

                    lista.Add(cliente);
                }
            }

            return lista;
        }

        public void InserirCliente(string nome, string tipoPerfil)
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                string query = "INSERT INTO Cliente (Nome, Tipo_Perfil) VALUES (:nome, :tipoPerfil)";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("nome", nome));
                    command.Parameters.Add(new OracleParameter("tipoPerfil", tipoPerfil));

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
