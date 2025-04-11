// Pesquisa e ordernação
// Aula de 11/04/2025

int[] numeros = [ 5, 2, 8, 1, 9 ];
ImprimirArray(numeros);

// ordenação decrescente usando array.sort
Console.WriteLine("\n Array ordernada(crescente): ");
Array.Sort(numeros);
ImprimirArray(numeros);

// ordenação decrescente - usando o LINQ
var numeroDecrescente = numeros.OrderByDescending(x => x).ToArray();
Console.WriteLine("\n Array ordernada(decrescente): ");
ImprimirArray(numeroDecrescente);

static void ImprimirArray(int[] numeros){
    foreach (int numero in numeros)
    {
        Console.Write(numero + " ");
    }
    Console.WriteLine();
    //Console.WriteLine("Array Original: " +  string.Join(", ", numeros));
}