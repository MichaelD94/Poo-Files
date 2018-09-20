using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace BancoVeiculos
{
    class Dados
    {
        private ArrayList Cadastro;
        public Dados()
        {
            Cadastro = new ArrayList();
        }
        public void InserirVeiculo(Veiculo x)
        {
            Cadastro.Add(x);
        }
        public ArrayList RecuperarDados()
        {
            return Cadastro;
        }
        public Veiculo PesquisarVeiculo(string cod)
        {
            foreach (Veiculo x in Cadastro)
            {
                if (x.Placa == cod)
                    return x;
            }
            return null;
        }
        public void ExcluirVeiculo(Veiculo x)
        {
            Cadastro.Remove(x);
        }
        public void AlterarVeiculo(Veiculo x, Veiculo y)
        {
            int posicao = Cadastro.IndexOf(x);
            Cadastro.Remove(x);
            Cadastro.Insert(posicao, y);
        }
        public int OrdenarVeiculo()
        {
            Cadastro.Sort(new MinhaOrdenacao());
            return Cadastro.Count;
        }
        public class MinhaOrdenacao : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                return ((Veiculo)x).Fabricante.CompareTo(((Veiculo)y).Fabricante);
            }
        }
    }
}