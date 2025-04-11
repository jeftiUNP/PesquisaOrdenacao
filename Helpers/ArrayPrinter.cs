namespace PesquisaEOrdenacao.Helpers;

public static class ArrayPrinter{
    public static void ImprimirArray<T>(T[] array){
        Console.Write("[");
        bool firsElement = true;

        foreach (var values in array){
            if(!firsElement){
                Console.Write(", ");
            }
            Console.Write(values + " ");
            firsElement = false;
        }
        Console.WriteLine("]");
    }

    public static void ImprimirArrayComDescricao<T>(T[] array, string description){
        Console.Write($"{description}: [");
        bool firsElement = true;

        foreach (var values in array){
            if(!firsElement){
                Console.Write(", ");
            }
            Console.Write(values + " ");
            firsElement = false;
        }
        Console.WriteLine("]");
    }
}

