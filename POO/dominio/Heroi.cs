using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.dominio
{
    public class Heroi
    {
        private int _vidas;

        public int Vidas
        {
            get { return _vidas; }
            set { _vidas = value; }
        }

        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _habilidadeAtual;

        public string HabilidadeAtual
        {
            get { return _habilidadeAtual; }
            set { _habilidadeAtual = value; }
        }

        public void CarregarHabilidade(string habilidade)
        {

        }

        public bool AlterarVida(int valor)
        {
            return false;
        }
    }
}