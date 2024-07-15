// Datas

var now = DateTime.Now; // Obtém a data e hora atual
var today = DateTime.Today; // Obtém a data atual sem hora

var threeDaysAgo = today.AddDays(-3); // Data de três dias atrás
var sixMonthsLater = today.AddMonths(6); // Data em seis meses
var twoYearsLater = today.AddYears(2); // Data em dois anos

var shortDate = now.ToShortTimeString(); // Hora em formato curto
var longDate = now.ToLongDateString(); // Data em formato longo

var shortTime = now.ToShortTimeString(); // Hora em formato curto
var longTime = now.ToLongTimeString(); // Hora em formato longo

var date = now.Date;
var day = now.Day;
var month = now.Month;
var year = now.Year;
var hour = now.Hour;
var minute = now.Minute;
var second = now.Second;

var dayOfWeek = now.DayOfWeek; // Dia da semana

// Verifica se é fim de semana
if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
{
    Console.WriteLine("É fim de semana!");
}

var dayOfYear = now.DayOfYear; // Dia do ano

// Formatos de data
var formats = new string[] { "d", "D", "f", "F", "g", "G", "m", "o", "r", "s", "t", "T", "u", "U", "Y" };

foreach (var format in formats)
{
    Console.WriteLine("Data no Formato {0}: {1}", format, now.ToString(format)); // Imprime cada formato
    //Console.WriteLine($"Data no Formato {format}: {now.ToString(format)}");
}

Console.WriteLine("Diferentes maneiras de formatar manualmente");
Console.WriteLine($"Data no formato d: {now:d}"); // Formato curto
Console.WriteLine($"Data no formato MM-dd-yyyy: {now:MM-dd-yyyy}"); // Formato personalizado
var dateFormat = now.ToString("MM-dd-yyyy"); // Formato MM-dd-yyyy
var dateFormatBr = now.ToString("dd/MM/yyyy HH:mm:ss"); // Formato brasileiro