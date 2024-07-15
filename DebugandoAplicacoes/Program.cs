// Debugando

var numerosString = Console.ReadLine(); // Lê a linha de entrada do usuário
var numeros = numerosString.Split(' '); // Divide a string em um array de números

// Se estiver errado, você pode testar mudar o valor e avançar com o código.
foreach (var numero in numeros)
{
    var numeroInt = int.Parse(numero); // Converte a string para inteiro

    var aoQuadrado = Math.Pow(numeroInt, 2); // Calcula o quadrado do número

    Console.WriteLine($"{numeroInt}² = {aoQuadrado}"); // Exibe o resultado
}