// Arrays

var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var numbersCopy = new int[10]; // Array vazio com 10 elementos

// 0 - based: arrays em C# começam em 0
for (var i = 0; i < numbers.Length; i++)
{
    numbersCopy[i] = numbers[i]; // Copia elementos de numbers para numbersCopy
}

var numbersStrings = "0, 1, 2, 3, 4, 5, 6, 7, 8, 9"; // String com números
var numbersArray = numbersStrings.Split(' '); // Divide a string em um array
var numbersConvertedFromString = Array.ConvertAll(numbersArray, Convert.ToInt32); // Converte para int


// Listas
var list = new List<int> { 0, 1, 2, 3, 4 }; // Lista inicializada
var listFromArray = new List<int>(numbers); // Lista a partir do array

list.Add(5); // Adiciona 5 à lista
list.AddRange(new List<int> { 6, 7 }); // Adiciona uma nova lista
list.AddRange(new int[] { 8, 9 }); // Adiciona um array

var count = list.Count; // Contagem de elementos
var contains14 = list.Contains(14); // Verifica se 14 está na lista
var contains2 = list.Contains(2); // Verifica se 2 está na lista

Console.WriteLine("Lista reversa: ");
list.Reverse(); // Inverte a lista
list.ForEach(l => Console.WriteLine(l)); // Exibe cada elemento

list.Remove(4); // Remove o valor 4
list.RemoveAll(l => l > 5); // Remove todos > 5

list.Clear(); // Limpa a lista


// LINQ
var students = new List<Student>
{
    new Student(1, "Thais", "123456789", 100),
    new Student(2, "Roberto", "836394629", 35),
    new Student(3, "Breno", "630957443", 85),
    new Student(4, "Heitor", "893648924", 75),
    new Student(5, "Thais", "123456789", 75),
};

var any = students.Any(); // Verifica se há estudantes
var any100 = students.Any(s => s.Grade == 100); // Verifica nota 100

var single = students.Single(s => s.Id == 1); // Estudante com Id 1
var singleOrDefault = students.SingleOrDefault(s => s.Document == "123456789"); // Documento específico

var first = students.First(s => s.FullName == "Thais"); // Primeiro estudante "Thais"
var firstOrDefault = students.FirstOrDefault(s => s.Grade == 0); // Nota 0, se existir

var orderedByGrade = students.OrderBy(s => s.Grade); // Ordena por nota
var orderedByGradeDescinding = students.OrderByDescending(s => s.Grade); // Ordena decrescente

var approvedStudants = students.Where(s => s.Grade >= 70); // Estudantes aprovados

var grades = students.Select(s => s.Grade); // Seleciona notas
var phoneNumbers = students.SelectMany(s => s.PhoneNumbers); // Seleciona todos os números de telefone

var sum = students.Sum(s => s.Grade); // Soma das notas
var min = students.Min(s => s.Grade); // Menor nota
var max = students.Max(s => s.Grade); // Maior nota
var count1 = students.Count; // Contagem de estudantes


// Classe Student
public class Student
{
    public Student(int id, string fullName, string document, int grade) // Construtor
    {
        Id = id;
        FullName = fullName;
        Document = document;
        Grade = grade;

        PhoneNumbers = new List<string> { "123123123122", "12341234123", "4564564654" }; // Inicializa lista de telefones
    }

    // Propriedades da classe
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Document { get; set; }
    public int Grade { get; set; }
    public List<string> PhoneNumbers { get; set; }
}