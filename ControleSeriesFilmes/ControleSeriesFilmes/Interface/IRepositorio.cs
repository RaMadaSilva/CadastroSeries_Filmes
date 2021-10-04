using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSeriesFilmes.Interface
{
    public  interface IRepositorio<T>
    {
        List<T> Listar();
        T RetornaPorId(int id);
        void Inserir(T entidade);
        void Excluir(int id);
        void Actualizar(int id, T entidade);
        int ProximoId(); 

    }
}
