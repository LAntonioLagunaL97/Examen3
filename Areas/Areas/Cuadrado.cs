using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Cuadrado: Figura
    {
        public Cuadrado()

        {

            Console.WriteLine("Ingresa la Base");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa la Altura");
            y = Convert.ToDouble(Console.ReadLine());


        }

        public  void CalcularArea()
        {
            Area = x * y;
            Console.WriteLine("El area es: " + Area);
  

        }
    }
}
