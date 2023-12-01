using System;

namespace BBVA_PreExamen // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola!! Ingresa tu nombre completo de favor");
            var nombre = Console.ReadLine();
            Console.WriteLine($"Que bueno tenerte de vuelta {nombre} \n ");

            Console.WriteLine("Por favor, elige la opcion del producto que deseas \n1- Producto A  \n2- Producto B  \n3- Producto C  ");
            int opcion = int.Parse(Console.ReadLine());
            int costoA = 270;
            int costoB = 340;
            int costoC = 390;
            int cantidad = 0;
            int cambio;

            switch (opcion)
            {
                case 1:
                    EleccionA();
                    break;
                case 2:
                    EleccionB();
                    break;
                case 3:
                    EleccionC();
                    break;
                default:
                    Console.WriteLine("La opción ingresada no se encuentra en el menu, selecciona una opcion correcta");
                    break;


            }
            int EleccionA()
            {
                Console.WriteLine("----------------  PRODUCTO  A  ----------------");
                Console.WriteLine("Costo: $270 \n La máquina acepta y da cambio de monedas de $10, $50 y $100 ");
                Console.WriteLine("Ingresa el dinero hasta alcanzar el monto:");

                while (cantidad < costoA)
                {
                    Console.WriteLine("Ingresa las monedas para llegar al monto");
                    int moneda = int.Parse(Console.ReadLine());

                    if (moneda == 10 || moneda == 50 || moneda == 100)
                    {
                        cantidad += moneda;
                    }
                    else
                    {
                        Console.WriteLine("Lo sentimos, solo ingrese monedas de $10, $50 y $100");
                    }
                }
                if (cantidad > costoA)
                {
                    cambio = cantidad - costoA;
                    Console.WriteLine($"Su cambio es {cambio}, entregando monedas");
                    while (cambio > 0)
                    {
                        if (cambio >= 100)
                        {
                            Console.WriteLine("100");
                            cambio -= 100;
                        }
                        else if (cambio >= 50)
                        {
                            Console.WriteLine("50");
                            cambio -= 50;
                        }
                        else if (cambio >= 10)
                        {
                            Console.WriteLine("10");
                            cambio -= 10;
                        }
                    }

                    Console.WriteLine("----------- Resumen de la compra ----------");
                    Console.WriteLine($" Nombre: {nombre} \n Numero del producto elegido: {opcion} \n Monto pagado: {cantidad} \n");
                }

                return cantidad;
            }

            int EleccionB()
            {
                Console.WriteLine("----------------  PRODUCTO  B  ----------------");
                Console.WriteLine("Costo: $340 \n La máquina acepta y da cambio de monedas de $10, $50 y $100 ");
                Console.WriteLine("Ingresa el dinero hasta alcanzar el monto:");

                while (cantidad < costoB)
                {
                    Console.WriteLine("Ingresa las monedas para llegar al monto");
                    int moneda = int.Parse(Console.ReadLine());

                    if (moneda == 10 || moneda == 50 || moneda == 100)
                    {
                        cantidad += moneda;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingresa monedas de $10, $50 y $100");
                    }
                }
                if (cantidad > costoB)
                {
                    cambio = cantidad - costoB;
                    Console.WriteLine($"Su cambio es {cambio}, regresando monedas");
                    while (cambio > 0)
                    {
                        if (cambio >= 100)
                        {
                            Console.WriteLine("100");
                            cambio -= 100;

                        }
                        else if (cambio >= 50)
                        {
                            Console.WriteLine("50");
                            cambio -= 50;
                        }
                        else if (cambio >= 10)
                        {
                            Console.WriteLine("10");
                            cambio -= 10;
                        }
                    }
                    Console.WriteLine("----------- Resumen de la compra ----------");
                    Console.WriteLine($" Nombre: {nombre} \n Numero del producto elegido: {opcion} \n Monto pagado: {cantidad} \n");
                }

                return cantidad;
            }

            int EleccionC()
            {
                Console.WriteLine("----------------  PRODUCTO  C  ----------------");
                Console.WriteLine("Costo: $390 \n La máquina acepta y da cambio de monedas de $10, $50 y $100 ");
                Console.WriteLine("Ingresa el dinero hasta alcanzar el monto:");

                while (cantidad < costoC)
                {
                    Console.WriteLine("Ingresa las monedas hasta llegar al monto");
                    int moneda = int.Parse(Console.ReadLine());
                    if (moneda == 10 || moneda == 50 || moneda == 100)
                    {
                        cantidad += moneda;
                    }
                    else
                    {
                        Console.WriteLine("Lo sentimos, solo ingrese monedas de $10, $50 y $100");
                    }
                }
                Console.WriteLine("----------- Resumen de la compra ----------");
                Console.WriteLine($" Nombre: {nombre} \n Numero del producto elegido: {opcion} \n Monto pagado: {cantidad} \n");
                return cantidad;
            }

        }








    }
}