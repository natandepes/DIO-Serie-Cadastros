namespace DIO_Series.Interfaces
{
    public interface IRepositorio<X> // esse X é somente um valor genérico
    {
        List<X> Lista();

        X RetornaPorId(int id);

        void Insere(X entidade);

        void Exclui(int id);

        void Atualiza(int id, X entidade);

        int ProximoId();
    }
}