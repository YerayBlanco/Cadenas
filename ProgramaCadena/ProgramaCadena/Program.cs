using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaCadena
{
    class Program
    {
        static void Main(string[] args)
        {
            
            inicio();
            menu();

            string cadena;



            //2.1- Solicitar al usuario que introduzca una cadena de al menos 40 caracteres. Si la longitud de la cadena es menor de 40 caracteres, se mostrará un aviso al usuario, informándole de la longitud actual, y solicitándole que vuelva a introducir una nueva cadena. Por ejemplo: "La cadena introducida posee únicamente XX caracteres. Por favor, introduzca una nueva cadena con más de 40 caracteres: ".
            void inicio()
            {
               

                Console.WriteLine("Introduzca una cadena de texto con 40 caracteres o más");

                cadena = Console.ReadLine();

                while (cadena.Length < 40)
                {
                    Console.WriteLine($"Ha introducido una cadena de {cadena.Length} caracteres. Por favor, Introduzca una cadena con 40 caracteres o más.");
                    cadena = Console.ReadLine();

                }

            }

            void menu()
            {

                string selector;
                Console.WriteLine("Seleccione la acción que desea realizar:");
                Console.WriteLine("1.Sustituir una palabra por otra.");
                Console.WriteLine("2.Buscar texto en la cadena.");
                Console.WriteLine("3.Buscar texto al inicio de la cadena.");
                Console.WriteLine("4.Conversor de digito en cadena de 12 caracteres.");
                selector = Console.ReadLine();

                switch (selector)
                {
                    case "1":

                        sustituir();

                        menu();

                        break;

                    case "2":

                        buscar();
                        menu();

                        break;

                    case "3":

                        buscarini();
                        menu();

                        break;

                    case "4":

                        conversor();
                        menu();

                        break;

                    default:

                        Console.WriteLine("Por favor, seleccione una de las opciones indicadas");
                        menu();

                        break;
                }

                //- Sustituir una palabra por otra. Para ello, se solicitará introducir, separadas por un espacio, la palabra a sustituir, y la sustituta, mostrándose por pantalla el resultado final
                void sustituir()
                {
                    
                    string palabra1;
                    string palabra2;

                    Console.WriteLine("Por favor, introduzca, separadas por un espacio, la palabra a sustituir y la sustituta.");
                    palabra1 = Console.ReadLine();
                    palabra2 = Console.ReadLine();

                    var replacement = cadena.Replace($"{palabra1}", $"{palabra2}");

                    Console.WriteLine($"{replacement}");

                    menu();

                }
                //- Buscar texto en la cadena. Para ello, se solicitará introducir un texto para comprobar si existe o no.
                void buscar()
                {
                    string palabra3;

                    Console.WriteLine("Por favor, introduzca un texto para comprobar si existe o no en la cadena");
                    palabra3 = Console.ReadLine();
                    bool busqueda = cadena.Contains($"{palabra3}");
                    Console.WriteLine($"{busqueda}");

                    menu();
                }
                //- Buscar texto de inicio en la cadena. Para ello, se solicitará introducir un texto para comprobar si la cadena comienza por el mismo.
                void buscarini()
                {
                    string empieza;

                    Console.WriteLine("Introduzca el texto para comprobar si la cadena comienza con el mismo");
                    empieza = Console.ReadLine();

                    if (cadena.StartsWith(empieza))
                    {
                        Console.WriteLine("La cadena comienza con el texto indicado");
                    }
                    else
                    {
                        Console.WriteLine("La cadena no comienza con el texto indicado");
                    }

                    menu();
                }
                //- Introduce un dígito y conviértelo a cadena de 12 caracteres rellenados por cero por delante.
                void conversor()
                {
                    string digito;

                    
                    Console.WriteLine("Introduzca un entre 1 y 12 dígitos");
                    digito = Console.ReadLine();

                    int longitud = digito.Length;
                    int addceros = 12 - longitud;
                    

                    if (longitud >= 12)
                    {
                        Console.WriteLine($"La cadena resultante es {digito}");
                    }
                    else 
                      
                    {
                      string  final = new string('0', addceros) + digito;

                        Console.WriteLine($"La cadena resultante es {final}");

                    }
                }


            }

        }
    }
}
