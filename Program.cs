Console.WriteLine("-=-Múltiplo-=-");

Console.WriteLine("Por favor, digite um número: ");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Por favor, digite um segundo número:");
int numero2 = Convert.ToInt32(Console.ReadLine());

    if (numero1 % numero2 == 0)
        {
            Console.WriteLine($"\n{numero1} é múltiplo de {numero2}");
    
        }
    else
        {
            Console.WriteLine($"\n {numero1} não é múltiplo de {numero2}");
        }















