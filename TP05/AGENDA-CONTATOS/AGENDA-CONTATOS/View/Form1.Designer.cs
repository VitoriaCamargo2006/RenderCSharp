namespace AGENDA_CONTATOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtWhatsapp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btSalvar = new Button();
            dgv_contatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_contatos).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(151, 79);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(142, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(151, 161);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(142, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtWhatsapp
            // 
            txtWhatsapp.Location = new Point(151, 120);
            txtWhatsapp.Name = "txtWhatsapp";
            txtWhatsapp.Size = new Size(142, 23);
            txtWhatsapp.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 128);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 3;
            label1.Text = "WhatsApp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 169);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 87);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Nome:";
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(151, 202);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(142, 23);
            btSalvar.TabIndex = 6;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // dgv_contatos
            // 
            dgv_contatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_contatos.Location = new Point(313, 75);
            dgv_contatos.Name = "dgv_contatos";
            dgv_contatos.Size = new Size(322, 150);
            dgv_contatos.TabIndex = 7;
            dgv_contatos.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 325);
            Controls.Add(dgv_contatos);
            Controls.Add(btSalvar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtWhatsapp);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_contatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtWhatsapp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btSalvar;
        private DataGridView dgv_contatos;
    }
}
