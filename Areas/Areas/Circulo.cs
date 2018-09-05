using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Circulo: Figura
    {
        public Circulo()

        {

            Console.WriteLine("Ingresa el radio");
            x = Convert.ToDouble(Console.ReadLine());
           


        }

        public  void CalcularArea()
        {
            Area = 3.1416 * x * x;
            Console.WriteLine("El area es: " + Area);
  
        }
    }
}
