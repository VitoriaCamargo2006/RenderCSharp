using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AGENDA_CONTATOS.Controller;
using AGENDA_CONTATOS.Model;
using Microsoft.VisualBasic;

namespace AGENDA_CONTATOS
{
    public partial class Form1 : Form
    {
        private ContatoController controller = new ContatoController();
        public Form1()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string whatsapp = txtWhatsapp.Text;
            string email = txtEmail.Text;
            string msg = controller.SalvarContato(nome, whatsapp, email);
            MessageBox.Show(msg);
            this.RefreshDgv(); 
            
        }

        private void RefreshDgv()
        {
            List<Contatos> contatos = controller.ObterContatos();
            dgv_contatos.DataSource = null;
            dgv_contatos.DataSource = contatos;
            dgv_contatos.Visible = true; 
            
        }
    }
}
