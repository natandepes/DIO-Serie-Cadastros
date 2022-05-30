namespace DIO_Series{

    class Program{

        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args){
            
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X"){

                switch(opcaoUsuario){

                    case "1":
                        ListarSeries();
                    break;
                    case "2":
                        InserirSerie();
                    break;
                    case "3":
                        AtualizarSerie();
                    break;
                    case "4":
                        ExcluirSerie();
                    break;
                    case "5":
                        VisualizarSerie();
                    break;
                    case "C":
                        Console.Clear();
                    break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            System.Console.WriteLine("Obrigado por nos escolher, volte sempre!");
            System.Console.WriteLine();
        }

        private static void ListarSeries(){

            System.Console.WriteLine("Listar séries");

            var lista = repositorio.Lista();

            if(lista.Count() == 0){

                System.Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExlcuido();

                System.Console.WriteLine("ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "Excluído" : ""));
            }
        }

        private static void InserirSerie(){

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            System.Console.WriteLine("Digite o genêro dentre das opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o título: ");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o ano em que foi lançada: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Faça uma sinopse da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie (id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            
            repositorio.Insere(novaSerie);
        }

        private static void AtualizarSerie(){

            System.Console.WriteLine("Digite o ID da serie: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            System.Console.WriteLine("Digite o genêro dentre das opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o título: ");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o ano em que foi lançada: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Faça uma sinopse da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie (id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            
            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }

        private static void ExcluirSerie(){

            System.Console.WriteLine("Digite o ID da série que deseja excluir: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceSerie);
        }

        private static void VisualizarSerie(){

            System.Console.WriteLine("Digite o ID da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            System.Console.WriteLine(serie);
        }

        private static string ObterOpcaoUsuario(){

            System.Console.WriteLine(); // pulando linha
            System.Console.WriteLine("Natan series. Bem-vindo!");
            System.Console.WriteLine("Informe a opção desejada:");

            System.Console.WriteLine("1 - Listar séries");
            System.Console.WriteLine("2 - Inserir nova série");
            System.Console.WriteLine("3 - Atualizar série");
            System.Console.WriteLine("4 - Excluir série");
            System.Console.WriteLine("5 - Visualizar série");
            System.Console.WriteLine("C - Limpar tela");
            System.Console.WriteLine("X - Sair");
            System.Console.WriteLine(); // pulando linha

            string opcaoUsuario = Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return opcaoUsuario;

        }
    }
}