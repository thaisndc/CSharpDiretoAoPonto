// Tratando Exceções

var seteString = "sete"; // String que não pode ser convertida para int
string valorNull = null; // Variável nula
var longValue = long.MaxValue.ToString(); // String representando o valor máximo de long

try
{
    // Tentativa de conversão, pode gerar exceções
    var fortmatException = int.Parse(seteString);
    var argumentNullException = int.Parse(valorNull);
    var overflowException = int.Parse(longValue);
}
catch (FormatException exception)
{
    Console.WriteLine($"Format Exception: {exception}"); // Trata a exceção de formato
}
catch (ArgumentNullException exception)
{
    Console.WriteLine($"Argument Null Exception: {exception.Message}"); // Trata a exceção de argumento nulo
}
catch (OverflowException exception)
{
    Console.WriteLine($"Overflow Exception: {exception.Message}"); // Trata a exceção de overflow
}
finally
{
    Console.WriteLine("Este código é executado sempre."); // Código que sempre é executado, independente de exceções
}
