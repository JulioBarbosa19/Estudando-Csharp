using System.Collections.Generic;
namespace DIO.Series
{
  public interface IRepositorio
    {
        List<> Lista();

        T RetornaPorId(int id);

        void Insere(T entidade);

        void Exclui(int id);

        void Atualiza(int id, T entidade);

        int ProximoId();
    }
}