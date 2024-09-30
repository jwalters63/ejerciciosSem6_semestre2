using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Limpia la pantalla para empezar
            Console.Clear();

            // Muestra el menú principal
            Console.WriteLine("===== Ejercicios de estructuras y arreglos =====");
            Console.WriteLine("Seleccione el ejercicio que desea ejecutar.");
            Console.WriteLine("1. Estudiante\n2. Productos\n3. Empleados\n4. Rectángulo\n5. Cuenta bancaria\n6. Carros\n7. Salir");
            Console.Write("-> ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            // Valida la opción ingresada
            while (opcion < 1 || opcion > 7)
            {
                Console.Clear();
                Console.WriteLine("Opción no válida.");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("===== Intente de nuevo =====");
                Console.WriteLine("1. Estudiante\n2. Productos\n3. Empleados\n4. Rectángulo\n5. Cuenta bancaria\n6. Carros\n7. Salir");
                Console.Write("-> ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }

            // Limpia la pantalla para mostrar el resultado
            Console.Clear();

            // Ejecuta el ejercicio seleccionado
            switch (opcion)
            {
                case 1:
                    structEstudiante();
                    Console.WriteLine("Presione cualquier tecla para salir...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    structProductos();
                    Console.WriteLine("Presione cualquier tecla para salir...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    structEmpleados();
                    Console.WriteLine("Presione cualquier tecla para salir...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    structRectangulos();
                    Console.WriteLine("Presione cualquier tecla para salir...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    structCuentaBancaria();
                    Console.WriteLine("Presione cualquier tecla para salir...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    structCarros();
                    Console.WriteLine("Presione cualquier tecla para salir...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 7:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        // Estructura para representar un estudiante
        struct Estudiante
        {
            public string Nombre;
            public int Edad;
            public int Promedio;
        }

        // Estructura para representar un producto
        struct Producto
        {
            public int ID;
            public string Nombre;
            public double Precio;
            public int CantidadEnStock;
        }

        // Estructura para representar un empleado
        struct Empleado
        {
            public string Nombre;
            public Direccion Direccion;
        }

        // Estructura para representar una dirección
        struct Direccion
        {
            public string Calle;
            public string Ciudad;
            public int CodigoPostal;
        }

        // Estructura para representar un rectángulo
        struct Rectangulo
        {
            public double Ancho;
            public double Altura;
            public double Area()
            {
                return Ancho * Altura;
            }
        }

        // Estructura para representar una cuenta bancaria
        struct CuentaBancaria
        {
            public int NumeroDeCuenta;
            public string NombreTitular;
            public double Saldo;

            public CuentaBancaria(int numeroDeCuenta, string nombreTitular, double saldo)
            {
                NumeroDeCuenta = numeroDeCuenta;
                NombreTitular = nombreTitular;
                Saldo = saldo;
            }
        }

        // Estructura para representar un carro
        struct Carro
        {
            public string Marca;
            public string Modelo;
            public int Año;
        }

        // Ejercicio para trabajar con estructuras de estudiantes
        static void structEstudiante()
        {
            // Limpia la pantalla para empezar
            Console.Clear();

            Console.WriteLine("===== Escriba los datos del estudiante =====");
            Estudiante estudiante = new Estudiante();
            Console.Write("¿Cuál es el nombre del estudiante?\n-> ");
            estudiante.Nombre = Console.ReadLine();
            Console.Write("¿Que edad tiene?\n-> ");
            estudiante.Edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("¿Cuál es su prom edio de notas?\n-> ");
            estudiante.Promedio = Convert.ToInt32(Console.ReadLine());

            // Limpia la pantalla para mostrar el resultado
            Console.Clear();

            Console.WriteLine("===== Datos del estudiante =====");
            Console.WriteLine("Nombre: {0}\nEdad: {1}\nPromedio: {2}", estudiante.Nombre, estudiante.Edad, estudiante.Promedio);
            Console.WriteLine("================================");
        }

        // Ejercicio para trabajar con estructuras de productos
        static void structProductos()
        {
            Producto[] productos = new Producto[5];

            productos[0] = new Producto { ID = 1, Nombre = "Galleta", Precio = 10.5, CantidadEnStock = 10 };
            productos[1] = new Producto { ID = 2, Nombre = "Coca-Cola", Precio = 20.0, CantidadEnStock = 3 };
            productos[2] = new Producto { ID = 3, Nombre = "Jabon", Precio = 15.75, CantidadEnStock = 7 };
            productos[3] = new Producto { ID = 4, Nombre = "Pasta de dientes", Precio = 30.0, CantidadEnStock = 2 };
            productos[4] = new Producto { ID = 5, Nombre = "Bolsa de pan", Precio = 25.0, CantidadEnStock = 5 };

            double precioTotal = 0;

            Console.WriteLine("===== Detalles de los productos =====");
            foreach (var producto in productos)
            {
                Console.WriteLine($"ID: {producto.ID}, Nombre: {producto.Nombre}, Precio: {producto.Precio}, Cantidad en Stock: {producto.CantidadEnStock}");
                precioTotal += producto.Precio;
            }
            Console.WriteLine("=====================================");
            Console.WriteLine("Precio total de todos los productos: {0}", precioTotal);

            Console.WriteLine("===== Productos con existencia baja =====");
            foreach (var producto in productos)
            {
                if (producto.CantidadEnStock <= 5)
                {
                    Console.WriteLine($"ID: {producto.ID}, Nombre: {producto.Nombre}, Cantidad en Stock: {producto.CantidadEnStock}");
                }
            }
            Console.WriteLine("=========================================");
        }

        // Ejercicio para trabajar con estructuras de empleados
        static void structEmpleados()
        {
            Empleado empleado = new Empleado
            {
                Nombre = "Juan Perez",
                Direccion = new Direccion
                {
                    Calle = "Calle Falsa 123",
                    Ciudad = "Ciudad Ejemplo",
                    CodigoPostal = 12345
                }
            };

            Console.WriteLine("===== Datos del empleado =====");
            Console.WriteLine($"Nombre: {empleado.Nombre}");
            Console.WriteLine($"Calle: {empleado.Direccion.Calle}");
            Console.WriteLine($"Ciudad: {empleado.Direccion.Ciudad}");
            Console.WriteLine($"Código Postal: {empleado.Direccion.CodigoPostal}");
            Console.WriteLine("================================");

            Empleado[] empleados = new Empleado[3];
            empleados[0] = new Empleado { Nombre = "Juan Perez", Direccion = new Direccion { Calle = "Calle Falsa 123", Ciudad = "Ciudad Ejemplo", CodigoPostal = 12345 } };
            empleados[1] = new Empleado { Nombre = "Maria Lopez", Direccion = new Direccion { Calle = "Calle Real 456", Ciudad = "Ciudad Ejemplo", CodigoPostal = 67890 } };
            empleados[2] = new Empleado { Nombre = "Carlos Sanchez", Direccion = new Direccion { Calle = "Avenida Siempre Viva 742", Ciudad = "Otra Ciudad", CodigoPostal = 11223 } };

            Console.WriteLine("===== Empleados en Ciudad Ejemplo =====");
            foreach (var emp in empleados)
            {
                if (emp.Direccion.Ciudad == "Ciudad Ejemplo")
                {
                    Console.WriteLine($"Nombre: {emp.Nombre}, Calle: {emp.Direccion.Calle}, Ciudad: {emp.Direccion.Ciudad}, Código Postal: {emp.Direccion.CodigoPostal}");
                }
            }
            Console.WriteLine("=======================================");
        }

        // Ejercicio para trabajar con estructuras de rectángulos
        static void structRectangulos()
        {
            Rectangulo[] rectangulos = new Rectangulo[3];
            rectangulos[0] = new Rectangulo { Ancho = 5, Altura = 10 };
            rectangulos[1] = new Rectangulo { Ancho = 7, Altura = 3 };
            rectangulos[2] = new Rectangulo { Ancho =  4, Altura = 6 };

            Console.WriteLine("===== Áreas de los rectángulos =====");
            foreach (var rect in rectangulos)
            {
                Console.WriteLine($"Ancho: {rect.Ancho}, Altura: {rect.Altura}, Área: {rect.Area()}");
            }
            Console.WriteLine("====================================");
        }

        // Ejercicio para trabajar con estructuras de cuentas bancarias
        static void structCuentaBancaria()
        {
            CuentaBancaria[] cuentas = new CuentaBancaria[3];
            cuentas[0] = new CuentaBancaria(123456, "Juan Perez", 1500.75);
            cuentas[1] = new CuentaBancaria(789012, "Maria Lopez", 2500.50);
            cuentas[2] = new CuentaBancaria(345678, "Carlos Sanchez", 3500.25);

            Console.WriteLine("===== Detalles de las cuentas bancarias =====");
            foreach (var cuenta in cuentas)
            {
                Console.WriteLine($"Numero de Cuenta: {cuenta.NumeroDeCuenta}, Nombre del Titular: {cuenta.NombreTitular}, Saldo: {cuenta.Saldo}");
            }
            Console.WriteLine("=============================================");
        }

        // Ejercicio para trabajar con estructuras de carros
        static void structCarros()
        {
            List<Carro> carros = new List<Carro>();
            string continuar;

            do
            {
                Carro carro = new Carro();
                Console.Write("Ingrese la marca del carro:\n-> ");
                carro.Marca = Console.ReadLine();
                Console.Write("Ingrese el modelo del carro:\n-> ");
                carro.Modelo = Console.ReadLine();
                Console.Write("Ingrese el año del carro:\n-> ");
                carro.Año = Convert.ToInt32(Console.ReadLine());

                carros.Add(carro);

                Console.Write("¿Desea ingresar otro carro? (s/n):\n-> ");
                continuar = Console.ReadLine().ToLower();
            } while (continuar != "n");

            // Limpia la pantalla para mostrar el resultado
            Console.Clear();

            Console.WriteLine("===== Lista de carros ingresados =====");
            foreach (var carro in carros)
            {
                Console.WriteLine($"Marca: {carro.Marca}, Modelo: {carro.Modelo}, Año: {carro.Año}");
            }
            Console.WriteLine("======================================");
        }
    }
}