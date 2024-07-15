// Estrutura de Condição - if/else

Console.Write("Digite sua nota: "); // Solicita ao usuário que digite a nota
var notaDigitada = Console.ReadLine(); // Lê a entrada do usuário

var nota = int.Parse(notaDigitada); // Converte a entrada para inteiro

// Verifica a nota e exibe o resultado
if (nota >= 70)
{
    Console.WriteLine("Aprovado!");
}
else if (nota >= 40)
{
    Console.WriteLine("Em recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}


// switch / case
Console.WriteLine("Seja bem-vindo a empresa X.");

// Opções disponíveis
Console.WriteLine("Digite 1 - Contratação de um plano");
Console.WriteLine("Digite 2 - Reclamação de um serviço prestado");
Console.WriteLine("Digite 3 - Segunda via de boleto");
Console.WriteLine("Digite 4 - Sair");

var opcao = Console.ReadLine(); // Lê a opção escolhida

// Estrutura switch para processar a opção
switch (opcao)
{
    case "1":
        Console.WriteLine("Informações de um plano novo.");
        break;
    case "2":
        Console.WriteLine("Fale sobre sua reclamação.");
        break;
    case "3":
        Console.WriteLine("Segunda via de boleto enviada por e-mail.");
        break;
    case "4":
        Console.WriteLine("Tenha um bom dia!");
        break;
    default:
        Console.WriteLine("Opção não encontrada.");
        break;
}