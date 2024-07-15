// Trabalhando com Strings

var paragrafo = "   C# é uma linguagem moderna e versátil. " +
            "Com C# consigo desenvolver para web, Desktop, jogos, " +
            "Mobile, entre outros.  ";

// Length
var tamanho = paragrafo.Length; // Obtém o tamanho da string

// Empty
var vazio = string.Empty; // String vazia

// ToLower, ToUpper
var paragrafoMinuscula = paragrafo.ToLower(); // Converte para minúsculas
var paragrafoMaiusculo = paragrafo.ToUpper(); // Converte para maiúsculas

// Split
var frases = paragrafo.Split('.'); // Divide o parágrafo em frases

// Trim, TrimEnd, TrimStart
var paragrafoTrim = paragrafo.Trim(); // Remove espaços no início e no fim
var paragrafoTrimEnd = paragrafo.TrimEnd(); // Remove espaços no fim
var paragrafoTrimStart = paragrafo.TrimStart(); // Remove espaços no início

// IsNullOrWhiteSpace
var isNullOrWhiteSpace = string.IsNullOrWhiteSpace(paragrafo); // Verifica se é nulo ou só contém espaços

// Replace
var paragrafoCsharp = paragrafo.Replace("C#", "C-Sharp"); // Substitui "C#" por "C-Sharp"


var outroparagrafo = "C# é uma linguagem moderna e versátil. " +
                     "Com C# consigo desenvolver para web, Desktop, jogos, " +
                     "Mobile, entre outros.  ";

// IndexOf
var indexOf = outroparagrafo.IndexOf("C#"); // Encontra o índice da primeira ocorrência de "C#"

// LastIndexOf
var lastIndexOf = outroparagrafo.LastIndexOf("C#"); // Encontra o índice da última ocorrência de "C#"

// StartsWith
var startsWith = outroparagrafo.StartsWith("C#"); // Verifica se começa com "C#"

// Substring
var indexOfMobile = outroparagrafo.IndexOf("Mobile"); // Encontra o índice de "Mobile"
var substringMobile = outroparagrafo.Substring(indexOfMobile, 6); // Extrai "Mobile"

// Contains
var containsJogos = outroparagrafo.Contains("jogos", StringComparison.OrdinalIgnoreCase); // Verifica se contém "jogos", ignorando maiúsculas/minúsculas
var containsjogos = outroparagrafo.Contains("jogos"); // Verifica se contém "jogos"
var containsJogosExact = outroparagrafo.Contains("Jogos"); // Verifica se contém "Jogos"
var containsRuim = outroparagrafo.Contains("ruim"); // Verifica se contém "ruim"