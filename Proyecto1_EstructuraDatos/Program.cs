using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_EstructuraDatos
{
    internal class Program
    {
        // Se declaran los diccionarios, estos diccionarios se utilizarán para almacenar los datos de los proveedores.
        // El diccionario ciudades almacena el nombre del proveedor y la ciudad en la que reside.
        // El diccionario cantidades almacena el nombre del proveedor y la cantidad de artículos que provee.

        static Dictionary<string, string> ciudades = new Dictionary<string, string>();
        static Dictionary<string, int> cantidades = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            mostrarMenu();

            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
            Environment.Exit(0);
        }

        static void mostrarMenu()
        {
            string opciones = "*******Proyecto1 Estructura Datos*******\n";
            opciones += "Menú de opciones:\n";
            opciones += "1.Ejercicio1\n";
            opciones += "2.Ejercicio2\n";
            opciones += "3.Ejercicio3\n";
            opciones += "4.Salir\n";
            opciones += "*******Digite una Opción*******\n";

            int opcion = 0;

            do
            {
                Console.WriteLine(opciones);

                opcion = int.Parse(Console.ReadLine());

                switch (opcion) 
                {
                    case 1:
                        ejercicio1();
                        break;
                    case 2:
                        ejercicio2();
                        break;
                    case 3:
                        ejercicio3();
                        break;
                    case 4:
                        break;
                }

            } while (opcion != 4);

        }

        static void ejercicio1()
        {
            // Ejercicio 1:  crear una matriz con numeros random en c# de un tamano de 5 x 5 y sumar solo las esquinas
            int[,] matriz = new int[5, 5];

            // Generamos números aleatorios para asignarlos  a la matriz
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = random.Next(1, 100); // Generar un número aleatorio entre 1 y 100
                }
            }

            // Imprimir la matriz
            Console.WriteLine("Matriz:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Sumamos las esquinas
            int sumaEsquinas = matriz[0, 0] + matriz[0, 4] + matriz[4, 0] + matriz[4, 4];

            // Imprimimos la suma de las esquinas
            Console.WriteLine("Suma de las esquinas: " + sumaEsquinas);

            // el usuario presiona una tecla para salir
            Console.WriteLine("Presiona la tecla enter para terminar: ");
            Console.ReadKey();

        }

        static void ejercicio2()
        {
            //Crear una matriz con numeros random en C# de un tamaño de 5x5 y sumar las diagonales 

            //saludo al usuario
            Console.WriteLine("Bienvenido presiona cualquier tecla: ");
            Console.ReadLine();

            // Definir el tamaño de la matriz
            int tamaño = 5;

            // Crear un generador de números aleatorios
            Random aleatorio = new Random();

            // Crear una matriz de 5x5
            int[,] matriz = new int[tamaño, tamaño];

            // Rellenar la matriz con números aleatorios
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {
                    matriz[i, j] = aleatorio.Next(1, 10); // Genera números aleatorios entre 1 y 9
                }
            }

            // Imprimir la matriz
            Console.WriteLine("Matriz:");
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Calcular la suma de las diagonales
            int sumaDiagonalPrincipal = 0;
            int sumaDiagonalSecundaria = 0;


            for (int i = 0; i < tamaño; i++)
            {
                sumaDiagonalPrincipal += matriz[i, i];
                sumaDiagonalSecundaria += matriz[i, tamaño - 1 - i];

            }

            int sumaTotalDiagonales = sumaDiagonalPrincipal + sumaDiagonalSecundaria;


            // Imprimir la suma de las diagonales
            Console.WriteLine("\n");
            Console.WriteLine("Suma de la diagonal principal: " + sumaDiagonalPrincipal);
            Console.WriteLine("Suma de la diagonal secundaria: " + sumaDiagonalSecundaria);
            Console.WriteLine($"Suma de las diagonales es: {sumaTotalDiagonales}\n");

            //fin de programa 
            Console.WriteLine("Presiona la tecla enter para terminar: ");
            Console.ReadLine();

        }

        static void ejercicio3()
        {

            bool finalizado = false;

            // Se inicia un bucle while que se ejecutará hasta que se indique la finalización del programa.
            // Dentro del bucle, se muestra un menú con diferentes opciones para interactuar con el programa. 
            // Se le pide al usuario que ingrese una opción mediante la función Console.ReadLine() y se convierte a un valor entero mediante Convert.ToInt32().

            while (!finalizado)

            //MENÚ DE OPCIONES QUE SE DESEAN REALIZAR.
            {
                Console.WriteLine("---BIENVENIDO AL MENÚ DE OPCIONES DE LOS PROVEEDORES---");
                Console.WriteLine("***NO OLVIDE INCORPORAR A LOS PROVEEDORES EN PRIMER LUGAR***");
                Console.WriteLine("1. Informar datos de un proveedor");
                Console.WriteLine("2. Actualizar nombre de la ciudad de un proveedor");
                Console.WriteLine("3. Actualizar cantidad de artículos de un proveedor");
                Console.WriteLine("4. Incorporar un nuevo proveedor");
                Console.WriteLine("5. Dar de baja a un proveedor");
                Console.WriteLine("6. Salir");
                Console.WriteLine("----------------");
                Console.WriteLine("Ingrese una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                // Se utiliza una estructura switch para realizar diferentes acciones según la opción elegida por el usuario.

                switch (opcion)
                {
                    case 1:
                        InformarProveedor();
                        break;
                    case 2:
                        ActualizarCiudad();
                        break;
                    case 3:
                        ActualizarCantidadArticulos();
                        break;
                    case 4:
                        IncorporarProveedor();
                        break;
                    case 5:
                        DarDeBajaProveedor();
                        break;
                    case 6:
                        Console.WriteLine("***Gracias por utilizar el programa***");
                        finalizado = true;

                        //Permite realizar una pausa para esperar la tecla
                        Console.WriteLine("Presiona la tecla enter para terminar: ");
                        Console.ReadKey();

                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();
            }
        }

        //Cada una de las funciones llamadas en el paso anterior realiza una operación específica relacionada con los proveedores de acuerdo a los requisitos del programa.
        static void InformarProveedor()
        {
            Console.WriteLine("Ingrese el nombre del proveedor: ");
            string nombre = Console.ReadLine();

            if (ciudades.ContainsKey(nombre) && cantidades.ContainsKey(nombre))
            {
                Console.WriteLine("Proveedor: " + nombre);
                Console.WriteLine("Ciudad: " + ciudades[nombre]);
                Console.WriteLine("Cantidad de artículos: " + cantidades[nombre]);
            }
            else
            {
                Console.WriteLine("Proveedor no encontrado.");
            }
        }

        static void ActualizarCiudad()
        {
            Console.WriteLine("Ingrese el nombre del proveedor: ");
            string nombre = Console.ReadLine();

            if (ciudades.ContainsKey(nombre))
            {
                Console.WriteLine("Ingrese el nuevo nombre de la ciudad: ");
                string nuevaCiudad = Console.ReadLine();

                ciudades[nombre] = nuevaCiudad;
                Console.WriteLine("Ciudad actualizada correctamente.");
            }
            else
            {
                Console.WriteLine("Proveedor no encontrado.");
            }
        }

        static void ActualizarCantidadArticulos()
        {
            Console.WriteLine("Ingrese el nombre del proveedor: ");
            string nombre = Console.ReadLine();

            if (cantidades.ContainsKey(nombre))
            {
                Console.WriteLine("Ingrese la cantidad de artículos a actualizar (positiva para aumentar, negativa para disminuir): ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                cantidades[nombre] += cantidad;
                Console.WriteLine("Cantidad de artículos actualizada correctamente.");
            }
            else
            {
                Console.WriteLine("Proveedor no encontrado.");
            }
        }

        static void IncorporarProveedor()
        {
            Console.WriteLine("Ingrese el nombre del nuevo proveedor: ");
            string nombre = Console.ReadLine();

            if (ciudades.ContainsKey(nombre) || cantidades.ContainsKey(nombre))
            {
                Console.WriteLine("El proveedor ya existe en el sistema.");
                return;
            }

            Console.WriteLine("Ingrese el nombre de la ciudad del proveedor: ");
            string ciudad = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad de artículos que provee el proveedor: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            ciudades.Add(nombre, ciudad);
            cantidades.Add(nombre, cantidad);

            Console.WriteLine("Proveedor incorporado correctamente.");
        }
        static void DarDeBajaProveedor()
        {
            Console.WriteLine("Ingrese el nombre del proveedor a dar de baja: ");
            string nombre = Console.ReadLine();

            if (ciudades.ContainsKey(nombre) && cantidades.ContainsKey(nombre))
            {
                ciudades.Remove(nombre);
                cantidades.Remove(nombre);

                Console.WriteLine("Proveedor dado de baja correctamente.");
            }
            else
            {
                Console.WriteLine("Proveedor no encontrado.");
            }
        }

        private class Dictionary
        {
        }
    }
    //Después de ejecutar la acción correspondiente a la opción elegida por el usuario, el programa vuelve al inicio del bucle while y muestra nuevamente el menú.
    //Se espera que el usuario seleccione otra opción.
    //El bucle while se ejecuta hasta que el usuario elija la opción 6 para finalizar el programa. En ese momento, se muestra un mensaje de despedida y el programa termina.
}

