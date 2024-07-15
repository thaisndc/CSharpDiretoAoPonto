class Program
{
    static void Main(string[] args)
    {
        // Conversões

        int notaAluno = 10; // Declaração da nota do aluno

        double notaAlunoDouble = notaAluno; // Conversão implícita de int para double
        int numeroDoubleComoInt = (int)notaAlunoDouble; // Conversão explícita de double para int

        string notaString = "10"; // String representando um número

        int notaConvert = Convert.ToInt32(notaString); // Conversão utilizando Convert

        int notaParse = int.Parse(notaString); // Conversão utilizando Parse

        // Tenta converter e verifica se é válido
        if (int.TryParse(notaString, out int notaTryParse))
        {
            // Conversão bem-sucedida
        }
        else
        {
            Console.WriteLine("Número em formato inválido"); // Mensagem de erro
        }

        // Operadores Aritméticos

        // Unários ++, --, + e -
        int numeroOperador = 4;

        Console.WriteLine(numeroOperador++); // Imprime 4 e incrementa depois
        Console.WriteLine(numeroOperador--); // Imprime 5 e decrementa depois

        Console.WriteLine(++numeroOperador); // Incrementa para 5 e imprime
        Console.WriteLine(--numeroOperador); // Decrementa para 4 e imprime

        Console.WriteLine(numeroOperador); // Imprime o valor atual (4)
        Console.WriteLine(-numeroOperador); // Imprime o valor negativo: -4
        Console.WriteLine(-(numeroOperador)); // Imprime o valor negativo usando parênteses: -4


        // Binários
        var soma = 4 + 5; 
        var subtracao = 4 - 5;
        var multiplicacao = 4 * 5;
        var divisao = 20 / 3;
        var divisaoDouble = (double)20 / 3;

        var multiplos = (4 * 5) + 10; // Operação composta


        // Operadores de Comparação
        Console.WriteLine(4 > 5); // Falso
        Console.WriteLine(5 > 5); // Falso
        Console.WriteLine(6 >= 5); // Verdadeiro

        Console.WriteLine(5 > 4); // Verdadeiro
        Console.WriteLine(5 <= 5); // Verdadeiro
        Console.WriteLine(5 < 6); // Verdadeiro


        // Operadores de Igualdade
        Console.WriteLine(5 == 5); // Verdadeiro
        Console.WriteLine(5 == 4); // Falso

        Console.WriteLine(5 != 5); // Falso
        Console.WriteLine(4 != 5); // Verdadeiro


        // Operadores Lógicos
        var minhaNota = 7;
        var ultimoAno = true;

        // Verifica se o aluno está aprovado e terminou o curso
        if (minhaNota >= 7 && ultimoAno)
        {
            Console.WriteLine("Aprovado e terminou o curso, parabéns!");
        }

        // Condição alternativa
        /*
        if (minhaNota >= 7 || ultimoAno)
        {
            Console.WriteLine("Aprovado");
        }*/


        // Operações lógicas
        Console.WriteLine(true || false); // Verdadeiro
        Console.WriteLine(false || true); // Verdadeiro
        Console.WriteLine(true || true); // Verdadeiro
        Console.WriteLine(false || false); // Falso

        Console.WriteLine(true && false); // Falso
        Console.WriteLine(false && true); // Falso
        Console.WriteLine(true && true); // Verdadeiro
        Console.WriteLine(false && false); // Falso

        bool usuarioBloqueado = false; // Verifica se o usuário está bloqueado

        if (!usuarioBloqueado) // Se não estiver bloqueado
        {
            Console.WriteLine("Usuário não está bloqueado. Pode prosseguir.");
        }
        else
        {
            Console.WriteLine("Usuário está bloqueado. Acesso negado.");
        }
    }
}