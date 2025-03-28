using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AGENDA_CONTATOS.Model
{
    public class Contatos
    {
        public string Nome { get; set; }
        public string Whatsapp { get; set; }
        public string Email { get; set;  }
    }
}
