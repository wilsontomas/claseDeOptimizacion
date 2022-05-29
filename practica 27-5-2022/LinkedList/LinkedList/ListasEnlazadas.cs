using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ListasEnlazadas
    {
        public LinkedList<string> alumnos { get; set; }

        public ListasEnlazadas() 
        {
            alumnos = new LinkedList<string>();
        }
        public int menu() 
        {
            Console.Clear();
            int opcion = 0;
            Console.WriteLine("Elije la opcion deseada");
            Console.WriteLine("_____________________");
            Console.WriteLine("Agregar alumno: 1");
            Console.WriteLine("Agregar alumno de primero: 2");
            Console.WriteLine("Agregar alumno de ultimo: 3");
            Console.WriteLine("Mover un alumno de ultimo: 4");
            Console.WriteLine("Eliminar un alumno: 5");
            Console.WriteLine("Verificar si el alumno existe: 6");
            Console.WriteLine("Listar alumnos: 7");
            Console.WriteLine("Salir: 8");
            Console.WriteLine("_____________________");
            var op = Console.ReadLine();
            if (!int.TryParse(op, out opcion)) { return 0; }
            return opcion;
        }
        public bool opciones(int op) 
        {
            
            switch (op) 
            {
                case 1:
                    Console.WriteLine("agregar 3 elementos");
                    agregarVarios();
                    return true;
                   
                case 2:
                    Console.WriteLine("agregar de primero");
                    agregarPrimero();
                    return true;

                case 3:
                    Console.WriteLine("agregar de ultimo");
                    agregarUltimo();
                    return true;

                case 4:
                    Console.WriteLine("Mover al ultimo");
                    mover();
                    return true;
                case 5:
                    Console.WriteLine("Eliminar alumno");
                    eliminar();
                    return true;
                case 6:
                    Console.WriteLine("Verificar");
                    verificar();
                    return true;
                case 7:
                    Console.WriteLine("Listar");
                   
                    listar();
                   
                    return true;
                default:
                    return false;

            }
        }

        public void StartMenu() 
        {
            var active = true;
            while (active) 
            {
                var op = menu();
                Console.Clear();
                active = opciones(op);
                Console.ReadKey();
            }
        }

        public void listar() 
        {
            Console.Clear();
            Console.WriteLine("_____________");
            foreach (var item in alumnos) 
            { 
                Console.WriteLine(item);
            }
            Console.WriteLine("_____________");
        }

        public void agregarVarios() 
        {
            Console.Clear();
            for (int i = 0; i <= 3; i++) 
            {
                Console.WriteLine("Ingrese el nombre del nuevo alumno");
                var nuevo = Console.ReadLine();
                alumnos.AddLast(nuevo ?? "N/A");
                Console.ReadKey();
            }
           
        }

        public void agregarPrimero()
        {
            Console.Clear();
          
                Console.WriteLine("Ingrese el nombre del nuevo alumno");
                var nuevo = Console.ReadLine();
                alumnos.AddFirst(nuevo ?? "N/A");
                Console.ReadKey();
            

        }

        public void agregarUltimo()
        {
            Console.Clear();

            Console.WriteLine("Ingrese el nombre del nuevo alumno para agregar al ultimo");
            var nuevo = Console.ReadLine();
            alumnos.AddLast(nuevo ?? "N/A");
            Console.ReadKey();


        }
        public void verificar()
        {
            Console.Clear();

            Console.WriteLine("Verificar");
            Console.WriteLine("Ingrese el nombre");

            var nuevo = Console.ReadLine();
            var buscado = alumnos.Find(nuevo);
            if (buscado != null)
            {
                Console.WriteLine("Existe el elemento");
            }
            else 
            {
                Console.WriteLine("No existe el elemento");
            }
            Console.ReadKey();


        }
        public void eliminar()
        {
            Console.Clear();

            Console.WriteLine("Eliminar alumno");
            Console.WriteLine("Ingrese el nombre para eliminar");

            var nuevo = Console.ReadLine();
            var buscado = alumnos.Find(nuevo);
            if (buscado != null)
            {
                Console.WriteLine("Se elimino");
                alumnos.Remove(buscado);
            }
            else
            {
                Console.WriteLine("No existe el elemento");
            }
            Console.ReadKey();


        }

        public void mover()
        {
            Console.Clear();

            Console.WriteLine("Mover alumno");
            Console.WriteLine("Ingrese el nombre para mover");

            var nuevo = Console.ReadLine();
            var buscado = alumnos.Find(nuevo);

            Console.WriteLine("Donde moverlo?");
            Console.WriteLine("Adelante? 1");
            Console.WriteLine("Atras? 2");
          
            var op = Console.ReadLine();
            int opcion = 0;
            if (int.TryParse(op, out opcion)) 
            {
                var temp = buscado.Value;
                if (opcion == 1) 
                {
                   
                    alumnos.Remove(buscado);
                    alumnos.AddLast(temp);

                }
                if (opcion == 2)
                {
                    alumnos.Remove(buscado);
                    alumnos.AddFirst(temp);
                }
                Console.WriteLine("Efectuado");


            }
          
            Console.ReadKey();


        }
    }
}
