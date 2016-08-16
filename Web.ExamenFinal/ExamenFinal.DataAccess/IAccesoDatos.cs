using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.DataAccess
{
   public  interface IAccesoDatos<T>
    {
        List<T> ObtenerLista();
        int Adicionar(T entity);
        int Eliminar(T entity);
        int Actualizar(T entity);
        int Contar();
    }
}
