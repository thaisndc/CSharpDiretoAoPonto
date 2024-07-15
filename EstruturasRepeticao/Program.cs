// Estruturas de Repetição

Console.WriteLine("Digite uma sequência de números separados por espaço. ");
// Exemplo: 0 1 2 3 4 5 6 7 8 9 10

var numerosTexto = Console.ReadLine(); // Lê a sequência de números

var numeros = numerosTexto.Split(' '); // Divide a string em um array de números

Console.WriteLine("Usando for: ");
for (int i = 0; i < numeros.Length; i++) // Loop usando for
{
    Console.WriteLine(numeros[i]); // Exibe cada número
}

// While
Console.WriteLine("Usando while: ");
var contador = 0; // Inicializa contador

while (contador < numeros.Length) // Loop enquanto contador é menor que o tamanho do array
{
    Console.WriteLine(numeros[contador]); // Exibe cada número
    contador++; // Incrementa contador
}

// foreach
Console.WriteLine("Usando foreach: ");
foreach (var numero in numeros) // Loop foreach para iterar sobre os números
{
    Console.WriteLine(numero); // Exibe cada número
}

Console.ReadKey(); // Aguarda uma tecla ser pressionada