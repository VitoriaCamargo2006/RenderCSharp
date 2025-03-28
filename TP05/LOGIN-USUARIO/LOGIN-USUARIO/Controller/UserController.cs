using LOGIN_USUARIO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN_USUARIO.Controller
{
    class UserController
    {
        public static string Login(string username, string password)
        {
            bool login = UserModel.ValidateUsers(username, password);
            return login ? "Login realizado com sucesso!" : "Usuario ou senha errado!";

        }

    }
}
