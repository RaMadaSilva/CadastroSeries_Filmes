using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControleSeriesFilmes
{
    public class Serie: EntidadeBase
    {
        //Os Atributos de uma serie 

        private int Temporadas { get; set; }
        private int EpodioTemporada { get; set; }
        private int TotalEpisodio { get; set; }


        public Serie(int id, Genero genero, string titulo, string descricao, int ano, int temporadas, int episodiosTemporada )
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Temporadas = temporadas;
            this.EpodioTemporada = episodiosTemporada;
            this.AnoLacamento = ano; 

            this.TotalEpisodio = temporadas * episodiosTemporada; 

        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.AnoLacamento + Environment.NewLine;
            retorno += "Temporadas: " + this.Temporadas + Environment.NewLine;
            retorno += "Episodios por Temporadas: " + this.EpodioTemporada + Environment.NewLine;
            retorno += "Total de Episodios da serie: " + this.TotalEpisodio + Environment.NewLine;
            retorno += "Excluidoo : " + this.Excluido + Environment.NewLine;

            return retorno; 
        }

       
    }
}
