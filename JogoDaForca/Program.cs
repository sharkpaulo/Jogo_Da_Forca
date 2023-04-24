using JogoDaForca;

var opcao = "0";
Console.WriteLine("Bem vindo ao jogo da forca");
while (opcao != "3")
{
    Console.Clear();
    Console.WriteLine("ESCOLHA UMA OPÇÂO!");
    Console.WriteLine("---------------------------");
    Console.WriteLine("[1] Palavra Aleatória");
    Console.WriteLine("[2] Escrever Palavra");
    Console.WriteLine("[3] Encerrar Game");
    Console.WriteLine("---------------------------");
    Console.Write("Escolha uma opção: ");
    opcao = Console.ReadLine();
    Console.Clear();
    switch (opcao)
    {
        case "1":
            var listaAleatoria = new List<string>() { "teste", "aleatorio", "programa" };
            Random random = new Random();
            var tamanho = listaAleatoria.Count;
            var palavra = listaAleatoria[random.Next(tamanho)];
            Forca.VerificaPalavra(palavra);
            Console.ReadKey();
            break;
        case "2":
            Console.Write("Digite uma palavra: ");
            palavra = Console.ReadLine();
            if (palavra == "" || palavra == " ")
            {
                Console.WriteLine("Nenhuma palavra digitada tente novamente!");
                Console.ReadKey();
                break;
            }
            Forca.VerificaPalavra(palavra);
            Console.ReadKey();
            break;
        case "3":
            Console.WriteLine("Encerrando...");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Opção desconhecida escolha novamente");
            Console.ReadKey();
            break;
    }
}
