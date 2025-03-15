using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriacaoComponentes
{
    public partial class Form1 : Form
    {
        private bool rendered = false;
        public Form1()
        {
            InitializeComponent();
        }

        List <Produto> produtos = new List <Produto>();

       

        private void btCreate_Click(object sender, EventArgs e)
        {
            if (!rendered)
            {
                this.Render();

            } else
            {
                MessageBox.Show("Já está criado!"); 
            }
        }

        private void Render()
        {
            
            Label lbQuant = new Label();
            lbQuant.Name = "lbQuant";
            lbQuant.Text = "Quantidade: ";
            lbQuant.Location = new Point(39, 197);
            lbQuant.Width = 70;
            this.Controls.Add(lbQuant);

            Label lbDesc = new Label()
            {
                Name = "lbDesc",
                Text = "Descrição: ",
                Location = new Point(39, 240),
                Width = 70

            };
            this.Controls.Add(lbDesc);


            TextBox txtQuant = new TextBox()
            {
                Name = "txtQuant",
                Location = new Point(111, 197),
                Width = 111


            };
            this.Controls.Add(txtQuant);

            TextBox txtDesc = new TextBox()
            {
                Name = "txtDesc",
                Location = new Point(111, 240),
                Width = 111

            };
            this.Controls.Add(txtDesc);

            //BOTÃO 

            Button btSave = new Button()
            {
                Name = "btSave",
                Text = "Salvar",
                Location = new Point(255,197 ),
                Size = new Size(103, 68)
            };
            this.Controls.Add(btSave);

            btSave.Click += (s, e) =>
            {
                
                string name = txtName.Text;
                double price = Double.Parse(txtPrice.Text);
                int quant = int.Parse(txtQuant.Text);
                string desc = txtDesc.Text; 
                Produto produto = new Produto(name, price, quant, desc);

            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
