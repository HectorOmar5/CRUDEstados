using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{
    internal class Program
    {
        private static Dictionary<int, Estado> _estados = new Dictionary<int, Estado>();

        static Estado _objEstado = new Estado();
        static void Main(string[] args)
        {
            bool Salir = false;
            while (!Salir)
            {
                try
                {
                    Console.WriteLine("============MENU PRINCIPAL============");
                    Console.WriteLine("\t");
                    Console.WriteLine("\t***************************");
                    Console.WriteLine("\t1.- Consultar Todos");
                    Console.WriteLine("\t***************************");
                    Console.WriteLine("\t2.- Consultar Solo Uno");
                    Console.WriteLine("\t***************************");
                    Console.WriteLine("\t3.- Agregar");
                    Console.WriteLine("\t***************************");
                    Console.WriteLine("\t4.- Actualizar");
                    Console.WriteLine("\t***************************");
                    Console.WriteLine("\t5.- Eliminar");
                    Console.WriteLine("\t***************************");
                    Console.WriteLine("\t6.- Terminar");
                    Console.WriteLine("\t***************************");
                    Console.WriteLine("\nSeleccione Una Opción De La Lista");

                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            _estados = CrudEstados.ConsultarTodos();
                            foreach (KeyValuePair <int, Estado> estado in _estados)
                            {
                                Console.WriteLine("Key = {0}, Value = {1}", estado.Key, estado.Value.nombre);
                            }
                            Console.WriteLine("\n");
                            break;
                        case "2":
                            Console.WriteLine("Ingresa el id del estado a consultar");
                            Estado state = CrudEstados.ConsultarUno(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("Key = {0}, Value = {1}",state.id,state.nombre);
                            Console.WriteLine("\n");
                            break;
                        case "3":
                            _objEstado = new Estado();
                            Console.WriteLine("Ingresa el id del estado");
                            _objEstado.id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingresa el nombre del estado");
                            _objEstado.nombre = Console.ReadLine();
                            CrudEstados.Agregar(_objEstado);
                            Console.WriteLine("\n");
                            break;
                        case "4":
                            Console.WriteLine("Ingresa el id a actualizar");
                            _objEstado.id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingresa el nuevo nombre del estado");
                            _objEstado.nombre = Console.ReadLine();
                            CrudEstados.Actualizar(_objEstado);
                            Console.WriteLine("\n");
                            break;
                        case "5":
                            Console.WriteLine("Ingresa el id del estado a eliminar");
                            _objEstado = CrudEstados.ConsultarUno(Convert.ToInt32(Console.ReadLine()));
                            CrudEstados.Eliminar(_objEstado.id);
                            Console.WriteLine("\n");
                            break;
                        case "6":
                            Console.WriteLine("¿Deseas Salir De La Consola? Presiona <ENTER>");
                            Console.WriteLine("\n");
                            Salir = true;
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadLine();
        }
    }
}
