using LOGIN_USUARIO.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_USUARIO
{
    public partial class Form1: Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string senha = txtPassword.Text;
            string msg = UserController.Login(usuario, senha);
            MessageBox.Show(msg);
            txtPassword.Clear();
            txtUser.Clear(); 

        }
    }
}
