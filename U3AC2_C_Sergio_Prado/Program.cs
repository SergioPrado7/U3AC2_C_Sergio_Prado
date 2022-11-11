using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace U3AC2_C_Sergio_Prado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarando los datos necesarios
            string nombreUsuario, nombreDeUsuario, contraseñaLogear, contraseña, contraseñaConfirmar, nombre, apellidoPaterno, apellidoMaterno, email, localidad;
            byte edad;
            //Utilizando los datos en distintas variables
            Console.WriteLine("PROGRAMA PARA INICIAR SESIÓN \t (Al terminar de escribir o digitar presionar la tecla ENTER) \n");
            Console.WriteLine("Por favor ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su primer apellido:");
            apellidoPaterno = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su segundo apellido:");
            apellidoMaterno = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su edad: \t (Solo digitos)");
            edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Por favor ingrese email:");
            email = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su localidad:");
            localidad = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("MUY BIEN, AHORA ES MOMENTO DE REGISTRARSE \n");
            Console.WriteLine("Ingrese un nombre de usuario:");
            nombreUsuario = Console.ReadLine();
            Console.WriteLine("Ingrese una contraseña:");
            contraseña = Console.ReadLine();
            Console.WriteLine("Ingrese nuevamente la contraseña:");
            contraseñaConfirmar = Console.ReadLine();
            Console.WriteLine("\n");
            //Usando If
            if (contraseña == contraseñaConfirmar)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("MUY BIEN ES MOMENTO DE INICIAR SESIÓN \n");
                Console.WriteLine("Ingrese su nombre de usuario:");
                nombreDeUsuario = Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña:");
                contraseñaLogear = Console.ReadLine();
                if (contraseñaConfirmar == contraseñaLogear)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\t Los datos del usuario son: \n");
                    Console.WriteLine("\t Nombre: {0} {1} {2} ", nombre, apellidoPaterno, apellidoMaterno);
                    Console.WriteLine("\t Edad: {0} años", edad);
                    Console.WriteLine("\t Email: {0} ", email);
                    Console.WriteLine("\t Localidad: {0}", localidad);
                    Console.WriteLine("\t Usuario: {0}", nombreUsuario);
                    Console.WriteLine("\t Contraseña: {0}", contraseña);
                    Console.WriteLine("\n");
                    Console.WriteLine("AHORA ES MOMENTO DE PERSONALIZAR \n");
                    string colorFondo, colorLetra, tamanoAltura, tamanoAnchura, nombrePrograma;
                    Console.WriteLine("Empezemos primeramente por el color de fondo \t (Debera escribir el número de su preferencia)");
                    Console.WriteLine("1=Azul 2=Verde 3=Magenta");
                    colorFondo = Console.ReadLine();
                    if (colorFondo == "1")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.WriteLine("\t Los datos del usuario son: \n");
                        Console.WriteLine("\t Nombre: {0} {1} {2} ", nombre, apellidoPaterno, apellidoMaterno);
                        Console.WriteLine("\t Edad: {0} años", edad);
                        Console.WriteLine("\t Email: {0} ", email);
                        Console.WriteLine("\t Localidad: {0}", localidad);
                        Console.WriteLine("\t Usuario: {0}", nombreUsuario);
                        Console.WriteLine("\t Contraseña: {0}", contraseña);
                        Console.WriteLine("\n");

                    }
                    if (colorFondo == "2")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.WriteLine("\t Los datos del usuario son: \n");
                        Console.WriteLine("\t Nombre: {0} {1} {2} ", nombre, apellidoPaterno, apellidoMaterno);
                        Console.WriteLine("\t Edad: {0} años", edad);
                        Console.WriteLine("\t Email: {0} ", email);
                        Console.WriteLine("\t Localidad: {0}", localidad);
                        Console.WriteLine("\t Usuario: {0}", nombreUsuario);
                        Console.WriteLine("\t Contraseña: {0}", contraseña);
                        Console.WriteLine("\n");
                    }
                    if (colorFondo == "3")
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.Clear();
                        Console.WriteLine("\t Los datos del usuario son: \n");
                        Console.WriteLine("\t Nombre: {0} {1} {2} ", nombre, apellidoPaterno, apellidoMaterno);
                        Console.WriteLine("\t Edad: {0} años", edad);
                        Console.WriteLine("\t Email: {0} ", email);
                        Console.WriteLine("\t Localidad: {0}", localidad);
                        Console.WriteLine("\t Usuario: {0}", nombreUsuario);
                        Console.WriteLine("\t Contraseña: {0}", contraseña);
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("Perfecto una vez escogido el color de fondo sigamos con el color de la letra");
                    Console.WriteLine("1=Azul 2=Verde 3=Magenta");
                    colorLetra = Console.ReadLine();
                    if (colorLetra == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.WriteLine("\t Los datos del usuario son: \n");
                        Console.WriteLine("\t Nombre: {0} {1} {2} ", nombre, apellidoPaterno, apellidoMaterno);
                        Console.WriteLine("\t Edad: {0} años", edad);
                        Console.WriteLine("\t Email: {0} ", email);
                        Console.WriteLine("\t Localidad: {0}", localidad);
                        Console.WriteLine("\t Usuario: {0}", nombreUsuario);
                        Console.WriteLine("\t Contraseña: {0}", contraseña);
                        Console.WriteLine("\n");
                    }
                    if (colorLetra == "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.WriteLine("\t Los datos del usuario son: \n");
                        Console.WriteLine("\t Nombre: {0} {1} {2} ", nombre, apellidoPaterno, apellidoMaterno);
                        Console.WriteLine("\t Edad: {0} años", edad);
                        Console.WriteLine("\t Email: {0} ", email);
                        Console.WriteLine("\t Localidad: {0}", localidad);
                        Console.WriteLine("\t Usuario: {0}", nombreUsuario);
                        Console.WriteLine("\t Contraseña: {0}", contraseña);
                        Console.WriteLine("\n");
                    }
                    if (colorLetra == "3")
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Clear();
                        Console.WriteLine("\t Los datos del usuario son: \n");
                        Console.WriteLine("\t Nombre: {0} {1} {2} ", nombre, apellidoPaterno, apellidoMaterno);
                        Console.WriteLine("\t Edad: {0} años", edad);
                        Console.WriteLine("\t Email: {0} ", email);
                        Console.WriteLine("\t Localidad: {0}", localidad);
                        Console.WriteLine("\t Usuario: {0}", nombreUsuario);
                        Console.WriteLine("\t Contraseña: {0}", contraseña);
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("Perfecto, ahora vamos con el tamaño de altura \t (Recuerda seleccionar el número de tu preferencia)");
                    Console.WriteLine("1=10px 2=15px 3=25px");
                    tamanoAltura = Console.ReadLine();
                    if (tamanoAltura == "1")
                    {
                        Console.WindowHeight = 10;
                        Console.Clear();
                        Console.WriteLine("\t Los datos del usuario son: \n");
                        Console.WriteLine("\t Nombre: {0} {1} {2} ", nombre, apellidoPaterno, apellidoMaterno);
                        Console.WriteLine("\t Edad: {0} años", edad);
                        Console.WriteLine("\t Email: {0} ", email);
                        Console.WriteLine("\t Localidad: {0}", localidad);
                        Console.WriteLine("\t Usuario: {0}", nombreUsuario);
                        Console.WriteLine("\t Contraseña: {0}", contraseña);
                        Console.WriteLine("\n");
                    }
                    if (tamanoAltura == "2")
                    {
                        Console.WindowHeight = 15;
                        Console.Clear();
                        Console.WriteLine("\t Los datos del usuario son: \n");
                        Console.WriteLine("\t Nombre: {0} {1} {2} ", nombre, apellidoPaterno, apellidoMaterno);
                        Console.WriteLine("\t Edad: {0} años", edad);
                        Console.WriteLine("\t Email: {0} ", email);
                        Console.WriteLine("\t Localidad: {0}", localidad);
                        Console.WriteLine("\t Usuario: {0}", nombreUsuario);
                        Console.WriteLine("\t Contraseña: {0}", contraseña);
                        Console.WriteLine("\n");
                    }
                    if (tamanoAltura == "3")
                    {
                        Console.WindowHeight = 25;
                        Console.Clear();
                        Console.WriteLine("\t Los datos del usuario son: \n");
                        Console.WriteLine("\t Nombre: {0} {1} {2} ", nombre, apellidoPaterno, apellidoMaterno);
                        Console.WriteLine("\t Edad: {0} años", edad);
                        Console.WriteLine("\t Email: {0} ", email);
                        Console.WriteLine("\t Localidad: {0}", localidad);
                        Console.WriteLine("\t Usuario: {0}", nombreUsuario);
                        Console.WriteLine("\t Contraseña: {0}", contraseña);
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("Perfecto, ahora vamos con el tamaño de anchura \t (Recuerda seleccionar el número de tu preferencia)");
                    Console.WriteLine("1=25px 2=50px 3=90px");
                    tamanoAnchura = Console.ReadLine();
                    if (tamanoAnchura == "1")
                    {
                        Console.WindowWidth = 25;
                        Console.Clear();
                        Console.WriteLine("\t Los datos del usuario son: \n");
                        Console.WriteLine("\t Nombre: {0} {1} {2} ", nombre, apellidoPaterno, apellidoMaterno);
                        Console.WriteLine("\t Edad: {0} años", edad);
                        Console.WriteLine("\t Email: {0} ", email);
                        Console.WriteLine("\t Localidad: {0}", localidad);
                        Console.WriteLine("\t Usuario: {0}", nombreUsuario);
                        Console.WriteLine("\t Contraseña: {0}", contraseña);
                        Console.WriteLine("\n");
                    }
                    if (tamanoAnchura == "2")
                    {
                        Console.WindowWidth = 50;
                        Console.Clear();
                        Console.WriteLine("\t Los datos del usuario son: \n");
                        Console.WriteLine("\t Nombre: {0} {1} {2} ", nombre, apellidoPaterno, apellidoMaterno);
                        Console.WriteLine("\t Edad: {0} años", edad);
                        Console.WriteLine("\t Email: {0} ", email);
                        Console.WriteLine("\t Localidad: {0}", localidad);
                        Console.WriteLine("\t Usuario: {0}", nombreUsuario);
                        Console.WriteLine("\t Contraseña: {0}", contraseña);
                        Console.WriteLine("\n");
                    }
                    if (tamanoAnchura == "3")
                    {
                        Console.WindowWidth = 90;
                        Console.Clear();
                        Console.WriteLine("\t Los datos del usuario son: \n");
                        Console.WriteLine("\t Nombre: {0} {1} {2} ", nombre, apellidoPaterno, apellidoMaterno);
                        Console.WriteLine("\t Edad: {0} años", edad);
                        Console.WriteLine("\t Email: {0} ", email);
                        Console.WriteLine("\t Localidad: {0}", localidad);
                        Console.WriteLine("\t Usuario: {0}", nombreUsuario);
                        Console.WriteLine("\t Contraseña: {0}", contraseña);
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("Escriba un nombre para este programa:");
                    nombrePrograma = Console.ReadLine();
                    Console.Title = nombrePrograma;
                    Console.WriteLine("\n");
                }
                else
                {
                    return;
                }
            }
            else
            {
                Console.WriteLine("Su contraseña es incorrecta");
                return;
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Perfecto eso ha sido todo, muchas gracias por su colaboración, nos vemos luego");
            Console.WriteLine("\n");
            Console.WriteLine("Saliendo de consola.");
            Thread.Sleep(5000);
            Console.WriteLine("Saliendo de consola..");
            Thread.Sleep(5000);
            Console.WriteLine("Saliendo de consola...");
            Thread.Sleep(5000);
        }
    }
}
