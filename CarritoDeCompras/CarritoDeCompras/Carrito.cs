using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    class Carrito
    {
        private bool primeraVez = true;
        private static int CantidadDeCamisasAñadidas;
        private int CantidadDeCamisasEliminadas;
        private double DescuentoAplicado = 0.0;
        private int PrecioUnitarioCamisa = 1000;
        private double PrecioTotalSinDescuento;
        private double PrecioTotalConDescuento;
        
        static public int GetCantidadDeCamisasAñadidas
        {
            get
            {
                return CantidadDeCamisasAñadidas;
            }
        }

        public void AñadirCamisas()
        {
            if (primeraVez == true)
            {
                Console.Write("Cuantas camisas desea añadir: ");
                CantidadDeCamisasAñadidas = int.Parse(Console.ReadLine());

                primeraVez = false; 
            }
            else
            {
                int auxiliarCantidad;

                Console.Write("Cuantas camisas desea añadir: ");
                auxiliarCantidad = int.Parse(Console.ReadLine());

                CantidadDeCamisasAñadidas = CantidadDeCamisasAñadidas + auxiliarCantidad;
            }
        }

        public void EliminarCamisas()
        {
            if(CantidadDeCamisasAñadidas == 0)
            {
                Console.WriteLine("El carrito se encuentra vacio en estos momentos");
                Console.WriteLine("Debe añadir camisas antes de eliminarlas...");
            }
            else
            {
                Console.Write("Cuantas camisas desea eliminar:");
                CantidadDeCamisasEliminadas = int.Parse(Console.ReadLine());

                if (CantidadDeCamisasEliminadas > CantidadDeCamisasAñadidas)
                {
                    Console.WriteLine("No se pueden eliminar mas camisas de las que hay");
                }
                else
                {
                    CantidadDeCamisasAñadidas = CantidadDeCamisasAñadidas - CantidadDeCamisasEliminadas;

                    if (CantidadDeCamisasAñadidas > 5)
                    {
                        DescuentoAplicado = 0.2;
                    }
                    else if (CantidadDeCamisasAñadidas >= 3 || CantidadDeCamisasAñadidas <= 5)
                    {
                        DescuentoAplicado = 0.1;

                    }else if(CantidadDeCamisasAñadidas < 3)
                    {
                        DescuentoAplicado = 0.0;
                    }
                }   
            }
        }

        public void CalcularPrecioSinDescuento()
        {
            PrecioTotalSinDescuento  = PrecioUnitarioCamisa * CantidadDeCamisasAñadidas;
        }

        public void CalcularPrecioConDescuento()
        {
            if(CantidadDeCamisasAñadidas > 5)
            {
                DescuentoAplicado = 0.20;

                PrecioTotalConDescuento = PrecioTotalSinDescuento - (PrecioTotalSinDescuento * DescuentoAplicado);

            }else if(CantidadDeCamisasAñadidas >= 3 || CantidadDeCamisasAñadidas <= 5)
            {
                DescuentoAplicado = 0.10;

                PrecioTotalConDescuento = PrecioTotalSinDescuento - (PrecioTotalSinDescuento * DescuentoAplicado);
            }
            else
            {
                PrecioTotalConDescuento = PrecioTotalSinDescuento;
            }
        }
        public double GetPrecioTotalSinDescuento
        {
            get
            {
                return PrecioTotalSinDescuento;
            }
        }

        public double GetPrecioTotalConDescuento
        {
            get
            {
                return PrecioTotalConDescuento;
            }
        }

        public double RetornarDescuento()
        {
            double auxiliar;

            auxiliar = (DescuentoAplicado * 100);

            return auxiliar;
        }
    }
}
