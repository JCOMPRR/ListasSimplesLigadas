using ListasDoblementeLigadas;

Lista listas = new Lista();
listas.AgregarNodo("Cero");
listas.AgregarNodo("Uno");
listas.AgregarNodo("Dos");
listas.AgregarNodo("Tres");
Console.WriteLine(listas.RecorrerLista());

Console.WriteLine();

Console.WriteLine("Buscando Nodo");
Nodo nodoDos = listas.Buscar("Tres");
Console.WriteLine(nodoDos.Valor);

Console.WriteLine();

Console.WriteLine("Borrar Nodo");
listas.BorrarNodo("Uno");
Console.WriteLine(listas.RecorrerLista());