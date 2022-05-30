namespace DIO_Series
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; } 

        private int Ano { get; set; }

        public bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id; // nao esta aqui mas esta na entidade base
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine; // quebrar linha de acordo com o sistema presente, sem correr riscos de \b ou \n nao funcionarem
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de início: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo(){
            
            return this.Titulo;
        }

         public int retornaId(){
            
            return this.Id;
        }

         public bool retornaExlcuido(){
            
            return this.Excluido;
        }

        public void Excluir(){
            this.Excluido = true;
        }
    }
}