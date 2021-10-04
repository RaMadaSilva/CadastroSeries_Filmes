using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSeriesFilmes
{
    class Filmes: EntidadeBase
    {
        //Atributo do filme 

        public double Duracao { get; set; }

        public Filmes(int id, Genero genero, string titulo, string descricao, int ano, double duracao)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.AnoLacamento = ano;
            this.Duracao = duracao; 
        }
       
        public override string ToString()
        {
            string retorno = "";

            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.AnoLacamento + Environment.NewLine;
            retorno += "Duração do filme em Horas" + this.Duracao + Environment.NewLine;
            retorno += "Excluido : " + this.Excluido + Environment.NewLine;

            return retorno; 


        }
    }
}
