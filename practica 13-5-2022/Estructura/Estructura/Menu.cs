using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura
{
    public class Menu
    {
        public List<Libro> Libros { get; set; }

        public Menu() {
            Libros = new List<Libro>();
        }
        public int options() 
        {
            Console.Clear();
            int op = 0;

            Console.WriteLine("Seleccione la opcion");
            Console.WriteLine("Agregar libro: 1");
            Console.WriteLine("Ver lista: 2");
            Console.WriteLine("Cerrar: 3");
            var opcion = Console.ReadLine();

            if (!int.TryParse(opcion,out op)) 
            {
                op = 0;
            }

            return op;
        }

        public void startMenu() {

            var active = true;

            while (active) { 
              var op= options();
                active = selection(op);
            }
        }
        public bool selection(int op)
        {
            switch(op)
            {
                case 1:
                    add();

                    return true;
                case 2:
                    view();
                    return true;

                default:
                    return false;
            }
        }

        public void add()
        {
            var lib = new Libro();
            Console.WriteLine("Ingrese los datos del libro");
            Console.WriteLine("Titulo:");
            lib.titulo = Console.ReadLine() ?? "N/A";

            Console.WriteLine("Autor:");
            lib.autor = Console.ReadLine() ?? "N/A";

            Console.WriteLine("Edutorial:");
            lib.editorial = Console.ReadLine() ?? "N/A";

            Console.WriteLine("Categoria:");
            lib.categoria = Console.ReadLine() ?? "N/A";

            Console.WriteLine("Anio:");
            lib.anio = Console.ReadLine() ?? "N/A";

            Libros.Add(lib);

        }

        public void view() {

            foreach (var lib in Libros) 
            {
                Console.WriteLine("___________");
                Console.WriteLine("Titulo: "+lib.titulo);
                Console.WriteLine("Autor: "+lib.autor);
                Console.WriteLine("Editorial: "+lib.editorial);
                Console.WriteLine("Categoria: "+lib.categoria);
                Console.WriteLine("Anio: "+lib.anio);
                Console.WriteLine("___________");
            }
            Console.ReadKey();
        }
    }
}
