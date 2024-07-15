using CsharpDiretoAoPonto;


var professor = new Professor(5000m, "João", "12345", new DateTime(1980, 1, 1));
var estudante = new Estudante("A", "Thais", "56789", new DateTime(1995, 1, 24));

// Lista para armazenar as pessoas (estudantes e professores)
var pessoas = new List<Pessoa> { estudante, professor };

// Itera sobre cada pessoa na lista e chama o método SeApresentar
foreach (var pessoa in pessoas)
{
    pessoa.SeApresentar();
}