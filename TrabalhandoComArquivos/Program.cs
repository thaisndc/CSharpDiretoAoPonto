// Directory e DirectoryInfo

var folderName = "pasta"; // Nome da pasta principal
var subFolderName = "subpasta"; // Nome da subpasta
var subFolderNameStatic = "subpasta_usingstatic"; // Nome da subpasta estática

var directoryInfoSubFolder = new DirectoryInfo(subFolderName); // Cria um objeto DirectoryInfo para a subpasta

// Verifica se a subpasta não existe
if (!Directory.Exists(subFolderName) || !directoryInfoSubFolder.Exists)
{
    Directory.CreateDirectory(subFolderNameStatic); // Cria a subpasta estática
    Directory.CreateDirectory(folderName); // Cria a pasta principal
    directoryInfoSubFolder.Create(); // Cria a subpasta

    directoryInfoSubFolder.MoveTo($"{folderName}//{subFolderName}"); // Move a subpasta para a pasta principal
    Directory.Move(subFolderNameStatic, $@"{folderName}\{subFolderNameStatic}"); // Move a subpasta estática para a pasta principal
}

// Obtém informações sobre a subpasta
var name = directoryInfoSubFolder.Name;
var parent = directoryInfoSubFolder.Parent; // Pasta pai
var root = directoryInfoSubFolder.Root; // Raiz do diretório
var exist = directoryInfoSubFolder.Exists; // Verifica se a subpasta existe

// Exibe todos os diretórios dentro da pasta principal
foreach (var directory in Directory.GetDirectories(folderName))
{
    Console.WriteLine(directory);
}

// Deleta a subpasta
Directory.Delete($@"{folderName}\{subFolderName}");

// File e FileInfo

var file = @"pasta\texto.txt"; // Caminho do arquivo

// Verifica se o arquivo não existe
if (!File.Exists(file))
{
    File.CreateText(file); // Cria o arquivo texto
}

var fileInfo = new FileInfo(file); // Cria um objeto FileInfo para o arquivo

// Exibe informações sobre o arquivo
Console.WriteLine($"Nome: {fileInfo.Name}, Tamanho: {fileInfo.Length}, Data de atualização: {fileInfo.LastWriteTime}");