using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP3.Estrutura.Repository;

namespace CP3.Estrutura.Controller
{
    public class UsuarioController
    {
        public bool validarUsuarioSenha(string rm, string senha)
        {
            UsuarioRepository repositorio = new UsuarioRepository();
            return repositorio.validarLogin(rm, senha);
        }
    }
}
