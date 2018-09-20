using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_final_POO
{
    public partial class Form1 : Form
    {
        Caracteres Mychar = new Caracteres();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVogais_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxfrase.Text == "")

                    throw new ArgumentNullException();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Textos nulos nao podem ser calculados");                
            }
            string vogais = textBoxfrase.Text.ToLower();
            Mychar.ContadorV(vogais);
            textBoxresultado.Text = Mychar.z.ToString();
            
        }

        private void textBoxfrase_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonConsoantes_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxfrase.Text == "")

                    throw new ArgumentNullException();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Textos nulos nao podem ser calculados");
            }
            string consoantes = textBoxfrase.Text.ToLower();
            Mychar.ContadorC(consoantes);
            textBoxresultado.Text = Mychar.z.ToString();
        }

        private void buttonNumeros_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxfrase.Text == "")

                    throw new ArgumentNullException();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Textos nulos nao podem ser calculados");
            }
            Mychar.ContadorN(textBoxfrase.Text);
            textBoxresultado.Text = Mychar.z.ToString();
        }

        private void buttonSpace_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxfrase.Text == "")

                    throw new ArgumentNullException();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Textos nulos nao podem ser calculados");
            }
            Mychar.ContadorS(textBoxfrase.Text);
            textBoxresultado.Text = Mychar.z.ToString();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
