using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrito miCarroDeCompra = new Carrito();

            int opcionElegida = 0;
            String opcionSalir;
            bool salir = false;

            do
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("SHOPPING ONLINE DE CAMISAS - Venta miinorista y mayorista");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("MENÚ PRINCIPAL");
                Console.WriteLine("1 -> Añadir camisa al carro de compras");
                Console.WriteLine("2 -> Eliminar camisa al carro de compras");
                Console.WriteLine("3 -> Salir");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("             -  Cantidad de camisas en el carro de compras: "+Carrito.GetCantidadDeCamisasAñadidas+" unidad/es");
                Console.WriteLine("             -  Precio unitario: $1000");
                Console.WriteLine("             -  Precio total sin descuento: $"+miCarroDeCompra.GetPrecioTotalSinDescuento);
                Console.WriteLine("             -  Tipo de descuento aplicado: %"+miCarroDeCompra.RetornarDescuento());
                Console.WriteLine("             -  Precio final con descuento: $"+miCarroDeCompra.GetPrecioTotalConDescuento);
                Console.WriteLine("---------------------------------------------------------");
                Console.Write("Ingrese una opción del menú:");
                opcionElegida = int.Parse(Console.ReadLine());

                switch (opcionElegida)
                {
                    case 1:
                        miCarroDeCompra.AñadirCamisas();
                        miCarroDeCompra.CalcularPrecioSinDescuento();
                        miCarroDeCompra.CalcularPrecioConDescuento();
                        break;

                    case 2:
                        miCarroDeCompra.EliminarCamisas();
                        miCarroDeCompra.CalcularPrecioSinDescuento();
                        miCarroDeCompra.CalcularPrecioConDescuento();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("¿Está seguro que desea salir? S/N");
                        opcionSalir = Console.ReadLine();

                        if (opcionSalir == "S" || opcionSalir == "s")
                        {
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Saliendo del shopping online...");
                            Console.WriteLine("-------------------------------");
                            salir = true;

                        }else if(opcionSalir == "N" || opcionSalir == "n")
                        {
                            Console.WriteLine("");
                        } 
                        break;

                    default:
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("Opcin ingresada de manera incorrecta");
                        Console.WriteLine("Ingreselo nuevamente...");
                        Console.WriteLine("------------------------------------");
                        break;
                }

            } while (salir == false);
            
        }
    }
}
