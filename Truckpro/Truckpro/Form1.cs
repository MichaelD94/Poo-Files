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
    public partial class Form1 : Form
    {
        LoginInfo Entrar = new LoginInfo();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrar.BuscaLoginXML();
            if (Entrar.PesquisaLogin(txtentrarlogin.Text, txtentrarsenha.Text) != null)
            {
                Form novo = new Main();
                novo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Invalido","Erro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form novo = new Form2();
            novo.ShowDialog();
        }
    }
}
