using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CP3.Estrutura.Repository
{
    public class UsuarioRepository
    {
        private readonly string _connectionString = "User Id=RM551716;Password=200398;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));";
        private string nomeUsuarioLogado = "";

        public string getNomeUsuario()
        {
            return nomeUsuarioLogado;
        }
        public string ObterNomeUsuario(string rm)
        {
            using (OracleConnection connection = new OracleConnection(_connectionString))
            {
                string query = "select Nome from Usuarios where RM = :rm";

                connection.Open();

                OracleCommand cmd = new OracleCommand(query, connection);
                cmd.Parameters.Add(new OracleParameter("rm", rm));

                object resultado = cmd.ExecuteScalar();

                return resultado?.ToString() ?? "";
            }
        }

        public bool validarLogin(string rm, string senha)
        {

            if (int.TryParse(rm, out int numero))
            {
                using (OracleConnection connection = new OracleConnection(_connectionString))
                {
                    string query = "select count(1) from Usuarios where RM='" + rm + "' and Senha ='" + senha + "'";

                    connection.Open();

                    OracleCommand cmd = new OracleCommand(query, connection);

                    object resultado = cmd.ExecuteScalar();

                    if (Convert.ToInt32(resultado) == 0)
                    {
                        return false;
                    }
                    else
                    {
                        nomeUsuarioLogado = ObterNomeUsuario(rm);
                        return true;
                    }
                }
            }
            else
            {
                // Não é um número
                return false;
            }
        }
    }
}
