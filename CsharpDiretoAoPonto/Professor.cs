using System;
using System.Collections.Generic;

namespace CsharpDiretoAoPonto
{
    public class Professor : Pessoa // Classe Professor que herda de Pessoa
    {
        // Construtor
        public Professor(decimal salario, string nome, string documento, DateTime dataNascimento)
            : base(nome, documento, dataNascimento) // Chama o construtor da classe base
        {
            Salario = salario; // Inicializa o salário
            Turmas = new List<string> { "A", "B" }; // Inicializa as turmas
        }

        public List<string> Turmas { get; private set; }
        public decimal Salario { get; private set; }

        // Método sobreposto para apresentar informações do professor
        public override void SeApresentar()
        {
            base.SeApresentar(); // Chama o método SeApresentar da classe base

            var turmas = string.Join(',', Turmas); // Concatena as turmas em uma string

            // Exibe informações sobre o professor
            Console.WriteLine($"Meu salário é {Salario}, e ensino para as turmas {turmas}");
        }
    }
}