using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01
{
    internal class Pessoa
    {
        private string nome;

        public Pessoa()
        {
            this.nome = null;
        }
        
        public Pessoa(string nome)
        {
            this.nome = nome;

        }
        public string Nome
        { 
            get { return nome; }
            set { nome = value; } 
        }


        public override string ToString()
        {
            return (String.Format("Nome: {0}", nome));
        }
    }
  
}
