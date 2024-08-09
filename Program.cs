using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCoffee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BebidaComponent cafe = new CafeDescafeinado();

            cafe = new Crema(cafe);

            Console.WriteLine($"Producto: {cafe.Descripcion} tiene un costo de: {cafe.Costo}");

            BebidaComponent cafe2 = new CafeSolo();
            cafe2 = new Crema(cafe2);
            cafe2 = new Azucar(cafe2);

            Console.WriteLine($"Producto: {cafe2.Descripcion} tiene un costo de: {cafe2.Costo}");

            Console.ReadKey();
        }
    }
}
