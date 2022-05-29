using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguro
{
    public class Menu
    {
        public List<Persona> personas { get; set; }
        public int generador { get; set; }

        public double afp { get; set; }
        public double sfs { get; set; }

        public Menu() {
            personas = new List<Persona>();
            generador = 1;
            afp = 2.87;
            sfs = 3.04;
        }
        public int seleccion() 
        {
            int opcion = 0;
            Console.Clear();
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("______________________");
            Console.WriteLine("Agregar empleado: 1");
            Console.WriteLine("Contar empleados: 2");
            Console.WriteLine("Buscar empleados: 3");
            Console.WriteLine("Eliminar empleados: 4");
            Console.WriteLine("Listar empleados: 5");
            Console.WriteLine("Salir: 0");
            Console.WriteLine("_____________________");
            Console.WriteLine("Introdusca la opcion:");
            string seleccion = Console.ReadLine();

            if (!int.TryParse(seleccion,out opcion)) 
            {
                return 0;
            }
            Console.Clear();
            return opcion;


        }

        public bool opciones(int op) 
        {
            switch (op) 
            {
                case 1:
                    Console.WriteLine("Agregar");
                   var per = agregar();
                    personas.Add(per);
                    return true;
                    
                case 2:
                    Console.WriteLine("contar");
                    Console.WriteLine("Hay "+ personas.Count+" Personas");
                    Console.ReadKey();
                    return true;
                    
                case 3:
                    Console.WriteLine("Buscar");
                    buscar();
                    return true;
                    
                case 4:
                    Console.WriteLine("Eliminar");
                    eliminar();
                    return true;
                    
                case 5:
                    Console.WriteLine("Listar");
                    listar();
                    return true;
                    
                case 6:
                    Console.WriteLine("Saliendo");
                    return false;
                    
                default:
                    return false;
            }
        }

        public void MenuAction() 
        {
            
            while (true) 
            {
                var op = seleccion();
                if (!opciones(op)) {
                    break;
                }
                
            }
        }

        public Persona agregar() 
        {
            var per = new Persona();
            double salarioInt = 0;
            per.id = generador;
            Console.WriteLine("Introdusca el nombre");
            per.nombre = Console.ReadLine();
            Console.WriteLine("Introdusca el cargo");
            per.cargo= Console.ReadLine();
            Console.WriteLine("Introdusca el salario");
            var salarioStr = Console.ReadLine();
            if (!double.TryParse(salarioStr, out salarioInt))
            {
                per.sueldo = 0;
            }
            else 
            { 
                per.sueldo = salarioInt; 
            }

            per.afp = (per.sueldo / 100) * afp;
            per.sfs = (per.sueldo / 100) * sfs;
            per.total = per.sueldo - per.afp - per.sfs;
            generador++;

            Console.WriteLine("Se agrego la persona");
            Console.ReadKey();
            return per;
            
        }

        public void listar() 
        {
            foreach (var pel in personas)
            {
                Console.WriteLine("___________");
                Console.WriteLine("Id: " + pel.id);

                Console.WriteLine("Nombre: " + pel.nombre);
                Console.WriteLine("Cargo:" + pel.cargo);

                Console.WriteLine("Sueldo: " + pel.sueldo);

                Console.WriteLine("AFP: " +pel.afp);

                Console.WriteLine("SFS: " +pel.sfs);

                Console.WriteLine("Total: " + pel.total);

                Console.WriteLine("___________");

            }
           
            Console.ReadKey();
        }

        public void buscar() 
        {
            var id = 0;
            Console.WriteLine("Introdusca el id de la persona a buscar");
            var search = Console.ReadLine();
            if (!int.TryParse(search,out id)) 
            {
                id = 1;
            }

            var persona = personas.Where(x => x.id == id).FirstOrDefault();
            if (persona != null)
            {
                Console.WriteLine("__________");
                Console.WriteLine("Id: " + persona.id.ToString());
                Console.WriteLine("Nombre: " + persona.nombre);
                Console.WriteLine("Cargo: " + persona.cargo);
                Console.WriteLine("Sueldo: " + persona.sueldo.ToString());
                Console.WriteLine("AFP: " + persona.afp.ToString());
                Console.WriteLine("SFS: " + persona.sfs.ToString());
                Console.WriteLine("Total: " + persona.total.ToString());

                Console.WriteLine("__________");

            }
            else {
                Console.WriteLine("No se encontro una persona con ese ID");
            }
            Console.ReadKey();
        }

        public void eliminar() 
        {
            var id = 0;
            Console.WriteLine("Introdusca el id de la persona a eliminar");
            var search = Console.ReadLine();
            if (!int.TryParse(search, out id))
            {
                id = 1;
            }
            var persona = personas.Where(x => x.id == id).FirstOrDefault();
            if (persona != null)
            {
                Console.WriteLine("Se elimino la persona");
                personas.Remove(persona);
            }
            else {
                Console.WriteLine("No se pudo eliminar la persona");
                }
            Console.ReadKey();
        }
    }
}
