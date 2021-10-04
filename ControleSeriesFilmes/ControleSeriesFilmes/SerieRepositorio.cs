using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleSeriesFilmes.Interface; 

namespace ControleSeriesFilmes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        
         private List<Serie> listaSerie = new List<Serie>(); 

        public void Actualizar(int id, Serie entidade)
        {
            listaSerie[id] = entidade; ;
        }

        public void Excluir(int id)
        {
            listaSerie[id].Excluir(); 
        }

        public void Inserir(Serie entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Serie> Listar()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count; 
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
