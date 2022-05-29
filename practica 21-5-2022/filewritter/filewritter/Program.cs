// See https://aka.ms/new-console-template for more information
Console.WriteLine("Inicio");

string path= @"C:\Users\pc\Desktop\UCE 2022 C2\Optimizacion de algoritmos\practica 21-5-2022\archivo.txt";

if (!File.Exists(path)) 
{
    using (StreamWriter sw = File.CreateText(path)) 
    {
        sw.WriteLine("Hola mundo");
    }

}

using (StreamReader sr = File.OpenText(path))
{
    string linea;
    while ((linea = sr.ReadLine() ?? "") != null)
    {
        Console.WriteLine(linea);
    }
}