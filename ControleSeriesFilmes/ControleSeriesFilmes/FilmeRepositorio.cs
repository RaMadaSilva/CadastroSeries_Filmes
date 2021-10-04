using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleSeriesFilmes.Interface; 

namespace ControleSeriesFilmes
{
    class FilmeRepositorio : IRepositorio<Filmes>
    {

        private List<Filmes> listaFilmes = new List<Filmes>(); 

        public void Actualizar(int id, Filmes entidade)
        {
            listaFilmes[id]= entidade;
        }

        public void Excluir(int id)
        {
            listaFilmes[id].Excluir();
        }

        public void Inserir(Filmes entidade)
        {
           listaFilmes.Add(entidade);
        }

        public List<Filmes> Listar()
        {
           return listaFilmes;
        }

        public int ProximoId()
        {
           return listaFilmes.Count;
        }

        public Filmes RetornaPorId(int id)
        {
            return listaFilmes[id];
        }
    }
}
