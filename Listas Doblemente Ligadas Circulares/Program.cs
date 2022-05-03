using Listas_Circulares;

Lista listas = new Lista();
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

Nodo nodoPosteriorAtres = listas.Buscar("Tres");
//Console.WriteLine(nodoPosteriorAtres.Enlace.Enlace.Valor);

Console.WriteLine();


Console.WriteLine("Se borro nodo");
listas.BorrarNodo("Dos");
Console.WriteLine(listas.RecorrerLista());