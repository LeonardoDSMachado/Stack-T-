Stack<int> numeros = new Stack<int> ();
numeros.Push (10);
numeros.Push (20);
numeros.Push (30);
numeros.Push (10);

Console.WriteLine($"-A pilha original contém {numeros.Count} itens");

ExibirPilha(numeros);

//retornar sem remover
Console.WriteLine($"\nItem obtido da pilha (Peek) : {numeros.Peek()}");

//remove e retorna
Console.WriteLine($"\n-Item Removido da pilha (Pop) : {numeros.Pop()}");

Console.WriteLine($"\n-A pilha agora contém {numeros.Count} itens");

if(numeros.Contains (20))
    Console.WriteLine("\n-Item 20 esta na pilha");
else
    Console.WriteLine("\n-Item 20 não esta na pilha");

var copia = new Stack<int> (numeros.ToArray());
ExibirPilha (copia);

ExibirPilha(numeros);

Console.ReadKey();

static void ExibirPilha<T>(IEnumerable<T> numeros)
{
    Console.WriteLine();
    foreach (var item in numeros)
    {
        Console.WriteLine(item);
    }
}