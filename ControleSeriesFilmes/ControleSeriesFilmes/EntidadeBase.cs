using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSeriesFilmes
{
   public abstract class EntidadeBase
    {
        public int Id { get; protected set; }
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int AnoLacamento { get; set; }
        public bool Excluido { get; set; }



        public string RetornarTitulo()
        {
            return this.Titulo; 
        }

        public int RetornarId()
        {
            return this.Id; 
        }

        public bool RetornaExcluido()
        {
            return this.Excluido; 
        }

        public void Excluir()
        {
            this.Excluido = true; 
        }
    }
}
