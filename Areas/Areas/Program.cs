using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu=0;
            //Menu de que Queremos hacer 
            Console.WriteLine("Que quiere hacer? \n1) Calcular Areas \n2) Sumar Areas ");
            menu = Convert.ToInt16(Console.ReadLine()); //Lectura de que se quiere 
            if (menu==1) //Calculo del áreas
            {
                while (menu != 0)
                {
                    Console.WriteLine("Seleciona la Figura para calcular su área \n1) Cuadrado\n2) Triangulo\n3) Circulo\nCualquier otro valor para Salir");
                    menu = Convert.ToInt16(Console.ReadLine());


                    switch (menu)
                    {

                        case 1:
                            Console.WriteLine("Escogiste cuadrado, dame el lado");
                            Cuadrado C1 = new Cuadrado();
                            C1.CalcularArea();
                            break;
                        case 2:
                            Console.WriteLine("Escogiste Triangulo, dame la base y la altura");
                            Triangulo T1 = new Triangulo();
                            T1.CalcularArea();
                            break;
                        case 3:
                            Console.WriteLine("Escogiste Circulo, dame el radio");
                            Circulo Ci = new Circulo();
                            Ci.CalcularArea();
                            break;
                        case 4:
                            menu = 0;
                            break;

                    }

                }
            }
            else if (menu == 2){ //Suma de áreas 
                menu = 0;
                Figura a=new Figura(),b= new Figura(); // sumandos 
                double R; //resultado
            
                Console.WriteLine("Tu Primer figura  \n1) Cuadrilatero \n2) Triangulo\n3) Circulo ");          

                while (menu == 0) {
                    menu = Convert.ToInt16(Console.ReadLine());
                    switch (menu)
                    {

                        case 1:
                            Console.WriteLine("Escogiste cuadrilatero, dame los lados");
                            Cuadrado C1 = new Cuadrado();
                            b = C1;
                            C1.CalcularArea();
                            break;
                        case 2:
                            Console.WriteLine("Escogiste Triangulo, dame la base y la altura");
                            Triangulo T1 = new Triangulo();
                            b = T1;
                            T1.CalcularArea();
                            break;
                        case 3:
                            Console.WriteLine("Escogiste Circulo, dame el radio");
                            Circulo Ci = new Circulo();
                            Ci.CalcularArea();
                            b = Ci;
                            break;
                        case 4:
                            Console.WriteLine("Dame una figura");
                            menu = 10;
                            break;

                    }


                } //Seleccion de las Figuras a sumar sino elige ninguna no lo deja avanzar

                Console.WriteLine("Tu Segunda figura  \n1) Cuadrilatero \n2) Triangulo\n3) Circulo ");
                menu = 0;
                while (menu == 0)
                {
                    menu = Convert.ToInt16(Console.ReadLine());
                    switch (menu)
                    {

                        case 1:
                            Console.WriteLine("Escogiste cuadrilatero, dame los lados");
                            Cuadrado C2 = new Cuadrado();
                            C2.CalcularArea();
                            a = C2;
                            break;
                        case 2:
                            Console.WriteLine("Escogiste Triangulo, dame la base y la altura");
                            Triangulo T2 = new Triangulo();
                            T2.CalcularArea();
                            a = T2;
                            break;
                        case 3:
                            Console.WriteLine("Escogiste Circulo, dame el radio");
                            Circulo Cj = new Circulo();
                            a = Cj;
                            Cj.CalcularArea();
                            break;
                        case 4:
                            Console.WriteLine("Dame una figura");
                            menu = 0;
                            break;

                    }


                } //Seleccion de las Figuras a sumar sino elige ninguna no lo deja avanzar

                R = a + b; //Suma De las figuras sin importar su tipo  (Sobre carga de operadore)

                Console.WriteLine("\nLa Suma de las áreas es " + R); //impresion del resultado en consola
            }
            Console.ReadKey();
        }
    }
}
