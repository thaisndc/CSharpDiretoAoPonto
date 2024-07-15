using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpDiretoAoPonto
{
    public class Estudante : Pessoa 
    {
        // Construtor
        public Estudante(string turma, string nome, string documento, DateTime dataNascimento)
            : base(nome, documento, dataNascimento) // Chama o construtor da classe base
        {
            Turma = turma; // Inicializa a turma
            Notas = new List<int> { 5, 10, 4, 2, 3, 5 }; // Inicializa a lista de notas
        }

        public string Turma { get; private set; } 
        public List<int> Notas { get; private set; }

        // Método sobreposto para apresentar informações do estudante
        public override void SeApresentar()
        {
            base.SeApresentar(); // Chama o método SeApresentar da classe base

            var media = Notas.Average(); // Calcula a média das notas

            // Exibe informações sobre o estudante
            Console.WriteLine($"Sou um estudante da turma {Turma}, Média de Nota: {media}");
        }
    }
}