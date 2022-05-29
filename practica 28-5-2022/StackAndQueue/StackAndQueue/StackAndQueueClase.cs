using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class StackAndQueueClase
    {
        public Queue<string> fila { get; set; }
        public Stack<string> pila { get; set; }
        public string op1 { get; set; }
        public string op2 { get; set; }

        public StackAndQueueClase()
        {
            fila = new Queue<string>();
            pila = new Stack<string>();
            op1 = "cola";
            op2 = "pila";
        }
        public int menuFila(int typeOption)
        {
            string tipo = "";
            if (typeOption == 1) { tipo = op1; }
            else { tipo = op2; }
            Console.Clear();
            int opcion = 0;
            Console.WriteLine("Elije la opcion deseada");
            Console.WriteLine("_____________________");
            Console.WriteLine("Agregar elementoa la " +tipo+ " : 1");
            Console.WriteLine("Eliminar elementoa la " + tipo + ": 2");
            Console.WriteLine("Listar elementos a la " + tipo + ": 3");
            Console.WriteLine("Salir: 4");
            Console.WriteLine("_____________________");
            var op = Console.ReadLine();
            if (!int.TryParse(op, out opcion)) { return 0; }
            return opcion;
        }
      
        public bool opciones(int op,int typeOption)
        {
            string tipo = "";
            if (typeOption == 1) { tipo = op1; }
            else { tipo = op2; }

            switch (op)
            {
                case 1:
                    Console.WriteLine("agregar elemento de la " + tipo + "");
                    agregar(typeOption);
                    return true;

                case 2:
                    Console.WriteLine("Eliminar de la " + tipo + "");
                    eliminar(typeOption);
                    return true;

                case 3:
                    Console.WriteLine("Listar  " + tipo + "");

                    listar(typeOption);

                    return true;
                default:
                    return false;

            }
        }

        

        public void StartMenu()
        {
            Console.WriteLine("Que coleccion desea utilizar?");
            Console.WriteLine("Fila: 1");
            Console.WriteLine("Pila: 2");
           
            var active = true;
            var type = Console.ReadLine();
            int opcion = 0;
            if (!int.TryParse(type, out opcion)) { active = false; }

          
                while (active)
                {
                    var op = menuFila(opcion);
                    Console.Clear();
                    active = opciones(op,opcion);
                    Console.ReadKey();
                }
            
           


           
        }


        public void agregar(int op) 
        {
            string tipo = "";
            if (op == 1) { tipo = op1; }
            else { tipo = op2; }

            Console.Clear();
            Console.WriteLine("Ingrese el nombre del elemento para la "+tipo+"");
            var nuevo = Console.ReadLine();
            if (op == 1)
            {
                fila.Enqueue(nuevo ?? "N/A");
            } else if (op ==2) 
            {
                pila.Push(nuevo?? "N/A");
            }
           
            Console.WriteLine("Se agrego el elemento a la "+tipo+"");
            Console.ReadKey();

        }

        public void eliminar(int op) 
        {

            Console.Clear();
            if (op == 1) {
                Console.WriteLine("El elemento a eliminar sera: " +fila.Peek());
            }else if(op == 2)
            {
                Console.WriteLine("El elemento a eliminar sera: " + pila.Peek());
            }
            Console.WriteLine("Desea eliminarlo? y/n");
            var opcion = Console.ReadLine();
            if (opcion == "y") {
                if (op == 1) fila.Dequeue();
                if (op == 2) pila.Pop();
                Console.WriteLine("Se elimino");
                Console.WriteLine("______________");
                listar(op);
                Console.WriteLine("______________");
            }
            else { Console.WriteLine("No se elimino"); }
        }

        public void listar(int op) {
            if (op == 1) {
                foreach (var item in fila) {
                    Console.WriteLine(item);
                }
            }
            if (op == 2)
            {
                foreach (var item in pila)
                {
                    Console.WriteLine(item);
                }
            }
        }
       

    }
}
