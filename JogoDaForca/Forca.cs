namespace JogoDaForca
{
    public static class Forca
    {
        public static void VerificaPalavra(string palavraCerta)
        {
            try
            {
                var palavra = palavraCerta.ToUpper();
                Console.Clear();
                Console.WriteLine("-----------------");
                Console.WriteLine("O JOGO COMEÇOU!");
                Console.WriteLine("APERTE ENTER PARA COMEÇAR!");
                Console.WriteLine("-----------------");
                Console.ReadKey();
                var tamanhoPalavra = palavra.Count();
                var palavraForca = "";
                for (int i = 0; i < tamanhoPalavra; i++)
                {
                    palavraForca += "*";
                }
                var letrasPassadas = "";
                var erros = 0;
                while (palavra != palavraForca)
                {
                    Console.Clear();
                    if (letrasPassadas != "")
                    {
                        Console.WriteLine($"Letras já digitadas: \n {letrasPassadas}");
                    }
                    try
                    {
                        Console.Write("Digite uma letra: ");
                        var letra = Console.ReadLine().ToUpper()[0];
                        letrasPassadas += letra + " - ";
                        var temNaPalavra = palavra.IndexOf(letra, 0);
                        if (temNaPalavra >= 0)
                        {
                            for (int i = 0; i < palavra.Length; i++)
                            {
                                if (palavra[i].Equals(letra))
                                {
                                    char[] caracter = palavraForca.ToCharArray();
                                    caracter[i] = letra;
                                    palavraForca = new string(caracter);
                                    Console.WriteLine("------------ACERTOU!-------------");
                                    Console.WriteLine(palavraForca);
                                    Console.ReadKey();
                                }
                            }
                        }
                        else
                        {
                            erros++;
                            Errou(erros);
                            if (erros == 6)
                            {
                                break;
                            }
                            Console.ReadKey();
                        }
                    }
                    catch (Exception ex)
                    {

                        throw new ForcaException(ex.Message);
                    }
                    
                    if (palavra == palavraForca)
                    {
                        Console.Clear();
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine($"UHULLLLLLL VOCÊ ACERTOU A PALAVRA {palavraForca}");
                        Console.WriteLine(" 👏  👏  👏  PARABENS!!!  👏  👏  👏 ");
                        Console.WriteLine("----------------------------------------");
                    }
                }
            }
            catch (ForcaException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private static void Errou(int erros)
        {
            switch (erros)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("ERROU SUA FORCA ESTA ASSIM:");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("   ________          \n" +
                                      "  |        |         \n" +
                                      "  |        O         \n" +
                                      "  |                  \n" +
                                      "  |                  \n" +
                                     @"  |                    ");
                    Console.WriteLine("----------------------------");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("ERROU SUA FORCA ESTA ASSIM:");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("   ________          \n" +
                                      "  |        |         \n" +
                                      "  |        O         \n" +
                                      "  |      __|         \n" +
                                      "  |                  \n" +
                                      "  |                  \n");
                    Console.WriteLine("----------------------------");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("ERROU SUA FORCA ESTA ASSIM:");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("   ________          \n" +
                                      "  |        |         \n" +
                                      "  |        O         \n" +
                                      "  |      __|__       \n" +
                                      "  |                  \n" +
                                     @"  |                    ");
                    Console.WriteLine("----------------------------");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("ERROU SUA FORCA ESTA ASSIM:");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("   ________          \n" +
                                      "  |        |         \n" +
                                      "  |        O         \n" +
                                      "  |      __|__       \n" +
                                      "  |        |         \n" +
                                     @"  |                    ");
                    Console.WriteLine("----------------------------");
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("ERROU SUA FORCA ESTA ASSIM:");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("   ________          \n" +
                                      "  |        |         \n" +
                                      "  |        O         \n" +
                                      "  |      __|__       \n" +
                                      "  |        |         \n" +
                                     @"  |       /            ");
                    Console.WriteLine("----------------------------");
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("ERROU SUA FORCA ESTA ASSIM:");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("   ________          \n" +
                                      "  |        |         \n" +
                                      "  |        O         \n" +
                                      "  |      __|__       \n" +
                                      "  |        |         \n" +
                                     @"  |       / \          ");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("FIM DE JOGO");
                    Console.WriteLine("tecle enter para jogar novamente");
                    break;
                default:
                    break;
            }          
        }
    }
}
