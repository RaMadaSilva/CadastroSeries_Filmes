using System;

namespace ControleSeriesFilmes
{
    class Program
    {
        static FilmeRepositorio repositorioFilmes = new FilmeRepositorio();
        static SerieRepositorio repositorioSeries = new SerieRepositorio();

        static void Main(string[] args)
        {
            Principio();
 
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Lista de Serie \n");

            var lista = repositorioSeries.Listar();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Serie Cadastrado.\n");
                return;
            }

            foreach (Serie series in lista)
            {
                var excluido = series.RetornaExcluido();
                Console.WriteLine("#{0}: - {1}  {2}", series.RetornarId(), series.RetornarTitulo(), (excluido ? "*Excluido*" : ""));
            }
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Visualizar Serie");

            Console.WriteLine("Digite o Id do Serie que pretendes visualizar");
            int entradaId = int.Parse(Console.ReadLine());

            Serie serie = repositorioSeries.RetornaPorId(entradaId);
            Console.WriteLine(serie);

        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Exluir Series\n");

            Console.WriteLine("Digite o Id da Serie que pretendes Exluir");
            int entradaId = int.Parse(Console.ReadLine());

            repositorioSeries.Excluir(entradaId);
        }

        private static void AtualizarSerie()
        {

            Console.WriteLine("Actualizar Serie \n");

            Console.WriteLine("Digite o Id do Serie que pretendes Actualizar");
            int entradaId = int.Parse(Console.ReadLine());

            foreach (var item in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", item, Enum.GetName(typeof(Genero), item));
            }

            Console.WriteLine("Digite o valor do Genero nas opções acima");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo da Serie: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de lançamento da Serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição  da Serie: ");
            string entradaDescricao = Console.ReadLine();

            Console.WriteLine("Digite O numero de Temporadas ");
            int entradaTemporada = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos Episodios a serie tem por temporada? ");
            int entradaEpic = int.Parse(Console.ReadLine());

            Serie actualizarSerie = new Serie(entradaId, (Genero)entradaGenero, entradaTitulo, entradaDescricao,  entradaAno, entradaTemporada, entradaEpic);

            repositorioSeries.Actualizar(entradaId, actualizarSerie);

        }

        private static void InserirSerie()
        {

            Console.WriteLine("Inserir Series\n");
            foreach (int item in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", item, Enum.GetName(typeof(Genero), item));
            }

            Console.WriteLine("Digite o valor do Genero nas opções acima");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo da Series: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de lançamento da Series: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição  da Serie: ");
            string entradaDescricao = Console.ReadLine();

            Console.WriteLine("Digite O numero de Temporadas ");
            int entradaTemporada = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos Episodios a serie tem por temporada? ");
            int entradaEpic = int.Parse(Console.ReadLine());

            Serie novaSerie= new Serie(repositorioSeries.ProximoId(), (Genero)entradaGenero, entradaTitulo, entradaDescricao, entradaAno, entradaTemporada, entradaEpic); 

            repositorioSeries.Inserir(novaSerie);

        }

        private static void VisualizarFimes()
        {
            Console.WriteLine("Visualizar Filme");

            Console.WriteLine("Digite o Id do Filme que pretendes visualizar");
            int entradaId = int.Parse(Console.ReadLine());

            Filmes filme = repositorioFilmes.RetornaPorId(entradaId);
            Console.WriteLine(filme); 
        }

        private static void ExcluirFilme()
        {
            Console.WriteLine("Exluir Filmes\n");

            Console.WriteLine("Digite o Id do Filme que pretendes Exluir");
            int entradaId = int.Parse(Console.ReadLine());

            repositorioFilmes.Excluir(entradaId); 
        }

        private static void AtualizarFilme()
        {
            Console.WriteLine("Actualizar Filmes \n");

            Console.WriteLine("Digite o Id do Filme que pretendes Actualizar");
            int entradaId = int.Parse(Console.ReadLine()); 

            foreach (var item in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", item, Enum.GetName(typeof(Genero), item));
            }

            Console.WriteLine("Digite o valor do Genero nas opções acima");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de lançamento do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a duração do Filme: ");
            double entradaDuracao = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição do Filme do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filmes actualFime = new Filmes(entradaId, (Genero)entradaGenero, entradaTitulo, entradaDescricao, entradaAno,
                entradaDuracao);

            repositorioFilmes.Actualizar(entradaId, actualFime); 

        }

        private static void InserirFilme()
        {
            Console.WriteLine("Inserir Filmes\n");
            foreach (int item in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", item, Enum.GetName(typeof(Genero), item)); 
            }

            Console.WriteLine("Digite o valor do Genero nas opções acima");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de lançamento do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a duração do Filme: ");
            double entradaDuracao = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição do Filme do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filmes novoFilme = new Filmes(repositorioFilmes.ProximoId(), (Genero)entradaGenero, entradaTitulo, entradaDescricao, entradaAno, 
                entradaDuracao);

            repositorioFilmes.Inserir(novoFilme); 

        }

        private static void ListarFilmes()
        {
            Console.WriteLine("Lista de Filmes \n");
            var lista = repositorioFilmes.Listar();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Filme Cadastrado.\n");
                return; 
            }

            foreach(var filmes in lista)
            {
                var excluido = filmes.RetornaExcluido();
                Console.WriteLine("#{0}: - {1} com uma duração de: {2} hs.  {3}  ", filmes.RetornarId(), filmes.RetornarTitulo(), filmes.Duracao, (excluido ? "*Excluido*" : "")); 
            }
        }

        private static void Voltar()
        {
           Console.Clear(); 
           Principio();
        }

        //metodo para a obteção do valor da opção escolhida pelo utilizador caso seja cadastro de filmes
        private static string ObterOpcaoFilmes()
        {
            
            Console.WriteLine();
            Console.WriteLine("**NETCABO CADASTREO DE FILMES**");
            Console.WriteLine("Informa a opção Desejada..!");
            Console.WriteLine("1- Listar Filmes");
            Console.WriteLine("2- Inserir Novo Filme");
            Console.WriteLine("3- Atualizar Filme");
            Console.WriteLine("4- Excluir Filme");
            Console.WriteLine("5- Visualizar Filme");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("V- Voltar no Menu Principal");
            Console.WriteLine();

            string opcaoFilme = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoFilme;
        }

        //metodo para a obteção do valor da opção escolhida pelo utilizador caso seja cadastro de Sereis 
        private static string ObterOpcaoSeries()
        {
           
            Console.WriteLine();
            Console.WriteLine("**NETCABO CADASTREO DE SEREIS**");
            Console.WriteLine("Informa a opção Desejada..!");
            Console.WriteLine("1- Listar Series");
            Console.WriteLine("2- Inserir Novo Series");
            Console.WriteLine("3- Atualizar Series");
            Console.WriteLine("4- Excluir Series");
            Console.WriteLine("5- Visualizar Series");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("V- Voltar no Menu Principal");
            Console.WriteLine();

            string opcaoSerie = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoSerie;
        }


        //metodo para abertura do sistema ou seja menu pricipal. 
        private static void Principio()
        {

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("CADASTRO DE FILMES E DE SERIES DA NETCABO\n");
            foreach(int i in Enum.GetValues(typeof(MenuPrincipal)))
            {
                Console.WriteLine("{0} => {1}", i, Enum.GetName(typeof(MenuPrincipal), i).ToUpper()); 
            }
            Console.WriteLine("------------------------------------------------\n");

            Console.WriteLine(" escolha uma das opções");
            string escolha = Console.ReadLine().ToUpper();

            while (escolha != "3")
            {

                switch (escolha)
                {
                    case "1":
                        OpcaoSeries(); 
                        break;
                    case "2":
                        OpcaoFilmes();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(); 
                }
                escolha = Console.ReadLine().ToUpper();
            }


        }

        private static void OpcaoFilmes()
        {
            string opcao = ObterOpcaoFilmes();

            while (opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                        ListarFilmes();
                        break;
                    case "2":
                        InserirFilme();
                        break;
                    case "3":
                        AtualizarFilme();
                        break;
                    case "4":
                        ExcluirFilme();
                        break;
                    case "5":
                        VisualizarFimes();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    case "V":
                        Voltar();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcao = ObterOpcaoFilmes();
            }
        }

        static  void OpcaoSeries()
        {

           string opcao = ObterOpcaoSeries();
           

            while (opcao.ToUpper() != "X")
            {
                switch (opcao)
                {

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

                    case "V":
                        Voltar();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcao = ObterOpcaoSeries();
                
            }
            return;
        }

    }
}
