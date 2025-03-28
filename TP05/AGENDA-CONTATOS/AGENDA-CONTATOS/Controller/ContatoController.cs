using AGENDA_CONTATOS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGENDA_CONTATOS.Controller
{
    class ContatoController
    {
        public ContatosModel model = new ContatosModel();
        
        public string SalvarContato(string nome, string whatsapp, string email)
        {
            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(whatsapp) ||
                string.IsNullOrWhiteSpace(email))
                return "Atenção: todos os campos são obrigatórios!";

            Contatos contato = new Contatos()
            {
                Nome = nome,
                Whatsapp = whatsapp,
                Email = email
            };

            model.AdicionarContatos(contato);
            return "Contato salvo"; 
        }

        public List<Contatos> ObterContatos ()
        {
            return model.ListarContatos(); 
        }

    }
}
