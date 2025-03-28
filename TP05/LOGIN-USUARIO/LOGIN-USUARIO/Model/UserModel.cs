using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN_USUARIO.Model
{
    class UserModel
    {
        private static List<User> users = new List<User>()
        {
            new User { Username = "adm", Password="mousse"},
            new User { Username = "aluno", Password="pudim"},
            new User { Username = "professor", Password="chocolate"}

        };

        public static bool ValidateUsers (string username, string password)
        {
            return users.Exists(u => u.Username == username && u.Password == password);
        }
       




    }
}
