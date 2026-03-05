internal class Program
{
    enum Menu { Soma = 1, Subtracao = 2, Multiplicacao = 3, Divisao = 4, Potencia = 5, Raiz = 6, Sair = 7 }
    private static void Main(string[] args)
    {
        bool escoolheusair = false; // Variável para controlar o loop do menu
        while (!escoolheusair) // Loop para exibir o menu até que o usuário escolha sair, a exclamação é para negar a condição, ou seja, enquanto o usuário não escolher sair, o menu continuará sendo exibido

        {
            Console.WriteLine("Calculadora CMD");
            Console.WriteLine("1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n5-Potencia\n6-Raiz\n7-Sair");
            Console.WriteLine("\n");
            escoolheusair = true;

            try
            {
                Menu opcao = (Menu)int.Parse(Console.ReadLine()); // Lê a opção escolhida pelo usuário e converte para o tipo Menu, usando int.Parse para converter a entrada de string para inteiro e depois fazendo um cast para o tipo Menu


                switch (opcao)
                {
                    case Menu.Soma:
                        Soma(); // Chama o método Soma para realizar a operação de soma
                        break;

                    case Menu.Subtracao:
                        Subtracao();
                        break;

                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;

                    case Menu.Divisao:
                        Divisao();
                        break;

                    case Menu.Potencia:
                        Potencia();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        escoolheusair = true; // Se o usuário escolher a opção de sair, a variável escoolheusair é definida como true, o que fará com que o loop do menu seja encerrado
                        break;
                }
                Console.Clear(); // Limpa a tela do console para exibir o menu novamente, deixando a interface mais limpa e organizada
            }
            catch (Exception ex) // Bloco de captura para lidar com exceções que possam ocorrer durante a execução do código, como erros de conversão ou entrada inválida
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}"); // Exibe uma mensagem de erro para o usuário, mostrando a descrição da exceção que ocorreu
                Console.ReadLine(); // Aguarda o usuário pressionar Enter antes de continuar, para que ele possa ler a mensagem de erro antes de o menu ser exibido novamente
                Console.Clear(); // Limpa a tela do console para exibir o menu novamente, mantendo a interface limpa e organizada mesmo após um erro

            }

            static void Soma()
            {
                Console.WriteLine();
                Console.WriteLine("Soma de dois números!");
                Console.WriteLine();
                Console.Write("Digite o primeiro número:");
                int som1 = int.Parse(Console.ReadLine()); // Lê o primeiro número digitado pelo usuário e converte para double
                Console.WriteLine();
                Console.Write("Digite o segundo número:");
                int som2 = int.Parse(Console.ReadLine()); // Lê o segundo número digitado pelo usuário e converte para double
                Console.WriteLine();
                int resultado = som1 + som2; // Realiza a soma dos dois números
                Console.WriteLine($"O resultado da soma é: {resultado}"); // Exibe o resultado da soma para o usuário
                Console.ReadLine(); // Aguarda o usuário pressionar Enter antes de continuar, para que ele possa ver o resultado antes de o menu ser exibido novamente
            }

            static void Subtracao()
            {
                Console.WriteLine();
                Console.WriteLine("Subtração de dois números");
                Console.WriteLine();
                Console.Write("Digite o primeiro número:");
                int sub1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Digite o segundo número:");
                int sub2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int resultadosub = sub1 - sub2;
                Console.WriteLine($"O resultado é: {resultadosub}");
                Console.ReadLine();
            }

            static void Multiplicacao()
            {
                Console.WriteLine();
                Console.WriteLine("Multiplicação de dois números!");
                Console.WriteLine();
                Console.Write("Digite o primeiro número:");
                int mult1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Digite o segundo número");
                int mult2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int resultadomult = mult1 * mult2;
                Console.WriteLine($"O resultado é: {resultadomult}");
                Console.ReadLine();
            }

            static void Divisao()
            {
                Console.WriteLine();
                Console.WriteLine("Divisao de dois números!");
                Console.WriteLine();
                Console.Write("Digite o Primeiro número:");
                int div1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Digite o segundo número:");
                int div2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                float resultadodiv = (float)div1 / (float)div2;
                Console.WriteLine($"O resultado é: {resultadodiv}");
                Console.ReadLine();
            }

            static void Potencia()
            {
                Console.WriteLine();
                Console.WriteLine("Potencia de dois números!");
                Console.WriteLine();
                Console.Write("Digite a base:");
                int baseNum = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Digite o expoente:");
                int expo = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int resultadopot = (int)Math.Pow(baseNum, expo);
                Console.WriteLine($"O resultado é: {resultadopot}");
                Console.ReadLine();
            }

            static void Raiz()
            {
                Console.WriteLine();
                Console.WriteLine("Raiz de um número!");
                Console.WriteLine();
                Console.Write("Digite o número:");
                int raiz1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                double resultadoraiz = Math.Sqrt(raiz1);
                Console.WriteLine($"O resultado é: {resultadoraiz}");
                Console.ReadLine();
            }
        }

    }
}