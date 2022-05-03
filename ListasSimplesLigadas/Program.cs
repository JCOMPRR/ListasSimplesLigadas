using ListasSimplesLigadas;

Listas listas = new Listas();
listas.AgregarNodo("Cero");
listas.AgregarNodo("Uno");
listas.AgregarNodo("Dos");
listas.AgregarNodo("Tres");
Console.WriteLine(listas.RecorrerLista());

Console.WriteLine();
Console.WriteLine("Buscando Nodo");
Nodo nodoDos = listas.Buscar("Dos");
Console.WriteLine(nodoDos.Valor);

Console.WriteLine();

Console.WriteLine("Se borro nodo");
listas.BorrarNodo("Dos");
Console.WriteLine(listas.RecorrerLista());