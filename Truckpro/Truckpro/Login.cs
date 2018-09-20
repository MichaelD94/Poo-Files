using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Truckpro
{
    public class LoginInfo
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        private ArrayList cadLogin;
        public LoginInfo()
        {
            Login = "";
            Senha = "";
            cadLogin = new ArrayList();
        }
        public ArrayList GravaLogin(LoginInfo x)
        {
            cadLogin.Add(x);
            return cadLogin;
        }
        public LoginInfo PesquisaLogin(string login, string senha)
        {
            foreach (LoginInfo loginSRC in cadLogin)
            {
                if (login == loginSRC.Login && senha == loginSRC.Senha)
                    return loginSRC;
            }
            return null;
        }
        public void ArmazenaLoginXML()
        {
            string diretorio = Path.Combine(Directory.GetCurrentDirectory(), @"Login.xml");
            TextWriter novoWritter = new StreamWriter(diretorio);
            LoginInfo[] storeXML = (LoginInfo[])cadLogin.ToArray(typeof(LoginInfo));
            XmlSerializer serial = new XmlSerializer(storeXML.GetType());
            serial.Serialize(novoWritter, storeXML);
            novoWritter.Close();
        }
        public ArrayList BuscaLoginXML()
        {
            cadLogin.Clear();
            string diretorio = Path.Combine(Directory.GetCurrentDirectory(), @"Login.xml");
            FileStream arquivo = new FileStream(diretorio, FileMode.Open);
            LoginInfo[] restoreXML = (LoginInfo[])cadLogin.ToArray(typeof(LoginInfo));
            XmlSerializer serial = new XmlSerializer(restoreXML.GetType());
            restoreXML = (LoginInfo[])serial.Deserialize(arquivo);
            cadLogin.Clear();
            cadLogin.AddRange(restoreXML);
            arquivo.Close();
            return cadLogin;
        }
    }
}
