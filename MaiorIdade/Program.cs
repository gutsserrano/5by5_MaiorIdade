// Faça um algorítmo que leia a idade de uma pessoa e informe se ela é maior ou menor de idade

int idade;

Console.WriteLine("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());

if (idade < 0)
{
    Console.WriteLine("Idade inválida!\n");
}
else
{
    if (idade < 18)
    {
        Console.WriteLine("Menor de idade\n");
    }
    else
    {
        Console.WriteLine("Maior de idade\n");
    }
}

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();
