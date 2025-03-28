using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGENDA_CONTATOS.Model
{
    class ContatosModel
    {
        private static List<Contatos> contatos = new List<Contatos>(); 
        public void AdicionarContatos (Contatos contato)
        {
            contatos.Add(contato); 
        }
        public List<Contatos> ListarContatos()
        {
            return contatos; 
        }
    }
}
