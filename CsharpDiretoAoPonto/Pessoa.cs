using System;

namespace CsharpDiretoAoPonto
{
    public abstract class Pessoa // Classe abstrata Pessoa
    {
        // Construtor 
        public Pessoa(string nome, string documento, DateTime dataNascimento)
        {
            Nome = nome; // Inicializa o nome
            Documento = documento; // Inicializa o documento
            DataNascimento = dataNascimento; // Inicializa a data de nascimento
        }

        public string Nome { get; protected set; } 
        public string Documento { get; protected set; } 
        public DateTime DataNascimento { get; protected set; }

        // Método virtual para apresentar informações da pessoa
        public virtual void SeApresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, Documento {Documento}, Data de Nascimento: {DataNascimento}");
        }
    }
}

