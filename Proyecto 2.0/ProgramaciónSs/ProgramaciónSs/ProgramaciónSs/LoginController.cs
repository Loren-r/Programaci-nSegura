using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaciónSs
{
    public class LoginController

    {
        private readonly RepositorioUsuario repo;

        public LoginController()
        {
            repo = new RepositorioUsuario();
        }

        public Usuario AutenticarUsuario(string usuario, string contraseña)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                return null;
            }
            else
            {
                var repo = new RepositorioUsuario();
                Usuario user = repo.ValidarCredenciales(usuario, contraseña);
                return user;
            }


        }

    }
}
