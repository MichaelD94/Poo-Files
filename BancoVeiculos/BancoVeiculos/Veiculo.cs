using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoVeiculos
{
    public class Veiculo
    {
        private string _Placa;
        public string Placa
        {
            get { return _Placa; }
            set { _Placa = value; }
        }
        private string _Fabricante;
        public string Fabricante
        {
            get { return _Fabricante; }
            set { _Fabricante = value; }
        }
        private string _Modelo;
        public string Modelo
        {
            get { return _Modelo; }
            set { _Modelo = value; }
        }
        private string _AnoFab;
        public string AnoFab
        {
            get { return _AnoFab; }
            set { _AnoFab = value; }
        }
        public Veiculo()
        {
            _Placa = "";
            _Fabricante = "";
            _Modelo = "";
            _AnoFab = "";
        }
    }
}
