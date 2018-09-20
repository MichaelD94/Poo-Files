using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace AulaAgendaBetim
{
    class Dados
    {
        private ArrayList Cadastro;
        public Dados()
        {
            Cadastro = new ArrayList();
        }
        public void InserirAluno(Aluno x)
        {
            Cadastro.Add(x);
        }
        public ArrayList RecuperarDados()
        {
            return Cadastro;
        }
        public Aluno PesquisarAluno(string cod)
        {
            foreach (Aluno x in Cadastro)
            {
                if (x.Código == cod)
                    return x;
            }
            return null;
        }
        public void ExcluirAluno(Aluno x)
        {
            Cadastro.Remove(x);
        }
        public void AlterarAluno(Aluno x, Aluno y)
        {
            int posicao = Cadastro.IndexOf(x);
            Cadastro.Remove(x);
            Cadastro.Insert(posicao, y);
        }
        public int OrdenarAlunos()
        {
            Cadastro.Sort(new MinhaOrdenacao());
            return Cadastro.Count;
        }
        public class MinhaOrdenacao : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                return ((Aluno)x).Nome.CompareTo(((Aluno)y).Nome);
            }
        }
        public int SalvarXML()
        {
            TextWriter novoWritter = new StreamWriter(@"C:\Users\Michael\source\repos\agdbetim\agdbetim\CadastroAlunos.xml");
            Aluno[] ListaAlunoVetor = (Aluno[])Cadastro.ToArray(typeof(Aluno));
            XmlSerializer Serializacao = new XmlSerializer(ListaAlunoVetor.GetType());
            Serializacao.Serialize(novoWritter, ListaAlunoVetor);
            novoWritter.Close();
            return Cadastro.Count;
        }
        public int CarregarXML()
        {
            FileStream Arquivo = new FileStream(@"C:\Users\Michael\source\repos\agdbetim\agdbetim\CadastroAlunos.xml", FileMode.Open);
            Aluno[] ListaVetorAluno = (Aluno[])Cadastro.ToArray(typeof(Aluno));
            XmlSerializer Serializacao = new XmlSerializer(ListaVetorAluno.GetType());
            ListaVetorAluno = (Aluno[])Serializacao.Deserialize(Arquivo);
            Cadastro.Clear();
            Cadastro.AddRange(ListaVetorAluno);
            Arquivo.Close();
            return Cadastro.Count;
        }
    }
}