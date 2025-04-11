// Pesquisa e ordernação
// Aula de 11/04/2025

int[] numeros = [ 5, 2, 8, 1, 9 ];
ImprimirArray(numeros);

static void ImprimirArray(int[] numeros){
    foreach (int numero in numeros)
    {
        Console.Write(numero);
    }
    //Console.WriteLine("Array Original: " +  string.Join(", ", numeros));
}