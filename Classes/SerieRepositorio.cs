using DIO_Series.Interfaces;

namespace DIO_Series
{
    public class SerieRepositorio : IRepositorio<Serie> // aqui estou fazendo com que aquela interface funcione pela classe serie
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir(); // fazendo isso para evitar problemas ao excluir um vetor
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto); // Add é um metodo padrão do C#
        }

        public List<Serie> Lista()
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