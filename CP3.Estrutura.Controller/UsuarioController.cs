using CP3.Estrutura.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP3.Estrutura.Controller
{
    public class UsuarioController
    {
        UsuarioRepository repositorio = new UsuarioRepository();
        public bool validarUsuarioSenha(string rm, string senha)
        {
            return repositorio.validarLogin(rm, senha);
        }

        public string pegarUsuarioNome()
        {
            return repositorio.getNomeUsuario();
        }
    }
}
