// See https://aka.ms/new-console-template for more information
using practica1;

Console.WriteLine("Inicio");
string path = @"C:\Users\pc\Desktop\UCE 2022 C2\Optimizacion de algoritmos\archivo.txt";
//var peliculas = new List<Pelicula>();
Pelicula[] Peliculas = new Pelicula[2];
for (int i = 0; i < 2; i++) {
    Console.Clear();
    var peli = new Pelicula();

    Console.WriteLine("Agregando pelicula");
    Console.WriteLine("Titulo");
    peli.titulo = Console.ReadLine() ??  "N/A";
    Console.WriteLine("Director");
    peli.director = Console.ReadLine() ?? "N/A";
    Console.WriteLine("Escritor");
    peli.escrito = Console.ReadLine() ?? "N/A";
    Console.WriteLine("Genero");
    peli.genero = Console.ReadLine() ?? "N/A";
    Console.WriteLine("Duracion");
    peli.duracion = Console.ReadLine() ?? "N/A";
    Console.WriteLine("Clasificacion");
    peli.clasificacion = Console.ReadLine() ?? "N/A";
    Console.WriteLine("Productora");
    peli.productora = Console.ReadLine() ?? "N/A";

    Peliculas[i] = peli;
    //peliculas.Add(peli);

}
var lista = Peliculas.ToList();
Console.Clear();



using (StreamWriter sw = File.CreateText(path))
{   
        foreach (var pel in lista) {
        sw.WriteLine("___________");
        sw.WriteLine("Titulo: " + pel.titulo);

        sw.WriteLine("Director: " + pel.director);
        sw.WriteLine("Escritor:" + pel.titulo);

        sw.WriteLine("Genero: " + pel.genero);

        sw.WriteLine("Clasificacion: " + pel.clasificacion);

        sw.WriteLine("Duracion: " + pel.duracion);

        sw.WriteLine("Productora: " + pel.productora);

        sw.WriteLine("___________");
        
    }
   
}


using (StreamReader sr = File.OpenText(path))
{
    string linea;
    while ((linea = sr.ReadLine()) != null)
    {
        Console.WriteLine(linea);
    }
}
