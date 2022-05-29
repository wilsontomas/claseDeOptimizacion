// See https://aka.ms/new-console-template for more information
using LinkedList;

Console.WriteLine("Inicio");

/*
LinkedList<string> listaEnlazada = new LinkedList<string>();

listaEnlazada.AddLast("primero");
listaEnlazada.AddLast("segundo");
listaEnlazada.AddLast("tercero");
listaEnlazada.AddLast("cuerto");
listaEnlazada.AddLast("quinto");

foreach (var item in listaEnlazada) 
{
    Console.WriteLine(item);
}
Console.WriteLine("_____________");
listaEnlazada.AddFirst("Se agrego de primero");
var nodo = listaEnlazada.Find("segundo");
listaEnlazada.AddBefore(nodo,"nuevo nodo antes");
listaEnlazada.AddAfter(nodo,"nuevo nodo despues");

foreach (var item in listaEnlazada)
{
    Console.WriteLine(item);
}*/

var clase = new ListasEnlazadas();

clase.StartMenu();