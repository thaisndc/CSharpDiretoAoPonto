class Program
{
    static void Main(string[] args)
    {
        // Tipos de Dados

        int numeroInt = 10; // Declara um inteiro

        int maiorNumeroInt = int.MinValue; // Menor valor possível para int
        int menorNumeroInt = int.MinValue; // Menor valor possível para int

        long numeroLong = 1234567891011; // Declara um long

        long maiorNumeroLong = long.MaxValue; // Maior valor possível para long
        long menorNumeroLong = long.MinValue; // Menor valor possível para long

        decimal numeroDecimal = 10.52m; // Declara um decimal

        double numeroDouble = 12.3; // Declara um double
        double menorNumeroDouble = double.MinValue; // Menor valor possível para double

        bool verdadeiro = true; // Declara um booleano como verdadeiro
        bool falso = false; // Declara um booleano como falso

        var numero = 10; // Declara um inteiro com tipo implícito

        string nome = "Thais Nascimento"; // Declara uma string
        char letra = 'T'; // Declara um caractere

        DateTime entradaEmpresa = new DateTime(2024, 1, 1); // Declara uma data
        TimeSpan quantotempoEmpresa = DateTime.Now - entradaEmpresa; // Calcula a diferença de tempo
    }
}