

static void Main(string[] agrs)
{

int escolha_lanche = Convert.ToInt32(0);
while (escolha_lanche == 1)
{
    Console.WriteLine("Suas opções de lanche são;");
    Console.WriteLine("╔═════════════╗");
    Console.WriteLine("[1] - Big MC  |");
    Console.WriteLine("[2] - Cheddar |");
    Console.WriteLine("[3] - Ticken  |");
    Console.WriteLine("[4] - Bebidas |");
    Console.WriteLine("╚═════════════╝");
    decimal bigmc = Convert.ToDecimal(15.70);
    decimal cheddar = Convert.ToDecimal(13.00);
    decimal ticken = Convert.ToDecimal(12.50);

    escolha_lanche = Convert.ToInt32(Console.ReadLine())!;

    decimal valor_lanche = Convert.ToDecimal(0.0);

    switch (escolha_lanche)
    {
        case 1:
            valor_lanche = Convert.ToDecimal(bigmc);
            Console.WriteLine("\nHumm Big MC, boa escolha ^^\n");
            break;

        case 2:
            valor_lanche = Convert.ToDecimal(cheddar);
            Console.WriteLine("Humm Cheddar, boa escolha ^^\n");
            break;


        case 3:
            valor_lanche = Convert.ToDecimal(ticken);
            Console.WriteLine("Humm MC Ticken, boa escolha ^^\n");
            break;

        case 4:
            {
                Console.WriteLine("-- Agora escolha sua bebida!\n");
                Console.WriteLine("╔════════════════════╗");
                Console.WriteLine("[1] - Coca-Cola      |");
                Console.WriteLine("[2] - Soda           |");
                Console.WriteLine("[3] - Guarana Jesus  |");
                Console.WriteLine("╚════════════════════╝");

                decimal coca_cola = Convert.ToDecimal(8.00);
                decimal soda = Convert.ToDecimal(6.20);
                decimal guarana_jesus = Convert.ToDecimal(7.50);


                int escolha_bebida = Convert.ToInt32(Console.ReadLine())!;

                decimal valor_bebida = Convert.ToDecimal(0.0);

                switch (escolha_bebida)
                {
                    case 1:
                        valor_bebida = Convert.ToDecimal(coca_cola);
                        Console.WriteLine($"\nHumm Coca-Cola, boa escolha ^^\n");
                        break;

                    case 2:
                        valor_bebida = Convert.ToDecimal(soda);
                        Console.WriteLine($"\nHumm Soda, boa escolha ^^\n");
                        break;

                    case 3:
                        valor_bebida = Convert.ToDecimal(guarana_jesus);
                        Console.WriteLine($"\nHumm Guarana Jesus, boa escolha ^^\n");
                        break;
                    default:

                        Console.WriteLine("╔═════════════════════╗");
                        Console.WriteLine("┊ Escolha uma bebida. ┊");
                        Console.WriteLine("╚═════════════════════╝");


                        Console.WriteLine($"Total Lanche = {valor_lanche}");
                        Console.WriteLine($"Total Bebida = {valor_bebida}");
                        Console.WriteLine($"_______________________________");
                        Console.WriteLine($"Total = {escolha_bebida + valor_lanche}\n\n");
                        break;

                }
            }
            break;

        default:
            {

                Console.WriteLine("╔════════════════════╗");
                Console.WriteLine("┊ Escolha um lanche. ┊");
                Console.WriteLine("╚════════════════════╝");
                Console.WriteLine("\n");
                break;

            }

    }

}
}