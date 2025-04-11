// Pesquisa e ordernação
// Aula de 11/04/2025
using PesquisaEOrdenacao.Helpers;

int[] numeros = [ 5, 2, 8, 1, 9 ];
Console.WriteLine("\n Array aleatória: ");
ArrayPrinter.ImprimirArray(numeros);

// ordenação decrescente usando array.sort
Console.WriteLine("\n Array ordernada(crescente): ");
Array.Sort(numeros);
ArrayPrinter.ImprimirArray(numeros);

// ordenação decrescente - usando o LINQ
var numeroDecrescente = numeros.OrderByDescending(x => x).ToArray();

//Console.WriteLine("\n Array ordernada(decrescente): ");
ArrayPrinter.ImprimirArrayComDescricao(numeros, "Array ordenada");

