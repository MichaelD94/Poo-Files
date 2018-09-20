using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Truckpro
{
    public partial class Form2 : Form
    {
        LoginInfo novoLogin = new LoginInfo();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            novoLogin.BuscaLoginXML();
            if (txtLogin.Text != "" && txtSenha.Text != "")
            {
                novoLogin.Login = txtLogin.Text;
                novoLogin.Senha = txtSenha.Text;
                novoLogin.GravaLogin(novoLogin);
                novoLogin.ArmazenaLoginXML();
                MessageBox.Show("CADASTRO CRIADO COM SUCESSO", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                MessageBox.Show("ENTRADA INVÁLIDA!" + Environment.NewLine + "POR FAVOR INSIRA SEU LOGIN E SENHA", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Text = "";
                txtSenha.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
