using CP3.Estrutura.Model;
using CP3.Estrutura.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP3.Estrutura.Controller
{
    public class ClienteController
    {
        private readonly ClienteRepository _repository = new ClienteRepository();

        public void AdicionarCliente(string nome, string tipoPerfil)
        {
            _repository.InserirCliente(nome, tipoPerfil);
        }

        public List<Cliente> ListarClientes()
        {
            return _repository.ListarClientes();
        }
    }
}
